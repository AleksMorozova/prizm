using Data.DAL.Hibernate;
using Data.DAL.Mill;
using NHibernate;
using Ninject.Modules;
using PrizmMain.Forms.PipeMill.Search;
using PrizmMain.Forms.Railcar.NewEdit;

using Data.DAL.Hibernate;

namespace PrizmMain
{
    public class PrizmModule : NinjectModule
    {
        public override void Load()
        {
            Bind<RailcarViewModel>().ToSelf();
            Bind<IRailcarRepository>().To<RailcarRepository>();

            Bind<MillPipeSearchViewModel>().ToSelf();
            Bind<IPipeRepository>().To<PipeRepository>();

            Bind<ISession>().ToMethod(_ => HibernateUtil.OpenSession());
        }
    }
}