using Ninject;
using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Synch.Export;
using Prizm.Main.Synch.SerializableEntities;
using Prizm.UnitTests.Synch.SerializableEntities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.Import
{
   public class MasterImporter : Importer
   {
      readonly IImportRepository importRepo;

      [Inject]
      public MasterImporter(IImportRepository importRepo, IHasher hasher, IEncryptor encryptor) : base(hasher, encryptor)
      {
         this.importRepo = importRepo;
      }

      public override ImportResult Import(string archiveName)
      {
         if (!ArchiveExists(archiveName))
            return ImportResult.Failed;

         try
         {
            string tempDir = CreateTempDir();

            UnzipContent(archiveName, tempDir);

            ValidateChecksum(Path.Combine(tempDir, "Manifest"));
            ValidateChecksum(Path.Combine(tempDir, "Data"));

            ImportData(tempDir);
         }
         catch (Exception e)
         {
            return FireError(new ImportException(e.Message, e));
         }
            

         return ImportResult.Success;
      }

      void ImportData(string tempDir)
      {
         Manifest manifest = Deserialize<Manifest>(Path.Combine(tempDir, "Manifest"));

         if (manifest.WorkstationType == Domain.Entity.Setup.WorkstationType.Mill)
         {
            MillData millData = Deserialize<MillData>(Path.Combine(tempDir, "Data"));

            importRepo.PipeRepo.BeginTransaction();
            
            ImportPipes(millData.Pipes);

            importRepo.PipeRepo.Commit();
         }
      }

      private void ImportPipes(List<PipeObject> pipes)
      {
         foreach (var pipeObj in pipes)
         {
            Pipe pipe = importRepo.PipeRepo.Get(pipeObj.Id);
            if (pipe == null)
            {
               pipe = new Pipe();
               pipe.Id = pipeObj.Id;
               pipe.IsActive = pipeObj.IsActive;
               pipe.Number = pipeObj.Number;
               pipe.Length = pipeObj.Length;
               pipe.IsAvailableToJoint = pipeObj.IsAvailableToJoint;
               pipe.ConstructionStatus = pipeObj.ConstructionStatus;
               pipe.InspectionStatus = pipeObj.InspectionStatus;
               pipe.Plate = ImportPlate(pipeObj.Plate);
               pipe.Mill = pipeObj.Mill;
               pipe.Diameter = pipeObj.Diameter;
               pipe.WallThickness = pipeObj.WallThickness;
               pipe.Weight = pipeObj.Weight;
               pipe.ProductionDate = pipeObj.ProductionDate;
               pipe.Type = ImportSizeType(pipeObj.Type);
               pipe.Railcar = ImportRailcar(pipeObj.Railcar);
               pipe.PurchaseOrder = ImportPurchaseOrder(pipeObj.PurchaseOrder);
               pipe.Status = pipeObj.Status;

               if (pipeObj.Spools != null)
               {
               }

               if (pipeObj.Attachments != null)
               {
               }

               importRepo.PipeRepo.Save(pipe);
            }
            else
            {
               // TODO: CONFLICT RESOLVING
            }
         }
      }

      private Plate ImportPlate(PlateObject plateObj)
      {
         if (plateObj == null)
            return null;

         Plate plate = importRepo.PlateRepo.Get(plateObj.Id);
         if (plate == null)
            plate = new Plate();

         plate.Id = plateObj.Id;
         plate.IsActive = plateObj.IsActive;
         plate.Number = plateObj.Number;
         plate.Thickness = plateObj.Thickness;
         plate.Heat = ImportHeat(plateObj.Heat);

         importRepo.PlateRepo.SaveOrUpdate(plate);
         return plate;
      }

      private Heat ImportHeat(HeatObject heatObj)
      {
         if (heatObj == null)
            return null;

         Heat heat = importRepo.HeatRepo.Get(heatObj.Id);
         if (heat == null)
            heat = new Heat();

         heat.Id = heatObj.Id;
         heat.IsActive = heatObj.IsActive;
         heat.Number = heatObj.Number;
         heat.SteelGrade = heatObj.SteelGrade;
         heat.PlateManufacturer = ImportPlateManifacturer(heatObj.PlateManufacturer);

         importRepo.HeatRepo.SaveOrUpdate(heat);
         return heat;
      }

      private PlateManufacturer ImportPlateManifacturer(PlateManufacturerObject plateManufacturerObj)
      {
         if (plateManufacturerObj == null)
            return null;

         PlateManufacturer manufacturer = importRepo.PlateManufacturerRepo.Get(plateManufacturerObj.Id);
         if (manufacturer == null)
            manufacturer = new PlateManufacturer();

         manufacturer.Id = plateManufacturerObj.Id;
         manufacturer.Name = plateManufacturerObj.Name;
         manufacturer.IsActive = plateManufacturerObj.IsActive;

         importRepo.PlateManufacturerRepo.SaveOrUpdate(manufacturer);
         return manufacturer;
      }

      private PipeMillSizeType ImportSizeType(SizeTypeObject sizeTypeObj)
      {
         if (sizeTypeObj == null)
            return null;

         PipeMillSizeType type = importRepo.SizeTypeRepo.Get(sizeTypeObj.Id);
         if (type == null)
            type = new PipeMillSizeType();

         type.Id = sizeTypeObj.Id;
         type.IsActive = sizeTypeObj.IsActive;
         type.Type = sizeTypeObj.Type;
         type.Length = sizeTypeObj.Length;
         type.Diameter = sizeTypeObj.Diameter;
         type.Thickness = sizeTypeObj.Thickness;
         type.SeamType = ImportSeamType(sizeTypeObj.SeamType);

         importRepo.SizeTypeRepo.SaveOrUpdate(type);
         return type;
      }

      private SeamType ImportSeamType(SeamTypeObject seamTypeObj)
      {
         if (seamTypeObj == null)
            return null;

         SeamType seamType = importRepo.SeamTypeRepo.Get(seamTypeObj.Id);
         if (seamType == null)
            seamType = new SeamType();

         seamType.Id = seamTypeObj.Id;
         seamType.IsActive = seamTypeObj.IsActive;
         seamType.Name = seamTypeObj.Name;

         if (seamTypeObj.SeamTypes != null)
         {
            foreach (var st in seamTypeObj.SeamTypes)
            {
               seamType.SeamTypes.Add(ImportSeamType(st));
            }
         }

         importRepo.SeamTypeRepo.SaveOrUpdate(seamType);
         return seamType;
      }

      private Railcar ImportRailcar(RailcarObject railcarObj)
      {
         if (railcarObj == null)
            return null;

         Railcar railcar = importRepo.RailcarRepo.Get(railcarObj.Id);
         if (railcar == null)
            railcar = new Railcar();

         railcar.Id = railcarObj.Id;
         railcar.IsActive = railcarObj.IsActive;
         railcar.Number = railcarObj.Number;
         railcar.Certificate = railcarObj.Certificate;
         railcar.Destination = railcarObj.Destination;
         railcar.ShippingDate = railcarObj.ShippingDate;
         railcar.IsShipped = railcarObj.IsShipped;

         importRepo.RailcarRepo.SaveOrUpdate(railcar);
         return railcar;
      }

      private PurchaseOrder ImportPurchaseOrder(PurchaseOrderObject purchaseOrderObj)
      {
         if (purchaseOrderObj == null)
            return null;

         PurchaseOrder order = importRepo.PurchaseOrderRepo.Get(purchaseOrderObj.Id);
         if (order == null)
            order = new PurchaseOrder();

         order.Id = purchaseOrderObj.Id;
         order.IsActive = purchaseOrderObj.IsActive;
         order.Number = purchaseOrderObj.Number;
         order.Date = purchaseOrderObj.Date;

         importRepo.PurchaseOrderRepo.SaveOrUpdate(order);
         return order;
      }

      T Deserialize<T>(string file)
      {
         byte[] bytes;
         using (FileStream fs = new FileStream(file, FileMode.Open))
         {
            bytes = new byte[fs.Length];
            fs.Read(bytes, 0, bytes.Length);
            fs.Close();
         }

         byte[] descrypted = encryptor.Decrypt(bytes, "^PRIZM_ENCRYPTION_KEY$");
         string xml = Encoding.Unicode.GetString(descrypted);

         XmlSerializer serializer = new XmlSerializer(typeof(T));
         StringReader sr = new StringReader(xml);
         T data = (T)serializer.Deserialize(sr);

         return data;
      }

      string CreateTempDir()
      {
         string tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
         Directory.CreateDirectory(tempDir);
         return tempDir;
      }
   }
}
