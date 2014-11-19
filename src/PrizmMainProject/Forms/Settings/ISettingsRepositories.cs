﻿using Data.DAL.Mill;
using Data.DAL.Setup;
using Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Settings
{
   public interface ISettingsRepositories : IDisposable
   {
      IWelderRepository WelderRepo { get; }
      IMillPipeSizeTypeRepository PipeSizeTypeRepo { get; }
      IPipeTestRepository PipeTestRepo { get; }
      IProjectRepository ProjectRepo { get; }
      IPlateManufacturerRepository PlateManufacturerRepo { get; }

      void Commit();
      void BeginTransaction();
   }
}
