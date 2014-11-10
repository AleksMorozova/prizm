using Data.DAL;
using Data.DAL.Hibernate;
using NHibernate;
using Ninject.Modules;
using PrizmMain.Forms.Railcar.Edit;

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