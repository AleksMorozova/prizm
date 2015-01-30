using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Languages
{
    static class StringResources
    {
        public static StringResource TestString = new StringResource { Id = "Test_String", Description = "Проверочная строка. Нигде не используется." };

        #region --- Common strings like Active - Not active, Hold - Witness, etc. Messages.
        // to be used on different forms



        #endregion // --- Common

        #region --- Audit ---

        public static StringResource Audit_ElementNumberLabel = new StringResource
        {
            Id = "Audit_ElementNumberLabel",
            Description = "Аудит. Надпись номера элемента."
        };

        #endregion //--- Audit --

        #region --- About ---

        public static StringResource AboutForm_TitleLabel = new StringResource
        {
            Id = "AboutForm_TitleLabel",
            Description = "Текст в окне \"О программе \""
        };

        #endregion // --- About ---

        #region---NewEdit Pipe---
        public static StringResource NewEditPipe_PipeNumberLabel = new StringResource
        {
            Id = "NewEditPipe_PipeNumberLabel",
            Description = "Труба. Номер трубы"
        };
        public static StringResource NewEditPipe_PipeSizeLabel = new StringResource
        {
            Id = "NewEditPipe_PipeSizeLabel",
            Description = "Труба. Типоразмер"
        };
        public static StringResource NewEditPipe_HeatsComboLabel = new StringResource
        {
            Id = "NewEditPipe_HeatsComboLabel",
            Description = "Труба. Плавка"
        };
        public static StringResource NewEditPipe_PurchaseOrdersComboLabel = new StringResource
        {
            Id = "NewEditPipe_PurchaseOrdersComboLabel",
            Description = "Труба. Номер наряд-заказа"
        };
        public static StringResource NewEditPipe_PurchaseOrederDateLabel = new StringResource
        {
            Id = "NewEditPipe_PurchaseOrederDateLabel",
            Description = "Труба. Дата наряд-заказа"
        };
        public static StringResource NewEditPipe_PipeCreationLabel = new StringResource
        {
            Id = "NewEditPipe_PipeCreationLabel",
            Description = "Труба. Дата создания трубы"
        };
        public static StringResource NewEditPipe_PipeStatusLabel = new StringResource
        {
            Id = "NewEditPipe_PipeStatusLabel",
            Description = "Труба. Статус трубы"
        };
        public static StringResource NewEditPipe_PlateNumberLabel = new StringResource
        {
            Id = "NewEditPipe_PlateNumberLabel",
            Description = "Труба. Номер листа"
        };
        public static StringResource NewEditPipe_PlateThicknessLabel = new StringResource
        {
            Id = "NewEditPipe_PlateThicknessLabel",
            Description = "Труба. Толщина листа"
        };
        public static StringResource NewEditPipe_PlateManufacturerLabel = new StringResource
        {
            Id = "NewEditPipe_PlateManufacturerLabel",
            Description = "Труба. Производитель листа"
        };
        public static StringResource NewEditPipe_PlateSteelGradeLabel = new StringResource
        {
            Id = "NewEditPipe_PlateSteelGradeLabel",
            Description = "Труба. Марка стали"
        };
        public static StringResource NewEditPipe_PipeLengthLabel = new StringResource
        {
            Id = "NewEditPipe_PipeLengthLabel",
            Description = "Труба. Длина трубы"
        };
        public static StringResource NewEditPipe_PipeWeightLabel = new StringResource
        {
            Id = "NewEditPipe_PipeWeightLabel",
            Description = "Труба. Вес трубы"
        };
        public static StringResource NewEditPipe_TypeSizeLengthLabel = new StringResource
        {
            Id = "NewEditPipe_TypeSizeLengthLabel",
            Description = "Труба. Длина по типоразмеру"
        };
        public static StringResource NewEditPipe_TypeSizeDiameterLabel = new StringResource
        {
            Id = "NewEditPipe_TypeSizeDiameterLabel",
            Description = "Труба. Диаметр по типоразмеру"
        };
        public static StringResource NewEditPipe_TypeSizeThicknessLabel = new StringResource
        {
            Id = "NewEditPipe_TypeSizeThicknessLabel",
            Description = "Труба. Толщина по типоразмеру"
        };
        public static StringResource NewEditPipe_RailcarNumber_Label = new StringResource
        {
            Id = "NewEditPipe_RailcarNumber_Label",
            Description = "Труба. Номер вагона"
        };
        public static StringResource NewEditPipe_RailcarCertificate_Label = new StringResource
        {
            Id = "NewEditPipe_RailcarCertificate_Label",
            Description = "Труба. Сертификат вагона"
        };
        public static StringResource NewEditPipe_RailcarShippedDate_Label = new StringResource
        {
            Id = "NewEditPipe_RailcarShippedDate_Label",
            Description = "Труба. Дата отправки вагона"
        };
        public static StringResource NewEditPipe_RailcarDestination_Label = new StringResource
        {
            Id = "NewEditPipe_RailcarDestination_Label",
            Description = "Труба. Получатель"
        };
        public static StringResource NewEditPipe_AttachmentsButton = new StringResource
        {
            Id = "NewEditPipe_AttachmentsButton",
            Description = "Труба. Кнопка добавления файлов"
        };
        public static StringResource NewEditPipe_DeactivatedCheckBox = new StringResource
        {
            Id = "NewEditPipe_DeactivatedCheckBox",
            Description = "Труба. Деактивация"
        };
        public static StringResource NewEditPipe_SaveButton = new StringResource
        {
            Id = "NewEditPipe_SaveButton",
            Description = "Труба. Кнопка сохранить"
        };
        public static StringResource NewEditPipe_SaveAndNewButton = new StringResource
        {
            Id = "NewEditPipe_SaveAndNewButton",
            Description = "Труба. Кнопка сохранить и создать"
        };
        public static StringResource NewEditPipe_InspectionsAddButton = new StringResource
        {
            Id = "NewEditPipe_InspectionsAddButton",
            Description = "Труба. Кнопка добавления контрольных операций"
        };
        public static StringResource NewEditPipe_InspectionsEditsButton = new StringResource
        {
            Id = "NewEditPipe_InspectionsEditsButton",
            Description = "Труба. Кнопка редактирования контрольных операций"
        };
        public static StringResource NewEditPipe_WeldersColumnHeader = new StringResource
        {
            Id = "NewEditPipe_WeldersColumnHeader",
            Description = "Труба. Столбец сварщики"
        };
        public static StringResource NewEditPipe_WeldingDateColumnHeader = new StringResource
        {
            Id = "NewEditPipe_WeldingDateColumnHeader",
            Description = "Труба. Столбец дата сварки"
        };
        public static StringResource NewEditPipe_CoatingDateColumnHeader = new StringResource
        {
            Id = "NewEditPipe_CoatingDateColumnHeader",
            Description = "Труба. Столбец дата покрытия"
        };
        public static StringResource NewEditPipe_CoatingTypeColumnHeader = new StringResource
        {
            Id = "NewEditPipe_CoatingTypeColumnHeader",
            Description = "Труба. Столбец тип покрытия"
        };
        public static StringResource NewEditPipe_InspectionCodeColumnHeader = new StringResource
        {
            Id = "NewEditPipe_InspectionCodeColumnHeader",
            Description = "Труба. Столбец код контрольной операции"
        };
        public static StringResource NewEditPipe_InspectionNameColumnHeader = new StringResource
        {
            Id = "NewEditPipe_InspectionNameColumnHeader",
            Description = "Труба. Столбец название контрольной операции"
        };
        public static StringResource NewEditPipe_InspectionCategoryColumnHeader = new StringResource
        {
            Id = "NewEditPipe_InspectionCategoryColumnHeader",
            Description = "Труба. Столбец группа контрольной операции"
        };
        public static StringResource NewEditPipe_InspectionExpectedResultColumnHeader = new StringResource
        {
            Id = "NewEditPipe_InspectionExpectedResultColumnHeader",
            Description = "Труба. Столбец ожидаемого результата контрольной операции"
        };
        public static StringResource NewEditPipe_InspectionValueColumnHeader = new StringResource
        {
            Id = "NewEditPipe_InspectionValueColumnHeader",
            Description = "Труба. Столбец значения контрольной операции"
        };
        public static StringResource NewEditPipe_InspectionResultColumnHeader = new StringResource
        {
            Id = "NewEditPipe_InspectionResultColumnHeader",
            Description = "Труба. Столбец результата контрольной операции"
        };
        public static StringResource NewEditPipe_InspectionDateColumnHeader = new StringResource
        {
            Id = "NewEditPipe_InspectionDateColumnHeader",
            Description = "Труба. Столбец даты контрольной операции"
        };
        public static StringResource NewEditPipe_InspectorsCodeColumnHeader = new StringResource
        {
            Id = "NewEditPipe_InspectorsCodeColumnHeader",
            Description = "Труба. Столбец инспекторы"
        };
        public static StringResource NewEditPipe_PlateGroup = new StringResource
        {
            Id = "NewEditPipe_PlateGroup",
            Description = "Труба. Группа лист"
        };
        public static StringResource NewEditPipe_FactSizeGroup = new StringResource
        {
            Id = "NewEditPipe_FactSizeGroup",
            Description = "Труба. Группа фактических параметров"
        };
        public static StringResource NewEditPipe_TypeSizeGroup = new StringResource
        {
            Id = "NewEditPipe_TypeSizeGroup",
            Description = "Труба. Группа параметров типоразмера"
        };
        public static StringResource NewEditPipe_ShippingGroup = new StringResource
        {
            Id = "NewEditPipe_ShippingGroup",
            Description = "Труба. Группа отправка"
        };
        public static StringResource NewEditPipe_CoverGroup = new StringResource
        {
            Id = "NewEditPipe_CoverGroup",
            Description = "Труба. Группа покрытие"
        };
        public static StringResource NewEditPipe_WeldsGroup = new StringResource
        {
            Id = "NewEditPipe_WeldsGroup",
            Description = "Труба. Группа сварка"
        };
        public static StringResource NewEditPipe_PipeTabGroup = new StringResource
        {
            Id = "NewEditPipe_PipeTabGroup",
            Description = "Труба. Вкладка трубы"
        };
        public static StringResource NewEditPipe_InspectionsTabGroup = new StringResource
        {
            Id = "NewEditPipe_InspectionsTabGroup",
            Description = "Труба. Вкладка контрольных операций"
        };
        public static StringResource NewEditPipe_PipeStatusUndefined = new StringResource
        {
            Id = "NewEditPipe_PipeStatusUndefined",
            Description = "Труба. Статус не определен"
        };
        public static StringResource NewEditPipe_PipeStatusProduced = new StringResource
        {
            Id = "NewEditPipe_PipeStatusProduced",
            Description = "Труба. Статус в производстве"
        };
        public static StringResource NewEditPipe_PipeStatusStocked = new StringResource
        {
            Id = "NewEditPipe_PipeStatusStocked",
            Description = "Труба. Статус на складе"
        };
        public static StringResource NewEditPipe_PipeStatusShipped = new StringResource
        {
            Id = "NewEditPipe_PipeStatusShipped",
            Description = "Труба. Статус отгружена"
        };
        #endregion

        #region---Search pipe---
        public static StringResource SearchPipe_MillStatusProduced = new StringResource
        {
            Id = "SearchPipe_MillStatusProduced",
            Description = "Поиск труб. Статус в производстве"
        };
        public static StringResource SearchPipe_MillStatusStocked = new StringResource
        {
            Id = "SearchPipe_MillStatusStocked",
            Description = "Поиск труб. статус на складе"
        };
        public static StringResource SearchPipe_MillStatusShipped = new StringResource
        {
            Id = "SearchPipe_MillStatusShipped",
            Description = "Поиск труб. статус отгружена"
        };
        public static StringResource SearchPipe_ActivityComboActive = new StringResource
        {
            Id = "SearchPipe_ActivityComboActive",
            Description = "Поиск труб. Активность – активна"
        };
        public static StringResource SearchPipe_ActivityComboNotActive = new StringResource
        {
            Id = "SearchPipe_ActivityComboNotActive",
            Description = "Поиск труб. Активность – деактивирована"
        };
        public static StringResource SearchPipe_ActivityComboAll = new StringResource
        {
            Id = "SearchPipe_ActivityComboAll",
            Description = "Поиск труб. Активность – все"
        };
        public static StringResource SearchPipe_NumberLabel = new StringResource
        {
            Id = "SearchPipe_NumberLabel",
            Description = "Поиск труб. Номер трубы"
        };
        public static StringResource SearchPipe_TypeSizeLabel = new StringResource
        {
            Id = "SearchPipe_TypeSizeLabel",
            Description = "Поиск труб. Типоразмер"
        };
        public static StringResource SearchPipe_StatusLabel = new StringResource
        {
            Id = "SearchPipe_StatusLabel",
            Description = "Поиск труб. Статус трубы"
        };
        public static StringResource SearchPipe_ActivityLabel = new StringResource
        {
            Id = "SearchPipe_ActivityLabel",
            Description = "Поиск труб. Активность трубы"
        };
        public static StringResource SearchPipe_WeldingDateLabel = new StringResource
        {
            Id = "SearchPipe_WeldingDateLabel",
            Description = "Поиск труб. Дата сварки"
        };
        public static StringResource SearchPipe_ExternalCoatingDateLabel = new StringResource
        {
            Id = "SearchPipe_ExternalCoatingDateLabel",
            Description = "Поиск труб. Дата внешнего покрытия"
        };
        public static StringResource SearchPipe_InternalCoatingDateLabel = new StringResource
        {
            Id = "SearchPipe_InternalCoatingDateLabel",
            Description = "Поиск труб. Дата внутреннего покрытия"
        };
        public static StringResource SearchPipe_SearchButton = new StringResource
        {
            Id = "SearchPipe_SearchButton",
            Description = "Поиск труб. Кнопка поиск"
        };
        public static StringResource SearchPipe_PipeNumberColumn = new StringResource
        {
            Id = "SearchPipe_PipeNumberColumn",
            Description = "Поиск труб. Столбец номер трубы"
        };
        public static StringResource SearchPipe_PipeMillColumn = new StringResource
        {
            Id = "SearchPipe_PipeMillColumn",
            Description = "Поиск труб. Столбец завод"
        };
        public static StringResource SearchPipe_PipetypeSizeColumn = new StringResource
        {
            Id = "SearchPipe_PipetypeSizeColumn",
            Description = "Поиск труб. Столбец типоразмер"
        };
        public static StringResource SearchPipe_PipeHeatNumberColumn = new StringResource
        {
            Id = "SearchPipe_PipeHeatNumberColumn",
            Description = "Поиск труб. Столбец плавка"
        };
        public static StringResource SearchPipe_PipeStatusColumn = new StringResource
        {
            Id = "SearchPipe_PipeStatusColumn",
            Description = "Поиск труб. Столбец статус"
        };
        public static StringResource SearchPipe_PipeWeldingDateColumn = new StringResource
        {
            Id = "SearchPipe_PipeWeldingDateColumn",
            Description = "Поиск труб. Столбец дата сварки"
        };
        public static StringResource SearchPipe_ExternalCoatingDateColumn = new StringResource
        {
            Id = "SearchPipe_ExternalCoatingDateColumn",
            Description = "Поиск труб. Столбец дата внешнего покрытия"
        };
        public static StringResource SearchPipe_InternalCoatingColumn = new StringResource
        {
            Id = "SearchPipe_InternalCoatingColumn",
            Description = "Поиск труб. Столбец дата внутреннего покрытия"
        };
        public static StringResource SearchPipe_SearchGroup = new StringResource
        {
            Id = "SearchPipe_SearchGroup",
            Description = "Поиск труб. Группа поиск"
        };
        public static StringResource SearchPipe_ResultGroup = new StringResource
        {
            Id = "SearchPipe_ResultGroup",
            Description = "Поиск труб. Группа результат"
        };
        #endregion

        #region---Railcar NewEdit---
        public static StringResource RailcarNewEdit_ReleaseNumberLabel = new StringResource
        {
            Id = "RailcarNewEdit_ReleaseNumberLabel",
            Description = "Разрешение на отгрузку. Номер разрешения"
        };
        public static StringResource RailcarNewEdit_ReleaseDateLabel = new StringResource
        {
            Id = "RailcarNewEdit_ReleaseDateLabel",
            Description = "Разрешение на отгрузку. Дата разрешения"
        };
        public static StringResource RailcarNewEdit_RailcarNumberLabel = new StringResource
        {
            Id = "RailcarNewEdit_RailcarNumberLabel",
            Description = "Разрешение на отгрузку. Номер вагона"
        };
        public static StringResource RailcarNewEdit_CertificateLabel = new StringResource
        {
            Id = "RailcarNewEdit_CertificateLabel",
            Description = "Разрешение на отгрузку. Сертификат вагона"
        };
        public static StringResource RailcarNewEdit_DestinationLabel = new StringResource
        {
            Id = "RailcarNewEdit_DestinationLabel",
            Description = "Разрешение на отгрузку. Получатель"
        };
        public static StringResource RailcarNewEdit_AddPipeButton = new StringResource
        {
            Id = "RailcarNewEdit_AddPipeButton",
            Description = "Разрешение на отгрузку. Кнопка добавления трубы"
        };
        public static StringResource RailcarNewEdit_RemovePipeButton = new StringResource
        {
            Id = "RailcarNewEdit_RemovePipeButton",
            Description = "Разрешение на отгрузку. Кнопка удаления трубы"
        };
        public static StringResource RailcarNewEdit_AttachmentsButton = new StringResource
        {
            Id = "RailcarNewEdit_AttachmentsButton",
            Description = "Разрешение на отгрузку. Кнопка добавления файлов"
        };
        public static StringResource RailcarNewEdit_ShipButton = new StringResource
        {
            Id = "RailcarNewEdit_ShipButton",
            Description = "Разрешение на отгрузку. Кнопка отгрузки"
        };
        public static StringResource RailcarNewEdit_UnshipButton = new StringResource
        {
            Id = "RailcarNewEdit_UnshipButton",
            Description = "Разрешение на отгрузку. Кнопка отклонения отгрузки"
        };
        public static StringResource RailcarNewEdit_SaveButton = new StringResource
        {
            Id = "RailcarNewEdit_SaveButton",
            Description = "Разрешение на отгрузку. Кнопка сохранить"
        };
        public static StringResource RailcarNewEdit_PipeNumberColumn = new StringResource
        {
            Id = "RailcarNewEdit_PipeNumberColumn",
            Description = "Разрешение на отгрузку. Столбец номер трубы"
        };
        public static StringResource RailcarNewEdit_PipeTypeSizeColumn = new StringResource
        {
            Id = "RailcarNewEdit_PipeTypeSizeColumn",
            Description = "Разрешение на отгрузку. Столбец типоразмер"
        };
        public static StringResource RailcarNewEdit_PipeStatusColumn = new StringResource
        {
            Id = "RailcarNewEdit_PipeStatusColumn",
            Description = "Разрешение на отгрузку. Столбец статус"
        };
        #endregion //--- Railcar NewEdit ---

        #region---Railcar Search---
        public static StringResource ReleaseSearch_NumberLabel = new StringResource
        {
            Id = "ReleaseSearch_NumberLabel",
            Description = "Поиск разрешений на отгрузку. Номер разрешения"
        };
        public static StringResource ReleaseSearch_DateLabel = new StringResource
        {
            Id = "ReleaseSearch_DateLabel",
            Description = "Поиск разрешений на отгрузку. Дата"
        };
        public static StringResource ReleaseSearch_DestinationLabel = new StringResource
        {
            Id = "ReleaseSearch_DestinationLabel",
            Description = "Поиск разрешений на отгрузку. Получатель"
        };
        public static StringResource ReleaseSearch_RailcarLabel = new StringResource
        {
            Id = "ReleaseSearch_RailcarLabel",
            Description = "Поиск разрешений на отгрузку. Вагон"
        };
        public static StringResource ReleaseSearch_CertificateLabel = new StringResource
        {
            Id = "ReleaseSearch_CertificateLabel",
            Description = "Поиск разрешений на отгрузку. Сертификат вагона"
        };
        public static StringResource NewEditPipe_SearchButton = new StringResource
        {
            Id = "NewEditPipe_SearchButton",
            Description = "Поиск разрешений на отгрузку. Кнопка поиск"
        };
        public static StringResource ReleaseSearch_ReleaseNumberColumnHeader = new StringResource
        {
            Id = "ReleaseSearch_ReleaseNumberColumnHeader",
            Description = "Поиск разрешений на отгрузку. Столбец номер разрешения"
        };
        public static StringResource ReleaseSearch_ReleaseDateColumnHeader = new StringResource
        {
            Id = "ReleaseSearch_ReleaseDateColumnHeader",
            Description = "Поиск разрешений на отгрузку. Столбец дата разрешения"
        };
        public static StringResource ReleaseSearch_RailcarNumberColumnHeader = new StringResource
        {
            Id = "ReleaseSearch_RailcarNumberColumnHeader",
            Description = "Поиск разрешений на отгрузку. Столбец номер вагона"
        };
        public static StringResource ReleaseSearch_DestinationColumnHeader = new StringResource
        {
            Id = "ReleaseSearch_DestinationColumnHeader",
            Description = "Поиск разрешений на отгрузку. Столбец получатель"
        };
        public static StringResource ReleaseSearch_CertificateColumnHeader = new StringResource
        {
            Id = "ReleaseSearch_CertificateColumnHeader",
            Description = "Поиск разрешений на отгрузку. Столбец сертификат"
        };
        public static StringResource ReleaseSearch_SearchGroup = new StringResource
        {
            Id = "ReleaseSearch_SearchGroup",
            Description = "Поиск разрешений на отгрузку. Группа поиск"
        };
        public static StringResource ReleaseSearch_ResultGroup = new StringResource
        {
            Id = "ReleaseSearch_ResultGroup",
            Description = "Поиск разрешений на отгрузку. Группа результат"
        };
        #endregion //--- Railcar Search ---

        #region---Login---
        public static StringResource Login_LoginLabel = new StringResource
        {
            Id = "Login_LoginLabel",
            Description = "Логин. Логин"
        };
        public static StringResource Login_PasswordLabel = new StringResource
        {
            Id = "Login_PasswordLabel",
            Description = "Логин. Пароль"
        };
        public static StringResource Login_LoginButton = new StringResource
        {
            Id = "Login_LoginButton",
            Description = "Логин. Кнопка логин"
        };
        public static StringResource Login_ExitButton = new StringResource
        {
            Id = "Login_ExitButton",
            Description = "Логин. Кнопка выход"
        };
        #endregion //--- Login ---

        #region First Setup
        public static StringResource FirstSetup_ProjectTitleLabel = new StringResource
        {
            Id = "FirstSetup_ProjectTitleLabel",
            Description = "Начальные установки. Название проекта"
        };
        public static StringResource FirstSetup_FileSizeLabel = new StringResource
        {
            Id = "FirstSetup_FileSizeLabel",
            Description = "Начальные установки. Размер файла"
        };
        public static StringResource FirstSetup_TypeLabel = new StringResource
        {
            Id = "FirstSetup_TypeLabel",
            Description = "Начальные установки. Тип станции"
        };
        public static StringResource FirstSetup_MillLabel = new StringResource
        {
            Id = "FirstSetup_MillLabel",
            Description = "Начальные установки. Название завода"
        };
        public static StringResource FirstSetup_LoginLabel = new StringResource
        {
            Id = "FirstSetup_LoginLabel",
            Description = "Начальные установки. Логин"
        };
        public static StringResource FirstSetup_PasswordLabel = new StringResource
        {
            Id = "FirstSetup_PasswordLabel",
            Description = "Начальные установки. Пароль"
        };
        public static StringResource FirstSetup_ReEnterPasswordLabel = new StringResource
        {
            Id = "FirstSetup_ReEnterPasswordLabel",
            Description = "Начальные установки. Повторный пароль"
        };
        public static StringResource FirstSetup_LastNameLabel = new StringResource
        {
            Id = "FirstSetup_LastNameLabel",
            Description = "Начальные установки. Фамилия"
        };
        public static StringResource FirstSetup_FirstNameLabel = new StringResource
        {
            Id = "FirstSetup_FirstNameLabel",
            Description = "Начальные установки. имя"
        };
        public static StringResource FirstSetup_MiddleNameLabel = new StringResource
        {
            Id = "FirstSetup_MiddleNameLabel",
            Description = "Начальные установки. Отчество"
        };
        public static StringResource FirstSetup_SaveButton = new StringResource
        {
            Id = "FirstSetup_SaveButton",
            Description = "Начальные установки. Кнопка сохранить"
        };
        public static StringResource FirstSetup_CancelButton = new StringResource
        {
            Id = "FirstSetup_CancelButton",
            Description = "Начальные установки. Кнопка отмена"
        };
        #endregion

        #region Heat
        public static StringResource Heat_NumberLabel = new StringResource
        {
            Id = "Heat_NumberLabel",
            Description = "Плавка. Номер плавки"
        };
        public static StringResource Heat_SteelLabel = new StringResource
        {
            Id = "Heat_SteelLabel",
            Description = "Плавка. Марка стали"
        };
        public static StringResource Heat_PlateManufacturerLabel = new StringResource
        {
            Id = "Heat_PlateManufacturerLabel",
            Description = "Плавка. Производитель листа"
        };
        public static StringResource Heat_SaveButton = new StringResource
        {
            Id = "Heat_SaveButton",
            Description = "Плавка. Кнопка сохранить"
        };
        public static StringResource Heat_CancelButton = new StringResource
        {
            Id = "Heat_CancelButton",
            Description = "Плавка. Кнопка отмена"
        };
        #endregion

        #region Inspection
        public static StringResource InspectionAddEdit_CodeLabel = new StringResource
        {
            Id = "InspectionAddEdit_CodeLabel",
            Description = "Контрольная операция. Код"
        };
        public static StringResource InspectionAddEdit_CategoryLabel = new StringResource
        {
            Id = "InspectionAddEdit_CategoryLabel",
            Description = "Контрольная операция. Категория"
        };
        public static StringResource InspectionAddEdit_NameLabel = new StringResource
        {
            Id = "InspectionAddEdit_NameLabel",
            Description = "Контрольная операция. Название"
        };
        public static StringResource InspectionAddEdit_ExpectedResultLabel = new StringResource
        {
            Id = "InspectionAddEdit_ExpectedResultLabel",
            Description = "Контрольная операция. Ожидаемый результат"
        };
        public static StringResource InspectionAddEdit_FactStringResultLabel = new StringResource
        {
            Id = "InspectionAddEdit_FactStringResultLabel",
            Description = "Контрольная операция. Фактический результат строка"
        };
        public static StringResource InspectionAddEdit_FactBoolResultLabel = new StringResource
        {
            Id = "InspectionAddEdit_FactBoolResultLabel",
            Description = "Контрольная операция. Фактический результат логический"
        };
        public static StringResource InspectionAddEdit_FactLimitResultLabel = new StringResource
        {
            Id = "InspectionAddEdit_FactLimitResultLabel",
            Description = "Контрольная операция. Фактический результат диапазон"
        };
        public static StringResource InspectionAddEdit_DateLabel = new StringResource
        {
            Id = "InspectionAddEdit_DateLabel",
            Description = "Контрольная операция. Дата"
        };
        public static StringResource InspectionAddEdit_StatusLabel = new StringResource
        {
            Id = "InspectionAddEdit_StatusLabel",
            Description = "Контрольная операция. Статус"
        };
        public static StringResource InspectionAddEdit_InspectorsLabel = new StringResource
        {
            Id = "InspectionAddEdit_InspectorsLabel",
            Description = "Контрольная операция. Инспектора"
        };
        public static StringResource InspectionAddEdit_OperationGroup = new StringResource
        {
            Id = "InspectionAddEdit_OperationGroup",
            Description = "Контрольная операция. Группа контрольная операция"
        };
        public static StringResource InspectionAddEdit_ResultGroup = new StringResource
        {
            Id = "InspectionAddEdit_ResultGroup",
            Description = "Контрольная операция. Группа результат"
        };
        public static StringResource InspectionAddEdit_FactStringGroup = new StringResource
        {
            Id = "InspectionAddEdit_FactStringGroup",
            Description = "Контрольная операция. Группа фактический строковый"
        };
        public static StringResource InspectionAddEdit_FactBoolGroup = new StringResource
        {
            Id = "InspectionAddEdit_FactBoolGroup",
            Description = "Контрольная операция. Группа фактический логический"
        };
        public static StringResource InspectionAddEdit_FactLimitGroup = new StringResource
        {
            Id = "InspectionAddEdit_FactLimitGroup",
            Description = "Контрольная операция. Группа фактический диапазон"
        };
        public static StringResource InspectionAddEdit_SaveButton = new StringResource
        {
            Id = "InspectionAddEdit_SaveButton",
            Description = "Контрольная операция. Кнопка сохранить"
        };
        public static StringResource InspectionAddEdit_CancelButton = new StringResource
        {
            Id = "InspectionAddEdit_CancelButton",
            Description = "Контрольная операция. Кнопка отмена"
        };
        #endregion
    }
}
