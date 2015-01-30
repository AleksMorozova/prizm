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
        
        public static StringResource JointSearch_ActivityCriteria_StatusActive = new StringResource {
            Id = "JointSearch_ActivityCriteria_StatusActive",
            Description = "Активные"
        };
                
        public static StringResource JointSearch_ActivityCriteria_StatusUnactive = new StringResource {
            Id = "JointSearch_ActivityCriteria_StatusUnactive",
            Description = "Неактивные"
        };
                        
        public static StringResource JointSearch_ActivityCriteria_StatusAll = new StringResource {
            Id = "JointSearch_ActivityCriteria_StatusAll",
            Description = "Все"
        };
                   
        public static StringResource JointSearch_JointStatus_Welded = new StringResource {
            Id = "JointSearch_JointStatus_Welded",
            Description = "Сварен"
        };
                                        
        public static StringResource JointSearch_JointStatus_Lowered = new StringResource {
            Id = "JointSearch_JointStatus_Lowered",
            Description = "Уложен"
        };
                                             
        public static StringResource JointSearch_JointStatus_Withdrawn = new StringResource {
            Id = "JointSearch_JointStatus_Withdrawn",
            Description = "Вырезан"
        };        
        //part types
        public static StringResource PartTypePipe = new StringResource { 
            Id = "PartTypePipe", 
            Description = "Надпись типа элемента Труба"};

        public static StringResource PartTypeSpool = new StringResource { 
            Id = "PartTypeSpool", 
            Description = "Надпись типа элемента Катушка"};

        public static StringResource PartTypeComponent = new StringResource { 
            Id = "PartTypeComponent", 
            Description = "Надпись типа элемента Компонент"};

        //activity
        public static StringResource StatusActive = new StringResource { 
            Id = "StatusActive", 
            Description = "Надпись статуса активности элемента Активен"};

        public static StringResource StatusInactive = new StringResource { 
            Id = "StatusInactive", 
            Description = "Надпись статуса активности элемента Неактивен"};

        public static StringResource StatusAll = new StringResource { 
            Id = "StatusAll", 
            Description = "Надпись статуса активности элемента Все"};


        #endregion // --- Common

        #region PurchaseOrderForm
        public static StringResource PurchaseOrder_NumberLabel = new StringResource
        {
            Id = "PurchaseOrder_NumberLabel",
            Description = "Наряд-заказ. Надпись над полем номера"
        };

        public static StringResource PurchaseOrder_DateLabel = new StringResource
        {
            Id = "PurchaseOrder_DateLabel",
            Description = "Наряд-заказ. Надпись над полем даты"
        };
        public static StringResource PurchaseOrder_SaveButton = new StringResource
        {
            Id = "PurchaseOrder_SaveButton",
            Description = "Наряд-заказ.Кнопка сохранения"
        };
        public static StringResource PurchaseOrder_CancelButton = new StringResource
        {
            Id = "PurchaseOrder_CancelButton",
            Description = "Наряд-заказ.Кнопка отмены"
        };
        #endregion PurchaseOrderForm

        #region PasswordChange
        public static StringResource PassChange_OldPassLabel = new StringResource
        {
            Id = "PassChange_OldPassLabel",
            Description = "Смена пароля. Ввод старого пароля"
        };

        public static StringResource PassChange_PassLabel = new StringResource
        {
            Id = "PassChange_PassLabel",
            Description = "Смена пароля. Ввод нового пароля"
        };

        public static StringResource PassChange_ConfirmPassLabel = new StringResource
        {
            Id = "PassChange_ConfirmPassLabel",
            Description = "Смена пароля. Подтверждение пароля"
        };

        public static StringResource PassChange_OKButton = new StringResource
        {
            Id = "PassChange_OKButton",
            Description = "Смена пароля. Кнопка подтверждения"
        };

        public static StringResource PassChange_CancelButton = new StringResource
        {
            Id = "PassChange_CancelButton",
            Description = "Смена пароля. Кнопка отмены"
        };
        #endregion PasswordChange

        #region MillReport
        public static StringResource MillReport_ReportTypesLabel = new StringResource
        {
            Id = "MillReport_ReportTypesLabel",
            Description = "Отчеты на заводе. Выбор типа отчета"
        };

        public static StringResource MillReport_ReportPeriodLabel = new StringResource
        {
            Id = "MillReport_ReportPeriodLabel",
            Description = "Отчеты на заводе. Период формирования отчета"
        };
        public static StringResource MillReport_StartDateLabel = new StringResource
        {
            Id = "MillReport_StartDateLabel",
            Description = "Отчеты на заводе. Начальная дата"
        };

        public static StringResource MillReport_EndDateLabel = new StringResource
        {
            Id = "MillReport_EndDateLabel",
            Description = "Отчеты на заводе. Конечная дата"
        };

        public static StringResource MillReport_CategoriesLabel = new StringResource
        {
            Id = "MillReport_CategoriesLabel",
            Description = "Отчеты на заводе. Категория контрольной операции"
        };

        public static StringResource MillReport_StatusesLabel = new StringResource
        {
            Id = "MillReport_StatusesLabel",
            Description = "Отчеты на заводе. Статус контрольной операции"
        };
        public static StringResource MillReport_CreateGroup = new StringResource
        {
            Id = "MillReport_CreateGroup",
            Description = "Отчеты на заводе. Создание отчета"
        };
        public static StringResource MillReport_PreviewGroup = new StringResource
        {
            Id = "MillReport_PreviewGroup",
            Description = "Отчеты на заводе. Просмотр отчета"
        };

        public static StringResource MillReport_CreateButton = new StringResource
        {
            Id = "MillReport_CreateButton",
            Description = "Отчеты на заводе. Кнопка создания отчета"
        };

        public static StringResource MillReport_PreviewButton = new StringResource
        {
            Id = "MillReport_PreviewButton",
            Description = "Отчеты на заводе. Кнопка предпросмотра отчета"
        };
        public static StringResource MillReport_TypeByCategories = new StringResource
        {
            Id = "MillReport_TypeByCategories",
            Description = "Отчеты на заводе. Тип отчета - По категориям"
        };
        public static StringResource MillReport_TypeByShipped = new StringResource
        {
            Id = "MillReport_TypeByShipped",
            Description = "Отчеты на заводе. Тип отчета - По Отгруженным"
        };
        public static StringResource MillReport_TypeByProduced = new StringResource
        {
            Id = "MillReport_TypeByProduced",
            Description = "Отчеты на заводе. Тип отчета - ПО произведенным"
        };
        public static StringResource MillReport_TypeGeneral = new StringResource
        {
            Id = "MillReport_TypeGeneral",
            Description = "Отчеты на заводе. Тип отчета - Общий отчет"
        };
        #endregion MillReport

        #region IncomingInspectionReport
        public static StringResource InspectionReport_DateLabel = new StringResource
        {
            Id = "InspectionReport_DateLabel",
            Description = "Период для формирования отчета"
        };

        public static StringResource InspectionReport_StartDateLabel = new StringResource
        {
            Id = "InspectionReport_StartDateLabel",
            Description = "Отчет на входном контроле. Начальная дата"
        };

        public static StringResource InspectionReport_EndDateLabel = new StringResource
        {
            Id = "InspectionReport_EndDateLabel",
            Description = "Отчет на входном контроле. Крнечная дата"
        };

        public static StringResource InspectionReport_CreateGroup = new StringResource
        {
            Id = "InspectionReport_CreateGroup",
            Description = "Отчет на входном контроле. Создание отчета"
        };

        public static StringResource InspectionReport_PreviewGroup = new StringResource
        {
            Id = "InspectionReport_PreviewGroup",
            Description = "Отчет на входном контроле. Предпросмотр отчета"
        };

        public static StringResource InspectionReport_PreviewButton = new StringResource
        {
            Id = "InspectionReport_PreviewButton",
            Description = "Отчет на входном контроле. Кнопка предпросмотра отчета"
        };

        public static StringResource InspectionReport_CreateButton = new StringResource
        {
            Id = "InspectionReport_CreateButton",
            Description = "Отчет на входном контроле. Кнопка создания отчета"
        };
        #endregion IncomingInspectionReport

        #region Spool
        public static StringResource Spool_PipeNumberLabel = new StringResource
        {
            Id = "Spool_PipeNumberLabel",
            Description = "Катушка. Номер трубы для нарезания на кутушки"
        };

        public static StringResource Spool_SpoolNumberLabel = new StringResource
        {
            Id = "Spool_SpoolNumberLabel",
            Description = "Катушка. Номер катушки"
        };

        public static StringResource Spool_PipeLengthLabel = new StringResource
        {
            Id = "Spool_PipeLengthLabel",
            Description = "Катушка. Длина трубы"
        };

        public static StringResource Spool_SpoolLengthLabel = new StringResource
        {
            Id = "Spool_SpoolLengthLabel",
            Description = "Катушка. Длина катушки"
        };

        public static StringResource Spool_PipeSearchGroup = new StringResource
        {
            Id = "Spool_PipeSearchGroup",
            Description = "Катушка. Поиск трубы"
        };

        public static StringResource Spool_SpoolGroup = new StringResource
        {
            Id = "Spool_SpoolGroup",
            Description = "Катушка. Данные о катушке"
        };

        public static StringResource Spool_LenghtGroup = new StringResource
        {
            Id = "Spool_LenghtGroup",
            Description = "Катушка. Длины трубы и катушки"
        };

        public static StringResource Spool_InspectionDateColumn = new StringResource
        {
            Id = "Spool_InspectionDateColumn",
            Description = "Катушка. Дата входного контроля"
        };

        public static StringResource Spool_InspectionResultColumn = new StringResource
        {
            Id = "Spool_InspectionResultColumn",
            Description = "Катушка. Результат входного контроля"
        };

        public static StringResource Spool_InspectionInspectorsColumn = new StringResource
        {
            Id = "Spool_InspectionInspectorsColumn",
            Description = "Катушка. Инспектора"
        };

        public static StringResource Spool_InspectionReasonColumn = new StringResource
        {
            Id = "Spool_InspectionReasonColumn",
            Description = "Катушка. Комментарии по результату входного контроля"
        };

        public static StringResource Spool_SearchButton = new StringResource
        {
            Id = "Spool_SearchButton",
            Description = "Катушка. Кнопка поиска трубы"
        };

        public static StringResource Spool_AttachButton = new StringResource
        {
            Id = "Spool_AttachButton",
            Description = "Катушка. Кнопка вложений"
        };

        public static StringResource Spool_SaveButton = new StringResource
        {
            Id = "Spool_SaveButton",
            Description = "Катушка. Кнопка сохранения"
        };

        public static StringResource Spool_DeactivatedCheckBox = new StringResource
        {
            Id = "Spool_DeactivatedCheckBox",
            Description = "Катушка. Деактивация катушки"
        };
        #endregion Spool

        #region MissingPortion
        public static StringResource MissingPortion_missingNumbers = new StringResource
        {
            Id = "MissingPortion_missingNumbers",
            Description = "Недостающие порции. Номера порций"
        };

        public static StringResource MissingPortion_recomendation= new StringResource
        {
            Id = "MissingPortion_recomendation",
            Description = "Недостающие порции. Рекомендации"
        };

        public static StringResource MissingPortion_acceptButton = new StringResource
        {
            Id = "MissingPortion_acceptButton",
            Description = "Недостающие порции. Кнопка подтверждения импорта"
        };

        public static StringResource MissingPortion_cancelButton = new StringResource
        {
            Id = "MissingPortion_cancelButton",
            Description = "Недостающие порции. Кнопка отмены импорта"
        };
        #endregion MissingPortion

        #region Settings
        //project page
        public static StringResource SettingsProject_TitleLabel = new StringResource
        {
            Id = "SettingsProject_TitleLabel",
            Description = "Настройки-Проект. Название проекта"
        };
        public static StringResource SettingsProject_ClientLabel = new StringResource
        {
            Id = "SettingsProject_ClientLabel",
            Description = "Настройки-Проект. Имя заказчика"
        };
        public static StringResource SettingsProject_PlateManufacturerLabel = new StringResource
        {
            Id = "SettingsProject_PlateManufacturerLabel",
            Description = "Настройки-Проект. Список производителей листов"
        };
        public static StringResource SettingsProject_DocumentSizeLabel = new StringResource
        {
            Id = "SettingsProject_DocumentSizeLabel",
            Description = "Настройки-Проект. Максимальный размер документа"
        };
        public static StringResource SettingsProject_MillLabel = new StringResource
        {
            Id = "SettingsProject_MillLabel",
            Description = "Настройки-Проект. Название завода"
        };
        public static StringResource SettingsProject_MaskEditLabel = new StringResource
        {
            Id = "SettingsProject_MaskEditLabel",
            Description = "Настройки-Проект. Маска номера трубы"
        };
        public static StringResource SettingsProject_MaskLabel = new StringResource
        {
            Id = "SettingsProject_MaskLabel",
            Description = "Настройки-Проект. Правила задачи маски"
        };
        public static StringResource SettingsProject_OperationsLabel = new StringResource
        {
            Id = "SettingsProject_OperationsLabel",
            Description = "Настройки-Проект. Группы контрольных операций"
        };
        public static StringResource SettingsProject_SeamsLabel = new StringResource
        {
            Id = "SettingsProject_SeamsLabel",
            Description = "Настройки-Проект. Типы швов"
        };
        public static StringResource SettingsProject_CommonGroup = new StringResource
        {
            Id = "SettingsProject_CommonGroup",
            Description = "Настройки-Проект. Общие настройки"
        };
        public static StringResource SettingsProject_MillGroup = new StringResource
        {
            Id = "SettingsProject_MillGroup",
            Description = "Настройки-Проект. Настройки для завода"
        };
        public static StringResource SettingsProject_PlateManColumn = new StringResource
        {
            Id = "SettingsProject_PlateManColumn",
            Description = "Настройки-Проект. Производители листов-колонка"
        };

        public static StringResource SettingsProject_InspectionsCategoryColumn = new StringResource
        {
            Id = "SettingsProject_InspectionsCategoryColumn",
            Description = "Настройки-Проект. Название категорий контрольных операций"
        };
        public static StringResource SettingsProject_InspectionsIsActiveColumn = new StringResource
        {
            Id = "SettingsProject_InspectionsIsActiveColumn",
            Description = "Настройки-Проект. Активность категории контрольной операции"
        };
        public static StringResource SettingsProject_SeamTypeColumn = new StringResource
        {
            Id = "SettingsProject_SeamTypeColumn",
            Description = "Настройки-Проект. Название типов швов"
        };
        public static StringResource SettingsProject_SeamIsActiveColumn = new StringResource
        {
            Id = "SettingsProject_SeamIsActiveColumn",
            Description = "Настройки-Проект. Активность типа шва"
        };

        //pipe page
        public static StringResource SettingsPipe_SizesLabel = new StringResource
        {
            Id = "SettingsPipe_SizesLabel",
            Description = "Настройки-труба. Параметры типоразмера"
        };

        public static StringResource SettingsPipe_InspectionsLabel = new StringResource
        {
            Id = "SettingsPipe_InspectionsLabel",
            Description = "Настройки-труба. Контрольные операции для типоразмера"
        };
        public static StringResource SettingsPipe_DiameterLabel = new StringResource
        {
            Id = "SettingsPipe_DiameterLabel",
            Description = "Настройки-труба. Диаметр трубы с заданым типоразмером"
        };
        public static StringResource SettingsPipe_WallThicknessLabel = new StringResource
        {
            Id = "SettingsPipe_WallThicknessLabel",
            Description = "Настройки-труба. Толщина стенки для трубы с заданым типоразмером"
        };
        public static StringResource SettingsPipe_LengthLabel = new StringResource
        {
            Id = "SettingsPipe_LengthLabel",
            Description = "Настройки-труба. Длина трубы для заданного типоразмера"
        };
        public static StringResource SettingsPipe_SeamTypeLabel = new StringResource
        {
            Id = "SettingsPipe_SeamTypeLabel",
            Description = "Настройки-труба. Тип шва для заданого типоразмера"
        };
        
        public static StringResource SettingsPipe_CloneTypeSizeButton = new StringResource
        {
            Id = "SettingsPipe_CloneTypeSizeButton",
            Description = "Настройки-труба. Кнопка клонировать типоразмер"
        };
        public static StringResource SettingsPipe_AddTestButton = new StringResource
        {
            Id = "SettingsPipe_AddTestButton",
            Description = "Настройки-труба. Кнопка добавить контрольную операцию"
        };
        public static StringResource SettingsPipe_EditTestButton = new StringResource
        {
            Id = "SettingsPipe_EditTestButton",
            Description = "Настройки-труба. Кнопка редактировать контрольную операцию"
        };

        public static StringResource SettingsPipe_SizeGridColumn = new StringResource
        {
            Id = "SettingsPipe_SizeGridColumn",
            Description = "Настройки-труба. Список типоразеров"
        };
        public static StringResource SettingsPipe_SizeIsActiveGridColumn = new StringResource
        {
            Id = "SettingsPipe_SizeIsActiveGridColumn",
            Description = "Настройки-труба. Активность типоразмера"
        };
        
        public static StringResource SettingsPipe_InspectionsCodeColumn = new StringResource
        {
            Id = "SettingsPipe_InspectionsCodeColumn",
            Description = "Настройки-труба. Код контрольной операции"
        };
                public static StringResource SettingsPipe_InspectionsNameColumn = new StringResource
        {
            Id = "SettingsPipe_InspectionsNameColumn",
            Description = "Настройки-труба. Название контрольной операции"
        };
                public static StringResource SettingsPipe_InspectionsCategoryColumn = new StringResource
        {
            Id = "SettingsPipe_InspectionsCategoryColumn",
            Description = "Настройки-труба. Категория контрольной операции"
        };
                public static StringResource SettingsPipe_InspectionsControlTypeColumn = new StringResource
        {
            Id = "SettingsPipe_InspectionsControlTypeColumn",
            Description = "Настройки-труба. Тип контрольной операции"
        };
                public static StringResource SettingsPipe_InspectionsResultTypeColumn = new StringResource
        {
            Id = "SettingsPipe_InspectionsResultTypeColumn",
            Description = "Настройки-труба. Результат конрольной операции"
        };
                public static StringResource SettingsPipe_InspectionsBoolExpectedColumn = new StringResource
        {
            Id = "SettingsPipe_InspectionsBoolExpectedColumn",
            Description = "Настройки-труба. Ожидаемы результат для булевского результата"
        };
                public static StringResource SettingsPipe_InspectionsMinExpectedColumn = new StringResource
        {
            Id = "SettingsPipe_InspectionsMinExpectedColumn",
            Description = "Настройки-труба. Минимальный результат контрольной операции"
        };
                public static StringResource SettingsPipe_InspectionsMaxExpectedColumn = new StringResource
        {
            Id = "SettingsPipe_InspectionsMaxExpectedColumn",
            Description = "Настройки-труба. Максимальный результат контрольной операции"
        };
                public static StringResource SettingsPipe_InspectionsIsReqiredColumn = new StringResource
        {
            Id = "SettingsPipe_InspectionsIsReqiredColumn",
            Description = "Настройки-труба. Обязательная контрольная операция"
        };
                public static StringResource SettingsPipe_InspectionsIsActiveColumn = new StringResource
        {
            Id = "SettingsPipe_InspectionsIsActiveColumn",
            Description = "Настройки-труба. Активность контрольной операции"
        };
        #endregion Settings

        #region --- Audit ---

        public static StringResource Audit_ElementNumberLabel = new StringResource {
            Id = "Audit_ElementNumberLabel",
            Description = "Аудит. Надпись номера элемента."};
        
        public static StringResource Audit_PeriodLabel = new StringResource { 
            Id = "Audit_PeriodLabel", 
            Description = "Аудит. Надпись периода"};

        #endregion //--- Audit ---
        public static StringResource Audit_StartDateLabel = new StringResource { 
            Id = "Audit_StartDateLabel", 
            Description = "Аудит. Надпись начальной даты)"};

        public static StringResource Audit_EndDateLabel = new StringResource { 
            Id = "Audit_EndDateLabel", 
            Description = "Аудит. Надпись конечной даты)"};

        public static StringResource Audit_UserLabel = new StringResource { 
            Id = "Audit_UserLabel", 
            Description = "Аудит. Надпись пользователя"};

        public static StringResource Audit_SearchButton = new StringResource { 
            Id = "Audit_SearchButton", 
            Description = "Аудит. Надпись кнопки пользователя"};

        public static StringResource Audit_UserColumnHeader = new StringResource { 
            Id = "Audit_UserColumnHeader", 
            Description = "Аудит. Надпись колонки пользователя"};

        public static StringResource Audit_DateColumnHeader = new StringResource { 
            Id = "Audit_DateColumnHeader", 
            Description = "Аудит. Надпись колонки даты"};

        public static StringResource Audit_EntityColumnHeader = new StringResource { 
            Id = "Audit_EntityColumnHeader", 
            Description = "Аудит. Надпись колонки изменяемой сущности"};

        public static StringResource Audit_OldValueColumnHeader = new StringResource { 
            Id = "Audit_OldValueColumnHeader", 
            Description = "Аудит. Надпись колонки старого значения"};

        public static StringResource Audit_NewValueColumnHeader = new StringResource { 
            Id = "Audit_NewValueColumnHeader",
            Description = "Аудит. Надпись колонки нового значения" };

        public static StringResource Audit_FieldColumnHeader = new StringResource { 
            Id = "Audit_FieldColumnHeader", 
            Description = "Аудит. Надпись колонки поля"};

        public static StringResource Audit_NumberColumnHeader = new StringResource { 
            Id = "Audit_NumberColumnHeader", 
            Description = "Аудит. Надпись колонки номера"};

        public static StringResource Audit_SearchParametersGroup = new StringResource { 
            Id = "Audit_SearchParametersGroup", 
            Description = "Аудит. Надпись панели параметров поиска"};

        public static StringResource Audit_RadioPeriod = new StringResource { 
            Id = "Audit_RadioPeriod", 
            Description = "Аудит. Надпись радиокнопки периода"};

        public static StringResource Audit_RadioUser = new StringResource { 
            Id = "Audit_RadioUser", 
            Description = "Аудит. Надпись радиокнопки пользователя"};

        #endregion //--- Audit --

        #region --- About ---

        public static StringResource AboutForm_TitleLabel = new StringResource {
            Id = "AboutForm_TitleLabel",
            Description = "Текст в окне \"О программе \""
        };
        public static StringResource About_VersionLabel = new StringResource
        {
            Id = "About_VersionLabel",
            Description = "Версия программы"
        };
        public static StringResource About_AcceptButton = new StringResource
        {
            Id = "About_AcceptButton",
            Description = "Кнопка ОК"
        };
        #endregion // --- About ---

        #region --- Part Search ---

        public static StringResource PartSearch_SearchNumberLabel = new StringResource { 
            Id = "PartSearch_SearchNumberLabel",
            Description = "Поиск элементов трубопровода. Надпись номера элемента"};

        public static StringResource PartSearch_SearchTypeLabel = new StringResource { 
            Id = "PartSearch_SearchTypeLabel", 
            Description = "Поиск элементов трубопровода. Надпись типа элемента"};

        public static StringResource PartSearch_ActivityLabel = new StringResource { 
            Id = "PartSearch_ActivityLabel", 
            Description = "Поиск элементов трубопровода. Надпись активности элемента"};

        public static StringResource PartSearch_SearchButton = new StringResource {
            Id = "PartSearch_SearchButton", 
            Description = "Поиск элементов трубопровода. Надпись кнопки поиска"};

        public static StringResource PartSearch_NumberColumnHeader = new StringResource { 
            Id = "PartSearch_NumberColumnHeader", 
            Description = "Поиск элементов трубопровода. Надпись колонки номера"};

        public static StringResource PartSearch_TypeColumnHeader = new StringResource { 
            Id = "PartSearch_TypeColumnHeader", 
            Description = "Поиск элементов трубопровода. Надпись колонки типа"};

        public static StringResource PartSearch_SearchGroup = new StringResource { 
            Id = "PartSearch_SearchGroup", 
            Description = "Поиск элементов трубопровода. Надпись панели поиска"};

        public static StringResource PartSearch_SearchResultGroup = new StringResource { 
            Id = "PartSearch_SearchResultGroup", 
            Description = "Поиск элементов трубопровода. Надпись панели результатов поиска"};


        #endregion

        #region --- Export ---
        public static StringResource Export_ExportButton = new StringResource { 
            Id = "Export_ExportButton", 
            Description = "Экспорт. Надпись кнопки экспорта"};

        public static StringResource Export_PleaseWaitPanel = new StringResource { 
            Id = "Export_PleaseWaitPanel", 
            Description = "Экспорт. Надпись панели загрузки Ожидайте"};

        public static StringResource Export_ExportingData = new StringResource { 
            Id = "Export_ExportingData", 
            Description = "Экспорт. Надпись панели загрузки экспортирование"};
        
        public static StringResource Export_LogLabel = new StringResource { 
            Id = "Export_LogLabel", 
            Description = "Экспорт. Надпись надписи журнала"};

        public static StringResource Export_ReexportButton = new StringResource { 
            Id = "Export_ReexportButton", 
            Description = "Экспорт. Надпись кнопки реэкспорта"};

        public static StringResource Export_PortionIdColumnHeader = new StringResource {
            Id = "Export_PortionIdColumnHeader", 
            Description = "Экспорт. Надпись колонки Id порции"};

        public static StringResource Export_ExportDateColumnHeader = new StringResource { 
            Id = "Export_ExportDateColumnHeader", 
            Description = "Экспорт. Надпись колонки даты экспорта"};

        public static StringResource Export_LogTab = new StringResource { 
            Id = "Export_LogTab",
            Description = "Экспорт. Надпись вкладки журнала"};

        public static StringResource Export_HistoryTab = new StringResource { 
            Id = "Export_HistoryTab",
            Description = "Экспорт. Надпись вкладки истории"};

        #endregion

        #region ---Save Dialog---
        public static StringResource SaveDialog_SaveLabel = new StringResource { 
            Id = "SaveDialog_SaveLabel", 
            Description = "Диалог сохранения. Текст"};

        public static StringResource SaveDialog_SaveButton = new StringResource { 
            Id = "SaveDialog_SaveButton", 
            Description = "Диалог сохранения. Кнопка сохранения"};

        public static StringResource SaveDialog_DontSaveButton = new StringResource { 
            Id = "SaveDialog_DontSaveButton", 
            Description = "Диалог сохранения. Кнопка Не сохранять"};

        public static StringResource SaveDialog_CancelButton = new StringResource { 
            Id = "SaveDialog_CancelButton", 
            Description = "Диалог сохранения. Кнопка отмены"};


        #endregion

        #region --- External files ---
        public static StringResource ExternalFiles_AddFileButton = new StringResource { 
            Id = "ExternalFiles_AddFileButton", 
            Description = "Вложения. Кнопка добавления"};

        public static StringResource ExternalFiles_FileNameColumnHeader = new StringResource { 
            Id = "ExternalFiles_FileNameColumnHeader", 
            Description = "Вложения. Надпись колонки имени файла"};

        public static StringResource ExternalFiles_UploadDateColumnHeader = new StringResource { 
            Id = "ExternalFiles_UploadDateColumnHeader", 
            Description = "Вложения. Надпись колонки даты загрузки"};

        #endregion

        #region --- CreateSpoolComponentDialog ---
        public static StringResource CreateSpoolComponentDialog_CreateElementQuestionLabel = new StringResource {
            Id = "CreateSpoolComponentDialog_CreateElementQuestionLabel", 
            Description = "Диалог создания элемента. Текст вопроса"};

        public static StringResource CreateSpoolComponentDialog_RadioSpool = new StringResource { 
            Id = "CreateSpoolComponentDialog_RadioSpool", 
            Description = "Диалог создания элемента. Радиокнопка катушки"};

        public static StringResource CreateSpoolComponentDialog_RadioComponent = new StringResource { 
            Id = "CreateSpoolComponentDialog_RadioComponent", 
            Description = "Диалог создания элемента. Радиокнопка комплектующего"};

        public static StringResource CreateSpoolComponentDialog_CancelButton = new StringResource {
            Id = "CreateSpoolComponentDialog_CancelButton", 
            Description = "Диалог создания элемента. Кнопка отмены"};

        public static StringResource CreateSpoolComponentDialog_CreateButton = new StringResource { 
            Id = "CreateSpoolComponentDialog_CreateButton", 
            Description = "Диалог создания элемента. Кнопка создания"};
        #endregion

        #region --- InspectionSelectPartDialog ---
        public static StringResource InspectionSelectPartDialog_SearchResultsLabel = new StringResource { 
            Id = "InspectionSelectPartDialog_SearchResultsLabel", 
            Description = "Диалог выбора элемента инспекции. Надпись результатов поиска"};

        public static StringResource InspectionSelectPartDialog_CancelButton = new StringResource { 
            Id = "InspectionSelectPartDialog_CancelButton", Description = 
            "Диалог выбора элемента инспекции. Надпись кнопки отмены"};

        public static StringResource InspectionSelectPartDialog_InspectionButton = new StringResource { 
            Id = "InspectionSelectPartDialog_InspectionButton", 
            Description = "Диалог выбора элемента инспекции. Надпись кнопки контроля"};

        public static StringResource InspectionSelectPartDialog_NumberColumnHeader = new StringResource { 
            Id = "InspectionSelectPartDialog_NumberColumnHeader", 
            Description = "Диалог выбора элемента инспекции. Надпись колонки номера"};

        public static StringResource InspectionSelectPartDialog_TypeColumnHeader = new StringResource { 
            Id = "InspectionSelectPartDialog_TypeColumnHeader", 
            Description = "Диалог выбора элемента инспекции. Надпись колонки типа"};

        #endregion

        #region ---Conflict Dialog
        public static StringResource ConflictDialog_ConflictLabel = new StringResource { 
            Id = "ConflictDialog_ConflictLabel", 
            Description = "Диалог конфликта при импорте. Текст"};

        public static StringResource ConflictDialog_ReplaceButton = new StringResource { 
            Id = "ConflictDialog_ReplaceButton", 
            Description = "Диалог конфликта при импорте. Надпись кнопки замены"};

        public static StringResource ConflictDialog_SkipButton = new StringResource { 
            Id = "ConflictDialog_SkipButton", 
            Description = "Диалог конфликта при импорте. Надпись кнопки Пропустить"};

        public static StringResource ConflictDialog_PostponeButton = new StringResource {
            Id = "ConflictDialog_PostponeButton", 
            Description = "Диалог конфликта при импорте. Надпись кнопки отложения решения"};

        public static StringResource ConflictDialog_ApplyForAllChechbox = new StringResource { 
            Id = "ConflictDialog_ApplyForAllChechbox", 
            Description = "Диалог конфликта при импорте. Надпись чекбокса Применить для всех"};

        #endregion

        #region --- Import form ---
        public static StringResource Import_ArchiveLabel = new StringResource { 
            Id = "Import_ArchiveLabel", 
            Description = "Импорт. Надпись архива"};

        public static StringResource Import_BrowseButton = new StringResource { 
            Id = "Import_BrowseButton", 
            Description = "Импорт. Надпись кнопки поиска"};

        public static StringResource Import_ImportButton = new StringResource { 
            Id = "Import_ImportButton", 
            Description = "Импорт. Надпись кнопки импорта"};

        #endregion

        #region Heat Number Form
        public static StringResource HeatNumber_HeatNumberLabel = new StringResource { 
            Id = "HeatNumber_HeatNumberLabel", 
            Description = "Номер плавки. Надпись номера"};

        public static StringResource HeatNumber_SaveButton = new StringResource { 
            Id = "HeatNumber_SaveButton", 
            Description = "Номер плавки. Надпись кнопки сохранения"};

        public static StringResource HeatNumber_CancelButton = new StringResource { Id = 
            "HeatNumber_CancelButton", 
            Description = "Номер плавки. Надпись кнопки отмены"};

        #endregion
        #region --- ComponentNewEdit ---

        public static StringResource ComponentNewEdit_NewComponentLayoutGroup = new StringResource
        {
            Id = "ComponentNewEdit_NewComponentLayoutGroup",
            Description = "Комплектующее изделие"
        };

        public static StringResource ComponentNewEdit_ComponentNumberLayout = new StringResource
        {
            Id = "ComponentNewEdit_ComponentNumberLayout",
            Description = "Ном&ер изделия"
        };

        public static StringResource ComponentNewEdit_TypeLayoutControl = new StringResource
        {
            Id = "ComponentNewEdit_TypeLayoutControl",
            Description = "&Тип изделия"
        };

        public static StringResource ComponentNewEdit_CertificateLayout = new StringResource
        {
            Id = "ComponentNewEdit_CertificateLayout",
            Description = "Номер се&ртификата"
        };

        public static StringResource ComponentNewEdit_ComponentLengthLayout = new StringResource
        {
            Id = "ComponentNewEdit_ComponentLengthLayout",
            Description = "Длина комплектую&щего, мм"
        };

        public static StringResource ComponentNewEdit_AttachmentsButton = new StringResource
        {
            Id = "ComponentNewEdit_AttachmentsButton",
            Description = "&Вложения"
        };

        public static StringResource ComponentNewEdit_Deactivated = new StringResource
        {
            Id = "ComponentNewEdit_Deactivated",
            Description = "Компонент деактивирован"
        };

        public static StringResource ComponentNewEdit_NewSaveComponentButton = new StringResource
        {
            Id = "ComponentNewEdit_NewSaveComponentButton",
            Description = "Со&хранить / Создать"
        };

        public static StringResource ComponentNewEdit_SaveComponentButton = new StringResource
        {
            Id = "ComponentNewEdit_SaveComponentButton",
            Description = "&Сохранить"
        };

        public static StringResource ComponentNewEdit_InspectionDateColumn = new StringResource
        {
            Id = "ComponentNewEdit_InspectionDateColumn",
            Description = "Дата инспекции"
        };

        public static StringResource ComponentNewEdit_InspectorColumn = new StringResource
        {
            Id = "ComponentNewEdit_InspectorColumn",
            Description = "Инспекторы"
        };

        public static StringResource ComponentNewEdit_ResultColumn = new StringResource
        {
            Id = "ComponentNewEdit_ResultColumn",
            Description = "Результат"
        };

        public static StringResource ComponentNewEdit_ReasonColumn = new StringResource
        {
            Id = "ComponentNewEdit_ReasonColumn",
            Description = "Причина"
        };

        public static StringResource ComponentNewEdit_DiameterGridColumn = new StringResource
        {
            Id = "ComponentNewEdit_DiameterGridColumn",
            Description = "Диаметр отверстия"
        };

        public static StringResource ComponentNewEdit_WallThicknessGridColumn = new StringResource
        {
            Id = "ComponentNewEdit_WallThicknessGridColumn",
            Description = "Толщина стенки"
        };

        public static StringResource ComponentNewEdit_InspectionLayoutGroup = new StringResource
        {
            Id = "ComponentNewEdit_InspectionLayoutGroup",
            Description = "Входно&й контроль"
        };
   
        #endregion //--- ComponentNewEdit ---

        #region --- JointNew ---

        public static StringResource JointNew_JointNumberLayout = new StringResource
        {
            Id = "JointNew_JointNumberLayout",
            Description = "Ном&ер стыка"
        };

        public static StringResource JointNew_JointStatusLayout = new StringResource
        {
            Id = "JointNew_JointStatusLayout",
            Description = "Статус стыка"
        };

        public static StringResource JointNew_FirstJointElementLayout = new StringResource
        {
            Id = "JointNew_FirstJointElementLayout",
            Description = "&Первый элемент стыка"
        };

        public static StringResource JointNew_SecondJointElementLayout = new StringResource
        {
            Id = "JointNew_SecondJointElementLayout",
            Description = "В&торой элемент стыка"
        };

        public static StringResource JointNew_JointParametersLayoutGroup = new StringResource
        {
            Id = "JointNew_JointParametersLayoutGroup",
            Description = "Параметры стыка"
        };

        public static StringResource JointNew_LoweringLayoutGroup = new StringResource
        {
            Id = "JointNew_LoweringLayoutGroup",
            Description = "Параметры укладки"
        };

        public static StringResource JointNew_LoweringDateLayout = new StringResource
        {
            Id = "JointNew_LoweringDateLayout",
            Description = "Дата &укладки"
        };

        public static StringResource JointNew_PKLabelLayout = new StringResource
        {
            Id = "JointNew_PKLabelLayout",
            Description = "PK"
        };

        public static StringResource JointNew_PKNumberLayout = new StringResource
        {
            Id = "JointNew_PKNumberLayout",
            Description = "Номер п&икета"
        };

        public static StringResource JointNew_DistanceFromPKLayout = new StringResource
        {
            Id = "JointNew_DistanceFromPKLayout",
            Description = "Рассто&яние от пикета"
        };

        public static StringResource JointNew_GPSLabelLayout = new StringResource
        {
            Id = "JointNew_GPSLabelLayout",
            Description = "GPSLabelLayout"
        };

        public static StringResource JointNew_GPSLatLayout = new StringResource
        {
            Id = "JointNew_GPSLatLayout",
            Description = "&Широта"
        };

        public static StringResource JointNew_GPSLongLayout = new StringResource
        {
            Id = "JointNew_GPSLongLayout",
            Description = "До&лгота"
        };

        public static StringResource JointNew_ElevationLayout = new StringResource
        {
            Id = "JointNew_ElevationLayout",
            Description = "В&ысота"
        };

        public static StringResource JointNew_InspectionLayoutGroup = new StringResource
        {
            Id = "JointNew_InspectionLayoutGroup",
            Description = "Операции"
        };

        public static StringResource JointNew_RepairOperationLayout = new StringResource
        {
            Id = "JointNew_RepairOperationLayout",
            Description = "Сварка и ре&монт"
        };

        public static StringResource JointNew_ControlOperationsLayout = new StringResource
        {
            Id = "JointNew_ControlOperationsLayout",
            Description = "Контрольные опера&ции"
        };

        public static StringResource JointNew_SaveButton = new StringResource
        {
            Id = "JointNew_SaveButton",
            Description = "Со&хранить"
        };

        public static StringResource JointNew_SaveAndCreateButton = new StringResource
        {
            Id = "JointNew_SaveAndCreateButton",
            Description = "Сох&ранить/Создать"
        };

        public static StringResource JointNew_ExtraFiles = new StringResource
        {
            Id = "JointNew_ExtraFiles",
            Description = "&Вложения"
        };

        public static StringResource JointNew_Deactivated = new StringResource
        {
            Id = "JointNew_Deactivated",
            Description = "Стык деактивирован"
        };

        public static StringResource JointNew_RepairTypeGridColumn = new StringResource
        {
            Id = "JointNew_RepairTypeGridColumn",
            Description = "Название операции"
        };

        public static StringResource JointNew_RepairDateGridColumn = new StringResource
        {
            Id = "JointNew_RepairDateGridColumn",
            Description = "Дата"
        };

        public static StringResource JointNew_CompletedGridColumn = new StringResource
        {
            Id = "JointNew_CompletedGridColumn",
            Description = "Выполнено"
        };

        public static StringResource JointNew_WeldersGridColumn = new StringResource
        {
            Id = "JointNew_WeldersGridColumn",
            Description = "Сварщики"
        };

        public static StringResource JointNew_ControlTypeGridColumn = new StringResource
        {
            Id = "JointNew_ControlTypeGridColumn",
            Description = "Название операции"
        };

        public static StringResource JointNew_ResultGridColumn = new StringResource
        {
            Id = "JointNew_ResultGridColumn",
            Description = "Результат"
        };

        public static StringResource JointNew_ControlDateGridColumn = new StringResource
        {
            Id = "JointNew_ControlDateGridColumn",
            Description = "Дата контроля"
        };

        public static StringResource JointNew_InspectorsGridColumn = new StringResource
        {
            Id = "JointNew_InspectorsGridColumn",
            Description = "Инспекторы"
        };

        public static StringResource JointNew_ValueGridColumn = new StringResource
        {
            Id = "JointNew_ValueGridColumn",
            Description = "Значение"
        };

        #endregion //--- JointNew ---

        #region --- JointSearch ---

        public static StringResource JointSearch_JointNumber = new StringResource
        {
            Id = "JointSearch_JointNumber",
            Description = "Ном&ер стыка"
        };

        public static StringResource JointSearch_ControlStateLayout = new StringResource
        {
            Id = "JointSearch_ControlStateLayout",
            Description = "С&татус"
        };

        public static StringResource JointSearch_WeldingDateLabel = new StringResource
        {
            Id = "JointSearch_WeldingDateLabel",
            Description = "Дата сварки"
        };

        public static StringResource JointSearch_WeldingDateFromLayout = new StringResource
        {
            Id = "JointSearch_WeldingDateFromLayout",
            Description = "с"
        };

        public static StringResource JointSearch_WeldingDateToLayout = new StringResource
        {
            Id = "JointSearch_WeldingDateToLayout",
            Description = "по"
        };

        public static StringResource JointSearch_KMlayout = new StringResource
        {
            Id = "JointSearch_KMlayout",
            Description = "Номер п&икета"
        };

        public static StringResource JointSearch_ActivityLayout = new StringResource
        {
            Id = "JointSearch_ActivityLayout",
            Description = "Состояние стыка"
        };

        public static StringResource JointSearch_SearchLayoutGroup = new StringResource
        {
            Id = "JointSearch_SearchLayoutGroup",
            Description = "Параметры поиска"
        };

        public static StringResource JointSearch_SearchButton = new StringResource
        {
            Id = "JointSearch_SearchButton",
            Description = "&Поиск"
        };

        public static StringResource JointSearch_SearchResultLayoutGroup = new StringResource
        {
            Id = "JointSearch_SearchResultLayoutGroup",
            Description = "Резул&ьтаты поиска"
        };

        public static StringResource JointSearch_JointNumberGridColumn = new StringResource
        {
            Id = "JointSearch_JointNumberGridColumn",
            Description = "Номер стыка"
        };

        public static StringResource JointSearch_JoinStatusGridColumn = new StringResource
        {
            Id = "JointSearch_JoinStatusGridColumn",
            Description = "Статус"
        };

        public static StringResource JointSearch_NumberKPCol = new StringResource
        {
            Id = "JointSearch_NumberKPCol",
            Description = "Номер пикета"
        };

        public static StringResource JointSearch_LoweringDateCol = new StringResource
        {
            Id = "JointSearch_LoweringDateCol",
            Description = "Дата укладки"
        };

        public static StringResource JointSearch_GpsLatCol = new StringResource
        {
            Id = "JointSearch_GpsLatCol",
            Description = "Широта"
        };

        
        public static StringResource JointSearch_GpsLongCol = new StringResource
        {
            Id = "JointSearch_GpsLongCol",
            Description = "Долгота"
        };

                
        public static StringResource JointSearch_GpsHeightCol = new StringResource
        {
            Id = "JointSearch_GpsHeightCol",
            Description = "Высота"
        };

        #endregion //--- JointSearch ---

        #region --- ConstructionReports ---

        public static StringResource ConstructionReports_ReportTypeLayout = new StringResource
        {
            Id = "ConstructionReports_ReportTypeLayout",
            Description = "Тип отчета"
        };
        
        public static StringResource ConstructionReports_TypeLayout = new StringResource
        {
            Id = "ConstructionReports_TypeLayout",
            Description = "Тип изделия"
        };
                
        public static StringResource ConstructionReports_StartJointLayout = new StringResource
        {
            Id = "ConstructionReports_StartJointLayout",
            Description = "Начальный стык"
        };
                        
        public static StringResource ConstructionReports_StartKPComboBoxLayoutControl = new StringResource
        {
            Id = "ConstructionReports_StartKPComboBoxLayoutControl",
            Description = "Начальный пикет"
        };
                              
        public static StringResource ConstructionReports_EndJointLayout = new StringResource
        {
            Id = "ConstructionReports_EndJointLayout",
            Description = "Конечный стык"
        };
                                      
        public static StringResource ConstructionReports_EndKPLayout = new StringResource
        {
            Id = "ConstructionReports_EndKPLayout",
            Description = "Конечный пикет"
        };
                                           
        public static StringResource ConstructionReports_PreviewButton = new StringResource
        {
            Id = "ConstructionReports_PreviewButton",
            Description = "&Предпросмотр"
        };
                                                   
        public static StringResource ConstructionReports_CreateReportButton = new StringResource
        {
            Id = "ConstructionReports_CreateReportButton",
            Description = "Соз&дать отчет"
        };
                                                   
        public static StringResource ConstructionReports_CreateReportaLyoutGroup = new StringResource
        {
            Id = "ConstructionReports_CreateReportaLyoutGroup",
            Description = "Сформировать отчёт"
        };
                                                           
        public static StringResource ConstructionReports_PreviewLayoutGroup = new StringResource
        {
            Id = "ConstructionReports_PreviewLayoutGroup",
            Description = "Предварительный просмотр отчёта"
        };

                                                                   
        public static StringResource ConstructionReport_RadioJoints = new StringResource
        {
            Id = "ConstructionReport_RadioJoints",
            Description = "Стыки"
        };
                                                               
        public static StringResource ConstructionReport_RadioKP = new StringResource
        {
            Id = "ConstructionReport_RadioKP",
            Description = "Пикеты"
        };


        #endregion //--- ConstructionReports ---

        #region --- PipeConstractionReport ---

        public static StringResource PipeConstractionReport_PipeNumberLayout = new StringResource
        {
            Id = "PipeConstractionReport_PipeNumberLayout",
            Description = "Номер трубы"
        };
        
        public static StringResource PipeConstractionReport_PipeTypeCheckedComboLayout = new StringResource
        {
            Id = "PipeConstractionReport_PipeTypeCheckedComboLayout",
            Description = "Типоразмер"
        };
        
        public static StringResource PipeConstractionReport_PipeReportParametersLayoutGroup = new StringResource
        {
            Id = "PipeConstractionReport_PipeReportParametersLayoutGroup",
            Description = "Параметры отчета по трубам"
        };
        
        public static StringResource PipeConstractionReport_PreviewButton = new StringResource
        {
            Id = "PipeConstractionReport_PreviewButton",
            Description = "&Предпросмотр"
        };

        public static StringResource PipeConstractionReport_CreateReportButton = new StringResource
        {
            Id = "PipeConstractionReport_CreateReportButton",
            Description = "Соз&дать отчет"
        };
        
        public static StringResource PipeConstractionReport_DocumentViewerLayoutGroup = new StringResource
        {
            Id = "PipeConstractionReport_DocumentViewerLayoutGroup",
            Description = "Предварительный просмотр отчёта"
        };

        #endregion //--- PipeConstractionReport ---

        #region --- WeldDateReport ---

        public static StringResource WeldDateReport_WeldDateFromLayout = new StringResource {
            Id = "WeldDateReport_WeldDateFromLayout",
            Description = "Дата сварки: С"
        };
        
        public static StringResource WeldDateReport_WeldDateToLayout = new StringResource {
            Id = "WeldDateReport_WeldDateToLayout",
            Description = "Дата сварки: По"
        };
        
        public static StringResource WeldDateReport_PreviewButton = new StringResource {
            Id = "WeldDateReport_PreviewButton",
            Description = "&Предпросмотр"
        };
        
        public static StringResource WeldDateReport_CreateReportButton = new StringResource {
            Id = "WeldDateReport_CreateReportButton",
            Description = "Соз&дать отчет"
        };
                
        public static StringResource WeldDateReport_WeldReportParameterGroup = new StringResource {
            Id = "WeldDateReport_WeldReportParameterGroup",
            Description = "Сформировать отчёт"
        };
        
        public static StringResource WeldDateReport_JointReportViewerGroup = new StringResource {
            Id = "WeldDateReport_JointReportViewerGroup",
            Description = "Предварительный просмотр отчёта"
        };

        #endregion //--- WeldDateReport ---

        #region --- JointCutDialog ---

        public static StringResource JointCutDialog_FirstJoinedPartGroup = new StringResource {
            Id = "JointCutDialog_FirstJoinedPartGroup",
            Description = "Первый элемент"
        };
        
        public static StringResource JointCutDialog_FirstJoinedPartNumberLayout = new StringResource {
            Id = "JointCutDialog_FirstJoinedPartNumberLayout",
            Description = "Номер"
        };
                
        public static StringResource JointCutDialog_FirstJoinedPartLengthLayout = new StringResource {
            Id = "JointCutDialog_FirstJoinedPartLengthLayout",
            Description = "Длинна, мм"
        };
             
        public static StringResource JointCutDialog_SecondJoinedPartGroup = new StringResource {
            Id = "JointCutDialog_SecondJoinedPartGroup",
            Description = "Второй элемент"
        };

        public static StringResource JointCutDialog_SecondJoinedPartNumberLayout = new StringResource
        {
            Id = "JointCutDialog_SecondJoinedPartNumberLayout",
            Description = "Номер"
        };
        
        public static StringResource JointCutDialog_SecondJoinedPartLengthLayout = new StringResource {
            Id = "JointCutDialog_SecondJoinedPartLengthLayout",
            Description = "Длинна, мм"
        };
        
        public static StringResource JointCutDialog_CutJointButton = new StringResource {
            Id = "JointCutDialog_CutJointButton",
            Description = "Вырезать"
        };
        
        public static StringResource JointCutDialog_CancelButton = new StringResource {
            Id = "JointCutDialog_CancelButton",
            Description = "Отмена"
        };



        #endregion //--- JointCutDialog ---

        #region --- SelectDiameterDialog ---

        public static StringResource SelectDiameterDialog_DiametersIntersectionLayout = new StringResource {
            Id = "SelectDiameterDialog_DiametersIntersectionLayout",
            Description = "Выбор диаметра соединения"
        };
        
        public static StringResource SelectDiameterDialog_SaveChosenDiameter = new StringResource {
            Id = "SelectDiameterDialog_SaveChosenDiameter",
            Description = "Сохранить"
        };

        #endregion //--- SelectDiameterDialog ---
    }
} 