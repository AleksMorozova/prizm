using Data.DAL.Hibernate;
using Data.DAL.Mill;
using Data.DAL.Setup;
using Data.DAL;
using NHibernate;
using Ninject.Modules;
using PrizmMain.Forms.PipeMill.Search;
using PrizmMain.Forms.Component.NewEdit;
using PrizmMain.Forms.Component.Search;
using PrizmMain.Forms.Joint.NewEdit;
using PrizmMain.Forms.Joint.Search;
using PrizmMain.Forms.PipeIncoming;
using PrizmMain.Forms.PipeMill.NewEdit;
using PrizmMain.Forms.Railcar.NewEdit;
using PrizmMain.Forms.Railcar.Search;
using PrizmMain.Forms.Reports.Construction;
using PrizmMain.Forms.Reports.Incoming;
using PrizmMain.Forms.Reports.Mill;
using PrizmMain.Forms.Settings;
using PrizmMain.Forms.Spool;
using PrizmMain.Forms;
using PrizmMain.Forms.PipeMill.Heat;
using PrizmMain.Forms.Railcar;
using PrizmMain.Forms.PipeMill;
using PrizmMain.Forms.MainChildForm;
using PrizmMain.Forms.PipeMill.Purchase;
using Data.DAL.ADO;
using Data.DAL.Security;
using PrizmMain.Forms.Audit;
using PrizmMain.Security;
using PrizmMain.Forms.Joint;
using Data.DAL.Construction;
using PrizmMain.Forms.InspectionParts.Search;

namespace PrizmMain
{
    public class PrizmModule : NinjectModule
    {
        
        public override void Load()
        {
            #region Repository
            Bind<ISession>().ToMethod(_ => HibernateUtil.OpenSession(true));

            Bind<IRailcarRepository>().To<RailcarRepository>();
            Bind<IPipeRepository>().To<PipeRepository>();
            Bind<IHeatRepository>().To<HeatRepository>();
            Bind<IPlateRepository>().To<PlateRepository>();
            Bind<IAuditLogRepository>().To<AuditLogRepository>();
            Bind<IPurchaseOrderRepository>().To<PurchaseOrderRepository>();
            Bind<IWeldRepository>().To<WeldRepository>();
            Bind<IWelderRepository>().To<WelderRepository>();
            Bind<IPipeTestResultRepository>().To<PipeTestResultRepository>();
            Bind<IMillPipeSizeTypeRepository>().To<MillPipeSizeTypeRepository>();
            Bind<IPipeTestRepository>().To<PipeTestRepository>();
            Bind<IMillRepository>().To<MillRepository>();
            Bind<IJointOperationRepository>().To<JointOperationRepository>();

            Bind<ISettingsRepositories>().To<SettingsRepositories>();
            Bind<IRailcarRepositories>().To<RailcarRepositories>();
            Bind<IHeatRepositories>().To<HeatRepositories>();
            Bind<IProjectRepository>().To<ProjectRepository>();
            Bind<ICategoryRepository>().To<CategoryRepository>();
            Bind<IMillReportsRepository>().To<MillReportsRepository>();
            Bind<IUserRepository>().To<UserRepository>();
            Bind<IRoleRepository>().To<RoleRepository>();
            Bind<IPermissionRepository>().To<PermissionRepository>();
            Bind<IConstructionRepository>().To<ConstructionRepository>();
            Bind<IJointRepository>().To<JointRepository>();

            // TODO: remove TemporaryContext after binding to real context.
            Bind<PrizmMain.Security.ISecurityContext>().To<SecurityContext>().InSingletonScope();

            #endregion

            #region ViewModel
            Bind<HeatViewModel>().ToSelf();
            Bind<PurchaseOrderViewModel>().ToSelf();
            Bind<RailcarViewModel>().ToSelf();
            Bind<MillPipeSearchViewModel>().ToSelf();
            Bind<MillPipeNewEditViewModel>().ToSelf();
            Bind<RailcarSearchViewModel>().ToSelf();
            Bind<SettingsViewModel>().ToSelf();
            Bind<MillReportsViewModel>().ToSelf();
            Bind<PrizmApplicationViewModel>().ToSelf();
            Bind<JointNewEditViewModel>().ToSelf();
            Bind<PartsSearchViewModel>().ToSelf();
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
            Bind<HeatXtraForm>().ToSelf();
            Bind<PurchaseOrderXtraForm>().ToSelf();
            Bind<AuditXtraForm>().ToSelf();
            Bind<PartsSearchXtraForm>().ToSelf();
            #endregion

            Bind<IUserNotify>().To<PrizmApplicationXtraForm>().InSingletonScope();
            Bind<AuditInterceptor>().ToSelf();
        }
    }
}