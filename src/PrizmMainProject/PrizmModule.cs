using Data.DAL.Hibernate;
using Data.DAL.Mill;
using Data.DAL.Setup;
using NHibernate;
using Ninject.Modules;
using PrizmMain.Forms.Component.NewEdit;
using PrizmMain.Forms.Component.Search;
using PrizmMain.Forms.Joint.NewEdit;
using PrizmMain.Forms.Joint.Search;
using PrizmMain.Forms.PipeIncoming;
using PrizmMain.Forms.PipeMill.NewEdit;
using PrizmMain.Forms.PipeMill.Search;
using PrizmMain.Forms.Railcar.NewEdit;
using PrizmMain.Forms.Railcar.Search;
using PrizmMain.Forms.Reports.Construction;
using PrizmMain.Forms.Reports.Incoming;
using PrizmMain.Forms.Reports.Mill;
using PrizmMain.Forms.Settings;
using PrizmMain.Forms.Spool;

namespace PrizmMain
{
    public class PrizmModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ISession>().ToMethod(_ => HibernateUtil.OpenSession());

            #region Repository
            Bind<IRailcarRepository>().To<RailcarRepository>();
            Bind<IMillPipeSizeTypeRepository>().To<MillPipeSizeTypeRepository>(); 
            #endregion

            #region ViewModel
            Bind<RailcarViewModel>().ToSelf();
            Bind<RailcarSearchViewModel>().ToSelf();
            Bind<SettingsViewModel>().ToSelf();
            #endregion

            #region Forms Binding
            Bind<MillPipeNewEditXtraForm>().ToSelf();
            Bind<RailcarNewEditXtraForm>().ToSelf();
            Bind<MillPipeSearchXtraForm>().ToSelf();
            Bind<MillReportsXtraForm>().ToSelf();
            Bind<ComponentNewEditXtraForm>().ToSelf();
            Bind<InspectionReportsXtraForm>().ToSelf();
            Bind<ComponentSearchXtraForm>().ToSelf();
            Bind<JointNewEditXtraForm>().ToSelf();
            Bind<JointSearchXtraForm>().ToSelf();
            Bind<ConstructionReportsXtraForm>().ToSelf();
            Bind<SettingsXtraForm>().ToSelf();
            Bind<RailcarSearchXtraForm>().ToSelf();
            Bind<InspectionPipeSearchEditXtraForm>().ToSelf();
            Bind<SpoolsXtraForm>().ToSelf();
            #endregion
        }
    }
}