namespace Prizm.Main.Forms.Settings
{
    partial class SettingsXtraForm
    {
        /// <summary>
        /// Required  variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsXtraForm));
            this.pipesSizeList = new DevExpress.XtraGrid.GridControl();
            this.pipesSizeListGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pipeSizeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.typeRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.isActiveGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlPermission = new DevExpress.XtraGrid.GridControl();
            this.permissionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPermissions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPermissionDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewRole = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRoleSetupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlRoles = new DevExpress.XtraGrid.GridControl();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewRoles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlUsers = new DevExpress.XtraGrid.GridControl();
            this.gridViewUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPasswordExpires = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserPass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonUserPass = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.certificateTypes = new DevExpress.XtraGrid.GridControl();
            this.certificateTypesView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.certificateNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.certificateIsActiveColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryCertificateIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridControlInspectorsCertificates = new DevExpress.XtraGrid.GridControl();
            this.inspectorCertificateGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.inspectorCertificateNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.certificateTypeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryLookUpCertificateType = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryLookUpCertificateTypeView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.inspectorCertificateTypeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorCertificateExpirationCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlInspectors = new DevExpress.XtraGrid.GridControl();
            this.gridViewInspectors = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInspectorLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorLNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colInspectorFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorFNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colInspectorMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorMNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colInspectorActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInspectorCertExp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInspectorCertificate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorCertificateTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridControlWelders = new DevExpress.XtraGrid.GridControl();
            this.gridViewWelders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWelderFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.welderFNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colWelderLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.welderLNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colWelderMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.welderMNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colWelderCert = new DevExpress.XtraGrid.Columns.GridColumn();
            this.welderCertificateTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colWelderCertExp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWelderStamp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stampRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colWelderGrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWelderActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.componentryTypeGridControl = new DevExpress.XtraGrid.GridControl();
            this.componentryTypeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.typeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.connectorsNumbersColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryConnectorsNumbers = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.isActiveComponentColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryComponentryTypeCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.jointOperations = new DevExpress.XtraGrid.GridControl();
            this.jointsOperationsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isRequiredForJointGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TestTypeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.jointOperationTypeLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.testHasAcceptedGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.testHasToRepairGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.testHasToWithdrawGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.testResultRequiredGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isActiveJointOperationGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.externalDocumentSize = new DevExpress.XtraEditors.TextEdit();
            this.rootLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.closeButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.seemType = new DevExpress.XtraGrid.GridControl();
            this.seemTypeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.seemTypeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seemTypeIsActiveColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cloneTypeSizeButton = new DevExpress.XtraEditors.SimpleButton();
            this.categoriesGrid = new DevExpress.XtraGrid.GridControl();
            this.categoriesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.categoryNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.categoryRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.isActiveColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryIsActiveCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pipeNumberMaskRulesLabel = new DevExpress.XtraEditors.LabelControl();
            this.seamType = new DevExpress.XtraEditors.TextEdit();
            this.pipeLength = new DevExpress.XtraEditors.TextEdit();
            this.pipeNumberMask = new DevExpress.XtraEditors.TextEdit();
            this.millName = new DevExpress.XtraEditors.TextEdit();
            this.projectTitle = new DevExpress.XtraEditors.TextEdit();
            this.inspectionOperation = new DevExpress.XtraGrid.GridControl();
            this.inspectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inspectionView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.inspectionCodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.codeRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.inspectionNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.controlNameRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.controlTypeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.controlTypeItems = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.resultTypeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.resultTypeItems = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.boolExpectedGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.minExpectedGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maxExpectedGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isRequiredGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isRequired = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.testIsActiveGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.categoryColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemsСategory = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemsСategoryView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.subjectRepositoryItemEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.plateManufacturersList = new DevExpress.XtraGrid.GridControl();
            this.plateManufacturersListView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.plateManufacturerGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.manufacturerRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.client = new DevExpress.XtraEditors.TextEdit();
            this.wallThickness = new DevExpress.XtraEditors.TextEdit();
            this.pipeDiameter = new DevExpress.XtraEditors.TextEdit();
            this.RootGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabbedControlGroup = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup11 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup12 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup13 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup7 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup8 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup9 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup10 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup14 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem23 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem24 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup15 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem25 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem26 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem27 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem28 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.editDictionary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.editItem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pipeMillSizeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inspectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inspectorCertificateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jointOperationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.CurrentPipeMillSizeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pipesSizeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesSizeListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPermissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonUserPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateTypesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryCertificateIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInspectorsCertificates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorCertificateGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryLookUpCertificateType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryLookUpCertificateTypeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInspectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInspectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorLNRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorFNRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorMNRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorCertificateTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWelders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWelders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderFNRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderLNRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderMNRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderCertificateTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stampRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentryTypeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentryTypeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryConnectorsNumbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryComponentryTypeCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointsOperationsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointOperationTypeLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutControl)).BeginInit();
            this.rootLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seemType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seemTypeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryIsActiveCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seamType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumberMask.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlNameRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTypeItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultTypeItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isRequired)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemsСategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemsСategoryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectRepositoryItemEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallThickness.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDiameter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RootGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeMillSizeTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorCertificateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointOperationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPipeMillSizeTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pipesSizeList
            // 
            this.pipesSizeList.Cursor = System.Windows.Forms.Cursors.Default;
            this.pipesSizeList.Location = new System.Drawing.Point(24, 62);
            this.pipesSizeList.MainView = this.pipesSizeListGridView;
            this.pipesSizeList.Name = "pipesSizeList";
            this.pipesSizeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.typeRepositoryTextEdit});
            this.pipesSizeList.Size = new System.Drawing.Size(433, 412);
            this.pipesSizeList.TabIndex = 11;
            this.pipesSizeList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.pipesSizeListGridView});
            // 
            // pipesSizeListGridView
            // 
            this.pipesSizeListGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.pipeSizeGridColumn,
            this.isActiveGridColumn});
            this.pipesSizeListGridView.GridControl = this.pipesSizeList;
            this.pipesSizeListGridView.Name = "pipesSizeListGridView";
            this.pipesSizeListGridView.OptionsBehavior.FocusLeaveOnTab = true;
            this.pipesSizeListGridView.OptionsNavigation.UseTabKey = false;
            this.pipesSizeListGridView.OptionsView.ShowGroupPanel = false;
            this.pipesSizeListGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.pipesSizeListGridView_InitNewRow);
            this.pipesSizeListGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.pipesSizeListGridView_FocusedRowChanged);
            this.pipesSizeListGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pipesSizeListGridView_KeyDown);
            // 
            // pipeSizeGridColumn
            // 
            this.pipeSizeGridColumn.Caption = "Типоразмер";
            this.pipeSizeGridColumn.ColumnEdit = this.typeRepositoryTextEdit;
            this.pipeSizeGridColumn.FieldName = "Type";
            this.pipeSizeGridColumn.Name = "pipeSizeGridColumn";
            this.pipeSizeGridColumn.Visible = true;
            this.pipeSizeGridColumn.VisibleIndex = 0;
            this.pipeSizeGridColumn.Width = 213;
            // 
            // typeRepositoryTextEdit
            // 
            this.typeRepositoryTextEdit.AutoHeight = false;
            this.typeRepositoryTextEdit.Name = "typeRepositoryTextEdit";
            // 
            // isActiveGridColumn
            // 
            this.isActiveGridColumn.Caption = "Активный";
            this.isActiveGridColumn.FieldName = "IsActive";
            this.isActiveGridColumn.Name = "isActiveGridColumn";
            this.isActiveGridColumn.Visible = true;
            this.isActiveGridColumn.VisibleIndex = 1;
            this.isActiveGridColumn.Width = 42;
            // 
            // gridControlPermission
            // 
            this.gridControlPermission.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlPermission.DataSource = this.permissionsBindingSource;
            this.gridControlPermission.Location = new System.Drawing.Point(939, 62);
            this.gridControlPermission.MainView = this.gridViewPermissions;
            this.gridControlPermission.Name = "gridControlPermission";
            this.gridControlPermission.Size = new System.Drawing.Size(312, 438);
            this.gridControlPermission.TabIndex = 5;
            this.gridControlPermission.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPermissions});
            // 
            // gridViewPermissions
            // 
            this.gridViewPermissions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPermissionDesc});
            this.gridViewPermissions.GridControl = this.gridControlPermission;
            this.gridViewPermissions.Name = "gridViewPermissions";
            this.gridViewPermissions.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewPermissions.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridViewPermissions.OptionsNavigation.UseTabKey = false;
            this.gridViewPermissions.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewPermissions.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridViewPermissions.OptionsSelection.MultiSelect = true;
            this.gridViewPermissions.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewPermissions.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewPermissions.OptionsView.ShowColumnHeaders = false;
            this.gridViewPermissions.OptionsView.ShowGroupPanel = false;
            this.gridViewPermissions.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewPermissions_SelectionChanged);
            // 
            // colPermissionDesc
            // 
            this.colPermissionDesc.Caption = "Описание";
            this.colPermissionDesc.FieldName = "Description";
            this.colPermissionDesc.Name = "colPermissionDesc";
            this.colPermissionDesc.OptionsColumn.ReadOnly = true;
            this.colPermissionDesc.Visible = true;
            this.colPermissionDesc.VisibleIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.rolesBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(24, 62);
            this.gridControl1.MainView = this.gridViewRole;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(911, 438);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRole});
            // 
            // gridViewRole
            // 
            this.gridViewRole.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRoleSetupName,
            this.colDesc});
            this.gridViewRole.GridControl = this.gridControl1;
            this.gridViewRole.Name = "gridViewRole";
            this.gridViewRole.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewRole.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridViewRole.OptionsNavigation.UseTabKey = false;
            this.gridViewRole.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewRole.OptionsView.ShowGroupPanel = false;
            this.gridViewRole.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewRole_FocusedRowChanged);
            this.gridViewRole.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewRole_InvalidRowException);
            this.gridViewRole.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewRole_ValidateRow);
            // 
            // colRoleSetupName
            // 
            this.colRoleSetupName.Caption = "Название";
            this.colRoleSetupName.FieldName = "Name";
            this.colRoleSetupName.Name = "colRoleSetupName";
            this.colRoleSetupName.Visible = true;
            this.colRoleSetupName.VisibleIndex = 0;
            // 
            // colDesc
            // 
            this.colDesc.Caption = "Описание";
            this.colDesc.FieldName = "Description";
            this.colDesc.Name = "colDesc";
            this.colDesc.Visible = true;
            this.colDesc.VisibleIndex = 1;
            // 
            // gridControlRoles
            // 
            this.gridControlRoles.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlRoles.DataSource = this.usersBindingSource;
            this.gridControlRoles.Location = new System.Drawing.Point(939, 62);
            this.gridControlRoles.MainView = this.gridViewRoles;
            this.gridControlRoles.Name = "gridControlRoles";
            this.gridControlRoles.Size = new System.Drawing.Size(312, 438);
            this.gridControlRoles.TabIndex = 5;
            this.gridControlRoles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRoles});
            // 
            // gridViewRoles
            // 
            this.gridViewRoles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRoleName,
            this.colRoleDesc});
            this.gridViewRoles.GridControl = this.gridControlRoles;
            this.gridViewRoles.Name = "gridViewRoles";
            this.gridViewRoles.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewRoles.OptionsSelection.MultiSelect = true;
            this.gridViewRoles.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewRoles.OptionsView.ShowColumnHeaders = false;
            this.gridViewRoles.OptionsView.ShowGroupPanel = false;
            this.gridViewRoles.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewRoles_SelectionChanged);
            // 
            // colRoleName
            // 
            this.colRoleName.Caption = "Название";
            this.colRoleName.FieldName = "Name";
            this.colRoleName.Name = "colRoleName";
            this.colRoleName.OptionsColumn.ReadOnly = true;
            this.colRoleName.Visible = true;
            this.colRoleName.VisibleIndex = 1;
            // 
            // colRoleDesc
            // 
            this.colRoleDesc.Caption = "Описание";
            this.colRoleDesc.FieldName = "Description";
            this.colRoleDesc.Name = "colRoleDesc";
            this.colRoleDesc.OptionsColumn.ReadOnly = true;
            this.colRoleDesc.Visible = true;
            this.colRoleDesc.VisibleIndex = 2;
            // 
            // gridControlUsers
            // 
            this.gridControlUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlUsers.DataSource = this.usersBindingSource;
            this.gridControlUsers.Location = new System.Drawing.Point(24, 62);
            this.gridControlUsers.MainView = this.gridViewUsers;
            this.gridControlUsers.Name = "gridControlUsers";
            this.gridControlUsers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonUserPass});
            this.gridControlUsers.Size = new System.Drawing.Size(911, 438);
            this.gridControlUsers.TabIndex = 4;
            this.gridControlUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUsers});
            // 
            // gridViewUsers
            // 
            this.gridViewUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLogin,
            this.colLastName,
            this.colFirstName,
            this.colMiddleName,
            this.colPasswordExpires,
            this.colActive,
            this.colUserPass});
            this.gridViewUsers.GridControl = this.gridControlUsers;
            this.gridViewUsers.Name = "gridViewUsers";
            this.gridViewUsers.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewUsers.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewUsers.OptionsView.ShowGroupPanel = false;
            this.gridViewUsers.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridViewUsers_ShowingEditor);
            this.gridViewUsers.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewUsers_InitNewRow);
            this.gridViewUsers.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewUsers_FocusedRowChanged);
            this.gridViewUsers.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewUsers_InvalidRowException);
            this.gridViewUsers.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewUsers_ValidateRow);
            this.gridViewUsers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewUsers_KeyDown);
            // 
            // colLogin
            // 
            this.colLogin.Caption = "Логин";
            this.colLogin.FieldName = "Login";
            this.colLogin.Name = "colLogin";
            this.colLogin.Visible = true;
            this.colLogin.VisibleIndex = 0;
            this.colLogin.Width = 145;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Фамилия";
            this.colLastName.FieldName = "Name.LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 1;
            this.colLastName.Width = 145;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "Имя";
            this.colFirstName.FieldName = "Name.FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 2;
            this.colFirstName.Width = 145;
            // 
            // colMiddleName
            // 
            this.colMiddleName.Caption = "Отчество";
            this.colMiddleName.FieldName = "Name.MiddleName";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.Visible = true;
            this.colMiddleName.VisibleIndex = 3;
            this.colMiddleName.Width = 145;
            // 
            // colPasswordExpires
            // 
            this.colPasswordExpires.Caption = "Пароль истекает";
            this.colPasswordExpires.FieldName = "PasswordExpires";
            this.colPasswordExpires.Name = "colPasswordExpires";
            this.colPasswordExpires.Visible = true;
            this.colPasswordExpires.VisibleIndex = 4;
            this.colPasswordExpires.Width = 145;
            // 
            // colActive
            // 
            this.colActive.Caption = "Активен";
            this.colActive.FieldName = "IsActive";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 5;
            this.colActive.Width = 145;
            // 
            // colUserPass
            // 
            this.colUserPass.Caption = "Пароль";
            this.colUserPass.ColumnEdit = this.repositoryItemButtonUserPass;
            this.colUserPass.Name = "colUserPass";
            this.colUserPass.Visible = true;
            this.colUserPass.VisibleIndex = 6;
            this.colUserPass.Width = 60;
            // 
            // repositoryItemButtonUserPass
            // 
            this.repositoryItemButtonUserPass.AutoHeight = false;
            this.repositoryItemButtonUserPass.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::Prizm.Main.Properties.Resources.password, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonUserPass.Name = "repositoryItemButtonUserPass";
            this.repositoryItemButtonUserPass.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonUserPass.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonUserPass_ButtonClick);
            // 
            // certificateTypes
            // 
            this.certificateTypes.Cursor = System.Windows.Forms.Cursors.Default;
            this.certificateTypes.Location = new System.Drawing.Point(927, 93);
            this.certificateTypes.MainView = this.certificateTypesView;
            this.certificateTypes.Name = "certificateTypes";
            this.certificateTypes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryCertificateIsActive});
            this.certificateTypes.Size = new System.Drawing.Size(312, 395);
            this.certificateTypes.TabIndex = 5;
            this.certificateTypes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.certificateTypesView});
            // 
            // certificateTypesView
            // 
            this.certificateTypesView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.certificateNameColumn,
            this.certificateIsActiveColumn});
            this.certificateTypesView.GridControl = this.certificateTypes;
            this.certificateTypesView.Name = "certificateTypesView";
            this.certificateTypesView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.certificateTypesView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.certificateTypesView.OptionsView.ShowGroupPanel = false;
            this.certificateTypesView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.certificateTypesView_InitNewRow);
            this.certificateTypesView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.certificateTypesView_KeyDown);
            // 
            // certificateNameColumn
            // 
            this.certificateNameColumn.Caption = "Название";
            this.certificateNameColumn.FieldName = "Name";
            this.certificateNameColumn.Name = "certificateNameColumn";
            this.certificateNameColumn.Visible = true;
            this.certificateNameColumn.VisibleIndex = 0;
            this.certificateNameColumn.Width = 205;
            // 
            // certificateIsActiveColumn
            // 
            this.certificateIsActiveColumn.Caption = "Активен";
            this.certificateIsActiveColumn.ColumnEdit = this.repositoryCertificateIsActive;
            this.certificateIsActiveColumn.FieldName = "IsActive";
            this.certificateIsActiveColumn.Name = "certificateIsActiveColumn";
            this.certificateIsActiveColumn.Visible = true;
            this.certificateIsActiveColumn.VisibleIndex = 1;
            this.certificateIsActiveColumn.Width = 59;
            // 
            // repositoryCertificateIsActive
            // 
            this.repositoryCertificateIsActive.AutoHeight = false;
            this.repositoryCertificateIsActive.Name = "repositoryCertificateIsActive";
            // 
            // gridControlInspectorsCertificates
            // 
            this.gridControlInspectorsCertificates.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlInspectorsCertificates.Location = new System.Drawing.Point(430, 93);
            this.gridControlInspectorsCertificates.MainView = this.inspectorCertificateGridView;
            this.gridControlInspectorsCertificates.Name = "gridControlInspectorsCertificates";
            this.gridControlInspectorsCertificates.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryLookUpCertificateType});
            this.gridControlInspectorsCertificates.Size = new System.Drawing.Size(469, 395);
            this.gridControlInspectorsCertificates.TabIndex = 4;
            this.gridControlInspectorsCertificates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.inspectorCertificateGridView});
            // 
            // inspectorCertificateGridView
            // 
            this.inspectorCertificateGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.inspectorCertificateNumberCol,
            this.certificateTypeColumn,
            this.inspectorCertificateExpirationCol});
            this.inspectorCertificateGridView.GridControl = this.gridControlInspectorsCertificates;
            this.inspectorCertificateGridView.Name = "inspectorCertificateGridView";
            this.inspectorCertificateGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.inspectorCertificateGridView.OptionsBehavior.FocusLeaveOnTab = true;
            this.inspectorCertificateGridView.OptionsCustomization.AllowGroup = false;
            this.inspectorCertificateGridView.OptionsNavigation.UseTabKey = false;
            this.inspectorCertificateGridView.OptionsView.ShowGroupPanel = false;
            this.inspectorCertificateGridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.inspectorCertificateGridView_RowCellStyle);
            this.inspectorCertificateGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.inspectorCertificateGridView_InitNewRow);
            this.inspectorCertificateGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.inspectorCertificateGridView_ValidateRow);
            this.inspectorCertificateGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inspectorCertificateGridView_KeyDown);
            // 
            // inspectorCertificateNumberCol
            // 
            this.inspectorCertificateNumberCol.Caption = "Номер";
            this.inspectorCertificateNumberCol.FieldName = "Certificate.Number";
            this.inspectorCertificateNumberCol.Name = "inspectorCertificateNumberCol";
            this.inspectorCertificateNumberCol.Visible = true;
            this.inspectorCertificateNumberCol.VisibleIndex = 0;
            this.inspectorCertificateNumberCol.Width = 50;
            // 
            // certificateTypeColumn
            // 
            this.certificateTypeColumn.Caption = "Тип";
            this.certificateTypeColumn.ColumnEdit = this.repositoryLookUpCertificateType;
            this.certificateTypeColumn.FieldName = "Type";
            this.certificateTypeColumn.Name = "certificateTypeColumn";
            this.certificateTypeColumn.Visible = true;
            this.certificateTypeColumn.VisibleIndex = 1;
            // 
            // repositoryLookUpCertificateType
            // 
            this.repositoryLookUpCertificateType.AutoHeight = false;
            this.repositoryLookUpCertificateType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryLookUpCertificateType.Name = "repositoryLookUpCertificateType";
            this.repositoryLookUpCertificateType.NullText = "";
            this.repositoryLookUpCertificateType.View = this.repositoryLookUpCertificateTypeView;
            // 
            // repositoryLookUpCertificateTypeView
            // 
            this.repositoryLookUpCertificateTypeView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.inspectorCertificateTypeColumn});
            this.repositoryLookUpCertificateTypeView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryLookUpCertificateTypeView.Name = "repositoryLookUpCertificateTypeView";
            this.repositoryLookUpCertificateTypeView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryLookUpCertificateTypeView.OptionsView.ShowGroupPanel = false;
            this.repositoryLookUpCertificateTypeView.CustomRowFilter += new DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(this.repositoryLookUpCertificateTypeView_CustomRowFilter);
            // 
            // inspectorCertificateTypeColumn
            // 
            this.inspectorCertificateTypeColumn.FieldName = "Name";
            this.inspectorCertificateTypeColumn.Name = "inspectorCertificateTypeColumn";
            this.inspectorCertificateTypeColumn.OptionsColumn.ShowCaption = false;
            this.inspectorCertificateTypeColumn.Visible = true;
            this.inspectorCertificateTypeColumn.VisibleIndex = 0;
            // 
            // inspectorCertificateExpirationCol
            // 
            this.inspectorCertificateExpirationCol.Caption = "Дата окончания";
            this.inspectorCertificateExpirationCol.FieldName = "Certificate.ExpirationDate";
            this.inspectorCertificateExpirationCol.MaxWidth = 90;
            this.inspectorCertificateExpirationCol.Name = "inspectorCertificateExpirationCol";
            this.inspectorCertificateExpirationCol.Visible = true;
            this.inspectorCertificateExpirationCol.VisibleIndex = 2;
            this.inspectorCertificateExpirationCol.Width = 50;
            // 
            // gridControlInspectors
            // 
            this.gridControlInspectors.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlInspectors.Location = new System.Drawing.Point(36, 93);
            this.gridControlInspectors.MainView = this.gridViewInspectors;
            this.gridControlInspectors.Name = "gridControlInspectors";
            this.gridControlInspectors.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.inspectorLNRepositoryTextEdit,
            this.inspectorFNRepositoryTextEdit,
            this.inspectorMNRepositoryTextEdit,
            this.inspectorCertificateTextEdit});
            this.gridControlInspectors.Size = new System.Drawing.Size(390, 395);
            this.gridControlInspectors.TabIndex = 0;
            this.gridControlInspectors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInspectors});
            this.gridControlInspectors.Click += new System.EventHandler(this.gridControlInspectors_Click);
            // 
            // gridViewInspectors
            // 
            this.gridViewInspectors.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInspectorLastName,
            this.colInspectorFirstName,
            this.colInspectorMiddleName,
            this.colInspectorActive,
            this.colInspectorCertExp,
            this.colInspectorCertificate});
            this.gridViewInspectors.GridControl = this.gridControlInspectors;
            this.gridViewInspectors.Name = "gridViewInspectors";
            this.gridViewInspectors.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridViewInspectors.OptionsNavigation.UseTabKey = false;
            this.gridViewInspectors.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewInspectors.OptionsView.ShowGroupPanel = false;
            this.gridViewInspectors.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewInspectors_RowCellStyle);
            this.gridViewInspectors.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewInspectors_FocusedRowChanged);
            this.gridViewInspectors.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.HandleInvalidRowException);
            this.gridViewInspectors.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewInspectors_ValidateRow);
            this.gridViewInspectors.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewInspectors_KeyDown);
            // 
            // colInspectorLastName
            // 
            this.colInspectorLastName.Caption = "Фамилия";
            this.colInspectorLastName.ColumnEdit = this.inspectorLNRepositoryTextEdit;
            this.colInspectorLastName.FieldName = "LastName";
            this.colInspectorLastName.Name = "colInspectorLastName";
            this.colInspectorLastName.Visible = true;
            this.colInspectorLastName.VisibleIndex = 0;
            this.colInspectorLastName.Width = 162;
            // 
            // inspectorLNRepositoryTextEdit
            // 
            this.inspectorLNRepositoryTextEdit.AutoHeight = false;
            this.inspectorLNRepositoryTextEdit.Name = "inspectorLNRepositoryTextEdit";
            // 
            // colInspectorFirstName
            // 
            this.colInspectorFirstName.Caption = "Имя";
            this.colInspectorFirstName.ColumnEdit = this.inspectorFNRepositoryTextEdit;
            this.colInspectorFirstName.FieldName = "FirstName";
            this.colInspectorFirstName.Name = "colInspectorFirstName";
            this.colInspectorFirstName.Visible = true;
            this.colInspectorFirstName.VisibleIndex = 1;
            this.colInspectorFirstName.Width = 136;
            // 
            // inspectorFNRepositoryTextEdit
            // 
            this.inspectorFNRepositoryTextEdit.AutoHeight = false;
            this.inspectorFNRepositoryTextEdit.Name = "inspectorFNRepositoryTextEdit";
            // 
            // colInspectorMiddleName
            // 
            this.colInspectorMiddleName.Caption = "Отчество";
            this.colInspectorMiddleName.ColumnEdit = this.inspectorMNRepositoryTextEdit;
            this.colInspectorMiddleName.FieldName = "MiddleName";
            this.colInspectorMiddleName.Name = "colInspectorMiddleName";
            this.colInspectorMiddleName.Visible = true;
            this.colInspectorMiddleName.VisibleIndex = 2;
            this.colInspectorMiddleName.Width = 169;
            // 
            // inspectorMNRepositoryTextEdit
            // 
            this.inspectorMNRepositoryTextEdit.AutoHeight = false;
            this.inspectorMNRepositoryTextEdit.Name = "inspectorMNRepositoryTextEdit";
            // 
            // colInspectorActive
            // 
            this.colInspectorActive.Caption = "Активен";
            this.colInspectorActive.FieldName = "Active";
            this.colInspectorActive.MaxWidth = 115;
            this.colInspectorActive.Name = "colInspectorActive";
            this.colInspectorActive.Visible = true;
            this.colInspectorActive.VisibleIndex = 3;
            this.colInspectorActive.Width = 55;
            // 
            // colInspectorCertExp
            // 
            this.colInspectorCertExp.Caption = "Дата аттестации";
            this.colInspectorCertExp.FieldName = "CertificateExpiration";
            this.colInspectorCertExp.Name = "colInspectorCertExp";
            this.colInspectorCertExp.Width = 100;
            // 
            // colInspectorCertificate
            // 
            this.colInspectorCertificate.Caption = "Сертификат";
            this.colInspectorCertificate.ColumnEdit = this.inspectorCertificateTextEdit;
            this.colInspectorCertificate.FieldName = "Certificate";
            this.colInspectorCertificate.Name = "colInspectorCertificate";
            this.colInspectorCertificate.Width = 200;
            // 
            // inspectorCertificateTextEdit
            // 
            this.inspectorCertificateTextEdit.AutoHeight = false;
            this.inspectorCertificateTextEdit.Name = "inspectorCertificateTextEdit";
            // 
            // gridControlWelders
            // 
            this.gridControlWelders.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlWelders.Location = new System.Drawing.Point(24, 46);
            this.gridControlWelders.MainView = this.gridViewWelders;
            this.gridControlWelders.Name = "gridControlWelders";
            this.gridControlWelders.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.welderLNRepositoryTextEdit,
            this.welderFNRepositoryTextEdit,
            this.welderMNRepositoryTextEdit,
            this.welderCertificateTextEdit,
            this.stampRepositoryTextEdit});
            this.gridControlWelders.Size = new System.Drawing.Size(1227, 454);
            this.gridControlWelders.TabIndex = 0;
            this.gridControlWelders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWelders});
            // 
            // gridViewWelders
            // 
            this.gridViewWelders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWelderFirstName,
            this.colWelderLastName,
            this.colWelderMiddleName,
            this.colWelderCert,
            this.colWelderCertExp,
            this.colWelderStamp,
            this.colWelderGrade,
            this.colWelderActive});
            this.gridViewWelders.GridControl = this.gridControlWelders;
            this.gridViewWelders.Name = "gridViewWelders";
            this.gridViewWelders.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewWelders.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewWelders.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridViewWelders.OptionsNavigation.UseTabKey = false;
            this.gridViewWelders.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewWelders.OptionsView.ShowGroupPanel = false;
            this.gridViewWelders.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewWelders_RowCellStyle);
            this.gridViewWelders.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.HandleInvalidRowException);
            this.gridViewWelders.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewWelders_ValidateRow);
            this.gridViewWelders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewWelders_KeyDown);
            // 
            // colWelderFirstName
            // 
            this.colWelderFirstName.Caption = "Имя";
            this.colWelderFirstName.ColumnEdit = this.welderFNRepositoryTextEdit;
            this.colWelderFirstName.FieldName = "FirstName";
            this.colWelderFirstName.Name = "colWelderFirstName";
            this.colWelderFirstName.Visible = true;
            this.colWelderFirstName.VisibleIndex = 0;
            this.colWelderFirstName.Width = 164;
            // 
            // welderFNRepositoryTextEdit
            // 
            this.welderFNRepositoryTextEdit.AutoHeight = false;
            this.welderFNRepositoryTextEdit.Name = "welderFNRepositoryTextEdit";
            // 
            // colWelderLastName
            // 
            this.colWelderLastName.Caption = "Фамилия";
            this.colWelderLastName.ColumnEdit = this.welderLNRepositoryTextEdit;
            this.colWelderLastName.FieldName = "LastName";
            this.colWelderLastName.Name = "colWelderLastName";
            this.colWelderLastName.Visible = true;
            this.colWelderLastName.VisibleIndex = 1;
            this.colWelderLastName.Width = 164;
            // 
            // welderLNRepositoryTextEdit
            // 
            this.welderLNRepositoryTextEdit.AutoHeight = false;
            this.welderLNRepositoryTextEdit.Name = "welderLNRepositoryTextEdit";
            // 
            // colWelderMiddleName
            // 
            this.colWelderMiddleName.Caption = "Отчество";
            this.colWelderMiddleName.ColumnEdit = this.welderMNRepositoryTextEdit;
            this.colWelderMiddleName.FieldName = "MiddleName";
            this.colWelderMiddleName.Name = "colWelderMiddleName";
            this.colWelderMiddleName.Visible = true;
            this.colWelderMiddleName.VisibleIndex = 2;
            this.colWelderMiddleName.Width = 164;
            // 
            // welderMNRepositoryTextEdit
            // 
            this.welderMNRepositoryTextEdit.AutoHeight = false;
            this.welderMNRepositoryTextEdit.Name = "welderMNRepositoryTextEdit";
            // 
            // colWelderCert
            // 
            this.colWelderCert.Caption = "Сертификат";
            this.colWelderCert.ColumnEdit = this.welderCertificateTextEdit;
            this.colWelderCert.FieldName = "Certificate.Number";
            this.colWelderCert.Name = "colWelderCert";
            this.colWelderCert.Visible = true;
            this.colWelderCert.VisibleIndex = 3;
            this.colWelderCert.Width = 224;
            // 
            // welderCertificateTextEdit
            // 
            this.welderCertificateTextEdit.AutoHeight = false;
            this.welderCertificateTextEdit.Name = "welderCertificateTextEdit";
            // 
            // colWelderCertExp
            // 
            this.colWelderCertExp.Caption = "Дата аттестации";
            this.colWelderCertExp.FieldName = "CertificateExpiration";
            this.colWelderCertExp.Name = "colWelderCertExp";
            this.colWelderCertExp.Visible = true;
            this.colWelderCertExp.VisibleIndex = 4;
            this.colWelderCertExp.Width = 82;
            // 
            // colWelderStamp
            // 
            this.colWelderStamp.Caption = "Клеймо";
            this.colWelderStamp.ColumnEdit = this.stampRepositoryTextEdit;
            this.colWelderStamp.FieldName = "Stamp";
            this.colWelderStamp.Name = "colWelderStamp";
            this.colWelderStamp.Visible = true;
            this.colWelderStamp.VisibleIndex = 5;
            this.colWelderStamp.Width = 234;
            // 
            // stampRepositoryTextEdit
            // 
            this.stampRepositoryTextEdit.AutoHeight = false;
            this.stampRepositoryTextEdit.Name = "stampRepositoryTextEdit";
            // 
            // colWelderGrade
            // 
            this.colWelderGrade.Caption = "Разряд";
            this.colWelderGrade.FieldName = "Grade";
            this.colWelderGrade.Name = "colWelderGrade";
            this.colWelderGrade.Visible = true;
            this.colWelderGrade.VisibleIndex = 6;
            this.colWelderGrade.Width = 105;
            // 
            // colWelderActive
            // 
            this.colWelderActive.Caption = "Активен";
            this.colWelderActive.FieldName = "Active";
            this.colWelderActive.Name = "colWelderActive";
            this.colWelderActive.Visible = true;
            this.colWelderActive.VisibleIndex = 7;
            this.colWelderActive.Width = 62;
            // 
            // componentryTypeGridControl
            // 
            this.componentryTypeGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.componentryTypeGridControl.Location = new System.Drawing.Point(24, 62);
            this.componentryTypeGridControl.MainView = this.componentryTypeGridView;
            this.componentryTypeGridControl.Name = "componentryTypeGridControl";
            this.componentryTypeGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryComponentryTypeCheck,
            this.repositoryConnectorsNumbers});
            this.componentryTypeGridControl.Size = new System.Drawing.Size(611, 438);
            this.componentryTypeGridControl.TabIndex = 4;
            this.componentryTypeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.componentryTypeGridView});
            // 
            // componentryTypeGridView
            // 
            this.componentryTypeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.typeColumn,
            this.connectorsNumbersColumn,
            this.isActiveComponentColumn});
            this.componentryTypeGridView.GridControl = this.componentryTypeGridControl;
            this.componentryTypeGridView.Name = "componentryTypeGridView";
            this.componentryTypeGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.componentryTypeGridView.OptionsBehavior.FocusLeaveOnTab = true;
            this.componentryTypeGridView.OptionsNavigation.UseTabKey = false;
            this.componentryTypeGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.componentryTypeGridView.OptionsView.ShowGroupPanel = false;
            this.componentryTypeGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.componentryTypeGridView_InitNewRow);
            this.componentryTypeGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.componentryTypeGridView_KeyDown);
            // 
            // typeColumn
            // 
            this.typeColumn.Caption = "Тип комплектующего";
            this.typeColumn.FieldName = "Name";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.Visible = true;
            this.typeColumn.VisibleIndex = 0;
            this.typeColumn.Width = 169;
            // 
            // connectorsNumbersColumn
            // 
            this.connectorsNumbersColumn.Caption = "Количество коннекторов";
            this.connectorsNumbersColumn.ColumnEdit = this.repositoryConnectorsNumbers;
            this.connectorsNumbersColumn.FieldName = "ConnectorsCount";
            this.connectorsNumbersColumn.Name = "connectorsNumbersColumn";
            this.connectorsNumbersColumn.Visible = true;
            this.connectorsNumbersColumn.VisibleIndex = 1;
            this.connectorsNumbersColumn.Width = 280;
            // 
            // repositoryConnectorsNumbers
            // 
            this.repositoryConnectorsNumbers.AutoHeight = false;
            this.repositoryConnectorsNumbers.Mask.EditMask = "[1-9]";
            this.repositoryConnectorsNumbers.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryConnectorsNumbers.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryConnectorsNumbers.Name = "repositoryConnectorsNumbers";
            // 
            // isActiveComponentColumn
            // 
            this.isActiveComponentColumn.Caption = "Активно";
            this.isActiveComponentColumn.ColumnEdit = this.repositoryComponentryTypeCheck;
            this.isActiveComponentColumn.FieldName = "IsActive";
            this.isActiveComponentColumn.Name = "isActiveComponentColumn";
            this.isActiveComponentColumn.Visible = true;
            this.isActiveComponentColumn.VisibleIndex = 2;
            this.isActiveComponentColumn.Width = 59;
            // 
            // repositoryComponentryTypeCheck
            // 
            this.repositoryComponentryTypeCheck.AutoHeight = false;
            this.repositoryComponentryTypeCheck.Name = "repositoryComponentryTypeCheck";
            // 
            // jointOperations
            // 
            this.jointOperations.Cursor = System.Windows.Forms.Cursors.Default;
            this.jointOperations.Location = new System.Drawing.Point(24, 62);
            this.jointOperations.MainView = this.jointsOperationsGridView;
            this.jointOperations.Name = "jointOperations";
            this.jointOperations.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.jointOperationTypeLookUpEdit});
            this.jointOperations.Size = new System.Drawing.Size(1227, 438);
            this.jointOperations.TabIndex = 0;
            this.jointOperations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.jointsOperationsGridView});
            // 
            // jointsOperationsGridView
            // 
            this.jointsOperationsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameGridColumn,
            this.isRequiredForJointGridColumn,
            this.TestTypeColumn,
            this.testHasAcceptedGridColumn,
            this.testHasToRepairGridColumn,
            this.testHasToWithdrawGridColumn,
            this.testResultRequiredGridColumn,
            this.isActiveJointOperationGridColumn});
            this.jointsOperationsGridView.GridControl = this.jointOperations;
            this.jointsOperationsGridView.Name = "jointsOperationsGridView";
            this.jointsOperationsGridView.OptionsBehavior.FocusLeaveOnTab = true;
            this.jointsOperationsGridView.OptionsNavigation.UseTabKey = false;
            this.jointsOperationsGridView.OptionsView.ShowGroupPanel = false;
            this.jointsOperationsGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.jointsOperationsGridView_InitNewRow);
            // 
            // nameGridColumn
            // 
            this.nameGridColumn.Caption = "Название операции";
            this.nameGridColumn.FieldName = "Name";
            this.nameGridColumn.Name = "nameGridColumn";
            this.nameGridColumn.Visible = true;
            this.nameGridColumn.VisibleIndex = 0;
            this.nameGridColumn.Width = 300;
            // 
            // isRequiredForJointGridColumn
            // 
            this.isRequiredForJointGridColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.isRequiredForJointGridColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.isRequiredForJointGridColumn.Caption = "Обязательна";
            this.isRequiredForJointGridColumn.FieldName = "IsRequired";
            this.isRequiredForJointGridColumn.Name = "isRequiredForJointGridColumn";
            this.isRequiredForJointGridColumn.Visible = true;
            this.isRequiredForJointGridColumn.VisibleIndex = 1;
            this.isRequiredForJointGridColumn.Width = 115;
            // 
            // TestTypeColumn
            // 
            this.TestTypeColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.TestTypeColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TestTypeColumn.Caption = "Тип операции";
            this.TestTypeColumn.ColumnEdit = this.jointOperationTypeLookUpEdit;
            this.TestTypeColumn.FieldName = "Type";
            this.TestTypeColumn.Name = "TestTypeColumn";
            this.TestTypeColumn.Visible = true;
            this.TestTypeColumn.VisibleIndex = 2;
            this.TestTypeColumn.Width = 209;
            // 
            // jointOperationTypeLookUpEdit
            // 
            this.jointOperationTypeLookUpEdit.AutoHeight = false;
            this.jointOperationTypeLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.jointOperationTypeLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Text", "Тип операции")});
            this.jointOperationTypeLookUpEdit.DisplayMember = "Text";
            this.jointOperationTypeLookUpEdit.Name = "jointOperationTypeLookUpEdit";
            this.jointOperationTypeLookUpEdit.NullText = "";
            this.jointOperationTypeLookUpEdit.ValueMember = "Value";
            // 
            // testHasAcceptedGridColumn
            // 
            this.testHasAcceptedGridColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.testHasAcceptedGridColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.testHasAcceptedGridColumn.Caption = "Принято";
            this.testHasAcceptedGridColumn.FieldName = "TestHasAccepted";
            this.testHasAcceptedGridColumn.Name = "testHasAcceptedGridColumn";
            this.testHasAcceptedGridColumn.Visible = true;
            this.testHasAcceptedGridColumn.VisibleIndex = 3;
            this.testHasAcceptedGridColumn.Width = 115;
            // 
            // testHasToRepairGridColumn
            // 
            this.testHasToRepairGridColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.testHasToRepairGridColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.testHasToRepairGridColumn.Caption = "Ремонт";
            this.testHasToRepairGridColumn.FieldName = "TestHasToRepair";
            this.testHasToRepairGridColumn.Name = "testHasToRepairGridColumn";
            this.testHasToRepairGridColumn.Visible = true;
            this.testHasToRepairGridColumn.VisibleIndex = 4;
            this.testHasToRepairGridColumn.Width = 115;
            // 
            // testHasToWithdrawGridColumn
            // 
            this.testHasToWithdrawGridColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.testHasToWithdrawGridColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.testHasToWithdrawGridColumn.Caption = "Вырезка";
            this.testHasToWithdrawGridColumn.FieldName = "TestHasToWithdraw";
            this.testHasToWithdrawGridColumn.Name = "testHasToWithdrawGridColumn";
            this.testHasToWithdrawGridColumn.Visible = true;
            this.testHasToWithdrawGridColumn.VisibleIndex = 5;
            this.testHasToWithdrawGridColumn.Width = 115;
            // 
            // testResultRequiredGridColumn
            // 
            this.testResultRequiredGridColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.testResultRequiredGridColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.testResultRequiredGridColumn.Caption = "Обязательный результат";
            this.testResultRequiredGridColumn.FieldName = "TestResultRequired";
            this.testResultRequiredGridColumn.Name = "testResultRequiredGridColumn";
            this.testResultRequiredGridColumn.Visible = true;
            this.testResultRequiredGridColumn.VisibleIndex = 6;
            this.testResultRequiredGridColumn.Width = 115;
            // 
            // isActiveJointOperationGridColumn
            // 
            this.isActiveJointOperationGridColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.isActiveJointOperationGridColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.isActiveJointOperationGridColumn.Caption = "Активна";
            this.isActiveJointOperationGridColumn.FieldName = "IsActive";
            this.isActiveJointOperationGridColumn.Name = "isActiveJointOperationGridColumn";
            this.isActiveJointOperationGridColumn.Visible = true;
            this.isActiveJointOperationGridColumn.VisibleIndex = 7;
            this.isActiveJointOperationGridColumn.Width = 115;
            // 
            // externalDocumentSize
            // 
            this.externalDocumentSize.EditValue = "";
            this.externalDocumentSize.Location = new System.Drawing.Point(48, 456);
            this.externalDocumentSize.Name = "externalDocumentSize";
            this.externalDocumentSize.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.externalDocumentSize.Properties.Mask.EditMask = "d";
            this.externalDocumentSize.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.externalDocumentSize.Properties.Mask.SaveLiteral = false;
            this.externalDocumentSize.Properties.Mask.ShowPlaceHolders = false;
            this.externalDocumentSize.Size = new System.Drawing.Size(391, 20);
            this.externalDocumentSize.StyleController = this.rootLayoutControl;
            this.externalDocumentSize.TabIndex = 4;
            // 
            // rootLayoutControl
            // 
            this.rootLayoutControl.Controls.Add(this.closeButton);
            this.rootLayoutControl.Controls.Add(this.gridControlPermission);
            this.rootLayoutControl.Controls.Add(this.saveButton);
            this.rootLayoutControl.Controls.Add(this.gridControlRoles);
            this.rootLayoutControl.Controls.Add(this.gridControl1);
            this.rootLayoutControl.Controls.Add(this.certificateTypes);
            this.rootLayoutControl.Controls.Add(this.gridControlUsers);
            this.rootLayoutControl.Controls.Add(this.gridControlWelders);
            this.rootLayoutControl.Controls.Add(this.gridControlInspectorsCertificates);
            this.rootLayoutControl.Controls.Add(this.componentryTypeGridControl);
            this.rootLayoutControl.Controls.Add(this.gridControlInspectors);
            this.rootLayoutControl.Controls.Add(this.jointOperations);
            this.rootLayoutControl.Controls.Add(this.externalDocumentSize);
            this.rootLayoutControl.Controls.Add(this.seemType);
            this.rootLayoutControl.Controls.Add(this.cloneTypeSizeButton);
            this.rootLayoutControl.Controls.Add(this.categoriesGrid);
            this.rootLayoutControl.Controls.Add(this.pipeNumberMaskRulesLabel);
            this.rootLayoutControl.Controls.Add(this.seamType);
            this.rootLayoutControl.Controls.Add(this.pipeLength);
            this.rootLayoutControl.Controls.Add(this.pipeNumberMask);
            this.rootLayoutControl.Controls.Add(this.pipesSizeList);
            this.rootLayoutControl.Controls.Add(this.millName);
            this.rootLayoutControl.Controls.Add(this.projectTitle);
            this.rootLayoutControl.Controls.Add(this.inspectionOperation);
            this.rootLayoutControl.Controls.Add(this.plateManufacturersList);
            this.rootLayoutControl.Controls.Add(this.client);
            this.rootLayoutControl.Controls.Add(this.wallThickness);
            this.rootLayoutControl.Controls.Add(this.pipeDiameter);
            this.rootLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.rootLayoutControl.Name = "rootLayoutControl";
            this.rootLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(438, 207, 250, 350);
            this.rootLayoutControl.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.rootLayoutControl.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.rootLayoutControl.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.rootLayoutControl.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.rootLayoutControl.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.rootLayoutControl.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rootLayoutControl.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.rootLayoutControl.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.rootLayoutControl.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.rootLayoutControl.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.rootLayoutControl.Root = this.RootGroup;
            this.rootLayoutControl.Size = new System.Drawing.Size(1275, 550);
            this.rootLayoutControl.TabIndex = 2;
            this.rootLayoutControl.Text = "layoutControl3";
            // 
            // closeButton
            // 
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(1119, 516);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(144, 22);
            this.closeButton.StyleController = this.rootLayoutControl;
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Закр&ыть";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(973, 516);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(142, 22);
            this.saveButton.StyleController = this.rootLayoutControl;
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "&Сохранить";
            // 
            // seemType
            // 
            this.seemType.Cursor = System.Windows.Forms.Cursors.Default;
            this.seemType.Location = new System.Drawing.Point(833, 173);
            this.seemType.MainView = this.seemTypeGridView;
            this.seemType.Name = "seemType";
            this.seemType.Size = new System.Drawing.Size(406, 315);
            this.seemType.TabIndex = 17;
            this.seemType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.seemTypeGridView});
            // 
            // seemTypeGridView
            // 
            this.seemTypeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.seemTypeColumn,
            this.seemTypeIsActiveColumn});
            this.seemTypeGridView.GridControl = this.seemType;
            this.seemTypeGridView.Name = "seemTypeGridView";
            this.seemTypeGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.seemTypeGridView.OptionsView.ShowGroupPanel = false;
            this.seemTypeGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.seemTypeGridView_InitNewRow);
            this.seemTypeGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.seemTypeGridView_KeyDown);
            // 
            // seemTypeColumn
            // 
            this.seemTypeColumn.Caption = "Тип шва";
            this.seemTypeColumn.FieldName = "Name";
            this.seemTypeColumn.Name = "seemTypeColumn";
            this.seemTypeColumn.Visible = true;
            this.seemTypeColumn.VisibleIndex = 0;
            // 
            // seemTypeIsActiveColumn
            // 
            this.seemTypeIsActiveColumn.Caption = "Активен";
            this.seemTypeIsActiveColumn.FieldName = "IsActive";
            this.seemTypeIsActiveColumn.Name = "seemTypeIsActiveColumn";
            this.seemTypeIsActiveColumn.Visible = true;
            this.seemTypeIsActiveColumn.VisibleIndex = 1;
            // 
            // cloneTypeSizeButton
            // 
            this.cloneTypeSizeButton.Image = ((System.Drawing.Image)(resources.GetObject("cloneTypeSizeButton.Image")));
            this.cloneTypeSizeButton.Location = new System.Drawing.Point(24, 478);
            this.cloneTypeSizeButton.Name = "cloneTypeSizeButton";
            this.cloneTypeSizeButton.Size = new System.Drawing.Size(433, 22);
            this.cloneTypeSizeButton.StyleController = this.rootLayoutControl;
            this.cloneTypeSizeButton.TabIndex = 6;
            this.cloneTypeSizeButton.Text = "Копироват&ь типоразмер";
            this.cloneTypeSizeButton.Click += new System.EventHandler(this.cloneTypeSizeButton_Click);
            // 
            // categoriesGrid
            // 
            this.categoriesGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.categoriesGrid.Location = new System.Drawing.Point(479, 173);
            this.categoriesGrid.MainView = this.categoriesGridView;
            this.categoriesGrid.Name = "categoriesGrid";
            this.categoriesGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryIsActiveCheckEdit});
            this.categoriesGrid.Size = new System.Drawing.Size(350, 315);
            this.categoriesGrid.TabIndex = 7;
            this.categoriesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.categoriesGridView});
            // 
            // categoriesGridView
            // 
            this.categoriesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.categoryNameColumn,
            this.isActiveColumn});
            this.categoriesGridView.GridControl = this.categoriesGrid;
            this.categoriesGridView.Name = "categoriesGridView";
            this.categoriesGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.categoriesGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.categoriesGridView.OptionsView.ShowGroupPanel = false;
            this.categoriesGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.categoryGridView_InitNewRow);
            this.categoriesGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.categoryGridView_KeyDown);
            // 
            // categoryNameColumn
            // 
            this.categoryNameColumn.Caption = "Название";
            this.categoryNameColumn.ColumnEdit = this.categoryRepositoryTextEdit;
            this.categoryNameColumn.FieldName = "Name";
            this.categoryNameColumn.Name = "categoryNameColumn";
            this.categoryNameColumn.Visible = true;
            this.categoryNameColumn.VisibleIndex = 0;
            this.categoryNameColumn.Width = 411;
            // 
            // categoryRepositoryTextEdit
            // 
            this.categoryRepositoryTextEdit.AutoHeight = false;
            this.categoryRepositoryTextEdit.Name = "categoryRepositoryTextEdit";
            // 
            // isActiveColumn
            // 
            this.isActiveColumn.Caption = "Активна";
            this.isActiveColumn.ColumnEdit = this.repositoryIsActiveCheckEdit;
            this.isActiveColumn.FieldName = "IsActive";
            this.isActiveColumn.Name = "isActiveColumn";
            this.isActiveColumn.Visible = true;
            this.isActiveColumn.VisibleIndex = 1;
            this.isActiveColumn.Width = 189;
            // 
            // repositoryIsActiveCheckEdit
            // 
            this.repositoryIsActiveCheckEdit.AutoHeight = false;
            this.repositoryIsActiveCheckEdit.Name = "repositoryIsActiveCheckEdit";
            // 
            // pipeNumberMaskRulesLabel
            // 
            this.pipeNumberMaskRulesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pipeNumberMaskRulesLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.pipeNumberMaskRulesLabel.Location = new System.Drawing.Point(836, 117);
            this.pipeNumberMaskRulesLabel.Name = "pipeNumberMaskRulesLabel";
            this.pipeNumberMaskRulesLabel.Size = new System.Drawing.Size(400, 13);
            this.pipeNumberMaskRulesLabel.StyleController = this.rootLayoutControl;
            this.pipeNumberMaskRulesLabel.TabIndex = 16;
            // 
            // seamType
            // 
            this.seamType.Location = new System.Drawing.Point(1038, 456);
            this.seamType.Name = "seamType";
            this.seamType.Size = new System.Drawing.Size(201, 20);
            this.seamType.StyleController = this.rootLayoutControl;
            this.seamType.TabIndex = 14;
            // 
            // pipeLength
            // 
            this.pipeLength.Location = new System.Drawing.Point(859, 456);
            this.pipeLength.Name = "pipeLength";
            this.pipeLength.Size = new System.Drawing.Size(175, 20);
            this.pipeLength.StyleController = this.rootLayoutControl;
            this.pipeLength.TabIndex = 15;
            // 
            // pipeNumberMask
            // 
            this.pipeNumberMask.Location = new System.Drawing.Point(479, 133);
            this.pipeNumberMask.Name = "pipeNumberMask";
            this.pipeNumberMask.Size = new System.Drawing.Size(350, 20);
            this.pipeNumberMask.StyleController = this.rootLayoutControl;
            this.pipeNumberMask.TabIndex = 6;
            // 
            // millName
            // 
            this.millName.Location = new System.Drawing.Point(479, 93);
            this.millName.Name = "millName";
            this.millName.Size = new System.Drawing.Size(760, 20);
            this.millName.StyleController = this.rootLayoutControl;
            this.millName.TabIndex = 5;
            // 
            // projectTitle
            // 
            this.projectTitle.EditValue = "";
            this.projectTitle.Location = new System.Drawing.Point(36, 93);
            this.projectTitle.Name = "projectTitle";
            this.projectTitle.Size = new System.Drawing.Size(415, 20);
            this.projectTitle.StyleController = this.rootLayoutControl;
            this.projectTitle.TabIndex = 1;
            // 
            // inspectionOperation
            // 
            this.inspectionOperation.Cursor = System.Windows.Forms.Cursors.Default;
            this.inspectionOperation.DataSource = this.inspectionBindingSource;
            this.inspectionOperation.Location = new System.Drawing.Point(461, 62);
            this.inspectionOperation.MainView = this.inspectionView;
            this.inspectionOperation.Name = "inspectionOperation";
            this.inspectionOperation.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.isRequired,
            this.controlTypeItems,
            this.resultTypeItems,
            this.codeRepositoryTextEdit,
            this.controlNameRepositoryTextEdit,
            this.subjectRepositoryItemEdit,
            this.repositoryItemsСategory});
            this.inspectionOperation.Size = new System.Drawing.Size(790, 343);
            this.inspectionOperation.TabIndex = 9;
            this.inspectionOperation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.inspectionView});
            // 
            // inspectionBindingSource
            // 
            this.inspectionBindingSource.DataSource = typeof(Prizm.Main.DummyData.InspectionDummy);
            // 
            // inspectionView
            // 
            this.inspectionView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.inspectionCodeGridColumn,
            this.inspectionNameGridColumn,
            this.controlTypeGridColumn,
            this.resultTypeGridColumn,
            this.boolExpectedGridColumn,
            this.minExpectedGridColumn,
            this.maxExpectedGridColumn,
            this.isRequiredGridColumn,
            this.testIsActiveGridColumn,
            this.categoryColumn});
            this.inspectionView.GridControl = this.inspectionOperation;
            this.inspectionView.Name = "inspectionView";
            this.inspectionView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.inspectionView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.inspectionView.OptionsBehavior.FocusLeaveOnTab = true;
            this.inspectionView.OptionsNavigation.UseTabKey = false;
            this.inspectionView.OptionsView.ShowGroupPanel = false;
            this.inspectionView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.inspectionView_InitNewRow);
            this.inspectionView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inspectionView_KeyDown);
            // 
            // inspectionCodeGridColumn
            // 
            this.inspectionCodeGridColumn.Caption = "Код";
            this.inspectionCodeGridColumn.ColumnEdit = this.codeRepositoryTextEdit;
            this.inspectionCodeGridColumn.FieldName = "Code";
            this.inspectionCodeGridColumn.Name = "inspectionCodeGridColumn";
            this.inspectionCodeGridColumn.Visible = true;
            this.inspectionCodeGridColumn.VisibleIndex = 0;
            this.inspectionCodeGridColumn.Width = 60;
            // 
            // codeRepositoryTextEdit
            // 
            this.codeRepositoryTextEdit.AutoHeight = false;
            this.codeRepositoryTextEdit.Name = "codeRepositoryTextEdit";
            // 
            // inspectionNameGridColumn
            // 
            this.inspectionNameGridColumn.Caption = "Название операции";
            this.inspectionNameGridColumn.ColumnEdit = this.controlNameRepositoryTextEdit;
            this.inspectionNameGridColumn.FieldName = "Name";
            this.inspectionNameGridColumn.Name = "inspectionNameGridColumn";
            this.inspectionNameGridColumn.Visible = true;
            this.inspectionNameGridColumn.VisibleIndex = 1;
            this.inspectionNameGridColumn.Width = 240;
            // 
            // controlNameRepositoryTextEdit
            // 
            this.controlNameRepositoryTextEdit.AutoHeight = false;
            this.controlNameRepositoryTextEdit.Name = "controlNameRepositoryTextEdit";
            // 
            // controlTypeGridColumn
            // 
            this.controlTypeGridColumn.Caption = "Вид контроля";
            this.controlTypeGridColumn.ColumnEdit = this.controlTypeItems;
            this.controlTypeGridColumn.FieldName = "ControlType";
            this.controlTypeGridColumn.Name = "controlTypeGridColumn";
            this.controlTypeGridColumn.Visible = true;
            this.controlTypeGridColumn.VisibleIndex = 3;
            this.controlTypeGridColumn.Width = 120;
            // 
            // controlTypeItems
            // 
            this.controlTypeItems.AutoHeight = false;
            this.controlTypeItems.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.controlTypeItems.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Text", "Вид контроля")});
            this.controlTypeItems.DisplayMember = "Text";
            this.controlTypeItems.DropDownRows = 4;
            this.controlTypeItems.Name = "controlTypeItems";
            this.controlTypeItems.NullText = "";
            this.controlTypeItems.ValueMember = "Value";
            // 
            // resultTypeGridColumn
            // 
            this.resultTypeGridColumn.Caption = "Тип результата";
            this.resultTypeGridColumn.ColumnEdit = this.resultTypeItems;
            this.resultTypeGridColumn.FieldName = "ResultType";
            this.resultTypeGridColumn.Name = "resultTypeGridColumn";
            this.resultTypeGridColumn.Visible = true;
            this.resultTypeGridColumn.VisibleIndex = 4;
            this.resultTypeGridColumn.Width = 120;
            // 
            // resultTypeItems
            // 
            this.resultTypeItems.AutoHeight = false;
            this.resultTypeItems.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.resultTypeItems.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Text", "Тип результата")});
            this.resultTypeItems.DisplayMember = "Text";
            this.resultTypeItems.DropDownRows = 3;
            this.resultTypeItems.Name = "resultTypeItems";
            this.resultTypeItems.NullText = "";
            this.resultTypeItems.ValueMember = "Value";
            // 
            // boolExpectedGridColumn
            // 
            this.boolExpectedGridColumn.Caption = "Контрольное значение";
            this.boolExpectedGridColumn.FieldName = "BoolExpected";
            this.boolExpectedGridColumn.MaxWidth = 50;
            this.boolExpectedGridColumn.Name = "boolExpectedGridColumn";
            this.boolExpectedGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.boolExpectedGridColumn.Visible = true;
            this.boolExpectedGridColumn.VisibleIndex = 5;
            this.boolExpectedGridColumn.Width = 50;
            // 
            // minExpectedGridColumn
            // 
            this.minExpectedGridColumn.Caption = "min";
            this.minExpectedGridColumn.FieldName = "MinExpected";
            this.minExpectedGridColumn.Name = "minExpectedGridColumn";
            this.minExpectedGridColumn.Visible = true;
            this.minExpectedGridColumn.VisibleIndex = 6;
            this.minExpectedGridColumn.Width = 50;
            // 
            // maxExpectedGridColumn
            // 
            this.maxExpectedGridColumn.Caption = "max";
            this.maxExpectedGridColumn.FieldName = "MaxExpected";
            this.maxExpectedGridColumn.Name = "maxExpectedGridColumn";
            this.maxExpectedGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.maxExpectedGridColumn.Visible = true;
            this.maxExpectedGridColumn.VisibleIndex = 7;
            this.maxExpectedGridColumn.Width = 50;
            // 
            // isRequiredGridColumn
            // 
            this.isRequiredGridColumn.Caption = "Обязательна для отгрузки";
            this.isRequiredGridColumn.ColumnEdit = this.isRequired;
            this.isRequiredGridColumn.FieldName = "IsRequired";
            this.isRequiredGridColumn.MaxWidth = 50;
            this.isRequiredGridColumn.Name = "isRequiredGridColumn";
            this.isRequiredGridColumn.Visible = true;
            this.isRequiredGridColumn.VisibleIndex = 8;
            this.isRequiredGridColumn.Width = 40;
            // 
            // isRequired
            // 
            this.isRequired.AutoHeight = false;
            this.isRequired.Name = "isRequired";
            // 
            // testIsActiveGridColumn
            // 
            this.testIsActiveGridColumn.Caption = "Активная";
            this.testIsActiveGridColumn.FieldName = "IsActive";
            this.testIsActiveGridColumn.MaxWidth = 50;
            this.testIsActiveGridColumn.Name = "testIsActiveGridColumn";
            this.testIsActiveGridColumn.Visible = true;
            this.testIsActiveGridColumn.VisibleIndex = 9;
            this.testIsActiveGridColumn.Width = 43;
            // 
            // categoryColumn
            // 
            this.categoryColumn.Caption = "Группа";
            this.categoryColumn.ColumnEdit = this.repositoryItemsСategory;
            this.categoryColumn.FieldName = "Category";
            this.categoryColumn.Name = "categoryColumn";
            this.categoryColumn.Visible = true;
            this.categoryColumn.VisibleIndex = 2;
            this.categoryColumn.Width = 135;
            // 
            // repositoryItemsСategory
            // 
            this.repositoryItemsСategory.AutoHeight = false;
            this.repositoryItemsСategory.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemsСategory.LookAndFeel.SkinName = "VS2010";
            this.repositoryItemsСategory.Name = "repositoryItemsСategory";
            this.repositoryItemsСategory.NullText = "";
            this.repositoryItemsСategory.View = this.repositoryItemsСategoryView;
            // 
            // repositoryItemsСategoryView
            // 
            this.repositoryItemsСategoryView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CategoryName});
            this.repositoryItemsСategoryView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemsСategoryView.Name = "repositoryItemsСategoryView";
            this.repositoryItemsСategoryView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemsСategoryView.OptionsView.ShowGroupPanel = false;
            this.repositoryItemsСategoryView.CustomRowFilter += new DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(this.repositoryItemsСategoryView_CustomRowFilter);
            // 
            // CategoryName
            // 
            this.CategoryName.FieldName = "Name";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.OptionsColumn.AllowEdit = false;
            this.CategoryName.OptionsColumn.ShowCaption = false;
            this.CategoryName.Visible = true;
            this.CategoryName.VisibleIndex = 0;
            // 
            // subjectRepositoryItemEdit
            // 
            this.subjectRepositoryItemEdit.AutoHeight = false;
            this.subjectRepositoryItemEdit.Name = "subjectRepositoryItemEdit";
            // 
            // plateManufacturersList
            // 
            this.plateManufacturersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plateManufacturersList.Cursor = System.Windows.Forms.Cursors.Default;
            this.plateManufacturersList.Location = new System.Drawing.Point(36, 173);
            this.plateManufacturersList.MainView = this.plateManufacturersListView;
            this.plateManufacturersList.Name = "plateManufacturersList";
            this.plateManufacturersList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.manufacturerRepositoryTextEdit});
            this.plateManufacturersList.Size = new System.Drawing.Size(415, 232);
            this.plateManufacturersList.TabIndex = 3;
            this.plateManufacturersList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.plateManufacturersListView});
            // 
            // plateManufacturersListView
            // 
            this.plateManufacturersListView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.plateManufacturerGridColumn});
            this.plateManufacturersListView.GridControl = this.plateManufacturersList;
            this.plateManufacturersListView.Name = "plateManufacturersListView";
            this.plateManufacturersListView.OptionsBehavior.FocusLeaveOnTab = true;
            this.plateManufacturersListView.OptionsNavigation.UseTabKey = false;
            this.plateManufacturersListView.OptionsView.ShowGroupPanel = false;
            this.plateManufacturersListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.plateManufacturersList_KeyDown);
            // 
            // plateManufacturerGridColumn
            // 
            this.plateManufacturerGridColumn.Caption = "Название";
            this.plateManufacturerGridColumn.ColumnEdit = this.manufacturerRepositoryTextEdit;
            this.plateManufacturerGridColumn.FieldName = "Name";
            this.plateManufacturerGridColumn.Name = "plateManufacturerGridColumn";
            this.plateManufacturerGridColumn.Visible = true;
            this.plateManufacturerGridColumn.VisibleIndex = 0;
            // 
            // manufacturerRepositoryTextEdit
            // 
            this.manufacturerRepositoryTextEdit.AutoHeight = false;
            this.manufacturerRepositoryTextEdit.Name = "manufacturerRepositoryTextEdit";
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(36, 133);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(415, 20);
            this.client.StyleController = this.rootLayoutControl;
            this.client.TabIndex = 2;
            // 
            // wallThickness
            // 
            this.wallThickness.Location = new System.Drawing.Point(666, 456);
            this.wallThickness.Name = "wallThickness";
            this.wallThickness.Size = new System.Drawing.Size(189, 20);
            this.wallThickness.StyleController = this.rootLayoutControl;
            this.wallThickness.TabIndex = 12;
            // 
            // pipeDiameter
            // 
            this.pipeDiameter.Location = new System.Drawing.Point(473, 456);
            this.pipeDiameter.Name = "pipeDiameter";
            this.pipeDiameter.Size = new System.Drawing.Size(189, 20);
            this.pipeDiameter.StyleController = this.rootLayoutControl;
            this.pipeDiameter.TabIndex = 13;
            // 
            // RootGroup
            // 
            this.RootGroup.CustomizationFormText = "RootGroup";
            this.RootGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.RootGroup.GroupBordersVisible = false;
            this.RootGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup,
            this.layoutControlItem27,
            this.layoutControlItem28,
            this.emptySpaceItem2});
            this.RootGroup.Location = new System.Drawing.Point(0, 0);
            this.RootGroup.Name = "Root";
            this.RootGroup.Size = new System.Drawing.Size(1275, 550);
            this.RootGroup.Text = "Root";
            this.RootGroup.TextVisible = false;
            // 
            // tabbedControlGroup
            // 
            this.tabbedControlGroup.CustomizationFormText = "Группа вкладок";
            this.tabbedControlGroup.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlGroup.Name = "tabbedControlGroup";
            this.tabbedControlGroup.SelectedTabPage = this.layoutControlGroup11;
            this.tabbedControlGroup.SelectedTabPageIndex = 5;
            this.tabbedControlGroup.Size = new System.Drawing.Size(1255, 504);
            this.tabbedControlGroup.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup4,
            this.layoutControlGroup2,
            this.layoutControlGroup8,
            this.layoutControlGroup9,
            this.layoutControlGroup10,
            this.layoutControlGroup11,
            this.layoutControlGroup14,
            this.layoutControlGroup15});
            this.tabbedControlGroup.Text = "Группа вкладок";
            // 
            // layoutControlGroup11
            // 
            this.layoutControlGroup11.CustomizationFormText = "Инспекторы";
            this.layoutControlGroup11.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup12,
            this.layoutControlGroup13});
            this.layoutControlGroup11.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup11.Name = "layoutControlGroup11";
            this.layoutControlGroup11.Size = new System.Drawing.Size(1231, 458);
            this.layoutControlGroup11.Text = "Инспекторы";
            // 
            // layoutControlGroup12
            // 
            this.layoutControlGroup12.CustomizationFormText = "Инспекторы";
            this.layoutControlGroup12.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem21,
            this.layoutControlItem20});
            this.layoutControlGroup12.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup12.Name = "layoutControlGroup12";
            this.layoutControlGroup12.Size = new System.Drawing.Size(891, 458);
            this.layoutControlGroup12.Text = "Инспекторы";
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.Control = this.gridControlInspectorsCertificates;
            this.layoutControlItem21.CustomizationFormText = "Сертификаты";
            this.layoutControlItem21.Location = new System.Drawing.Point(394, 0);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Size = new System.Drawing.Size(473, 415);
            this.layoutControlItem21.Text = "Сертификаты";
            this.layoutControlItem21.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem21.TextSize = new System.Drawing.Size(312, 13);
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.Control = this.gridControlInspectors;
            this.layoutControlItem20.CustomizationFormText = "Инспекторы";
            this.layoutControlItem20.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(394, 415);
            this.layoutControlItem20.Text = "Инспекторы";
            this.layoutControlItem20.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem20.TextSize = new System.Drawing.Size(312, 13);
            // 
            // layoutControlGroup13
            // 
            this.layoutControlGroup13.CustomizationFormText = "Типы сертификатов";
            this.layoutControlGroup13.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem22});
            this.layoutControlGroup13.Location = new System.Drawing.Point(891, 0);
            this.layoutControlGroup13.Name = "layoutControlGroup13";
            this.layoutControlGroup13.Size = new System.Drawing.Size(340, 458);
            this.layoutControlGroup13.Text = "Типы сертификатов";
            // 
            // layoutControlItem22
            // 
            this.layoutControlItem22.Control = this.certificateTypes;
            this.layoutControlItem22.CustomizationFormText = "Список типов";
            this.layoutControlItem22.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem22.Name = "layoutControlItem22";
            this.layoutControlItem22.Size = new System.Drawing.Size(316, 415);
            this.layoutControlItem22.Text = "Список типов";
            this.layoutControlItem22.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem22.TextSize = new System.Drawing.Size(312, 13);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "&Проект";
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup5,
            this.layoutControlGroup6});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(1231, 458);
            this.layoutControlGroup4.Text = "&Проект";
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.CustomizationFormText = "Общие параметры";
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlGroup7});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(443, 458);
            this.layoutControlGroup5.Text = "Общие параметры";
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.projectTitle;
            this.layoutControlItem9.CustomizationFormText = "Названи&е";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(419, 40);
            this.layoutControlItem9.Text = "Названи&е";
            this.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(312, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.client;
            this.layoutControlItem10.CustomizationFormText = "Заказ&чик";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(419, 40);
            this.layoutControlItem10.Text = "Заказ&чик";
            this.layoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(312, 13);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.plateManufacturersList;
            this.layoutControlItem11.CustomizationFormText = "Производ&ители листов";
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(419, 252);
            this.layoutControlItem11.Text = "Производ&ители листов";
            this.layoutControlItem11.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem11.TextSize = new System.Drawing.Size(312, 13);
            // 
            // layoutControlGroup7
            // 
            this.layoutControlGroup7.CustomizationFormText = "Те&хнические параметры";
            this.layoutControlGroup7.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem16});
            this.layoutControlGroup7.Location = new System.Drawing.Point(0, 332);
            this.layoutControlGroup7.Name = "layoutControlGroup7";
            this.layoutControlGroup7.Size = new System.Drawing.Size(419, 83);
            this.layoutControlGroup7.Text = "Те&хнические параметры";
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.externalDocumentSize;
            this.layoutControlItem16.CustomizationFormText = "Допустимый размер внешнего документа, Kbytes";
            this.layoutControlItem16.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(395, 40);
            this.layoutControlItem16.Text = "Допустимый размер внешнего документа, Kbytes";
            this.layoutControlItem16.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem16.TextSize = new System.Drawing.Size(312, 13);
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.CustomizationFormText = "Завод";
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem12,
            this.layoutControlItem13,
            this.layoutControlItem15,
            this.layoutControlItem14,
            this.layoutControlItem5});
            this.layoutControlGroup6.Location = new System.Drawing.Point(443, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(788, 458);
            this.layoutControlGroup6.Text = "Завод";
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.millName;
            this.layoutControlItem12.CustomizationFormText = "Производител&ь";
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(764, 40);
            this.layoutControlItem12.Text = "Производител&ь";
            this.layoutControlItem12.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem12.TextSize = new System.Drawing.Size(312, 13);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.pipeNumberMask;
            this.layoutControlItem13.CustomizationFormText = "&Формат номера трубы";
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(354, 40);
            this.layoutControlItem13.Text = "&Формат номера трубы";
            this.layoutControlItem13.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem13.TextSize = new System.Drawing.Size(312, 13);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.categoriesGrid;
            this.layoutControlItem15.CustomizationFormText = "Группы контрольных операций";
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(354, 335);
            this.layoutControlItem15.Text = "Группы контрольных операций";
            this.layoutControlItem15.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem15.TextSize = new System.Drawing.Size(312, 13);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.pipeNumberMaskRulesLabel;
            this.layoutControlItem14.CustomizationFormText = "layoutControlItem14";
            this.layoutControlItem14.Location = new System.Drawing.Point(354, 40);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.layoutControlItem14.Size = new System.Drawing.Size(410, 40);
            this.layoutControlItem14.Text = "layoutControlItem14";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem14.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.seemType;
            this.layoutControlItem5.CustomizationFormText = "Типы сварочных швов";
            this.layoutControlItem5.Location = new System.Drawing.Point(354, 80);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(410, 335);
            this.layoutControlItem5.Text = "Типы сварочных швов";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(312, 13);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Труба";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlGroup3,
            this.layoutControlItem8});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1231, 458);
            this.layoutControlGroup2.Text = "Труба";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.pipesSizeList;
            this.layoutControlItem1.CustomizationFormText = "Список типораз&меров";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(437, 432);
            this.layoutControlItem1.Text = "Список типораз&меров";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(312, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.inspectionOperation;
            this.layoutControlItem2.CustomizationFormText = "Список контрольных операций для выбранного типоразмера";
            this.layoutControlItem2.Location = new System.Drawing.Point(437, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(794, 363);
            this.layoutControlItem2.Text = "Список контрольных операций для выбранного типоразмера";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(312, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "Параметры типоразмера";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup3.Location = new System.Drawing.Point(437, 363);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(794, 95);
            this.layoutControlGroup3.Text = "Параметры типоразмера";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.pipeDiameter;
            this.layoutControlItem3.CustomizationFormText = "Диаметр трубы";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(116, 40);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(193, 52);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Диаметр трубы";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(312, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.wallThickness;
            this.layoutControlItem4.CustomizationFormText = "Толщина стенки";
            this.layoutControlItem4.Location = new System.Drawing.Point(193, 0);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(116, 40);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(193, 52);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Толщина стенки";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(312, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.pipeLength;
            this.layoutControlItem6.CustomizationFormText = "Номинальная длина трубы";
            this.layoutControlItem6.Location = new System.Drawing.Point(386, 0);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(116, 40);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(179, 52);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "Номинальная длина трубы";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(312, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.seamType;
            this.layoutControlItem7.CustomizationFormText = "Тип шва";
            this.layoutControlItem7.Location = new System.Drawing.Point(565, 0);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(116, 40);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(205, 52);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "Тип шва";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(312, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.cloneTypeSizeButton;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 432);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(437, 26);
            this.layoutControlItem8.Text = "layoutControlItem8";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlGroup8
            // 
            this.layoutControlGroup8.CustomizationFormText = "Тру&бопровод";
            this.layoutControlGroup8.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem17});
            this.layoutControlGroup8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup8.Name = "layoutControlGroup8";
            this.layoutControlGroup8.Size = new System.Drawing.Size(1231, 458);
            this.layoutControlGroup8.Text = "Тру&бопровод";
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.jointOperations;
            this.layoutControlItem17.CustomizationFormText = "Набор операций - условия приемки стыка для спуска";
            this.layoutControlItem17.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(1231, 458);
            this.layoutControlItem17.Text = "Набор операций - условия приемки стыка для спуска";
            this.layoutControlItem17.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem17.TextSize = new System.Drawing.Size(312, 13);
            // 
            // layoutControlGroup9
            // 
            this.layoutControlGroup9.CustomizationFormText = "Комплектующие";
            this.layoutControlGroup9.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem18,
            this.emptySpaceItem1});
            this.layoutControlGroup9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup9.Name = "layoutControlGroup9";
            this.layoutControlGroup9.Size = new System.Drawing.Size(1231, 458);
            this.layoutControlGroup9.Text = "Комплектующие";
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.componentryTypeGridControl;
            this.layoutControlItem18.CustomizationFormText = "Типы комплектующих изделий";
            this.layoutControlItem18.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(615, 458);
            this.layoutControlItem18.Text = "Типы комплектующих изделий";
            this.layoutControlItem18.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem18.TextSize = new System.Drawing.Size(312, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(615, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(616, 458);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup10
            // 
            this.layoutControlGroup10.CustomizationFormText = "Сварщики";
            this.layoutControlGroup10.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem19});
            this.layoutControlGroup10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup10.Name = "layoutControlGroup10";
            this.layoutControlGroup10.Size = new System.Drawing.Size(1231, 458);
            this.layoutControlGroup10.Text = "Сварщики";
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.gridControlWelders;
            this.layoutControlItem19.CustomizationFormText = "Сварщики";
            this.layoutControlItem19.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(1231, 458);
            this.layoutControlItem19.Text = "Сварщики";
            this.layoutControlItem19.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem19.TextVisible = false;
            // 
            // layoutControlGroup14
            // 
            this.layoutControlGroup14.CustomizationFormText = "Пользователи";
            this.layoutControlGroup14.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem23,
            this.layoutControlItem24});
            this.layoutControlGroup14.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup14.Name = "layoutControlGroup14";
            this.layoutControlGroup14.Size = new System.Drawing.Size(1231, 458);
            this.layoutControlGroup14.Text = "Пользователи";
            // 
            // layoutControlItem23
            // 
            this.layoutControlItem23.Control = this.gridControlUsers;
            this.layoutControlItem23.CustomizationFormText = "Пользователи";
            this.layoutControlItem23.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem23.Name = "layoutControlItem23";
            this.layoutControlItem23.Size = new System.Drawing.Size(915, 458);
            this.layoutControlItem23.Text = "Пользователи";
            this.layoutControlItem23.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem23.TextSize = new System.Drawing.Size(312, 13);
            // 
            // layoutControlItem24
            // 
            this.layoutControlItem24.Control = this.gridControlRoles;
            this.layoutControlItem24.CustomizationFormText = "Роли";
            this.layoutControlItem24.Location = new System.Drawing.Point(915, 0);
            this.layoutControlItem24.Name = "layoutControlItem24";
            this.layoutControlItem24.Size = new System.Drawing.Size(316, 458);
            this.layoutControlItem24.Text = "Роли";
            this.layoutControlItem24.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem24.TextSize = new System.Drawing.Size(312, 13);
            // 
            // layoutControlGroup15
            // 
            this.layoutControlGroup15.CustomizationFormText = "Роли";
            this.layoutControlGroup15.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem25,
            this.layoutControlItem26});
            this.layoutControlGroup15.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup15.Name = "layoutControlGroup15";
            this.layoutControlGroup15.Size = new System.Drawing.Size(1231, 458);
            this.layoutControlGroup15.Text = "Роли";
            // 
            // layoutControlItem25
            // 
            this.layoutControlItem25.Control = this.gridControl1;
            this.layoutControlItem25.CustomizationFormText = "Роли";
            this.layoutControlItem25.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem25.Name = "layoutControlItem25";
            this.layoutControlItem25.Size = new System.Drawing.Size(915, 458);
            this.layoutControlItem25.Text = "Роли";
            this.layoutControlItem25.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem25.TextSize = new System.Drawing.Size(312, 13);
            // 
            // layoutControlItem26
            // 
            this.layoutControlItem26.Control = this.gridControlPermission;
            this.layoutControlItem26.CustomizationFormText = "Права";
            this.layoutControlItem26.Location = new System.Drawing.Point(915, 0);
            this.layoutControlItem26.Name = "layoutControlItem26";
            this.layoutControlItem26.Size = new System.Drawing.Size(316, 458);
            this.layoutControlItem26.Text = "Права";
            this.layoutControlItem26.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem26.TextSize = new System.Drawing.Size(312, 13);
            // 
            // layoutControlItem27
            // 
            this.layoutControlItem27.Control = this.saveButton;
            this.layoutControlItem27.CustomizationFormText = "layoutControlItem27";
            this.layoutControlItem27.Location = new System.Drawing.Point(961, 504);
            this.layoutControlItem27.Name = "layoutControlItem27";
            this.layoutControlItem27.Size = new System.Drawing.Size(146, 26);
            this.layoutControlItem27.Text = "layoutControlItem27";
            this.layoutControlItem27.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem27.TextVisible = false;
            // 
            // layoutControlItem28
            // 
            this.layoutControlItem28.Control = this.closeButton;
            this.layoutControlItem28.CustomizationFormText = "layoutControlItem28";
            this.layoutControlItem28.Location = new System.Drawing.Point(1107, 504);
            this.layoutControlItem28.Name = "layoutControlItem28";
            this.layoutControlItem28.Size = new System.Drawing.Size(148, 26);
            this.layoutControlItem28.Text = "layoutControlItem28";
            this.layoutControlItem28.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem28.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 504);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(961, 26);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // editDictionary
            // 
            this.editDictionary.Name = "editDictionary";
            // 
            // editItem
            // 
            this.editItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.editItem.Name = "editItem";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Prizm.Main.DummyData.User);
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(Prizm.Main.DummyData.Role);
            // 
            // jointOperationsBindingSource
            // 
            this.jointOperationsBindingSource.DataSource = typeof(Prizm.Main.DummyData.User);
            // 
            // SettingsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 550);
            this.Controls.Add(this.rootLayoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsXtraForm";
            this.Text = "Настройки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsXtraForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingsXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pipesSizeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesSizeListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPermissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonUserPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateTypesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryCertificateIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInspectorsCertificates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorCertificateGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryLookUpCertificateType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryLookUpCertificateTypeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInspectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInspectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorLNRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorFNRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorMNRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorCertificateTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWelders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWelders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderFNRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderLNRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderMNRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderCertificateTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stampRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentryTypeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentryTypeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryConnectorsNumbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryComponentryTypeCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointsOperationsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointOperationTypeLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutControl)).EndInit();
            this.rootLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seemType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seemTypeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryIsActiveCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seamType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumberMask.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlNameRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTypeItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultTypeItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isRequired)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemsСategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemsСategoryView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectRepositoryItemEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallThickness.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDiameter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RootGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeMillSizeTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorCertificateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointOperationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPipeMillSizeTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private DevExpress.XtraGrid.GridControl plateManufacturersList;
        private DevExpress.XtraGrid.Views.Grid.GridView plateManufacturersListView;
        private DevExpress.XtraGrid.Columns.GridColumn plateManufacturerGridColumn;
        private DevExpress.XtraEditors.TextEdit millName;
        private DevExpress.XtraEditors.TextEdit client;
        private DevExpress.XtraEditors.TextEdit externalDocumentSize;
        private DevExpress.XtraGrid.Columns.GridColumn editDictionary;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit editItem;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private DevExpress.XtraGrid.GridControl inspectionOperation;
        private DevExpress.XtraGrid.Views.Grid.GridView inspectionView;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionCodeGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn controlTypeGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn resultTypeGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn minExpectedGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn maxExpectedGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn boolExpectedGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn isRequiredGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit isRequired;
        private System.Windows.Forms.BindingSource inspectionBindingSource;
        private DevExpress.XtraGrid.GridControl pipesSizeList;
        private DevExpress.XtraGrid.Views.Grid.GridView pipesSizeListGridView;
        private DevExpress.XtraGrid.Columns.GridColumn pipeSizeGridColumn;
        private DevExpress.XtraEditors.SimpleButton closeButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraGrid.Columns.GridColumn isActiveGridColumn;
        private System.Windows.Forms.BindingSource pipeMillSizeTypeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn testIsActiveGridColumn;
        private DevExpress.XtraGrid.GridControl gridControlWelders;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewWelders;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderMiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderCert;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderCertExp;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderStamp;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderGrade;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderActive;
        private DevExpress.XtraGrid.GridControl gridControlInspectors;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInspectors;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectorFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectorLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectorMiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectorCertificate;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectorCertExp;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectorActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit controlTypeItems;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit resultTypeItems;
        private DevExpress.XtraLayout.EmptySpaceItem roleEmptySpace;
        private DevExpress.XtraEditors.TextEdit projectTitle;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit manufacturerRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit typeRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit codeRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit controlNameRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit subjectRepositoryItemEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit welderFNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit welderLNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit welderMNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit welderCertificateTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit stampRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit inspectorFNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit inspectorLNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit inspectorMNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit inspectorCertificateTextEdit;
        private DevExpress.XtraEditors.TextEdit pipeNumberMask;
        private DevExpress.XtraGrid.GridControl gridControlInspectorsCertificates;
        private DevExpress.XtraGrid.Views.Grid.GridView inspectorCertificateGridView;
        private DevExpress.XtraGrid.Columns.GridColumn inspectorCertificateNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn inspectorCertificateExpirationCol;
        private System.Windows.Forms.BindingSource inspectorBindingSource;
        private System.Windows.Forms.BindingSource inspectorCertificateBindingSource;
        private DevExpress.XtraGrid.GridControl categoriesGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView categoriesGridView;
        private DevExpress.XtraGrid.Columns.GridColumn categoryNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn isActiveColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryIsActiveCheckEdit;
        private DevExpress.XtraGrid.GridControl gridControlRoles;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRoles;
        private DevExpress.XtraGrid.GridControl gridControlUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUsers;
        private DevExpress.XtraGrid.Columns.GridColumn colLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colMiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn colPasswordExpires;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleName;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleDesc;
        private DevExpress.XtraGrid.GridControl gridControlPermission;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPermissions;
        private DevExpress.XtraGrid.Columns.GridColumn colPermissionDesc;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRole;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleSetupName;
        private DevExpress.XtraGrid.Columns.GridColumn colDesc;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private System.Windows.Forms.BindingSource permissionsBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colUserPass;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonUserPass;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit categoryRepositoryTextEdit;
        private DevExpress.XtraGrid.GridControl jointOperations;
        private DevExpress.XtraGrid.Views.Grid.GridView jointsOperationsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn nameGridColumn;
        private System.Windows.Forms.BindingSource jointOperationsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn isRequiredForJointGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn TestTypeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn testHasAcceptedGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn testHasToRepairGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn testHasToWithdrawGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn testResultRequiredGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn isActiveJointOperationGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit jointOperationTypeLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn categoryColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemsСategory;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemsСategoryView;
        private DevExpress.XtraGrid.Columns.GridColumn CategoryName;
        private DevExpress.XtraEditors.SimpleButton cloneTypeSizeButton;
        private DevExpress.XtraEditors.LabelControl pipeNumberMaskRulesLabel;
        private DevExpress.XtraGrid.GridControl componentryTypeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView componentryTypeGridView;
        private DevExpress.XtraGrid.Columns.GridColumn typeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn connectorsNumbersColumn;
        private DevExpress.XtraGrid.Columns.GridColumn isActiveComponentColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryComponentryTypeCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryConnectorsNumbers;
        private DevExpress.XtraGrid.GridControl certificateTypes;
        private DevExpress.XtraGrid.Views.Grid.GridView certificateTypesView;
        private DevExpress.XtraGrid.Columns.GridColumn certificateNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn certificateIsActiveColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryCertificateIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn certificateTypeColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryLookUpCertificateType;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryLookUpCertificateTypeView;
        private DevExpress.XtraGrid.Columns.GridColumn inspectorCertificateTypeColumn;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
        private DevExpress.XtraEditors.TextEdit pipeLength;
        private DevExpress.XtraEditors.TextEdit seamType;
        private DevExpress.XtraEditors.TextEdit pipeDiameter;
        private DevExpress.XtraEditors.TextEdit wallThickness;
        private DevExpress.XtraGrid.GridControl seemType;
        private DevExpress.XtraGrid.Views.Grid.GridView seemTypeGridView;
        private DevExpress.XtraGrid.Columns.GridColumn seemTypeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn seemTypeIsActiveColumn;
        private System.Windows.Forms.BindingSource CurrentPipeMillSizeTypeBindingSource;
        private DevExpress.XtraLayout.LayoutControl rootLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup RootGroup;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup11;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem22;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem23;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem24;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem25;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem26;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem27;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem28;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}