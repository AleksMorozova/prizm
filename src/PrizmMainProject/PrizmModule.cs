using Data.DAL.Hibernate;
using Data.DAL.Mill;
using NHibernate;
using Ninject.Modules;
using PrizmMain.Forms.Railcar.NewEdit;
using PrizmMain.Forms.Railcar.Search;

namespace PrizmMain
{
    public class PrizmModule : NinjectModule
    {
        public override void Load()
        {
            Bind<RailcarViewModel>().ToSelf();
            Bind<IRailcarRepository>().To<RailcarRepository>();
            Bind<ISession>().ToMethod(_ => HibernateUtil.OpenSession());

            Bind<RailcarSearchViewModel>().ToSelf();
        }
    }
}