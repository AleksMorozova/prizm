﻿using Data.DAL.Hibernate;
using Data.DAL.Mill;
using Data.DAL.Setup;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Settings
{
   public class SettingsRepositories : ISettingsRepositories
   {
      readonly IWelderRepository welderRepo;
      readonly IMillPipeSizeTypeRepository pipeSizeTypeRepo;
      readonly IPipeTestRepository pipeTestRepo;
      readonly IInspectorRepository inspectorRepo;
      readonly ISession session;

      [Inject]
      public SettingsRepositories(ISession session)
      {
         this.session = session;
         this.welderRepo = new WelderRepository(session);
         this.pipeTestRepo = new PipeTestRepository(session);
         this.pipeSizeTypeRepo = new MillPipeSizeTypeRepository(session);
         this.inspectorRepo = new InspectorRepository(session);
      }

      
      public void Dispose()
      {
         session.Dispose();
      }

      public IWelderRepository WelderRepo
      {
         get { return welderRepo; }
      }

      public IMillPipeSizeTypeRepository PipeSizeTypeRepo
      {
         get { return pipeSizeTypeRepo; }
      }

      public IPipeTestRepository PipeTestRepo
      {
         get { return pipeTestRepo; }
      }

      public IInspectorRepository InspectorRepo
      {
         get { return inspectorRepo; }
      }

      public void Commit()
      {
         session.Transaction.Commit();
      }

      public void BeginTransaction()
      {
         session.BeginTransaction();
      }
      
   }
}