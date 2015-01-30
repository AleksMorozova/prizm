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

        public static StringResource Settings_ProjectTab = new StringResource
        {
            Id = "Settings_ProjectTab",
            Description = "Настройки. Вкладка - Проект"
        };

        public static StringResource Settings_PipeTab = new StringResource
        {
            Id = "Settings_PipeTab",
            Description = "Настройки. Вкладка - Труба"
        };
        public static StringResource Settings_LineTab = new StringResource
        {
            Id = "Settings_LineTab",
            Description = "Настройки. Вкладка - Трубопровод"
        };
        public static StringResource Settings_PartsTab = new StringResource
        {
            Id = "Settings_PartsTab",
            Description = "Настройки. Вкладка - Комплектующие"
        };
        public static StringResource Settings_WeldersTab = new StringResource
        {
            Id = "Settings_WeldersTab",
            Description = "Настройки. Вкладка - Сварщики"
        };

        public static StringResource Settings_InspectorsTab = new StringResource
        {
            Id = "Settings_InspectorsTab",
            Description = "Настройки. Вкладка - Инспектора"
        };

        public static StringResource Settings_UsersTab = new StringResource
        {
            Id = "Settings_UsersTab",
            Description = "Настройки. Вкладка - Пользователи"
        };
        public static StringResource Settings_RolesTab = new StringResource
        {
            Id = "Settings_RolesTab",
            Description = "Настройки. Вкладка - Роли"
        };
        public static StringResource Settings_SaveButton = new StringResource
        {
            Id = "Settings_SaveButton",
            Description = "Настройки. Кнопка - Сохренить"
        };
        public static StringResource Settings_CloseButton = new StringResource
        {
            Id = "Settings_CloseButton",
            Description = "Настройки. Кнопка - Закрыть"
        };

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
        
        //pipeline page
        public static StringResource SettingsLine_LineGroup = new StringResource
        {
            Id = "SettingsLine_LineGroup",
            Description = "Настройки - Трубопровод. Список контрольных и ремонтных операций для стыка"
        };

        public static StringResource SettingsLine_NameColumn = new StringResource
        {
            Id = "SettingsLine_NameColumn",
            Description = "Настройки - Трубопровод. Название операции"
        };

        public static StringResource SettingsLine_IsReqiredColumn = new StringResource
        {
            Id = "SettingsLine_IsReqiredColumn",
            Description = "Настройки - Трубопровод. Обязательная операция"
        };

        public static StringResource SettingsLine_TestTypeColumn = new StringResource
        {
            Id = "SettingsLine_TestTypeColumn",
            Description = "Настройки - Трубопровод. Тип операции"
        };

        public static StringResource SettingsLine_HasAcceptedColumn = new StringResource
        {
            Id = "SettingsLine_HasAcceptedColumn",
            Description = "Настройки - Трубопровод. Результат контроля - Принято"
        };

        public static StringResource SettingsLine_RepairColumn = new StringResource
        {
            Id = "SettingsLine_RepairColumn",
            Description = "Настройки - Трубопровод. Результат контроля - Ремонт"
        };

        public static StringResource SettingsLine_WithdrawColumn = new StringResource
        {
            Id = "SettingsLine_WithdrawColumn",
            Description = "Настройки - Трубопровод. Результат контроля - Вырезка"
        };

        public static StringResource SettingsLine_IsReqiredResultColumn = new StringResource
        {
            Id = "SettingsLine_IsReqiredResultColumn",
            Description = "Настройки - Трубопровод. Обязательный результат контрольной операции"
        };

        public static StringResource SettingsLine_IsActiveColumn = new StringResource
        {
            Id = "SettingsLine_IsActiveColumn",
            Description = "Настройки - Трубопровод. Активность операции"
        };

        //component page

        public static StringResource SettingsComponent_PartsType = new StringResource
        {
            Id = "SettingsComponent_PartsType",
            Description = "Настройки - Комплектующие. Список типов комплектующих изделий"
        };

        public static StringResource SettingsComponent_TypeColumn = new StringResource
        {
            Id = "SettingsComponent_TypeColumn",
            Description = "Настройки - Комплектующие. Тип комплектующего"
        };

        public static StringResource SettingsComponent_ConnectorsNumberColumn = new StringResource
        {
            Id = "SettingsComponent_ConnectorsNumberColumn",
            Description = "Настройки - Комплектующие. Количество конекторов у комплектующего"
        };

        public static StringResource SettingsComponent_IsActiveTypeColumn = new StringResource
        {
            Id = "SettingsComponent_IsActiveTypeColumn",
            Description = "Настройки - Комплектующие. Активность комплектующего элемента"
        };

        //welder page
        public static StringResource SettingsWelders_LastNameColumn = new StringResource
        {
            Id = "SettingsWelders_LastNameColumn",
            Description = "Настройки - Сварщики. Фамилия сварщика"
        };
        public static StringResource SettingsWelders_FirstNameColumn = new StringResource
        {
            Id = "SettingsWelders_FirstNameColumn",
            Description = "Настройки - Сварщики. Имя сварщика"
        };
        public static StringResource SettingsWelders_MiddleNameColumn = new StringResource
        {
            Id = "SettingsWelders_MiddleNameColumn",
            Description = "Настройки - Сварщики. Отчество сварщика"
        };
        public static StringResource SettingsWelders_CertificateNameColumn = new StringResource
        {
            Id = "SettingsWelders_CertificateNameColumn",
            Description = "Настройки - Сварщики. Сертификат сварщика"
        };
        public static StringResource SettingsWelders_ExpiredColumn = new StringResource
        {
            Id = "SettingsWelders_ExpiredColumn",
            Description = "Настройки - Сварщики. Срок действия сертификата"
        };
        public static StringResource SettingsWelders_StampColumn = new StringResource
        {
            Id = "SettingsWelders_StampColumn",
            Description = "Настройки - Сварщики. Клеймо сварщика"
        };
        public static StringResource SettingsWelders_GradeColumn = new StringResource
        {
            Id = "SettingsWelders_GradeColumn",
            Description = "Настройки - Сварщики. Уровень сварщика"
        };
        public static StringResource SettingsWelders_IsActiveColumn = new StringResource
        {
            Id = "SettingsWelders_IsActiveColumn",
            Description = "Настройки - Сварщики. Активность сварщика"
        };

        //inspectors page
        public static StringResource SettingsInspectors_InspectorsLabel = new StringResource
        {
            Id = "SettingsInspectors_InspectorsLabel",
            Description = "Настройки - Инспектора. Список инспекторов"
        };
        public static StringResource SettingsInspectors_CertificatesLabel = new StringResource
        {
            Id = "SettingsInspectors_CertificatesLabel",
            Description = "Настройки - Инспектора. Список сертификатов для кокретного испектора"
        };
        public static StringResource SettingsInspectors_CertificateTypesLabel = new StringResource
        {
            Id = "SettingsInspectors_CertificateTypesLabel",
            Description = "Настройки - Инспектора. Типы сертификатов"
        };
        public static StringResource SettingsInspectors_InspectorsGroup = new StringResource
        {
            Id = "SettingsInspectors_InspectorsGroup",
            Description = "Настройки - Инспектора. Информация по всем инспекторам"
        };
        public static StringResource SettingsInspectors_CertificatesGroup = new StringResource
        {
            Id = "SettingsInspectors_CertificatesGroup",
            Description = "Настройки - Инспектора. Информация по всем сертификатам"
        };

        public static StringResource SettingsInspectors_LastNameColumn = new StringResource
        {
            Id = "SettingsInspectors_LastNameColumn",
            Description = "Настройки - Инспектора. Фамилия инспектора"
        };
        public static StringResource SettingsInspectors_FirstNameColumn = new StringResource
        {
            Id = "SettingsInspectors_FirstNameColumn",
            Description = "Настройки - Инспектора. Имя инспектора"
        };
        public static StringResource SettingsInspectors_MiddleNameColumn = new StringResource
        {
            Id = "SettingsInspectors_MiddleNameColumn",
            Description = "Настройки - Инспектора. Отчество инспектора"
        };

        public static StringResource SettingsInspectors_CertificateNumberColumn = new StringResource
        {
            Id = "SettingsInspectors_CertificateNumberColumn",
            Description = "Настройки - Инспектора. Номер сертификата инспектора"
        };
        public static StringResource SettingsInspectors_CertificateTypeColumn = new StringResource
        {
            Id = "SettingsInspectors_CertificateTypeColumn",
            Description = "Настройки - Инспектора. Тип сертификата"
        };
        public static StringResource SettingsInspectors_CertificateExpirationColumn = new StringResource
        {
            Id = "SettingsInspectors_CertificateExpirationColumn",
            Description = "Настройки - Инспектора. Срок дейстия сертификата инспектора"
        };

        public static StringResource SettingsInspectors_CertificateIsActiveColumn = new StringResource
        {
            Id = "SettingsInspectors_CertificateIsActiveColumn",
            Description = "Настройки - Инспектора. Активность типа сертификата"
        };
        public static StringResource SettingsInspectors_CertificateNameColumn = new StringResource
        {
            Id = "SettingsInspectors_CertificateNameColumn",
            Description = "Настройки - Инспектора. Название типа сертификата инспектора"
        };

        // user page

        public static StringResource SettingsUser_UsersLabel = new StringResource
        {
            Id = "SettingsUser_UsersLabel",
            Description = "Настройки - Пользователи. Список пользователей"
        };
        public static StringResource SettingsUser_LoginColumn = new StringResource
        {
            Id = "SettingsUser_LoginColumn",
            Description = "Настройки - Пользователи. Логин пользователя"
        };
        public static StringResource SettingsUser_LastNameColumn = new StringResource
        {
            Id = "SettingsUser_LastNameColumn",
            Description = "Настройки - Пользователи. Фамилия пользователя"
        };
        public static StringResource SettingsUser_MiddleNameColumn = new StringResource
        {
            Id = "SettingsUser_MiddleNameColumn",
            Description = "Настройки - Пользователи. Отчество пользователя"
        };
        public static StringResource SettingsUser_FirstNameColumn = new StringResource
        {
            Id = "SettingsUser_FirstNameColumn",
            Description = "Настройки - Пользователи. Имя пользвателя"
        };
        public static StringResource SettingsUser_PassExpiredColumn = new StringResource
        {
            Id = "SettingsUser_PassExpiredColumn",
            Description = "Настройки - Пользователи. Срок истечения пароля"
        };
        public static StringResource SettingsUser_IsActiveColumn = new StringResource
        {
            Id = "SettingsUser_IsActiveColumn",
            Description = "Настройки - Пользователи.  Активность пользователя"
        };
        public static StringResource SettingsUser_PassColumn = new StringResource
        {
            Id = "SettingsUser_PassColumn",
            Description = "Настройки - Пользователи. Пароль пользователя"
        };

        //role page
        public static StringResource SettingsRoles_Label = new StringResource
        {
            Id = "SettingsRoles_Label",
            Description = "Настройки - Роли. Список ролей"
        };
        public static StringResource SettingsRoles_PermissionLabel = new StringResource
        {
            Id = "SettingsRoles_PermissionLabel",
            Description = "Настройки - Роли. Права для конкретной роли"
        };
        public static StringResource SettingsRole_NameColumn = new StringResource
        {
            Id = "SettingsRole_NameColumn",
            Description = "Настройки - Роли. Название роли"
        };
        public static StringResource SettingsRole_DescriptionColumn = new StringResource
        {
            Id = "SettingsRole_DescriptionColumn",
            Description = "Настройки - Роли. Описание роли"
        };

        #endregion Settings

        #region --- Audit ---

        public static StringResource Audit_ElementNumberLabel = new StringResource {
            Id = "Audit_ElementNumberLabel",
            Description = "Аудит. Надпись номера элемента."
        };

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

    }
}
