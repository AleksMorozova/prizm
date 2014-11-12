using Data.DAL.Hibernate;
using Data.DAL.Mill;
using Data.DAL.Setup;
using NHibernate;
using Ninject.Modules;
using PrizmMain.Forms.Railcar.NewEdit;
using PrizmMain.Forms.Settings;

namespace PrizmMain
{
    public class PrizmModule : NinjectModule
    {
        public override void Load()
        {
            Bind<RailcarViewModel>().ToSelf();
            Bind<IRailcarRepository>().To<RailcarRepository>();

            Bind<SettingsViewModel>().ToSelf();
            Bind<IMillPipeSizeTypeRepository>().To<SettingsRepository>();

            Bind<ISession>().ToMethod(_ => HibernateUtil.OpenSession());
        }
    }
}