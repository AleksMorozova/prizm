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

            CopyAttachments(tempDir, millData.Pipes);
         }
      }

      private void CopyAttachments(string tempDir, List<PipeObject> pipes)
      {
         foreach (var pipe in pipes)
         {
            if (pipe.Attachments != null)
            {
               foreach (var attachment in pipe.Attachments)
               {
                  string fileName = Path.Combine(tempDir, "Attachments", attachment.NewName);
                  ValidateChecksum(fileName);
                  System.IO.File.Copy(fileName, Path.Combine(System.Environment.CurrentDirectory, "Data", "Attachments", attachment.NewName), true);
               }
            }
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
                  pipe.Attachments = new List<Prizm.Domain.Entity.File>();
                  foreach (var fileObject in pipeObj.Attachments)
                  {
                     Prizm.Domain.Entity.File f = ImportFile(fileObject, pipe.Id);
                     pipe.Attachments.Add(f);
                  }
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

         bool isNew = false;
         Plate plate = importRepo.PlateRepo.Get(plateObj.Id);
         if (plate == null)
         {
            plate = new Plate();
            isNew = true;
         }

         plate.Id = plateObj.Id;
         plate.IsActive = plateObj.IsActive;
         plate.Number = plateObj.Number;
         plate.Thickness = plateObj.Thickness;
         plate.Heat = ImportHeat(plateObj.Heat);

         if (isNew)
            importRepo.PlateRepo.Save(plate);
         else
            importRepo.PlateRepo.SaveOrUpdate(plate);

         return plate;
      }

      private Heat ImportHeat(HeatObject heatObj)
      {
         if (heatObj == null)
            return null;

         bool isNew = false;
         Heat heat = importRepo.HeatRepo.Get(heatObj.Id);
         if (heat == null)
         {
            heat = new Heat();
            isNew = true;
         }

         heat.Id = heatObj.Id;
         heat.IsActive = heatObj.IsActive;
         heat.Number = heatObj.Number;
         heat.SteelGrade = heatObj.SteelGrade;
         heat.PlateManufacturer = ImportPlateManifacturer(heatObj.PlateManufacturer);

         if (isNew)
            importRepo.HeatRepo.Save(heat);
         else
            importRepo.HeatRepo.SaveOrUpdate(heat);

         return heat;
      }

      private PlateManufacturer ImportPlateManifacturer(PlateManufacturerObject plateManufacturerObj)
      {
         if (plateManufacturerObj == null)
            return null;

         bool isNew = false;
         PlateManufacturer manufacturer = importRepo.PlateManufacturerRepo.Get(plateManufacturerObj.Id);
         if (manufacturer == null)
         {
            manufacturer = new PlateManufacturer();
            isNew = true;
         }

         manufacturer.Id = plateManufacturerObj.Id;
         manufacturer.Name = plateManufacturerObj.Name;
         manufacturer.IsActive = plateManufacturerObj.IsActive;

         if (isNew)
            importRepo.PlateManufacturerRepo.Save(manufacturer);
         else
            importRepo.PlateManufacturerRepo.SaveOrUpdate(manufacturer);

         return manufacturer;
      }

      private PipeMillSizeType ImportSizeType(SizeTypeObject sizeTypeObj)
      {
         if (sizeTypeObj == null)
            return null;

         bool isNew = false;
         PipeMillSizeType type = importRepo.SizeTypeRepo.Get(sizeTypeObj.Id);
         if (type == null)
         {
            type = new PipeMillSizeType();
            isNew = true;
         }

         type.Id = sizeTypeObj.Id;
         type.IsActive = sizeTypeObj.IsActive;
         type.Type = sizeTypeObj.Type;
         type.Length = sizeTypeObj.Length;
         type.Diameter = sizeTypeObj.Diameter;
         type.Thickness = sizeTypeObj.Thickness;
         type.SeamType = ImportSeamType(sizeTypeObj.SeamType);

         if (isNew)
            importRepo.SizeTypeRepo.Save(type);
         else
            importRepo.SizeTypeRepo.SaveOrUpdate(type);

         return type;
      }

      private SeamType ImportSeamType(SeamTypeObject seamTypeObj)
      {
         if (seamTypeObj == null)
            return null;

         bool isNew = false;
         SeamType seamType = importRepo.SeamTypeRepo.Get(seamTypeObj.Id);
         if (seamType == null)
         {
            seamType = new SeamType();
            isNew = true;
         }

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

         if (isNew)
            importRepo.SeamTypeRepo.Save(seamType);
         else
            importRepo.SeamTypeRepo.SaveOrUpdate(seamType);

         return seamType;
      }

      private Railcar ImportRailcar(RailcarObject railcarObj)
      {
         if (railcarObj == null)
            return null;

         bool isNew = false;
         Railcar railcar = importRepo.RailcarRepo.Get(railcarObj.Id);
         if (railcar == null)
         {
            railcar = new Railcar();
            isNew = true;
         }

         railcar.Id = railcarObj.Id;
         railcar.IsActive = railcarObj.IsActive;
         railcar.Number = railcarObj.Number;
         railcar.Certificate = railcarObj.Certificate;
         railcar.Destination = railcarObj.Destination;
         railcar.ShippingDate = railcarObj.ShippingDate;
         railcar.IsShipped = railcarObj.IsShipped;

         if (isNew)
            importRepo.RailcarRepo.Save(railcar);
         else
            importRepo.RailcarRepo.SaveOrUpdate(railcar);
         
         return railcar;
      }

      private PurchaseOrder ImportPurchaseOrder(PurchaseOrderObject purchaseOrderObj)
      {
         if (purchaseOrderObj == null)
            return null;

         bool isNew = false;
         PurchaseOrder order = importRepo.PurchaseOrderRepo.Get(purchaseOrderObj.Id);
         if (order == null)
         {
            order = new PurchaseOrder();
            isNew = true;
         }

         order.Id = purchaseOrderObj.Id;
         order.IsActive = purchaseOrderObj.IsActive;
         order.Number = purchaseOrderObj.Number;
         order.Date = purchaseOrderObj.Date;
         
         if (isNew)
            importRepo.PurchaseOrderRepo.Save(order);
         else
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

      private Domain.Entity.File ImportFile(FileObject fileObj, Guid pipeId)
      {
         if (fileObj == null)
            return null;

         bool isNew = false;
         Domain.Entity.File file = importRepo.FileRepo.Get(fileObj.Id);
         if (file == null)
         {
            isNew = true;
            file = new Domain.Entity.File();
         }

         file.Id = fileObj.Id;
         file.IsActive = fileObj.IsActive;
         file.FileName = fileObj.FileName;
         file.Description = fileObj.Description;
         file.UploadDate = fileObj.UploadDate;
         file.NewName = fileObj.NewName;
         file.Item = pipeId;

         if (isNew)
            importRepo.FileRepo.Save(file);
         else
            importRepo.FileRepo.SaveOrUpdate(file);

         return file;
      }

      string CreateTempDir()
      {
         string tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
         Directory.CreateDirectory(tempDir);
         return tempDir;
      }
   }
}
