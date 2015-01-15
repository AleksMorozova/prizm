using Ninject;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Forms.Synch;
using Prizm.Main.Properties;
using Prizm.Main.Synch.Export;
using Prizm.Main.Synch.SerializableEntities;
using Prizm.UnitTests.Synch.SerializableEntities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.Import
{
   public class DataImporter : Importer, IDisposable
   {
      readonly IImportRepository importRepo;

      [Inject]
      public DataImporter(IImportRepository importRepo, IHasher hasher, IEncryptor encryptor) : base(hasher, encryptor)
      {
         this.importRepo = importRepo;
      }

      int progress = 0;

      public override ImportResult Import(string archiveName)
      {
         if (!ArchiveExists(archiveName))
            return ImportResult.Failed;

         progress = 0;

         try
         {
            FireMessage(Resources.Import_TempStorage);
            string tempDir = CreateTempDir();

            FireMessage(Resources.Import_Unzip);
            UnzipContent(archiveName, tempDir);

            progress += 5;
            FireProgress(progress);

            FireMessage(Resources.Import_Checksum);
            ValidateChecksum(Path.Combine(tempDir, "Manifest"));
            ValidateChecksum(Path.Combine(tempDir, "Data"));

            progress += 5;
            FireProgress(progress);

            FireMessage(Resources.Import_Data);
            ImportData(tempDir);
            FireOnDone();
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

         Data data = Deserialize<Data>(Path.Combine(tempDir, "Data"));

         importRepo.PipeRepo.BeginTransaction();

         CheckPortion(manifest.PortionID);

         Project project = ImportProject(data.Project);
         IList<Pipe> importedPipes = ImportPipes(manifest, data.Pipes, manifest.PortionID, tempDir);

         SavePortionInfo(manifest, importedPipes, project);

         importRepo.PipeRepo.Commit();
            
         progress = 100;
         FireProgress(progress);
         
      }

      void CheckPortion(Guid portionId)
      {
         Portion portion = importRepo.PortionRepo.Get(portionId);
         if (portion != null)
            throw new ImportException(Resources.Import_SamePortion);
      }

      private void SavePortionInfo(Manifest manifest, IList<Pipe> pipes, Project project)
      {
         Portion portion = new Portion();
         portion.ExportDateTime = DateTime.Now;
         portion.Id = manifest.PortionID;

         if (pipes != null && pipes.Count > 0)
         {
            foreach (var pipe in pipes)
            {
               portion.Pipes.Add(pipe);
            }
         }


         if (project != null)
         {
            portion.Projects.Add(project);
         }

         importRepo.PortionRepo.Save(portion);
      }

      private void CopyAttachment(string tempDir, Domain.Entity.File file)
      {
         string fileName = Path.Combine(tempDir, "Attachments", file.NewName);
         ValidateChecksum(fileName);
         System.IO.File.Copy(fileName, Path.Combine(System.Environment.CurrentDirectory, "Data", "Attachments", file.NewName), true);
      }

      public void MapSerializableEntityToPipe(string tempDir, PipeObject pipeObj, Pipe pipe)
      {
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
               CopyAttachment(tempDir, f);
            }
         }
      }

      private Project ImportProject(ProjectObject projectObj)
      {
         if (projectObj == null)
            return null;

         bool isNew = false;
         Project project = importRepo.ProjectRepo.Get(projectObj.Id);
         if (project == null)
         {
            project = new Project();
            isNew = true;
         }

         project.Id = projectObj.Id;
         project.IsActive = projectObj.IsActive;
         project.Title = projectObj.Title;
         project.Client = projectObj.Client;
         project.MillName = projectObj.MillName;
         project.DocumentSizeLimit = projectObj.DocumentSizeLimit;
         project.WorkstationType = projectObj.WorkstationType;
         project.MillPipeNumberMask = projectObj.MillPipeNumberMask;
         project.MillPipeNumberMaskRegexp = projectObj.MillPipeNumberMaskRegexp;

         if (isNew)
            importRepo.ProjectRepo.Save(project);
         else
            importRepo.ProjectRepo.SaveOrUpdate(project);

         return project;
      }

      private IList<Pipe> ImportPipes(Manifest manifest, List<PipeObject> pipes, Guid portionId, string tempDir)
      {
         IList<Pipe> importedPipes = new List<Pipe>();
         const int PROGRESS_RANGE = 90;

         if (pipes.Count == 0)
         {
            progress += PROGRESS_RANGE;
            FireProgress(progress);
            return importedPipes;
         }
         
         int step = PROGRESS_RANGE / pipes.Count;
         ConflictDecision decision = ConflictDecision.Undef;
         bool forAll = false;

         foreach (var pipeObj in pipes)
         {
            Pipe pipe = importRepo.PipeRepo.Get(pipeObj.Id);
            if (pipe == null)
            {
               pipe = new Pipe();

               MapSerializableEntityToPipe(tempDir, pipeObj, pipe);

               Project currentProject = importRepo.ProjectRepo.GetSingle();
               pipe.ToExport = currentProject.WorkstationType == WorkstationType.Master && manifest.WorkstationType == WorkstationType.Mill;

               importRepo.PipeRepo.Save(pipe);

               importedPipes.Add(pipe);
               
               progress += step;
               FireProgress(progress);
            }
            else
            {
               if (decision == ConflictDecision.Undef || !forAll)
               {
                  ConflictEventArgs args = new ConflictEventArgs();
                  args.Message = string.Format(Resources.Import_Conflict, pipeObj.Number);
                  FireConflict(args);
                  decision = args.Decision;
                  forAll = args.ForAll;
               }

               switch (decision)
               {
                  case ConflictDecision.Skip:
                     break;
                  case ConflictDecision.Replace:
                     Pipe existingPipe = importRepo.PipeRepo.Get(pipeObj.Id);
                     MapSerializableEntityToPipe(tempDir, pipeObj, existingPipe);
                     importRepo.PipeRepo.SaveOrUpdate(existingPipe);
                     importedPipes.Add(existingPipe);
                     break;
                  case ConflictDecision.Postpone:
                     Dump(pipeObj, portionId, tempDir);
                     CreateNotification(pipeObj);
                     break;
               }
               progress += step;
               FireProgress(progress);
            }
         }

         return importedPipes;
      }

      void Dump(PipeObject pipeObj, Guid portionId, string tempDir)
      {
         Conflict conflict = new Conflict();
         conflict.PortionID = portionId;
         conflict.Pipe = pipeObj;

         string conflictDir = Path.Combine(System.Environment.CurrentDirectory, "Conflicts");

         if (!Directory.Exists(conflictDir))
            Directory.CreateDirectory(conflictDir);

         string dumpFilePath = Path.Combine(conflictDir, pipeObj.Id + ".xml");

         if (System.IO.File.Exists(dumpFilePath))
            System.IO.File.Delete(dumpFilePath);

         string attDir = Path.Combine(conflictDir, pipeObj.Id + "_Attachments");
         if (pipeObj.Attachments != null && pipeObj.Attachments.Count > 0)
         {
            if (Directory.Exists(attDir))
               Directory.Delete(attDir, true);

            Directory.CreateDirectory(attDir);

            foreach (var file in pipeObj.Attachments)
            {
               string attPathInTemp = Path.Combine(tempDir, "Attachments", file.NewName);
               string targetPath = Path.Combine(attDir, file.NewName);

               System.IO.File.Copy(attPathInTemp, targetPath, true);
            }
         }

         XmlSerializer serializer = new XmlSerializer(typeof(Conflict));
         using (FileStream fs = new FileStream(dumpFilePath, FileMode.Create))
         {
            serializer.Serialize(fs, conflict);
         }
      }

      void CreateNotification(PipeObject pipeObj)
      { 
         //TODO: Notification should be created here.
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

      public T Deserialize<T>(string file, bool encrypted = true)
      {
         byte[] bytes;
         using (FileStream fs = new FileStream(file, FileMode.Open))
         {
            bytes = new byte[fs.Length];
            fs.Read(bytes, 0, bytes.Length);
            fs.Close();
         }

         byte[] decrypted;
         if (encrypted)
         {
            decrypted = encryptor.Decrypt(bytes, "^PRIZM_ENCRYPTION_KEY$");
         }
         else
         {
            decrypted = bytes;
         }

         
         string xml = Encoding.Unicode.GetString(decrypted);

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

      public void Dispose()
      {
         importRepo.Dispose();
      }
   }
}
