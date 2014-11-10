using Domain.DAL;
using Domain.DAL.Hibernate;
using NHibernate;
using Ninject.Modules;
using PrizmMain.Forms.Railcar.Edit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain
{
   public class PrizmModule : NinjectModule
   {
      public override void Load()
      {
         Bind<RailcarViewModel>().ToSelf();
         Bind<IRailcarRepository>().To<RailcarRepository>();
         Bind<ISession>().ToMethod(_ => HibernateUtil.OpenSession());
      }
   }
}
