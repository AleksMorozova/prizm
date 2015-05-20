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

        public static StringResource NewEditPipe_ReadyToShip = new StringResource
        {
            Id = "NewEditPipe_ReadyToShip",
            Description = "Готова к отгрузке"
        };

        public static StringResource WaitScreen_Caption = new StringResource
        {
            Id = "WaitScreen_Caption",
            Description = "Ожидайте"
        };

        public static StringResource WaitScreen_Description = new StringResource
        {
            Id = "WaitScreen_Description",
            Description = "Идет загрузка ..."
        };

        public static StringResource ChechedCombobox_SelectAll = new StringResource
        {
            Id = "ChechedCombobox_SelectAll",
            Description = "Выпадающий список. Выбрать все"
        };

        public static StringResource FixedCategoryLengthPassedHeader = new StringResource
        {
            Id = "FixedCategoryLengthPassedHeader",
            Description = "Не заданы результаты измерений"
        };

        public static StringResource WrongDate = new StringResource
        {
            Id = "WrongDate",
            Description = "Дата задана не верно"
        };

        public static StringResource FixedCategoryLengthPassed = new StringResource
        {
            Id = "FixedCategoryLengthPassed",
            Description = "Результаты измерения длины должны быть введены."
        };

        public static StringResource SelectInspectorsForTestResult = new StringResource
        {
            Id = "SelectInspectorsForTestResult",
            Description = "Сообщение - Укажите инспектора"
        };
        public static StringResource SelectInspectorsForTestResultHeader = new StringResource
        {
            Id = "SelectInspectorsForTestResultHeader",
            Description = "Заголовок сообщения - Укажите инспектора"
        };

        public static StringResource SelectWeldersForOperation = new StringResource
        {
            Id = "SelectWeldersForOperation",
            Description = "Сообщение - Укажите сварщика"
        };
        public static StringResource SelectWeldersForOperationHeader = new StringResource
        {
            Id = "SelectWeldersForOperationHeader",
            Description = "Заголовок сообщения - Укажите сварщика"
        };

        public static StringResource FirstEnterDate = new StringResource
        {
            Id = "FirstEnterDate",
            Description = "Вначале необходимо ввести дату"
        };
        
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

        public static StringResource JointNewEdit_JointStatus_Undefined = new StringResource
        {
            Id = "JointNewEdit_JointStatus_Undefined",
            Description = "Неопределен"
        };        

        public static StringResource AppSplashScreen_VersionLabel = new StringResource
        {
            Id = "AppSplashScreen_VersionLabel",
            Description = "Текст перед версией программы на всплывающем окне при загрузке программы"
        };

        //--- InspectionAddEditXtraForm ---
        public static StringResource InspectionAddEditXtraForm_SameCodeTestResultPlanned = new StringResource
        {
            Id = "InspectionAddEditXtraForm_SameCodeTestResultPlanned",
            Description = "Данная контрольная операция уже запланирована и содержится в списке инспекций"
        };
        public static StringResource InspectionAddEditXtraForm_SameCodeTestResultPlannedHeader = new StringResource
        {
            Id = "InspectionAddEditXtraForm_SameCodeTestResultPlannedHeader",
            Description = "Дублирование контрольной операции"
        };

        public static StringResource InspectionAddEditXtraForm_InspectionTestCompleted = new StringResource
        {
            Id = "InspectionAddEditXtraForm_InspectionTestCompleted",
            Description = "Данная контрольная операция уже выполнена, создайте новую или выберите запланированную"
        };
        public static StringResource InspectionAddEditXtraForm_InspectionTestCompletedHeader = new StringResource
        {
            Id = "InspectionAddEditXtraForm_InspectionTestCompletedHeader",
            Description = "Контрольная операция выполнена"
        };


        #region --- PartType ---
        public static StringResource PartTypePipe = new StringResource { 
            Id = "PartTypePipe", 
            Description = "Надпись типа элемента Труба"};

        public static StringResource PartTypeSpool = new StringResource { 
            Id = "PartTypeSpool", 
            Description = "Надпись типа элемента Катушка"};

        public static StringResource PartTypeComponent = new StringResource { 
            Id = "PartTypeComponent", 
            Description = "Надпись типа элемента Компонент"};

        public static StringResource PartTypeUndefined = new StringResource
        {
            Id = "PartTypeUndefined",
            Description = "Надпись типа элемента Неопределен"
        };

        #endregion

        #region --- Activity ---
        public static StringResource StatusActive = new StringResource { 
            Id = "StatusActive", 
            Description = "Надпись статуса активности элемента Активен"};

        public static StringResource StatusUnactive = new StringResource
        {
            Id = "StatusUnactive", 
            Description = "Надпись статуса активности элемента Неактивен"};

        public static StringResource StatusAll = new StringResource { 
            Id = "StatusAll", 
            Description = "Надпись статуса активности элемента Все"};
        #endregion

        public static StringResource Value_Required = new StringResource
        {
            Id = "Value_Required",
            Description = "Значение обязательно"
        };

        #region --- Test result types ---
        public static StringResource TestResultTypeBoolean = new StringResource { 
            Id = "TestResultTypeBoolean", 
            Description = "Тип результата контрольной операции. Логический"};

        public static StringResource TestResultTypeRange = new StringResource { 
            Id = "TestResultTypeRange", 
            Description = "Тип результата контрольной операции. Диапазон"};

        public static StringResource TestResultTypeString = new StringResource { 
            Id = "TestResultTypeString", 
            Description = "Тип результата контрольной операции. Строка"};
        #endregion


        #region --- Test control type ---
        public static StringResource ControlTypeWitness = new StringResource { 
            Id = "ControlTypeWitness",
            Description = "Вид контроля. Освидетельствование"};

        public static StringResource ControlTypeReview = new StringResource { 
            Id = "ControlTypeReview",
            Description = "Вид контроля. Проверка документов"};

        public static StringResource ControlTypeMonitor = new StringResource { 
            Id = "ControlTypeMonitor", 
            Description = "Вид контроля. Мониторинг"};

        public static StringResource ControlTypeHold = new StringResource { 
            Id = "ControlTypeHold", 
            Description = "Вид контроля. Обязательная проверка"};
        #endregion

        #region --- PartInspectionStatus ---
        public static StringResource PartInspectionStatus_Undefined = new StringResource
        {
            Id = "PartInspectionStatus_Undefined",
            Description = "Статус на входном контроле. Неопределен"
        };

        public static StringResource PartInspectionStatus_Pending = new StringResource
        {
            Id = "PartInspectionStatus_Pending",
            Description = "Статус на входном контроле. Ожидается"
        };

        public static StringResource PartInspectionStatus_Hold = new StringResource
        {
            Id = "PartInspectionStatus_Hold",
            Description = "Статус на входном контроле. Задержано"
        };

        public static StringResource PartInspectionStatus_Rejected = new StringResource
        {
            Id = "PartInspectionStatus_Rejected",
            Description = "Статус на входном контроле. Брак"
        };

        public static StringResource PartInspectionStatus_Accepted = new StringResource
        {
            Id = "PartInspectionStatus_Accepted",
            Description = "Статус на входном контроле. Принято"
        };
        #endregion

        #region --- Workstation types ---
        public static StringResource WorkstationType_Undefined = new StringResource
        {
            Id = "WorkstationType_Undefined",
            Description = "Тип рабочей станции. Неопределен"
        };

        public static StringResource WorkstationType_Master = new StringResource
        {
            Id = "WorkstationType_Master",
            Description = "Тип рабочей станции. Главный"
        };

        public static StringResource WorkstationType_Mill= new StringResource
        {
            Id = "WorkstationType_Mill",
            Description = "Тип рабочей станции. Завод"
        };
        
        public static StringResource WorkstationType_Construction = new StringResource
        {
            Id = "WorkstationType_Construction",
            Description = "Тип рабочей станции. Строительство"
        };
        #endregion

        #region --- Pipe test result statuses ---
        public static StringResource PipeTestResultStatus_Scheduled = new StringResource
        {
            Id = "PipeTestResultStatus_Scheduled",
            Description = "Результат контрольной операции. Ожидается"
        };

        public static StringResource PipeTestResultStatus_Accepted = new StringResource
        {
            Id = "PipeTestResultStatus_Accepted",
            Description = "Результат контрольной операции. Принят"
        };

        public static StringResource PipeTestResultStatus_Rejected = new StringResource
        {
            Id = "PipeTestResultStatus_Rejected",
            Description = "Результат контрольной операции. Брак"
        };

        public static StringResource PipeTestResultStatus_Repair = new StringResource
        {
            Id = "PipeTestResultStatus_Repair",
            Description = "Результат контрольной операции. Ремонт"
        };


        #endregion

        //messages 
        public static StringResource Message_ErrorHeader = new StringResource
        {
            Id = "Message_ErrorHeader",
            Description = "Универсальный заголовок сообщения об ошибке: Ошибка"
        };

        public static StringResource Message_AuthentificationFailed = new StringResource
        {
            Id = "Message_AuthentificationFailed",
            Description = "Сообщение при логине: Неверное имя пользователя или пароль."
        };

        public static StringResource Message_AuthentificationFailedUserInactive = new StringResource
        {
            Id = "Message_AuthentificationFailedUserInactive",
            Description = "Сообщение при логине: Вход для пользователя {0} заблокирован"
        };

        public static StringResource Message_ComponentDeactivationQuestionHeader = new StringResource
        {
            Id = "Message_ComponentDeactivationQuestionHeader",
            Description = "Заголовок вопроса о подтверждении деактивации компонента"
        };

        public static StringResource Message_ComponentDeactivationQuestion = new StringResource
        {
            Id = "Message_ComponentDeactivationQuestion",
            Description = "Вопрос о подтверждении деактивации компонента: Данное действие приведет к деактивации комплектующего элемента.  Параметры комплектующего элемента станут невозможны для редактирования. Деактивировать комплектующий элемент?"
        };

        public static StringResource PartInspection_InspectionsSaved = new StringResource
        {
            Id = "PartInspection_InspectionsSaved",
            Description = "Результаты контрольных операций успешно сохранены. Номер элемента: "
        };

        public static StringResource PartInspection_InspectionsSavedHeader = new StringResource
        {
            Id = "PartInspection_InspectionsSavedHeader",
            Description = "Сохранение контрольных операций"
        };

        public static StringResource ExternalFiles_FileAttachSuccess = new StringResource
        {
            Id = "ExternalFiles_FileAttachSuccess",
            Description = "Вложения успешно добавлены"
        };

        public static StringResource ExternalFiles_FileAttachSuccessHeader = new StringResource
        {
            Id = "ExternalFiles_FileAttachSuccessHeader",
            Description = "Добавление вложений"
        };

        public static StringResource ExternalFiles_FileDownloadHeader = new StringResource
        {
            Id = "ExternalFiles_FileDownloadHeader",
            Description = "Загрузка файла"
        };

        public static StringResource ExternalFiles_NotCopied = new StringResource
        {
            Id = "ExternalFiles_NotCopied",
            Description = "Прикрепленные файлы не сохранены"
        };

        public static StringResource ExternalFiles_NotCopied_Header = new StringResource
        {
            Id = "ExternalFiles_NotCopied_Header",
            Description = "Ошибка сохранения прикрепленных файлов"
        };

        public static StringResource ExternalFiles_FileDownloadSuccess = new StringResource
        {
            Id = "ExternalFiles_FileDownloadSuccess",
            Description = "Файл успешно загружен"
        };

        public static StringResource ExternalFiles_FileViewDownloadFail = new StringResource
        {
            Id = "ExternalFiles_FileViewDownloadFail",
            Description = "Для просмотра и скачивания вложений необходимо их предварительное сохранение"
        };

        public static StringResource ExternalFiles_FileViewDownloadFailHeader = new StringResource
        {
            Id = "ExternalFiles_FileViewDownloadFailHeader",
            Description = "Просмотр и загрузка несохрaненных файлов"
        };

        public static StringResource ExternalFiles_FileSizeIsTooBig= new StringResource
        {
            Id = "ExternalFiles_FileSizeIsTooBig",
            Description = "Сообщение: Размер вложения больше разрешенного"
        };


        public static StringResource Yes = new StringResource
        {
            Id = "Yes",
            Description = "Да"
        };

        public static StringResource No = new StringResource
        {
            Id = "No",
            Description = "Нет"
        };

         public static StringResource DateFirst = new StringResource
        {
            Id = "DateFirst",
            Description = "Сообщение об ошибке: Выберите дату"
        };

         public static StringResource Validation_ValueRequired = new StringResource
         {
             Id = "Validation_ValueRequired",
             Description = "Сообщение об ошибке: Значение обязательно"
         };

         public static StringResource Validation_UniqueValueRequired = new StringResource
         {
             Id = "Validation_UniqueValueRequired",
             Description = "Сообщение об ошибке: Введите уникальное значение"
         };

         public static StringResource Message_DeleteRecord = new StringResource
         {
             Id = "Message_DeleteRecord",
             Description = "Вопрос об удалении записи: Удалить запись?"
         };

         public static StringResource Message_NoMoreDocumentsCanOpen = new StringResource
         {
             Id = "Message_NoMoreDocumentsCanOpen",
             Description = "Сообщение: Нельзя одновременно открыть больше документов."
         };

         public static StringResource Alert_InfoHeader = new StringResource
         {
             Id = "Alert_InfoHeader",
             Description = "Заголовок для информационного сообщения: Внимание"
         };

         public static StringResource Message_FailureReportDate = new StringResource
         {
             Id = "Message_FailureReportDate",
             Description = "Сообщение об ошибке запуска отчёта: Начальная дата позже конечной"
         };

         public static StringResource Message_FailureReportDateHeader = new StringResource
         {
             Id = "Message_FailureReportDateHeader",
             Description = "Заголовок для ошибки запуска отчёта: Неверный диапазон дат"
         };

         public static StringResource Message_OpenSettingsForViewing = new StringResource
         {
             Id = "Message_OpenSettingsForViewing",
             Description = "Сообщение об открытии настроек в режиме просмотра (да/нет): Невозможно открыть настройки в режиме редактирования, когда открыты другие формы. Хотите открыть настройки в режиме просмотра?"
         };

         public static StringResource Message_OpenSettingsForViewingHeader = new StringResource
         {
             Id = "Message_OpenSettingsForViewingHeader",
             Description = "Заголовок для сообщения об открытии настроек: Открыть настройки в режиме просмотра?"
         };

         public static StringResource Message_OpenFormForViewing = new StringResource
         {
             Id = "Message_OpenFormForViewing",
             Description = "Сообщение об открытии настроек в режиме просмотра (да/нет): Невозможно открыть форму в режиме редактирования, когда открыты настройки. Хотите открыть форму в режиме просмотра?"
         };

         public static StringResource Message_OpenFormForViewingHeader = new StringResource
         {
             Id = "Message_OpenFormForViewingHeader",
             Description = "Заголовок для сообщения об открытии формы: Открыть форму в режиме просмотра?"
         };

         public static StringResource Message_CannotOpenForViewing = new StringResource
         {
             Id = "Message_CannotOpenForViewing",
             Description = "Сообщение о невозможности открыть форму: Невозможно открыть форму для просмотра. Для продолжения закройте настройки"
         };

         public static StringResource Message_CannotOpenForViewingHeader = new StringResource
         {
             Id = "Message_CannotOpenForViewingHeader",
             Description = "Заголок для сообщения о невозмости открытия формы в режиме просмотра: Невозможно открыть форму для просмотра"
         };

        #endregion // --- Common

         #region --- Main Window ---

         public static StringResource MainWindowHeader_Title = new StringResource
         {
             Id = "MainWindowHeader_Title",
             Description = "Сокращённое название программы: PRISM v.2"
         };

         public static StringResource MainWindowHeader_Construction = new StringResource
         {
             Id = "MainWindowHeader_Construction",
             Description = "Название рабочей станции: Строительство"
         };

         public static StringResource MainWindowHeader_Master = new StringResource
         {
             Id = "MainWindowHeader_Master",
             Description = "Название рабочей станции: Главный"
         };

         public static StringResource MainWindowHeader_Mill = new StringResource
         {
             Id = "MainWindowHeader_Mill",
             Description = "Название рабочей станции: Завод"
         };

         public static StringResource MainWindow_CloseEditingReleaseNote = new StringResource
         {
             Id = "MainWindow_CloseEditingReleaseNote",
             Description = "Сообщение: Пожалуйста сначала закройте редактируемое разрешение на отгрузку"
         };

         public static StringResource MainWindow_OpenReleaseNoteReadOnly = new StringResource
         {
             Id = "MainWindow_OpenReleaseNoteReadOnly",
             Description = "Сообщение: Форма Разрешение на отгрузку уже открыта, хотите открыть разрешение в режиме просмотра?"
         };
        
         public static StringResource MainWindow_ConstructionJoint = new StringResource
         {
             Id = "MainWindow_ConstructionJoint",
             Description = "Сообщение: Пожалуйста сначала закройте редактируемый стык"
         };

         public static StringResource MainWindow_OpenConstructionJointReadOnly = new StringResource
         {
             Id = "MainWindow_OpenConstructionJointReadOnly",
             Description = "Сообщение: Форма Создание стыка уже открыта, хотите открыть стык в режиме просмотра?"
         };
        
         public static StringResource Menu_File = new StringResource
         {
             Id = "Menu_File",
             Description = "Главное меню, пункт Файл"
         };

         public static StringResource Menu_File_Export = new StringResource
         {
             Id = "Menu_File_Export",
             Description = "Главное меню, пункт Экспорт"
         };
         public static StringResource Menu_File_Import = new StringResource
         {
             Id = "Menu_File_Import",
             Description = "Главное меню, пункт Импорт"
         };
         public static StringResource Menu_File_HistoryExportImport = new StringResource
         {
             Id = "Menu_File_HistoryExportImport",
             Description = "Главное меню, пункт История экспорта/импорта"
         };
         public static StringResource Menu_File_Exit = new StringResource
         {
             Id = "Menu_File_Exit",
             Description = "Главное меню, пункт Выход"
         };
         public static StringResource Menu_Mill = new StringResource
         {
             Id = "Menu_Mill",
             Description = "Главное меню, пункт Завод"
         };
         public static StringResource Menu_Mill_NewPipe = new StringResource
         {
             Id = "Menu_Mill_NewPipe",
             Description = "Главное меню, пункт Новая труба"
         };
         public static StringResource Menu_Mill_SearchPipes = new StringResource
         {
             Id = "Menu_Mill_SearchPipes",
             Description = "Главное меню, пункт Поиск труб"
         };
         public static StringResource Menu_Mill_NewReleaseNote = new StringResource
         {
             Id = "Menu_Mill_NewReleaseNote",
             Description = "Главное меню, пункт Разрешение на отгрузку"
         };
         public static StringResource Menu_Mill_SearchReleaseNotes = new StringResource
         {
             Id = "Menu_Mill_SearchReleaseNotes",
             Description = "Главное меню, пункт Поиск разрешений на отгрузку"
         };
         public static StringResource Menu_Mill_Reports = new StringResource
         {
             Id = "Menu_Mill_Reports",
             Description = "Главное меню, пункт Отчёты на заводе"
         };
         public static StringResource Menu_Construction = new StringResource
         {
             Id = "Menu_Construction",
             Description = "Главное меню, пункт Строительство и входной контроль"
         };
         public static StringResource Menu_Construction_NewComponent = new StringResource
         {
             Id = "Menu_Construction_NewComponent",
             Description = "Главное меню, пункт Создать комплектующее"
         };
         public static StringResource Menu_Construction_NewJoint = new StringResource
         {
             Id = "Menu_Construction_NewJoint",
             Description = "Главное меню, пункт Создать стык"
         };
         public static StringResource Menu_Construction_PartIncomingInspection = new StringResource
         {
             Id = "Menu_Construction_PartIncomingInspection",
             Description = "Главное меню, пункт Входной контроль элементов трубопровода"
         };
         public static StringResource Menu_Construction_FindParts = new StringResource
         {
             Id = "Menu_Construction_FindParts",
             Description = "Главное меню, пункт Поиск элементов трубопровода"
         };
         public static StringResource Menu_Construction_FindJoints = new StringResource
         {
             Id = "Menu_Construction_FindJoints",
             Description = "Главное меню, пункт Поиск стыков"
         };
         public static StringResource Menu_Construction_Spool = new StringResource
         {
             Id = "Menu_Construction_Spool",
             Description = "Главное меню, пункт Катушки"
         };
         public static StringResource Menu_Construction_InspectionReports = new StringResource
         {
             Id = "Menu_Construction_InspectionReports",
             Description = "Главное меню, пункт Отчёты на входном контроле"
         };
         public static StringResource Menu_Construction_PipeReports = new StringResource
         {
             Id = "Menu_Construction_PipeReports",
             Description = "Главное меню, пункт Отчёты по трубам на стройке"
         };
         public static StringResource Menu_Construction_WeldReports = new StringResource
         {
             Id = "Menu_Construction_WeldReports",
             Description = "Главное меню, пункт Отчёты по сварке (по дате)"
         };
         public static StringResource Menu_Construction_JointPKReports = new StringResource
         {
             Id = "Menu_Construction_JointPKReports",
             Description = "Главное меню, пункт Отчёты по сварке участка между пикетами"
         };
         public static StringResource Menu_Settings = new StringResource
         {
             Id = "Menu_Settings",
             Description = "Главное меню, пункт Настройки"
         };
         public static StringResource Menu_Settings_Project = new StringResource
         {
             Id = "Menu_Settings_Project",
             Description = "Главное меню, настройки, пункт Проект"
         };
         public static StringResource Menu_Settings_Pipe = new StringResource
         {
             Id = "Menu_Settings_Pipe",
             Description = "Главное меню, настройки, пункт Труба"
         };
         public static StringResource Menu_Settings_Pipeline = new StringResource
         {
             Id = "Menu_Settings_Pipeline",
             Description = "Главное меню, настройки, пункт Трубопровод"
         };
         public static StringResource Menu_Settings_Componentry = new StringResource
         {
             Id = "Menu_Settings_Componentry",
             Description = "Главное меню, настройки, пункт Комплектующие"
         };
         public static StringResource Menu_Settings_Welders = new StringResource
         {
             Id = "Menu_Settings_Welders",
             Description = "Главное меню, настройки, пункт Сварщики"
         };
         public static StringResource Menu_Settings_Inspectors = new StringResource
         {
             Id = "Menu_Settings_Inspectors",
             Description = "Главное меню, настройки, пункт Инспекторы"
         };
         public static StringResource Menu_Settings_Users = new StringResource
         {
             Id = "Menu_Settings_Users",
             Description = "Главное меню, настройки, пункт Пользователи"
         };
         public static StringResource Menu_Settings_Roles = new StringResource
         {
             Id = "Menu_Settings_Roles",
             Description = "Главное меню, настройки, пункт Роли"
         };
         public static StringResource Menu_Settings_Language = new StringResource
         {
             Id = "Menu_Settings_Language",
             Description = "Главное меню, настройки, пункт Язык"
         };
         public static StringResource Menu_Misc = new StringResource
         {
             Id = "Menu_Misc",
             Description = "Главное меню, настройки, пункт Разное"
         };
         public static StringResource Menu_Misc_Audit = new StringResource
         {
             Id = "Menu_Misc_Audit",
             Description = "Главное меню, настройки, пункт Аудит"
         };
         public static StringResource Menu_Misc_ImportantMessages = new StringResource
         {
             Id = "Menu_Misc_ImportantMessages",
             Description = "Главное меню, настройки, пункт Важные сообщения"
         };
         public static StringResource Menu_Help = new StringResource
         {
             Id = "Menu_Help",
             Description = "Главное меню, настройки, пункт Помощь"
         };
         public static StringResource Menu_Help_About = new StringResource
         {
             Id = "Menu_Help_About",
             Description = "Главное меню, настройки, пункт О программе"
         };

         public static StringResource MainWindow_StatusNotificationsHeader = new StringResource
         {
             Id = "MainWindow_StatusNotificationsHeader",
             Description = "Текст на панели статуса: Важные сообщения "
         };

         public static StringResource MainWindow_SecondCopyNotification = new StringResource
         {
             Id = "MainWindow_SecondCopyNotification",
             Description = "Уведомление о запуске второго клиента"
         };

         public static StringResource MainWindow_SecondCopyNotificationHeader = new StringResource
         {
             Id = "MainWindow_SecondCopyNotificationHeader",
             Description = "Уведомление о запуске второго клиента, заголовок "
         };

         #endregion //--- Main Window ---

         #region --- Form Manager ---

         public static StringResource FormManager_AccessForbidden = new StringResource
         {
             Id = "FormManager_AccessForbidden",
             Description = "Сообщение о невозможности доступа"
         };

         public static StringResource FormManager_AccessHeader = new StringResource
         {
             Id = "FormManager_AccessHeader",
             Description = "Заголовок сообщения о правах доступа"
         };

         #endregion // --- Form Manager ---

         #region PurchaseOrderForm
         //message
         public static StringResource PurchaseOrder_ValueRequired = new StringResource
        {
            Id = "PurchaseOrder_ValueRequired",
            Description = "Обязательное значение"
        };
        public static StringResource PurchaseOrder_ErrorHeader = new StringResource
        {
            Id = "PurchaseOrder_ErrorHeader",
            Description = "Ошибка создания наряд-заказа"
        };

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

        public static StringResource PassChange_Title = new StringResource
        {
            Id = "PassChange_Title",
            Description = "Смена пароля"
        };
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

        public static StringResource PassChange_InvalidOldPassword = new StringResource
        {
            Id = "PassChange_InvalidOldPassword",
            Description = "Сообщение об ошибке: Текущий пароль введен неверно."
        };

        public static StringResource PassChange_PasswordsNotMatch = new StringResource
        {
            Id = "PassChange_PasswordsNotMatch",
            Description = "Сообщение об ошибке: Пароли не совпадают."
        };

        #endregion PasswordChange

        #region MillReport

        public static StringResource MillReport_Title = new StringResource
        {
            Id = "MillReport_Title",
            Description = "Отчет"
        };

        public static StringResource MillReport_FootersCheck = new StringResource
        {
            Id = "MillReport_FootersCheck",
            Description = "Добавить колонтитулы"
        };

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

        //--- PipeConstructionXtraReport ---
        
        public static StringResource PipeConstructionXtraReport_PipeConstructionReportHeader = new StringResource
        {
            Id = "PipeConstructionXtraReport_PipeConstructionReportHeader",
            Description = "Отчет по трубам на строительстве"
        };
        public static StringResource PipeConstructionXtraReport_PipeNumberHeader = new StringResource
        {
            Id = "PipeConstructionXtraReport_PipeNumberHeader",
            Description = "Номер трубы"
        };
        public static StringResource PipeConstructionXtraReport_DiameterHeader = new StringResource
        {
            Id = "PipeConstructionXtraReport_DiameterHeader",
            Description = "Диаметр, мм"
        };
        public static StringResource PipeConstructionXtraReport_LengthHeader = new StringResource
        {
            Id = "PipeConstructionXtraReport_LengthHeader",
            Description = "Длина, мм"
        };
        public static StringResource PipeConstructionXtraReport_ThicknessHeader = new StringResource
        {
            Id = "PipeConstructionXtraReport_ThicknessHeader",
            Description = "Толщина, мм"
        };
        public static StringResource PipeConstructionXtraReport_SeamTypeHeader = new StringResource
        {
            Id = "PipeConstructionXtraReport_SeamTypeHeader",
            Description = "Тип шва"
        };
        public static StringResource PipeConstructionXtraReport_GradeHeader = new StringResource
        {
            Id = "PipeConstructionXtraReport_GradeHeader",
            Description = "Марка стали"
        };
        public static StringResource PipeConstructionXtraReport_FirstJointHeader = new StringResource
        {
            Id = "PipeConstructionXtraReport_FirstJointHeader",
            Description = "Первый стык"
        };
        public static StringResource PipeConstructionXtraReport_SecondJointHeader = new StringResource
        {
            Id = "PipeConstructionXtraReport_SecondJointHeader",
            Description = "Второй стык"
        };

        //--- LoadingXtraReport ---
        public static StringResource LoadingXtraReport_LoadingReportLabel = new StringResource
        {
            Id = "LoadingXtraReport_LoadingReportLabel",
            Description = "Рапорт по отгрузке"
        };
        public static StringResource LoadingXtraReport_ReleaseNoteNumberLabel = new StringResource
        {
            Id = "LoadingXtraReport_ReleaseNoteNumberLabel",
            Description = "Номер разрешения на отгрузку"
        };
        public static StringResource LoadingXtraReport_RailcarNumberLabel = new StringResource
        {
            Id = "LoadingXtraReport_RailcarNumberLabel",
            Description = "Номер вагона"
        };
        public static StringResource LoadingXtraReport_DestinationLabel = new StringResource
        {
            Id = "LoadingXtraReport_DestinationLabel",
            Description = "Станция назначения"
        };
        public static StringResource LoadingXtraReport_CertificateLabel = new StringResource
        {
            Id = "LoadingXtraReport_CertificateLabel",
            Description = "Сертификат"
        };
        public static StringResource LoadingXtraReport_MetersCountLabel = new StringResource
        {
            Id = "LoadingXtraReport_MetersCountLabel",
            Description = "Кол-во метров"
        };
        public static StringResource LoadingXtraReport_WeightCountLabel = new StringResource
        {
            Id = "LoadingXtraReport_WeightCountLabel",
            Description = "Вес"
        };
        public static StringResource LoadingXtraReport_PipesCountLabel = new StringResource
        {
            Id = "LoadingXtraReport_PipesCountLabel",
            Description = "Кол-во труб"
        };

        // ---- GeneralInformationXtraReport ----
        public static StringResource GeneralInformationXtraReport_GeneralReportHeaderLabel = new StringResource
        {
            Id = "GeneralInformationXtraReport_GeneralReportHeaderLabel",
            Description = "Отчет по заводу"
        };
        public static StringResource GeneralInformationXtraReport_BARLabel = new StringResource
        {
            Id = "GeneralInformationXtraReport_BARLabel",
            Description = "BAR (Производство готовой трубы)"
        };
        public static StringResource GeneralInformationXtraReport_EXCLabel = new StringResource
        {
            Id = "GeneralInformationXtraReport_EXCLabel",
            Description = "EXC (Наружнее покрытие)"
        };
        public static StringResource GeneralInformationXtraReport_COALabel = new StringResource
        {
            Id = "GeneralInformationXtraReport_COALabel",
            Description = "COA (Внутреннее покрытие)"
        };
        public static StringResource GeneralInformationXtraReport_ProductionDateLabel = new StringResource
        {
            Id = "GeneralInformationXtraReport_ProductionDateLabel",
            Description = "Дата производства"
        };
        public static StringResource GeneralInformationXtraReport_BARAcceptedLabel = new StringResource
        {
            Id = "GeneralInformationXtraReport_BARAcceptedLabel",
            Description = "Принято"
        };
        public static StringResource GeneralInformationXtraReport_BARRepairLabel = new StringResource
        {
            Id = "GeneralInformationXtraReport_BARRepairLabel",
            Description = "Временный брак"
        };
        public static StringResource GeneralInformationXtraReport_BARAfterRepairLabel = new StringResource
        {
            Id = "GeneralInformationXtraReport_BARAfterRepairLabel",
            Description = "Принято после ремонта"
        };
        public static StringResource GeneralInformationXtraReport_BARRejectedLabel = new StringResource
        {
            Id = "GeneralInformationXtraReport_BARRejectedLabel",
            Description = "Брак"
        };
        public static StringResource GeneralInformationXtraReport_EXCAcceptedLabel = new StringResource
        {
            Id = "GeneralInformationXtraReport_EXCAcceptedLabel",
            Description = "Принято"
        };
        public static StringResource GeneralInformationXtraReport_EXCRepairLabel = new StringResource
        {
            Id = "GeneralInformationXtraReport_EXCRepairLabel",
            Description = "Временный брак"
        };
        public static StringResource GeneralInformationXtraReport_EXCAfterRepairLabel = new StringResource
        {
            Id = "GeneralInformationXtraReport_EXCAfterRepairLabel",
            Description = "Принято после ремонта"
        };
        public static StringResource GeneralInformationXtraReport_EXCRejectedLabel = new StringResource
        {
            Id = "GeneralInformationXtraReport_EXCRejectedLabel",
            Description = "Брак"
        };
        public static StringResource GeneralInformationXtraReport_COAAcceptedLabel = new StringResource
        {
            Id = "GeneralInformationXtraReport_COAAcceptedLabel",
            Description = "Принято"
        };
        public static StringResource GeneralInformationXtraReport_COARepairLabel = new StringResource
        {
            Id = "GeneralInformationXtraReport_COARepairLabel",
            Description = "Временный брак"
        };
        public static StringResource GeneralInformationXtraReport_COAAfterRepairLabel = new StringResource
        {
            Id = "GeneralInformationXtraReport_COAAfterRepairLabel",
            Description = "Принято после ремонта"
        };
        public static StringResource GeneralInformationXtraReport_COARejectedLabel = new StringResource
        {
            Id = "GeneralInformationXtraReport_COARejectedLabel",
            Description = "Брак"
        };

        //--- AdditionToTheReport ---
        public static StringResource AdditionToTheReport_AdditionToTheReportHeaderLabel = new StringResource
        {
            Id = "AdditionToTheReport_AdditionToTheReportHeaderLabel",
            Description = "Приложение к отчету"
        };
        public static StringResource AdditionToTheReport_NumberLabel = new StringResource
        {
            Id = "AdditionToTheReport_NumberLabel",
            Description = "Номер"
        };
        public static StringResource AdditionToTheReport_HeatNumberLabel = new StringResource
        {
            Id = "AdditionToTheReport_HeatNumberLabel",
            Description = "Номер плавки"
        };
        public static StringResource AdditionToTheReport_WeightLabel = new StringResource
        {
            Id = "AdditionToTheReport_WeightLabel",
            Description = "Вес"
        };
        public static StringResource AdditionToTheReport_LengthLabel = new StringResource
        {
            Id = "AdditionToTheReport_LengthLabel",
            Description = "Длина"
        };
        public static StringResource AdditionToTheReport_ProductionDateLabel = new StringResource
        {
            Id = "AdditionToTheReport_ProductionDateLabel",
            Description = "Дата производства"
        };
        public static StringResource AdditionToTheReport_TotalCountLabel = new StringResource
        {
            Id = "AdditionToTheReport_TotalCountLabel",
            Description = "Количество:"
        };
        public static StringResource AdditionToTheReport_PipesLengthLabel = new StringResource
        {
            Id = "AdditionToTheReport_PipesLengthLabel",
            Description = "Общая длина:"
        };
        public static StringResource AdditionToTheReport_PipesWeightLabel = new StringResource
        {
            Id = "AdditionToTheReport_PipesWeightLabel",
            Description = "Общий вес:"
        };


        //--- TracingReport ---
        public static StringResource TracingReport_TracingPageHeaderXrLabel = new StringResource
        {
            Id = "TracingReport_TracingPageHeaderXrLabel",
            Description = "Трассировка трубопровода"
        };
        public static StringResource TracingReport_JointNumberHeder = new StringResource
        {
            Id = "TracingReport_JointNumberHeder",
            Description = "Номер стыка"
        };
        public static StringResource TracingReport_WeldingDate = new StringResource
        {
            Id = "TracingReport_WeldingDate",
            Description = "Дата сварки"
        };
        public static StringResource TracingReport_FirstPartNumberHeader = new StringResource
        {
            Id = "TracingReport_FirstPartNumberHeader",
            Description = "Номер элемента 1"
        };
        public static StringResource TracingReport_FirstPartTypeHeder = new StringResource
        {
            Id = "TracingReport_FirstPartTypeHeder",
            Description = "Тип элемента 1"
        };
        public static StringResource TracingReport_FirstPartLengthHeder = new StringResource
        {
            Id = "TracingReport_FirstPartLengthHeder",
            Description = "Длина, мм"
        };
        public static StringResource TracingReport_SecondPartNumberHeader = new StringResource
        {
            Id = "TracingReport_SecondPartNumberHeader",
            Description = "Номер элемента 2"
        };
        public static StringResource TracingReport_SecondPartTypeHeder = new StringResource
        {
            Id = "TracingReport_SecondPartTypeHeder",
            Description = "Тип элемента 2"
        };
        public static StringResource TracingReport_SecondPartLengthHeder = new StringResource
        {
            Id = "TracingReport_SecondPartLengthHeder",
            Description = "Длина, мм"
        };
        public static StringResource TracingReport_PipelineJointCountHeader = new StringResource
        {
            Id = "TracingReport_PipelineJointCountHeader",
            Description = "Количество стыков"
        };
        public static StringResource TracingReport_PipelinePipeCountHeader = new StringResource
        {
            Id = "TracingReport_PipelinePipeCountHeader",
            Description = "Количество труб"
        };
        public static StringResource TracingReport_PipelineSpoolCountHeader = new StringResource
        {
            Id = "TracingReport_PipelineSpoolCountHeader",
            Description = "Количество катушек"
        };
        public static StringResource TracingReport_PipelineComponentHeader = new StringResource
        {
            Id = "TracingReport_PipelineComponentHeader",
            Description = "Количество компонентов"
        };
        public static StringResource TracingReport_PipelineLengthHeader = new StringResource
        {
            Id = "TracingReport_PipelineLengthHeader",
            Description = "Общая длина, мм"
        };

        public static StringResource TracingReport_KPSwappedMessage = new StringResource
        {
            Id = "TracingReport_KPSwappedMessage",
            Description = "Сообщение: Начальный пикет больше конечного"
        };

        public static StringResource TracingReport_KPSwappedHeader = new StringResource
        {
            Id = "TracingReport_KPSwappedHeader",
            Description = "Заголовок сообщения: Начальный пикет больше конечного"
        };

        public static StringResource TracingReport_DiapasonIsEmptyMessage = new StringResource
        {
            Id = "TracingReport_DiapasonIsEmptyMessage",
            Description = "Сообщение: Неверный диапазон для формирования отчета"
        };

        public static StringResource TracingReport_DiapasonIsEmptyHeader = new StringResource
        {
            Id = "TracingReport_DiapasonIsEmptyHeader",
            Description = "Заголовок сообщения: Неверный диапазон"
        };

        public static StringResource TracingReport_PointNotConnectedMessage = new StringResource
        {
            Id = "TracingReport_PointNotConnectedMessage",
            Description = "Сообщение: Начальная и конечная точка пути не соедененны"
        };

        public static StringResource TracingReport_PointNotConnectedHeader = new StringResource
        {
            Id = "TracingReport_PointNotConnectedHeader",
            Description = "Заголовок сообщения: Начальная и конечная точка пути не соедененны"
        };

        #endregion MillReport

        #region IncomingInspectionReport

        public static StringResource InspectionReport_Title = new StringResource
        {
            Id = "InspectionReport_Title",
            Description = "Отчет по входному контролю"
        };

        public static StringResource InspectionReport_FootersCheck = new StringResource
        {
            Id = "InspectionReport_FootersCheck",
            Description = "Добавить колонтитулы"
        };

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



        public static StringResource IncomingReportsXtraReport_PipeNumberLabel = new StringResource
        {
            Id = "IncomingReportsXtraReport_PipeNumberLabel",
            Description = "Заводской номер трубы"
        };
        public static StringResource IncomingReportsXtraReport_ReportHeaderLabel = new StringResource
        {
            Id = "IncomingReportsXtraReport_ReportHeaderLabel",
            Description = "Отчет по входному контролю"
        };

        public static StringResource IncomingReportsXtraReport_PipeTypeLabel = new StringResource
        {
            Id = "IncomingReportsXtraReport_PipeTypeLabel",
            Description = "Тип трубы"
        };
        public static StringResource IncomingReportsXtraReport_PipeLengthLabel = new StringResource
        {
            Id = "IncomingReportsXtraReport_PipeLengthLabel",
            Description = "Длина"
        };
        public static StringResource IncomingReportsXtraReport_PipeWallThicknessLabel = new StringResource
        {
            Id = "IncomingReportsXtraReport_PipeWallThicknessLabel",
            Description = "Толщина"
        };
        public static StringResource IncomingReportsXtraReport_HeatNumberLabel = new StringResource
        {
            Id = "IncomingReportsXtraReport_HeatNumberLabel",
            Description = "Номер плавки"
        };
        public static StringResource IncomingReportsXtraReport_InspectionStatusLabel = new StringResource
        {
            Id = "IncomingReportsXtraReport_InspectionStatusLabel",
            Description = "Результат"
        };

        // --- MillReportsXtraReport ---
        public static StringResource MillReportsXtraReport_ReportHeaderLabel = new StringResource
        {
            Id = "MillReportsXtraReport_ReportHeaderLabel",
            Description = "Отчет на заводе"
        };
        public static StringResource MillReportsXtraReport_PageHeaderLabel = new StringResource
        {
            Id = "MillReportsXtraReport_PageHeaderLabel",
            Description = "Отчет на заводе"
        };
        public static StringResource MillReportsXtraReport_NumberLabel = new StringResource
        {
            Id = "MillReportsXtraReport_NumberLabel",
            Description = "Номер"
        };
        public static StringResource MillReportsXtraReport_TypeLabel = new StringResource
        {
            Id = "MillReportsXtraReport_TypeLabel",
            Description = "Тип трубы"
        };
        public static StringResource MillReportsXtraReport_StatusLabel = new StringResource
        {
            Id = "MillReportsXtraReport_StatusLabel",
            Description = "Статус"
        };
        public static StringResource MillReportsXtraReport_PurchaseOrderDateLabel = new StringResource
        {
            Id = "MillReportsXtraReport_PurchaseOrderDateLabel",
            Description = "Дата"
        };
        public static StringResource MillReportsXtraReport_PurchaseOrderNumberLabel = new StringResource
        {
            Id = "MillReportsXtraReport_PurchaseOrderNumberLabel",
            Description = "Номер"
        };
        public static StringResource MillReportsXtraReport_WallThicknessLabel = new StringResource
        {
            Id = "MillReportsXtraReport_WallThicknessLabel",
            Description = "Толщина"
        };
        public static StringResource MillReportsXtraReport_WeightLabel = new StringResource
        {
            Id = "MillReportsXtraReport_WeightLabel",
            Description = "Вес"
        };
        public static StringResource MillReportsXtraReport_LengthLabel = new StringResource
        {
            Id = "MillReportsXtraReport_LengthLabel",
            Description = "Длина"
        };
        public static StringResource MillReportsXtraReport_DiameterLabel = new StringResource
        {
            Id = "MillReportsXtraReport_DiameterLabel",
            Description = "Диаметр"
        };
        public static StringResource MillReportsXtraReport_PlateNumberLabel = new StringResource
        {
            Id = "MillReportsXtraReport_PlateNumberLabel",
            Description = "Номер листа"
        };
        public static StringResource MillReportsXtraReport_HeatNumberLabel = new StringResource
        {
            Id = "MillReportsXtraReport_HeatNumberLabel",
            Description = "Номер плавки"
        };
        public static StringResource MillReportsXtraReport_ActiveLabel = new StringResource
        {
            Id = "MillReportsXtraReport_ActiveLabel",
            Description = "Состояние"
        };

        //--- Used Product Report ---
        public static StringResource UsedProductsXtraReport_GroupHeaderLabel = new StringResource
        {
            Id = "UsedProductsXtraReport_GroupHeaderLabel",
            Description = "Отчет по использованным изделиям"
        };
        public static StringResource UsedProductsXtraReport_PageHeaderLabel = new StringResource
        {
            Id = "UsedProductsXtraReport_PageHeaderLabel",
            Description = "Отчет по использованным изделиям"
        };
        public static StringResource UsedProductsXtraReport_ProductNumberLabel = new StringResource
        {
            Id = "UsedProductsXtraReport_ProductNumberLabel",
            Description = "Номер изделия"
        };
        public static StringResource UsedProductsXtraReport_ProductTypeLabel = new StringResource
        {
            Id = "UsedProductsXtraReport_ProductTypeLabel",
            Description = "Тип изделия"
        };
        
        #endregion IncomingInspectionReport

        #region Spool
        //message

        public static StringResource SpoolsXtraForm_Title = new StringResource
        {
            Id = "SpoolsXtraForm_Title",
            Description = "Создание катушки"
        };
        
        public static StringResource CreateSpoolComponentDialog_Title = new StringResource
        {
            Id = "CreateSpoolComponentDialog_Title",
            Description = "Создание компонента"
        };
        
        public static StringResource Spool_SpoolLengtBigerThenPipeLength = new StringResource
        {
            Id = "Spool_SpoolLengtBigerThenPipeLength",
            Description = "Длина трубы меньше длины катушки"
        };
        public static StringResource Spool_CutSpoolFromPipe = new StringResource
        {
            Id = "Spool_CutSpoolFromPipe",
            Description = "Катушка успешно отрезана"
        };
        public static StringResource Spool_CutSpoolFromPipeHeader = new StringResource
        {
            Id = "Spool_CutSpoolFromPipeHeader",
            Description = "Заголовок орезания катушки"
        };
        public static StringResource Spool_NullSpoolLength = new StringResource
        {
            Id = "Spool_NullSpoolLength",
            Description = "Длина катушки равна 0"
        };
        public static StringResource Spool_WrongPipeNumberForCutting = new StringResource
        {
            Id = "Spool_WrongPipeNumberForCutting",
            Description = "Неверный номер трубы для нарезания на катушки"
        };
        public static StringResource Spool_WrongPipeNumberForCuttingHeader = new StringResource
        {
            Id = "Spool_WrongPipeNumberForCuttingHeader",
            Description = "Неверный номер трубы для нарезания на катушки"
        };
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

        public static StringResource Spool_IncomingInspectionGroup = new StringResource
        {
            Id = "Spool_IncomingInspectionGroup",
            Description = "Катушка. Входной контроль"
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

        public static StringResource Spool_InspectionOrderColumn = new StringResource
        {
            Id = "Spool_InspectionOrderColumn",
            Description = "Катушка. порядок операций входного контроля"
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

        public static StringResource Spool_DeactivationQuestion = new StringResource
        {
            Id = "Spool_DeactivationQuestion",
            Description = "Катушка, вопрос о деактивации: Данное действие приведет к деактивации катушки: длина исходной трубы будет пересчитана, параметры катушки станут невозможны для редактирования. Если катушка содержит брак, вместо деактивации рекомендуем присвоить ей соответствующий статус на входном контроле. Деактивировать комплектующий элемент?"
        };

        public static StringResource Spool_DeactivationQuestionHeader = new StringResource
        {
            Id = "Spool_DeactivationQuestionHeader",
            Description = "Катушка, заголовок вопроса о деактивации: Деактивация катушки"
        };

        public static StringResource Spool_EditDocumentHeader = new StringResource
        {
            Id = "Spool_EditDocumentHeader",
            Description = "Катушка, заголовок окна редактирования: Редактирование катушки"
        };

        public static StringResource Spool_Deactivated = new StringResource
        {
            Id = "Spool_Deactivated",
            Description = "Катушка деактивирована. Катушка #"
        };

        public static StringResource Spool_DeactivatedHeader = new StringResource
        {
            Id = "Spool_DeactivatedHeader",
            Description = "Деактивация катушки"
        };

        public static StringResource Spool_CutSpoolFromPipe_Fail_Header = new StringResource
        {
            Id = "Spool_CutSpoolFromPipeFail_Header",
            Description = "Ошибка при сохранении катушки"
        };

        public static StringResource Spool_CutSpoolFromPipe_Fail = new StringResource
        {
            Id = "Spool_CutSpoolFromPipe_Fail",
            Description = "Катушка не сохранена"
        };

        public static StringResource Message_DeactivationConnectedSpool = new StringResource
        {
            Id = "Message_DeactivationConnectedSpool",
            Description = "Соединена катушка не может быть деактивирован. Для деактивации катушки необходимо ее отсоединить."
        };

        public static StringResource Message_DeactivationConnectedSpoolHeader = new StringResource
        {
            Id = "Message_DeactivationConnectedSpoolHeader",
            Description = "Катушка имеет соединение"
        };
        
        #endregion Spool

        #region MissingPortion

        public static StringResource MissingPortionsDialog_SequenceIsBroken = new StringResource
        {
            Id = "MissingPortionsDialog_SequenceIsBroken",
            Description = "Последовательность импортируемых данных нарушена. Рабочая станция: "
        };

        public static StringResource MissingPortionsDialog_PortionsAlreadyExist = new StringResource
        {
            Id = "MissingPortionsDialog_PortionsAlreadyExist",
            Description = "Уже существуют порции с номерами:"
        };

        public static StringResource MissingPortionsDialog_Title = new StringResource
        {
            Id = "MissingPortionsDialog_Title",
            Description = "Нарушена последовательность"
        };
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
        //message

        public static StringResource Settings_Title = new StringResource
        {
            Id = "Settings_Title",
            Description = "Настройки"
        };
        public static StringResource Settings_PipeControlOperationValidation = new StringResource
        {
            Id = "Settings_PipeControlOperationValidation",
            Description = "Необходимо проверить следующие типоразмеры: "
        };
        public static StringResource Settings_PipeControlOperationValidationHeader = new StringResource
        {
            Id = "Settings_PipeControlOperationValidationHeader",
            Description = "Неверные данные для типоразмера"
        };
        public static StringResource  Settings_ValidateInspectorSertificate = new StringResource
        {
            Id = "Settings_ValidateInspectorSertificate",
            Description = "Для ввода сертификата необходимо выбрать инспектора"
        };
        public static StringResource Settings_ValueRequired = new StringResource
        {
            Id = "Settings_ValueRequired",
            Description = "Обязательное значение"
        };
        public static StringResource Settings_UniqueLogin = new StringResource
        {
            Id = "Settings_UniqueLogin",
            Description = "Значение должно быть уникальным"
        };
        public static StringResource Settings_UniqueValueRequired = new StringResource
        {
            Id = "Settings_UniqueValueRequired",
            Description = "Значение должно быть уникальным"
        };
        public static StringResource Settings_ChekControlOperations = new StringResource
        {
            Id = "Settings_ChekControlOperations",
            Description = "Необходимо проверить контрольную операцию"
        };
        public static StringResource Settings_DateExpired = new StringResource
        {
            Id = "Settings_DateExpired",
            Description = "Дата сертификата просрочена"
        };

        public static StringResource Settings_ErrorHeader = new StringResource
        {
            Id = "Settings_ErrorHeader",
            Description = "Заголовок ошибки"
        };
        public static StringResource Settings_CheckValues = new StringResource
        {
            Id = "Settings_CheckValues",
            Description = "Необходимо проверить значение"
        };
        public static StringResource Settings_SetupSavedHeader = new StringResource
        {
            Id = "Settings_SetupSavedHeader",
            Description = "Заголовок успешного сохранения настроек"
        };
        public static StringResource Settings_SetupSaves = new StringResource
        {
            Id = "Settings_SetupSaves",
            Description = "Настройки сохранены"
        };
        //setting form
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
            Description = "Настройки. Кнопка - Сохранить"
        };
        public static StringResource Settings_CloseButton = new StringResource
        {
            Id = "Settings_CloseButton",
            Description = "Настройки. Кнопка - Закрыть"
        };

        public static StringResource Settings_MillNameGridColumn = new StringResource
        {
            Id = "Settings_MillNameGridColumn",
            Description = "Настройки. Надпись колонки завода"
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
            Description = "Настройки-Проект. Название рабоче&й станции"
        };
        public static StringResource SettingsProject_MaskEditLabel = new StringResource
        {
            Id = "SettingsProject_MaskEditLabel",
            Description = "Настройки-Проект. Маска номера трубы"
        };

        public static StringResource MillPipeNumber_Mask_Hint = new StringResource
        {
            Id = "MillPipeNumber_Mask_Hint",
            Description = "Текст подсказки формата номера трубы: Формат номера трубы: "
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

        public static StringResource SettingsProject_TechParametersGroup = new StringResource
        {
            Id = "SettingsProject_TechParametersGroup",
            Description = "Настройки-Проект. Надпись группы техничекских параметров"
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
            Description = "Настройки-труба. Диаметр трубы с заданым типоразмером,мм"
        };
        public static StringResource SettingsPipe_WallThicknessLabel = new StringResource
        {
            Id = "SettingsPipe_WallThicknessLabel",
            Description = "Настройки-труба. Толщина стенки для трубы с заданым типоразмером, мм"
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
            Description = "Настройки-труба. Результат контрольной операции"
        };
        
        public static StringResource SettingsPipe_InspectionsBoolExpectedColumn = new StringResource
        {
            Id = "SettingsPipe_InspectionsBoolExpectedColumn",
            Description = "Настройки-труба. Ожидаемый результат для булевского результата"
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

        public static StringResource SettingsPipe_sizeParamsLayoutControlGroup = new StringResource
        {
            Id = "SettingsPipe_sizeParamsLayoutControlGroup",
            Description = "Настройки-труба. Группа параметров типоразмера"
        };

        public static StringResource SettingsPipe_RepeatedInspectionsGridColumn = new StringResource
        {
            Id = "SettingsPipe_RepeatedInspectionsGridColumn",
            Description = "Повтор"
        };

        
        //pipeline page
        public static StringResource SettingsLine_LineGroup = new StringResource
        {
            Id = "SettingsLine_LineGroup",
            Description = "Настройки - Трубопровод. Список контрольных и ремонтных операций для стыка"
        };

        public static StringResource SettingsLine_JointOperationLayoutControlItem = new StringResource
        {
            Id = "SettingsLine_JointOperationLayoutControlItem",
            Description = "Настройки - Трубопровод. Набор операций - условия приемки стыка для спуска"
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

        public static StringResource JointOperationType_Test = new StringResource
        {
            Id = "JointOperationType_Test",
            Description = "Настройки - Трубопровод.Тип операции.Контрольная"
        };

        public static StringResource JointOperationType_Action = new StringResource
        {
            Id = "JointOperationType_Action",
            Description = "Настройки - Трубопровод.Тип операции.Ремонтная"
        };

        public static StringResource JointOperationType_Weld = new StringResource
        {
            Id = "JointOperationType_Weld",
            Description = "Настройки - Трубопровод.Тип операции.Сварка"
        };

        public static StringResource JointOperationType_Withdraw = new StringResource
        {
            Id = "JointOperationType_Withdraw",
            Description = "Настройки - Трубопровод.Тип операции.Вырезка стыка"
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
            Description = "Настройки - Комплектующие. Количество коннекторов у комплектующего"
        };

        public static StringResource SettingsComponent_IsActiveTypeColumn = new StringResource
        {
            Id = "SettingsComponent_IsActiveTypeColumn",
            Description = "Настройки - Комплектующие. Активность комплектующего элемента"
        };

        public static StringResource SettingsComponent_ConstructionNameColumn = new StringResource
        {
            Id = "SettingsComponent_ConstructionNameColumn",
            Description = "Настройки - Комплектующие. Название строительного участка"
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

        public static StringResource SettingsInspectors_InspectorLayoutControlGroup = new StringResource
        {
            Id = "SettingsInspectors_InspectorLayoutControlGroup",
            Description = "Настройки - Инспектора. Группа инспекторов"
        };

        public static StringResource SettingsInspectors_CertificatesLabel = new StringResource
        {
            Id = "SettingsInspectors_CertificatesLabel",
            Description = "Настройки - Инспектора. Список сертификатов для конкретного инспектора"
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

        public static StringResource SettingsInspectors_IsActive = new StringResource
        {
            Id = "SettingsInspectors_IsActive",
            Description = "Настройки - Инспектора. Активен"
        };

        public static StringResource SettingsInspectors_InspectorGrade = new StringResource
        {
            Id = "SettingsInspectors_InspectorGrade",
            Description = "Настройки - Инспектора. Уровень"
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

        public static StringResource SettingsUser_RolesLabel = new StringResource
        {
            Id = "SettingsUser_RolesLabel",
            Description = "Настройки - Пользователи. Список ролей"
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
            Description = "Настройки - Пользователи. Имя пользователя"
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

        public static StringResource SecurityPrivilege_Audit = new StringResource
        {
            Id = "SecurityPrivilege_Audit",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_CreateComponent = new StringResource
        {
            Id = "SecurityPrivilege_CreateComponent",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_CreateJoint = new StringResource
        {
            Id = "SecurityPrivilege_CreateJoint",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_CreatePipe = new StringResource
        {
            Id = "SecurityPrivilege_CreatePipe",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_CreateReleaseNote = new StringResource
        {
            Id = "SecurityPrivilege_CreateReleaseNote",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_CreateSpool = new StringResource
        {
            Id = "SecurityPrivilege_CreateSpool",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_DeactivateComponent = new StringResource
        {
            Id = "SecurityPrivilege_DeactivateComponent",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_DeactivateJoint = new StringResource
        {
            Id = "SecurityPrivilege_DeactivateJoint",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_DeactivatePipe = new StringResource
        {
            Id = "SecurityPrivilege_DeactivatePipe",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_DeactivateSpool = new StringResource
        {
            Id = "SecurityPrivilege_DeactivateSpool",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_EditComponent = new StringResource
        {
            Id = "SecurityPrivilege_EditComponent",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_EditJoint = new StringResource
        {
            Id = "SecurityPrivilege_EditJoint",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_EditPipe = new StringResource
        {
            Id = "SecurityPrivilege_EditPipe",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_EditReleaseNote = new StringResource
        {
            Id = "SecurityPrivilege_EditReleaseNote",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_EditSettings = new StringResource
        {
            Id = "SecurityPrivilege_EditSettings",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_EditSpool = new StringResource
        {
            Id = "SecurityPrivilege_EditSpool",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ExportDataFromConstruction = new StringResource
        {
            Id = "SecurityPrivilege_ExportDataFromConstruction",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ExportDataFromMaster = new StringResource
        {
            Id = "SecurityPrivilege_ExportDataFromMaster",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ExportDataFromMill = new StringResource
        {
            Id = "SecurityPrivilege_ExportDataFromMill",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ImportData = new StringResource
        {
            Id = "SecurityPrivilege_ImportData",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ImportDataAtConstruction = new StringResource
        {
            Id = "SecurityPrivilege_ImportDataAtConstruction",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ImportDataAtMaster = new StringResource
        {
            Id = "SecurityPrivilege_ImportDataAtMaster",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_PartsInspection = new StringResource
        {
            Id = "SecurityPrivilege_PartsInspection",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_PrintConstructionReports = new StringResource
        {
            Id = "SecurityPrivilege_PrintConstructionReports",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_PrintInspectionReports = new StringResource
        {
            Id = "SecurityPrivilege_PrintInspectionReports",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_PrintMillReports = new StringResource
        {
            Id = "SecurityPrivilege_PrintMillReports",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ReleaseNotes = new StringResource
        {
            Id = "SecurityPrivilege_ReleaseNotes",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_SearchJoints = new StringResource
        {
            Id = "SecurityPrivilege_SearchJoints",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_SearchParts = new StringResource
        {
            Id = "SecurityPrivilege_SearchParts",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_SearchPipes = new StringResource
        {
            Id = "SecurityPrivilege_SearchPipes",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_SearchReleaseNotes = new StringResource
        {
            Id = "SecurityPrivilege_SearchReleaseNotes",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_UnshipAtMill = new StringResource
        {
            Id = "SecurityPrivilege_UnshipAtMill",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ViewComponent = new StringResource
        {
            Id = "SecurityPrivilege_ViewComponent",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ViewJoint = new StringResource
        {
            Id = "SecurityPrivilege_ViewJoint",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ViewPipe = new StringResource
        {
            Id = "SecurityPrivilege_ViewPipe",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ViewReleaseNote = new StringResource
        {
            Id = "SecurityPrivilege_ViewReleaseNote",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ViewSettings = new StringResource
        {
            Id = "SecurityPrivilege_ViewSettings",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ViewSpool = new StringResource
        {
            Id = "SecurityPrivilege_ViewSpool",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ViewExportImportHistory = new StringResource
        {
            Id = "SecurityPrivilege_ViewExportImportHistory",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_PrintWeldDateReport = new StringResource
        {
            Id = "SecurityPrivilege_PrintWeldDateReport",
            Description = "Отчеты сварки по дате"
        };
        public static StringResource SecurityPrivilege_PrintWeldTracingReport = new StringResource
        {
            Id = "SecurityPrivilege_PrintWeldTracingReport",
            Description = "Отчет по сварке между пикетами"
        };

        #endregion Settings

        #region --- Audit ---

        public static StringResource Audit_ElementNumberLabel = new StringResource {
            Id = "Audit_ElementNumberLabel",
            Description = "Аудит. Надпись номера элемента."};
        
        public static StringResource Audit_PeriodLabel = new StringResource { 
            Id = "Audit_PeriodLabel", 
            Description = "Аудит. Надпись периода"};

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

        public static StringResource Audit_OperationTypeColumnHeader = new StringResource
        {
            Id = "Audit_OperationTypeColumnHeader",
            Description = "Аудит. Надпись колонки типа операции"
        };

        public static StringResource Audit_SearchParametersGroup = new StringResource { 
            Id = "Audit_SearchParametersGroup", 
            Description = "Аудит. Надпись панели параметров поиска"};

        public static StringResource Audit_RadioPeriod = new StringResource { 
            Id = "Audit_RadioPeriod", 
            Description = "Аудит. Надпись радиокнопки периода"};

        public static StringResource Audit_RadioUser = new StringResource { 
            Id = "Audit_RadioUser", 
            Description = "Аудит. Надпись радиокнопки пользователя"};

        public static StringResource AuditXtraForm_Title = new StringResource
        {
            Id = "AuditXtraForm_Title",
            Description = "Заголовок: Аудит"
        };

        public static StringResource Audit_CheckEdited = new StringResource
        {
            Id = "Audit_CheckEdited",
            Description = "Аудит. Надпись чекбокса Отредактированные"
        };

        public static StringResource Audit_CheckImported = new StringResource
        {
            Id = "Audit_CheckImported",
            Description = "Аудит. Надпись чекбокса Импортированные"
        };

        public static StringResource Audit_CheckCreated = new StringResource
        {
            Id = "Audit_CheckCreated",
            Description = "Аудит. Надпись чекбокса Созданные"
        };

        public static StringResource Audit_CheckDeleted = new StringResource
        {
            Id = "Audit_CheckDeleted",
            Description = "Аудит. Надпись чекбокса Удаленные"
        };

        public static StringResource Audit_IncludeToSearchLayout= new StringResource
        {
            Id = "Audit_IncludeToSearchLayout",
            Description = "Аудит. Надпись Включить в результаты поиска"
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
            Description = "Текст перед версией программы в окне \"О программе \""
        };
        public static StringResource About_AcceptButton = new StringResource
        {
            Id = "About_AcceptButton",
            Description = "Кнопка ОК"
        };

        public static StringResource AboutXtraForm_Title = new StringResource
        {
            Id = "AboutXtraForm_Title",
            Description = "О программе"
        };

        
        #endregion // --- About ---

        #region --- Part Search ---

        public static StringResource PartSearch_Title = new StringResource
        {
            Id = "PartSearch_Title",
            Description = "Поиск элементов трубопровода"
        };

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

        #region --- Export/Import ---


        public static StringResource ImportForm_Title = new StringResource
        {
            Id = "ImportForm_Title",
            Description = "Импорт"
        };
        public static StringResource ExportForm_Title = new StringResource
        {
            Id = "ExportForm_Title",
            Description = "Экспорт"
        };

        public static StringResource Export_Ready = new StringResource
        {
            Id = "Export_Ready",
            Description = "Сообщение об успехе экспорта: Экспортирование завершено успешно. Количество экспортированных элементов:"
        };

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

        public static StringResource Export_ArchiveExported = new StringResource
        {
            Id = "Export_ArchiveExported",
            Description = "[{0}] Экспортировано в '{1}'"
        };

        public static StringResource Export_CreateTempStorage = new StringResource
        {
            Id = "Export_CreateTempStorage",
            Description = "Создание временного хранилища."
        };

        public static StringResource Export_CreatingArchive = new StringResource
        {
            Id = "Export_CreatingArchive",
            Description = "Создание конечного архива."
        };

        public static StringResource Export_Error = new StringResource
        {
            Id = "Export_Error",
            Description = "[{0}] Ошибка {1}"
        };

        public static StringResource Export_Filter = new StringResource
        {
            Id = "Export_Filter",
            Description = "PRISM archives"
        };

        public static StringResource Export_NoData = new StringResource
        {
            Id = "Export_NoData",
            Description = "Нет новых данных для экспортирования."
        };

        public static StringResource Export_ReadingData = new StringResource
        {
            Id = "Export_ReadingData",
            Description = "Чтение данных."
        };

        public static StringResource Export_WritingData = new StringResource
        {
            Id = "Export_WritingData",
            Description = "Экспортирование завершено успешно."
        };

        public static StringResource Import_Checksum = new StringResource
        {
            Id = "Import_Checksum",
            Description = "Проверка контрольной суммы"
        };

        public static StringResource Import_Conflict = new StringResource
        {
            Id = "Import_Conflict",
            Description = "Труба с номером '{0}' уже существует в БД."
        };

        public static StringResource Import_CopyAttachments = new StringResource
        {
            Id = "Import_CopyAttachments",
            Description = "Импорт вложений"
        };

        public static StringResource Import_Data = new StringResource
        {
            Id = "Import_Data",
            Description = "Импорт данных"
        };

        public static StringResource Import_SamePortion = new StringResource
        {
            Id = "Import_SamePortion",
            Description = "Данная порция уже была импортирована и не может быть импортирована снова."
        };

        public static StringResource Import_TempStorage = new StringResource
        {
            Id = "Import_TempStorage",
            Description = "Создание временного хранилища"
        };

        public static StringResource Import_Unzip = new StringResource
        {
            Id = "Import_Unzip",
            Description = "Распаковка"
        };

        public static StringResource ImportMessage_IsFinished= new StringResource
        {
            Id = "ImportMessage_IsFinished",
            Description = "Сообщение: Импортирование завершено"
        };

        public static StringResource Import_Progress_Message_Counter = new StringResource
        {
            Id = "Import_Progress_Message_Counter",
            Description = "Сообщение: Импортирование прогресс счетчик"
        };

        public static StringResource Import_Progress_Message_Type = new StringResource
        {
            Id = "Import_Progress_Message_Type",
            Description = "Сообщение: Импортирование прогресс тип"
        };

        public static StringResource HistoryExportImport_SynchType_Undefined = new StringResource
        {
            Id = "HistoryExportImport_SynchType_Undefined",
            Description = "Экспорт"
        };

        public static StringResource HistoryExportImport_SynchType_Export = new StringResource
        {
            Id = "HistoryExportImport_SynchType_Export",
            Description = "Экспорт"
        };

        public static StringResource HistoryExportImport_SynchType_Import = new StringResource
        {
            Id = "HistoryExportImport_SynchType_Import",
            Description = "Импорт"
        };

        public static StringResource HistoryExportImport_IsExportColumn = new StringResource
        {
            Id = "HistoryExportImport_IsExportColumn",
            Description = "Экспорт / Импорт"
        };

        public static StringResource HistoryExportImport_WorkstationColumn = new StringResource
        {
            Id = "HistoryExportImport_WorkstationColumn",
            Description = "Рабочая станция"
        };

        public static StringResource HistoryExportImport_Title = new StringResource
        {
            Id = "HistoryExportImport_Title",
            Description = "История экспорта / импорта"
        };

        #endregion // --- Export/Import ---

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

        public static StringResource SaveDialog_Title = new StringResource
        {
            Id = "SaveDialog_Title",
            Description = "Сохранить изменения?"
        };

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

        public static StringResource ExternalFilesXtraForm_Title = new StringResource
        {
            Id = "ExternalFilesXtraForm_Title",
            Description = "Внешние файлы"
        };

        public static StringResource ExternalFiles_CloseButton = new StringResource
        {
            Id = "ExternalFiles_CloseButton",
            Description = "Вложения. Кнопка закрытия"
        };
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



        public static StringResource PartInspection_Title = new StringResource
        {
            Id = "PartInspection_Title",
            Description = "Входной контроль"
        };

        public static StringResource InspectionSelectPartDialog_Title = new StringResource
        {
            Id = "InspectionSelectPartDialog_Title",
            Description = "Выбор элемента"
        };

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

        public static StringResource ConflictDialog_Title = new StringResource
        {
            Id = "ConflictDialog_Title",
            Description = "Конфликт"
        };
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

        public static StringResource Import_ExitButton = new StringResource
        {
            Id = "Import_ExitButton",
            Description = "Импорт. Надпись кнопки выхода"
        };

        public static StringResource Import_WrongWorkstationType = new StringResource
        {
            Id = "Import_WrongWorkstationType",
            Description = "Невозможно импортировать данные. Импортируемый файл был создан не на мастере."
        };

        #endregion

        #region --- Heat Number Form ---
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

        public static StringResource ComponentNewEdit_OrderColumn = new StringResource
        {
            Id = "ComponentNewEdit_OrderColumn",
            Description = "Порядок"
        };

        public static StringResource ComponentNewEdit_DiameterGridColumn = new StringResource
        {
            Id = "ComponentNewEdit_DiameterGridColumn",
            Description = "Диаметр отверстия, мм"
        };

        public static StringResource ComponentNewEdit_WallThicknessGridColumn = new StringResource
        {
            Id = "ComponentNewEdit_WallThicknessGridColumn",
            Description = "Толщина стенки, мм"
        };

        public static StringResource ComponentNewEdit_IsConnectedGridColumn = new StringResource
        {
            Id = "ComponentNewEdit_IsConnectedGridColumn",
            Description = "Соединен"
        };

        public static StringResource ComponentNewEdit_InspectionLayoutGroup = new StringResource
        {
            Id = "ComponentNewEdit_InspectionLayoutGroup",
            Description = "Входно&й контроль"
        };

        public static StringResource ComponentNewEdit_Duplicate = new StringResource
        {
            Id = "ComponentNewEdit_Duplicate",
            Description = "Сообщение о существующем номере: Уже существует комплектующий элемент с номером:"
        };

        public static StringResource ComponentNewEdit_DuplicateHeader = new StringResource
        {
            Id = "ComponentNewEdit_DuplicateHeader",
            Description = "Заголовок сообщения о существующем номере: Дублирование номера комплектующего элемента"
        };

        public static StringResource ComponentNewEdit_Saved = new StringResource
        {
            Id = "ComponentNewEdit_Saved",
            Description = "Сообщение о сохранении существующего элемента: Комплектующее изделие успешно сохранено в базе. Комплектующее изделие #"
        };

        public static StringResource ComponentNewEdit_SavedHeader = new StringResource
        {
            Id = "ComponentNewEdit_SavedHeader",
            Description = "Заголовок сообщения о сохранении существующего элемента"
        };

        public static StringResource ComponentNewEdit_DiameterValueValidation = new StringResource
        {
            Id = "ComponentNewEdit_DiameterValueValidation",
            Description = "Сообщение об ошибке: Величина диаметра должна быть больше нуля"
        };

        public static StringResource ComponentNewEdit_DeactivatedAction = new StringResource
        {
            Id = "ComponentNewEdit_DeactivatedAction",
            Description = "Сообщение о деактивации элемента: Комплектующее изделие деактивировано. Комплектующее изделие #"
        };

        public static StringResource ComponentNewEdit_DeactivatedActionHeader = new StringResource
        {
            Id = "ComponentNewEdit_DeactivatedActionHeader",
            Description = "Заголовок сообщения о деактивации элемента"
        };

        public static StringResource ComponentNewEdit_Title = new StringResource
        {
            Id = "ComponentNewEdit_Title",
            Description = "Комплектующее изделие"
        };

        public static StringResource Message_DeactivationConnectedComponent = new StringResource
        {
            Id = "Message_DeactivationConnectedComponent",
            Description = "Соединенный компонент не может быть деактивирован. Для деактивации компонента необходимо его отсоединить."
        };

        public static StringResource Message_DeactivationConnectedComponentHeader = new StringResource
        {
            Id = "Message_DeactivationConnectedComponentHeader",
            Description = "Комплектующее имеет соединение"
        };

        #endregion //--- ComponentNewEdit ---

        #region --- JointNew ---

        public static StringResource Joint_JointTestResultStatus_Withdraw = new StringResource
        {
            Id = "Joint_JointTestResultStatus_Withdraw",
            Description = "статус контрольной операции для стыка"
        };
        public static StringResource Joint_JointTestResultStatus_Repair = new StringResource
        {
            Id = "Joint_JointTestResultStatus_Repair",
            Description = "статус контрольной операции для стыка"
        };
        public static StringResource Joint_JointTestResultStatus_Accepted = new StringResource
        {
            Id = "Joint_JointTestResultStatus_Accepted",
            Description = "статус контрольной операции для стыка"
        };

        public static StringResource JointNew_SearchGroupLayout = new StringResource
        {
            Id = "JointNew_SearchGroupLayout",
            Description = "Поиск и редактирование стыка"
        };

        public static StringResource JointNew_SearchButton = new StringResource
        {
            Id = "JointNew_SearchButton",
            Description = "Найти и открыть для редактирования"
        };

        public static StringResource JointNew_SearchNumberLayout = new StringResource
        {
            Id = "JointNew_SearchNumberLayout",
            Description = "&Номер искомого стыка"
        };
        
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

        public static StringResource Joint_WithdrawQuestionHeader = new StringResource
        {
            Id = "Joint_WithdrawQuestionHeader",
            Description = "Заголовок вопроса о вырезке стыка: Вырезка стыка"
        };

        public static StringResource Joint_WithdrawQuestion = new StringResource
        {
            Id = "Joint_WithdrawQuestion",
            Description = "Текст вопроса о вырезке стыка: Данное действие приведет к разъединению элементов трубопровода. Вы действительно хотите вырезать стык?"
        };

        public static StringResource Joint_DeactivationQuestion = new StringResource
        {
            Id = "Joint_DeactivationQuestion",
            Description = "Вопрос о деактивации стыка: Данное действие приведет к деактивации стыка. Параметры стыка станут невозможны для редактирования. Деактивировать стык?"
        };

        public static StringResource Joint_DeactivationQuestionHeader = new StringResource
        {
            Id = "Joint_DeactivationQuestionHeader",
            Description = "Заголовок вопроса о деактивации стыка: Деактивация стыка"
        };

        public static StringResource Joint_Saved = new StringResource
        {
            Id = "Joint_Saved",
            Description = "Сообщение о сохранении стыка: Стык успешно сохранен в базе. Стык  #"
        };

        public static StringResource Joint_SavedHeader = new StringResource
        {
            Id = "Joint_SavedHeader",
            Description = "Заголовок сообщения о сохранении стыка: Сохранение стыка"
        };

        public static StringResource Joint_Duplicate = new StringResource
        {
            Id = "Joint_Duplicate",
            Description = "Сообщение о дублировании стыка: Уже существует стык с номером:"
        };

        public static StringResource Joint_DuplicateHeader = new StringResource
        {
            Id = "Joint_DuplicateHeader",
            Description = "Заголовок сообщения о дублировании стыка: Дублирование номера стыка"
        };

        public static StringResource Joint_IncorrectDiameter = new StringResource
        {
            Id = "Joint_IncorrectDiameter",
            Description = "Сообщение о диаметрах: Отсутствуют подходящие диаметры для формирования стыка."
        };

        public static StringResource Joint_IncorrectDiameterHeader = new StringResource
        {
            Id = "Joint_IncorrectDiameterHeader",
            Description = "Заголовок сообщения о диаметрах: Не совпадают диаметры стыкуемых элементов"
        };

        public static StringResource Joint_Deactivated = new StringResource
        {
            Id = "Joint_Deactivated",
            Description = "Стык деактивирован. Стык #"
        };

        public static StringResource Joint_DeactivatedHeader = new StringResource
        {
            Id = "Joint_DeactivatedHeader",
            Description = "Деактивация стыка"
        };

        public static StringResource JointNewXtraForm_Title = new StringResource
        {
            Id = "JointNewXtraForm_Title",
            Description = "Стык"
        };

        public static StringResource JointNewNotAllWeldOperationCompleted = new StringResource
        {
            Id = "JointNewNotAllWeldOperationCompleted",
            Description = "Сообщение о том, что не все сварочные операции выполнены"
        };

        public static StringResource JointNewNotAllWeldOperationCompletedHeader = new StringResource
        {
            Id = "JointNewNotAllWeldOperationCompletedHeader",
            Description = "Сообщение о том, что не все сварочные операции выполнены"
        };

        #endregion //--- JointNew ---

        #region --- JointSearch ---

        public static StringResource JointSearchXtraForm_Title = new StringResource
        {
            Id = "JointSearchXtraForm_Title",
            Description = "Поиск стыков"
        };

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

        public static StringResource ConstructionReport_Title = new StringResource
        {
            Id = "ConstructionReport_Title",
            Description = "Отчет по сварке участка между пикетами"
        };

        public static StringResource ConstructionReports_FootersCheck = new StringResource
        {
            Id = "ConstructionReports_FootersCheck",
            Description = "Добавить колонтитулы"
        };

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

        #region --- PipeConstructionReport ---

        public static StringResource PipeConstructionReport_Title = new StringResource
        {
            Id = "PipeConstructionReport_Title",
            Description = "Отчеты по трубам на стройке"
        };

        public static StringResource PipeConstructionReport_FootersCheck = new StringResource
        {
            Id = "PipeConstructionReport_FootersCheck",
            Description = "Добавить колонтитулы"
        };

        public static StringResource PipeConstructionReport_PipeNumberLayout = new StringResource
        {
            Id = "PipeConstructionReport_PipeNumberLayout",
            Description = "Номер трубы"
        };
        
        public static StringResource PipeConstructionReport_PipeTypeCheckedComboLayout = new StringResource
        {
            Id = "PipeConstructionReport_PipeTypeCheckedComboLayout",
            Description = "Типоразмер"
        };
        
        public static StringResource PipeConstructionReport_PipeReportParametersLayoutGroup = new StringResource
        {
            Id = "PipeConstructionReport_PipeReportParametersLayoutGroup",
            Description = "Параметры отчета по трубам"
        };
        
        public static StringResource PipeConstructionReport_PreviewButton = new StringResource
        {
            Id = "PipeConstructionReport_PreviewButton",
            Description = "&Предпросмотр"
        };

        public static StringResource PipeConstructionReport_CreateReportButton = new StringResource
        {
            Id = "PipeConstructionReport_CreateReportButton",
            Description = "Соз&дать отчет"
        };
        
        public static StringResource PipeConstructionReport_DocumentViewerLayoutGroup = new StringResource
        {
            Id = "PipeConstructionReport_DocumentViewerLayoutGroup",
            Description = "Предварительный просмотр отчёта"
        };

        public static StringResource ConstructionReport_ReportTypeTracingReport = new StringResource
        {
            Id = "ConstructionReport_ReportTypeTracingReport",
            Description = "Тип отчета. По трассировке"
        };

        public static StringResource ConstructionReport_ReportTypeUsedProductReport = new StringResource
        {
            Id = "ConstructionReport_ReportTypeUsedProductReport",
            Description = "Тип отчета. По использованным изделиям"
        };

        #endregion //--- PipeConstructionReport ---

        #region --- WeldDateReport ---

        public static StringResource WeldDateReport_Title = new StringResource
        {
            Id = "WeldDateReport_Title",
            Description = "Отчет по сварке (по дате)"
        };

        public static StringResource WeldDateReport_FootersCheck = new StringResource
        {
            Id = "WeldDateReport_FootersCheck",
            Description = "Добавить колонтитулы"
        };

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


        //--- Weld Date XtraReport ---
        public static StringResource WeldDateXtraReport_WeldReportByDateHeader = new StringResource {
            Id = "WeldDateXtraReport_WeldReportByDateHeader",
            Description = "Отчет по сварке (по дате)"
        };
        public static StringResource WeldDateXtraReport_DateHeader = new StringResource {
            Id = "WeldDateXtraReport_DateHeader",
            Description = "Дата сварки"
        };
        public static StringResource WeldDateXtraReport_JointNumberHeader = new StringResource {
            Id = "WeldDateXtraReport_JointNumberHeader",
            Description = "Номер стыка"
        };
        public static StringResource WeldDateXtraReport_FirstPartNumberHeader = new StringResource {
            Id = "WeldDateXtraReport_FirstPartNumberHeader",
            Description = "Номер первой части"
        };
        public static StringResource WeldDateXtraReport_SecondPartNumberHeader = new StringResource {
            Id = "WeldDateXtraReport_SecondPartNumberHeader",
            Description = "Номер второй части"
        };
        public static StringResource WeldDateXtraReport_FirstPartLengthHeader = new StringResource {
            Id = "WeldDateXtraReport_FirstPartLengthHeader",
            Description = "Длина первой части"
        };
        public static StringResource WeldDateXtraReport_SecondPartLengthHeader = new StringResource {
            Id = "WeldDateXtraReport_SecondPartLengthHeader",
            Description = "Длина второй части"
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
            Description = "Длина, мм"
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
            Description = "Длина, мм"
        };
        
        public static StringResource JointCutDialog_CutJointButton = new StringResource {
            Id = "JointCutDialog_CutJointButton",
            Description = "Вырезать"
        };
        
        public static StringResource JointCutDialog_CancelButton = new StringResource {
            Id = "JointCutDialog_CancelButton",
            Description = "Отмена"
        };

        public static StringResource JointCutDialog_Title = new StringResource
        {
            Id = "JointCutDialog_Title",
            Description = "Вырезка стыка"
        };

        



        #endregion //--- JointCutDialog ---

        #region --- SelectDiameterDialog ---


        public static StringResource SelectDiameterDialog_Title = new StringResource
        {
            Id = "SelectDiameterDialog_Title",
            Description = "Выбор диаметра"
        };

        public static StringResource SelectDiameterDialog_DiametersIntersectionLayout = new StringResource {
            Id = "SelectDiameterDialog_DiametersIntersectionLayout",
            Description = "Выбор диаметра соединения"
        };
        
        public static StringResource SelectDiameterDialog_SaveChosenDiameter = new StringResource {
            Id = "SelectDiameterDialog_SaveChosenDiameter",
            Description = "Сохранить"
        };

        #endregion //--- SelectDiameterDialog ---

        #region --- MillInspectionXtraForm ---

        public static StringResource MillInspection_Title = new StringResource
        {
            Id = "MillInspection_Title",
            Description = "Добавление контрольной операции"
        };

        public static StringResource MillInspection_FrequencyMeasureMeters = new StringResource { 
            Id = "MillInspection_FrequencyMeasureMeters", 
            Description = "Настройка контрольных опрераций завода. Мера измерения метры"};

        public static StringResource MillInspection_FrequencyMeasureTons = new StringResource { 
            Id = "MillInspection_FrequencyMeasureTons", 
            Description = "Настройка контрольных опрераций завода. Мера измерения тонны"};

        public static StringResource MillInspection_FrequencyMeasurePipes = new StringResource { 
            Id = "MillInspection_FrequencyMeasurePipes", 
            Description = "Настройка контрольных опрераций завода. Мера измерения трубы"};

        public static StringResource MillInspection_SaveButton = new StringResource { 
            Id = "MillInspection_SaveButton", Description = 
            "Настройка контрольных опрераций завода. Надпись кнопки сохранения"};

        public static StringResource MillInspection_CancelButton = new StringResource { 
            Id = "MillInspection_CancelButton", 
            Description = "Настройка контрольных опрераций завода. Надпись кнопки отмены"};

        public static StringResource MillInspection_IsActiveCheckbox = new StringResource { 
            Id = "MillInspection_IsActiveCheckbox", 
            Description = "Настройка контрольных опрераций завода. Надпись чекбокса Активна"};

        public static StringResource MillInspection_YesNoExpectedCheckbox = new StringResource { 
            Id = "MillInspection_YesNoExpectedCheckbox", 
            Description = "Настройка контрольных опрераций завода. Надпись чекбокса булевого значения"};

        public static StringResource MillInspection_CodeLabel = new StringResource { 
            Id = "MillInspection_CodeLabel", 
            Description = "Настройка контрольных опрераций завода. Надпись кода"};

        public static StringResource MillInspection_NameLabel = new StringResource { 
            Id = "MillInspection_NameLabel", 
            Description = "Настройка контрольных опрераций завода. Надпись названия"};

        public static StringResource MillInspection_CategoryLabel = new StringResource { 
            Id = "MillInspection_CategoryLabel", 
            Description = "Настройка контрольных опрераций завода. Надпись категории"};

        public static StringResource MillInspection_ResultTypeLabel = new StringResource { 
            Id = "MillInspection_ResultTypeLabel", 
            Description = "Настройка контрольных опрераций завода. Надпись типа результата"};

        public static StringResource MillInspection_ControlTypeLabel = new StringResource { 
            Id = "MillInspection_ControlTypeLabel", 
            Description = "Настройка контрольных опрераций завода. Надпись типа контроля"};

        public static StringResource MillInspection_FromLabel = new StringResource { 
            Id = "MillInspection_FromLabel", 
            Description = "Настройка контрольных опрераций завода. Надпись нижней границы значения"};

        public static StringResource MillInspection_ToLabel = new StringResource { 
            Id = "MillInspection_ToLabel", 
            Description = "Настройка контрольных опрераций завода. Надпись верхней границы значения"};

        public static StringResource MillInspection_FrequencyLabel = new StringResource { 
            Id = "MillInspection_FrequencyLabel", 
            Description = "Настройка контрольных опрераций завода. Надпись частоты"};

        public static StringResource MillInspection_FrequencyMeasureLabel = new StringResource { 
            Id = "MillInspection_FrequencyMeasureLabel", 
            Description = "Настройка контрольных опрераций завода. Надпись единицы измерения частоты"};

        public static StringResource MillInspection_RangeControlValueGroup = new StringResource { 
            Id = "MillInspection_RangeControlValueGroup", 
            Description = "Настройка контрольных опрераций завода. Надпись панели контрольного значения диапазон"};

        public static StringResource MillInspection_BoolControlValueGroup = new StringResource { 
            Id = "MillInspection_BoolControlValueGroup", 
            Description = "Настройка контрольных опрераций завода. Надпись панели булевого контрольного значения"};

        public static StringResource MillInspection_FrequencyGroup = new StringResource { 
            Id = "MillInspection_FrequencyGroup", 
            Description = "Настройка контрольных опрераций завода. Надпись панели периодической частоты"};

        public static StringResource MillInspection_RepeatedOperationsLabel = new StringResource
        {
            Id = "MillInspection_RepeatedOperationsLabel",
            Description = "Настройка контрольных опрераций завода. Надпись повторяемых операций"
        };

        public static StringResource MillInspection_CodeGridColumn = new StringResource
        {
            Id = "MillInspection_CodeGridColumn",
            Description = "Настройка контрольных опрераций завода. Надпись колонки кода"
        };

        public static StringResource MillInspection_NameGridColumn = new StringResource
        {
            Id = "MillInspection_NameGridColumn",
            Description = "Настройка контрольных опрераций завода. Надпись колонки названия"
        };

        public static StringResource MillInspection_OperationFrequencyGroup = new StringResource
        {
            Id = "MillInspection_OperationFrequencyGroup",
            Description = "Настройка контрольных опрераций завода. Надпись группы частоты выполнения операции"
        };

        public static StringResource MillInspection_FrequencyTypeLayout = new StringResource
        {
            Id = "MillInspection_FrequencyTypeLayout",
            Description = "Настройка контрольных опрераций завода. Надпись типа частоты"
        };

        public static StringResource MillInspection_SelectiveFrequencyGroup = new StringResource
        {
            Id = "MillInspection_SelectiveFrequencyGroup",
            Description = "Настройка контрольных опрераций завода. Надпись группы выборочной частоты"
        };

        public static StringResource MillInspection_PercentOfSelectLayout = new StringResource
        {
            Id = "MillInspection_PercentOfSelectLayout",
            Description = "Настройка контрольных опрераций завода. Надпись процента проверяемых труб"
        };

        public static StringResource InspectionFrequencyType_Required = new StringResource
        {
            Id = "InspectionFrequencyType_Required",
            Description = "Тип частоты контрольной операции. Обязательная"
        };

        public static StringResource InspectionFrequencyType_Recurring = new StringResource
        {
            Id = "InspectionFrequencyType_Recurring",
            Description = "Тип частоты контрольной операции. Периодичная"
        };

        public static StringResource InspectionFrequencyType_Selective = new StringResource
        {
            Id = "InspectionFrequencyType_Selective",
            Description = "Тип частоты контрольной операции. Выборочная"
        };

        public static StringResource MillInspection_BtnAdd = new StringResource
        {
            Id = "MillInspection_BtnAdd",
            Description = "Добавить"
        };
        public static StringResource MillInspection_BtnRemove = new StringResource
        {
            Id = "MillInspection_BtnRemove",
            Description = "Удалить"
        }; 

        
        #endregion

        #region --- PartInspectionXtraForm ---
        public static StringResource PartInspection_SearchNumberLabel = 
            new StringResource { 
                Id = "PartInspection_SearchNumberLabel", 
                Description = "Входной контроль элемента. Надпись искомого номера"};

        public static StringResource PartInspection_ElementNumberLabel = new StringResource { 
            Id = "PartInspection_ElementNumberLabel", 
            Description = "Входной контроль элемента. Надпись номера элемента"};

        public static StringResource PartInspection_ElementTypeLabel = new StringResource { 
            Id = "PartInspection_ElementTypeLabel", 
            Description = "Входной контроль элемента. Надпись типа элемента"};

        public static StringResource PartInspection_SearchButton = new StringResource { 
            Id = "PartInspection_SearchButton", 
            Description = "Входной контроль элемента. Надпись кнопки поиска"};

        public static StringResource PartInspection_SaveButton = new StringResource { 
            Id = "PartInspection_SaveButton", 
            Description = "Входной контроль элемента. Надпись кнопки сохранения"};

        public static StringResource PartInspection_SaveAndClearButton = new StringResource { 
            Id = "PartInspection_SaveAndClearButton", 
            Description = "Входной контроль элемента. Надпись кнопки сохранения и очистки"};

        public static StringResource PartInspection_DateColumnHeader = new StringResource { 
            Id = "PartInspection_DateColumnHeader", 
            Description = "Входной контроль элемента. Надпись колонки даты"};

        public static StringResource PartInspection_ResultColumnHeader = new StringResource { 
            Id = "PartInspection_ResultColumnHeader", 
            Description = "Входной контроль элемента. Надпись колонки результата"};

        public static StringResource PartInspection_InspectorColumnHeader = new StringResource {
            Id = "PartInspection_InspectorColumnHeader", 
            Description = "Входной контроль элемента. Надпись колонки инспектора"};

        public static StringResource PartInspection_ReasonColumnHeader = new StringResource { 
            Id = "PartInspection_ReasonColumnHeader", 
            Description = "Входной контроль элемента. Надпись колонки причины"};

        public static StringResource PartInspection_OrderColumnHeader = new StringResource
        {
            Id = "PartInspection_OrderColumnHeader",
            Description = "Входной контроль элемента. Надпись колонки порядок"
        };

        public static StringResource PartInspection_SearchGroup = new StringResource { 
            Id = "PartInspection_SearchGroup", 
            Description = "Входной контроль элемента. Надпись панели поиска"};

        public static StringResource PartInspection_IncomingInspectionGroup = new StringResource { 
            Id = "PartInspection_IncomingInspectionGroup", 
            Description = "Входной контроль элемента. Надпись инспекций"};

        public static StringResource Message_UnknownComponentType = new StringResource
        {
            Id = "Message_UnknownComponentType",
            Description = "Сообщение: Неизвестный тип компонента"
        };

        #endregion

        #region---NewEdit Pipe---

        public static StringResource PurchaseOrder_Title = new StringResource
        {
            Id = "PurchaseOrder_Title",
            Description = "Инспекция трубы"
        };
        public static StringResource InspectionAddEdit_Title = new StringResource
        {
            Id = "InspectionAddEdit_Title",
            Description = "Инспекция трубы"
        };

        public static StringResource Mask_Label = new StringResource
        {
            Id = "Mask_Label",
            Description = "Правила задания формата трубы: Правила задания формата : # - цифра, @ - буква, % - цифра или буква, ? - любой печатный символ, все остальные символы принимаются как есть"
        };

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
            Description = "Труба. Толщина листа, мм"
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
            Description = "Труба. Диаметр по типоразмеру,мм"
        };
        public static StringResource NewEditPipe_TypeSizeThicknessLabel = new StringResource
        {
            Id = "NewEditPipe_TypeSizeThicknessLabel",
            Description = "Труба. Толщина по типоразмеру, мм"
        };
        public static StringResource NewEditPipe_ReleaseNoteNumber_Label = new StringResource
        {
            Id = "NewEditPipe_ReleaseNoteNumber_Label",
            Description = "Труба. Номер разрешения на отгрузку"
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
        public static StringResource NewEditPipe_ReleaseNoteDate_Label = new StringResource
        {
            Id = "NewEditPipe_ReleaseNoteDate_Label",
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

        public static StringResource MillPipe_CoatInternal = new StringResource
        {
            Id = "MillPipe_CoatInternal",
            Description = "Труба, тип покрытия: Внутреннее"
        };

        public static StringResource MillPipe_CoatExternal = new StringResource
        {
            Id = "MillPipe_CoatExternal",
            Description = "Труба, тип покрытия: Внешнее"
        };

        public static StringResource MillPipe_PipeSizeChangeHeader = new StringResource
        {
            Id = "MillPipe_PipeSizeChangeHeader",
            Description = "Заголовок сообщения - подтверждения об изменении типоразмера трубы"
        };

        public static StringResource MillPipe_ChangeTypesizeConfirmation = new StringResource
        {
            Id = "MillPipe_ChangeTypesizeConfirmation",
            Description = "Вопрос о подтверждении изменения типоразмера: Вы действительно хотите изменить типоразмер трубы? Все введённые результаты контрольных операций будут удалены и необходимо их ввести заново"
        };

        public static StringResource MillPipe_NotAllowedToChangeTypesize = new StringResource
        {
            Id = "MillPipe_NotAllowedToChangeTypesize",
            Description = "Сообщение о невозможности изменить типоразмер: Нельзя изменить типоразмер для трубы, у которой уже есть данные по контрольным операциям. Если типоразмер ошибочен, деактивируйте эту трубу и создайте новую с таким же номером и правильным типоразмером."
        };

        public static StringResource MillPipe_ValueDoesNotMatchMask = new StringResource
        {
            Id = "MillPipe_ValueDoesNotMatchMask",
            Description = "Сообщение об ошибке: Значение не соответствует маске"
        };

        public static StringResource MillPipe_NewHeatQuestion = new StringResource
        {
            Id = "MillPipe_NewHeatQuestion",
            Description = "Вопрос о создании новой плавки: Создать плавку {0}?"
        };

        public static StringResource MillPipe_NewHeadQuestionHeader = new StringResource
        {
            Id = "MillPipe_NewHeadQuestionHeader",
            Description = "Заголовок вопроса о создании новой плавки: Новая плавка"
        };

        public static StringResource MillPipe_NewPurchaseOrderQuestion = new StringResource
        {
            Id = "MillPipe_NewPurchaseOrderQuestion",
            Description = "Вопрос о создании нового наряд-заказа: Создать наряд-заказ {0}?"
        };

        public static StringResource MillPipe_NewPurchaseOrderQuestionHeader = new StringResource
        {
            Id = "MillPipe_NewPurchaseOrderQuestionHeader",
            Description = "Заголовок вопроса о создании нового наряд-заказа: Новый наряд-заказ"
        };

        public static StringResource MillPipe_DeactivatePipeQuestion = new StringResource
        {
            Id = "MillPipe_DeactivatePipeQuestion",
            Description = "Вопрос о деактивации: Данное действие приведет к деактивации трубы. Параметры трубы станут невозможны для редактирования. Деактивировать трубу?"
        };

        public static StringResource MillPipe_DeactivatePipeQuestionHeader = new StringResource
        {
            Id = "MillPipe_DeactivatePipeQuestionHeader",
            Description = "Заголовок вопроса о деактивации: Деактивация трубы"
        };

        public static StringResource MillPipe_DeactivatePipeShippedError = new StringResource
        {
            Id = "MillPipe_DeactivatePipeShippedError",
            Description = "Сообщение: Труба находится в вагоне. Для деактивации необходимо удалить трубу из вагона."
        };

        public static StringResource MillPipe_DeactivatePipeShippedErrorHeader = new StringResource
        {
            Id = "MillPipe_DeactivatePipeShippedErrorHeader",
            Description = "Заголовок сообщения: Деактивация трубы в вагоне невозможна"
        };

        public static StringResource MillPipe_DeactivatePipeInRailcarError = new StringResource
        {
            Id = "MillPipe_DeactivatePipeInRailcarError",
            Description = "Сообщение: Невозможно деактивировать отгруженную трубу."
        };

        public static StringResource MillPipe_DeactivatePipeInRailcarErrorHeader = new StringResource
        {
            Id = "MillPipe_DeactivatePipeInRailcarErrorHeader",
            Description = "Заголовок сообщения: Труба отгружена"
        };

        public static StringResource MillPipe_ExistingNumberError = new StringResource
        {
            Id = "MillPipe_ExistingNumberError",
            Description = "Сообщение об ошибке: Уже существует труба с номером: "
        };

        public static StringResource MillPipe_ExistingNumberErrorHeader = new StringResource
        {
            Id = "MillPipe_ExistingNumberErrorHeader",
            Description = "Заголовок сообщения о дублировании трубы: Дублирование номера трубы"
        };

        public static StringResource MillPipe_PipeSaved = new StringResource
        {
            Id = "MillPipe_PipeSaved",
            Description = "Сообщение об успешном сохранении трубы: Труба успешно сохранена в базе. Труба  # "
        };

        public static StringResource MillPipe_PipeSavedHeader = new StringResource
        {
            Id = "MillPipe_PipeSavedHeader",
            Description = "Заголовок сообщения об успешном сохранении трубы: Сохранение трубы"
        };

        public static StringResource MillPipe_ErrorEditingInspectionOperationPipeInRailcar = new StringResource
        {
            Id = "MillPipe_ErrorEditingInspectionOperationPipeInRailcar",
            Description = "Сообщение: Нельзя добавить неуспешную контрольную операцию для трубы, которая находится в вагоне. Для этого необходимо удалить данную трубу из вагона. "
        };

        public static StringResource MillPipe_ErrorEmptyOrFutureDate = new StringResource
        {
            Id = "MillPipe_ErrorEmptyOrFutureDate",
            Description = "Сообщение об ошибке даты: Дата не может быть пустой или будущей"
        };

        public static StringResource Pipe_Deactivated = new StringResource
        {
            Id = "Pipe_Deactivated",
            Description = "Труба деактивирована. Труба #"
        };

        public static StringResource Pipe_DeactivatedHeader = new StringResource
        {
            Id = "Pipe_DeactivatedHeader",
            Description = "Деактивация трубы"
        };

        public static StringResource MillPipeNewEditXtraForm_Title = new StringResource
        {
            Id = "MillPipeNewEditXtraForm_Title",
            Description = "Труба"
        };

        #endregion

        #region---Search pipe---

        public static StringResource SearchPipe_Title = new StringResource
        {
            Id = "SearchPipe_Title",
            Description = "Поиск труб"
        };

        public static StringResource SearchPipe_MillStatusUndefined = new StringResource
        {
            Id = "SearchPipe_MillStatusUndefined",
            Description = "Не определен"
        };
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
        public static StringResource SearchPipe_ReadyToShip = new StringResource
        {
            Id = "SearchPipe_ReadyToShip",
            Description = "Готова к отгрузке"
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

        #region---Release Note NewEdit---

        public static StringResource ReleaseNoteNewEdit_Title = new StringResource
        {
            Id = "ReleaseNoteNewEdit_Title",
            Description = "Разрешение на отгрузку"
        };
        public static StringResource ReleaseNoteNewEdit_ReleaseNumberLabel = new StringResource
        {
            Id = "ReleaseNoteNewEdit_ReleaseNumberLabel",
            Description = "Разрешение на отгрузку. Номер разрешения"
        };
        public static StringResource ReleaseNoteNewEdit_ReleaseDateLabel = new StringResource
        {
            Id = "ReleaseNoteNewEdit_ReleaseDateLabel",
            Description = "Разрешение на отгрузку. Дата разрешения"
        };
        public static StringResource ReleaseNoteNewEdit_RailcarNumberLabel = new StringResource
        {
            Id = "ReleaseNoteNewEdit_RailcarNumberLabel",
            Description = "Разрешение на отгрузку. Номер вагона"
        };
        public static StringResource ReleaseNoteNewEdit_CertificateLabel = new StringResource
        {
            Id = "ReleaseNoteNewEdit_CertificateLabel",
            Description = "Разрешение на отгрузку. Сертификат вагона"
        };
        public static StringResource ReleaseNoteNewEdit_DestinationLabel = new StringResource
        {
            Id = "ReleaseNoteNewEdit_DestinationLabel",
            Description = "Разрешение на отгрузку. Получатель"
        };
        public static StringResource ReleaseNoteNewEdit_AddPipeButton = new StringResource
        {
            Id = "ReleaseNoteNewEdit_AddPipeButton",
            Description = "Разрешение на отгрузку. Кнопка добавления трубы"
        };
        public static StringResource ReleaseNoteNewEdit_RemovePipeButton = new StringResource
        {
            Id = "ReleaseNoteNewEdit_RemovePipeButton",
            Description = "Разрешение на отгрузку. Кнопка удаления трубы"
        };
        public static StringResource ReleaseNoteNewEdit_AttachmentsButton = new StringResource
        {
            Id = "ReleaseNoteNewEdit_AttachmentsButton",
            Description = "Разрешение на отгрузку. Кнопка добавления файлов"
        };
        public static StringResource ReleaseNoteNewEdit_ShipButton = new StringResource
        {
            Id = "ReleaseNoteNewEdit_ShipButton",
            Description = "Разрешение на отгрузку. Кнопка отгрузки"
        };
        public static StringResource ReleaseNoteNewEdit_UnshipButton = new StringResource
        {
            Id = "ReleaseNoteNewEdit_UnshipButton",
            Description = "Разрешение на отгрузку. Кнопка отклонения отгрузки"
        };
        public static StringResource ReleaseNoteNewEdit_SaveButton = new StringResource
        {
            Id = "ReleaseNoteNewEdit_SaveButton",
            Description = "Разрешение на отгрузку. Кнопка сохранить"
        };
        public static StringResource ReleaseNoteNewEdit_PipeNumberColumn = new StringResource
        {
            Id = "ReleaseNoteNewEdit_PipeNumberColumn",
            Description = "Разрешение на отгрузку. Столбец номер трубы"
        };
        public static StringResource ReleaseNoteNewEdit_PipeTypeSizeColumn = new StringResource
        {
            Id = "ReleaseNoteNewEdit_PipeTypeSizeColumn",
            Description = "Разрешение на отгрузку. Столбец типоразмер"
        };
        public static StringResource ReleaseNoteNewEdit_PipeStatusColumn = new StringResource
        {
            Id = "ReleaseNoteNewEdit_PipeStatusColumn",
            Description = "Разрешение на отгрузку. Столбец статус трубы"
        };

        public static StringResource ReleaseNoteNewEdit_RailcarNumberColumn = new StringResource
        {
            Id = "ReleaseNoteNewEdit_RailcarNumberColumn",
            Description = "Разрешение на отгрузку. Столбец номер вагона"
        };

        public static StringResource ReleaseNoteNewEdit_RailcarCertificateColumn = new StringResource
        {
            Id = "ReleaseNoteNewEdit_RailcarCertificateColumn",
            Description = "Разрешение на отгрузку. Столбец сертификат вагона"
        };

        public static StringResource ReleaseNoteNewEdit_RailcarDestinationColumn = new StringResource
        {
            Id = "ReleaseNoteNewEdit_RailcarDestinationColumn",
            Description = "Разрешение на отгрузку. Столбец получатель вагона"
        };

        public static StringResource ReleaseNoteNewEdit_ErrorAddingPipeAlreadyInRailcar = new StringResource
        {
            Id = "ReleaseNoteNewEdit_ErrorAddingPipeAlreadyInRailcar",
            Description = "Сообщение о том, что труба уже в вагоне: Данная труба находится в вагоне #"
        };

        public static StringResource ReleaseNoteNewEdit_UnshipFirst = new StringResource
        {
            Id = "ReleaseNoteNewEdit_UnshipFirst",
            Description = "Сообщение: сначала расформируйте вагон/разрешение на отгрузку"
        };

        public static StringResource ReleaseNoteNewEdit_NotShipped = new StringResource
        {
            Id = "ReleaseNoteNewEdit_NotShipped",
            Description = "Сообщение об ошибке попытки отмены отгрузки: Отмена отгрузки не актуальна, вагоны сейчас не отгружены"
        };

        public static StringResource ReleaseNoteNewEdit_Unshipped = new StringResource
        {
            Id = "ReleaseNoteNewEdit_Unshipped",
            Description = "Сообщение об успешной отмене отгрузки: Отгрузка отменена. Дата отгрузки аннулирована. Трубы перемещены на склад."
        };

        public static StringResource ReleaseNoteNewEdit_Shipped = new StringResource
        {
            Id = "ReleaseNoteNewEdit_Shipped",
            Description = "Сообщение об успешной отгрузке: Отгрузка произошла успешно."
        };

        public static StringResource ReleaseNoteNewEdit_PipesAbsent = new StringResource
        {
            Id = "ReleaseNoteNewEdit_PipesAbsent",
            Description = "Сообщение об ошибке отгрузки: Отправка без труб невозможна."
        };

        public static StringResource ReleaseNoteNewEdit_DifferentTypeSizeInRailcar = new StringResource
        {
            Id = "ReleaseNoteNewEdit_DifferentTypeSizeInRailcar",
            Description = "Сообщение об ошибке отгрузки: Все трубы в в вагоне должны быть одного типоразмера."
        };

        public static StringResource ReleaseNoteNewEdit_MissingReleaseNoteNumber = new StringResource
        {
            Id = "ReleaseNoteNewEdit_MissingReleaseNoteNumber",
            Description = "Сообщение об ошибке: Введите номер разрешения на отгрузку."
        };

        public static StringResource ReleaseNoteNewEdit_MissingRailcar = new StringResource
        {
            Id = "ReleaseNoteNewEdit_MissingRailcar",
            Description = "Сообщение об ошибке: Укажите вагон."
        };

        public static StringResource ReleaseNoteNewEdit_SaveSuccess = new StringResource
        {
            Id = "ReleaseNoteNewEdit_SaveSuccess",
            Description = "Сообщение: Данные разрешения на отгрузку сохранены"
        };

        public static StringResource ReleaseNoteNewEdit_SaveSuccessHeader = new StringResource
        {
            Id = "ReleaseNoteNewEdit_SaveSuccessHeader",
            Description = "Заголовок сообщения об успешном сохранении: Сохранение успешно"
        };

        public static StringResource ReleaseNoteNewEdit_ShippedStatus = new StringResource
        {
            Id = "ReleaseNoteNewEdit_ShippedStatus",
            Description = "Статус разрешения на отгрузку: отгружено"
        };

        public static StringResource ReleaseNoteNewEdit_PendingStatus = new StringResource
        {
            Id = "ReleaseNoteNewEdit_PendingStatus",
            Description = "Статус разрешения на отгрузку: формируется"
        };

        public static StringResource ReleaseNoteNewEdit_RailcarLayoutControlGroup = new StringResource
        {
            Id = "ReleaseNoteNewEdit_RailcarLayoutControlGroup",
            Description = "Разрешение на отгрузку. Группа вагона"
        };

        public static StringResource ReleaseNoteNewEdit_AddPipeLayoutGroup = new StringResource
        {
            Id = "ReleaseNoteNewEdit_AddPipeLayoutGroup",
            Description = "Разрешение на отгрузку. Группа добавления трубы"
        };

        public static StringResource ReleaseNoteNewEdit_PipesListLayoutGroup = new StringResource
        {
            Id = "ReleaseNoteNewEdit_PipesListLayoutGroup",
            Description = "Разрешение на отгрузку. Группа труб"
        };

        public static StringResource ReleaseNoteNewEdit_PipeNumberLayout = new StringResource
        {
            Id = "ReleaseNoteNewEdit_PipeNumberLayout",
            Description = "Разрешение на отгрузку. Надпись номера трубы"
        };

        public static StringResource ReleaseNoteNewEdit_ReleaseNoteLayoutGroup = new StringResource
        {
            Id = "ReleaseNoteNewEdit_ReleaseNoteLayoutGroup",
            Description = "Разрешение на отгрузку. Надпись параметров разрешения"
        };

        public static StringResource ReleaseNoteNewEdit_StatusLayout= new StringResource
        {
            Id = "ReleaseNoteNewEdit_StatusLayout",
            Description = "Разрешение на отгрузку. Надпись статуса"
        };

        #endregion //--- Railcar NewEdit ---


        #region---Railcar Search---
        //ReleaseSearch_PipeInReleaseNoteLabel
        public static StringResource ReleaseSearch_Title = new StringResource
        {
            Id = "ReleaseSearch_Title",
            Description = "Поиск разрешений на отгрузку"
        };
        public static StringResource ReleaseSearch_PipeInReleaseNoteLabel = new StringResource
        {
            Id = "ReleaseSearch_PipeInReleaseNoteLabel",
            Description = "Поиск разрешений на отгрузку. Номер трубы"
        };
        public static StringResource ReleaseSearch_NumberLabel = new StringResource
        {
            Id = "ReleaseSearch_NumberLabel",
            Description = "Поиск разрешений на отгрузку. Номер разрешения"
        };

        public static StringResource ReleaseSearch_StartDateLabel = new StringResource
        {
            Id = "ReleaseSearch_StartDateLabel",
            Description = "Поиск разрешений на отгрузку. Начальная дата"
        };
        public static StringResource ReleaseSearch_EndDateLabel = new StringResource
        {
            Id = "ReleaseSearch_EndDateLabel",
            Description = "Поиск разрешений на отгрузку. Конечная дата"
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
        public static StringResource ReleaseSearch_ReleaseStatusColumnHeader = new StringResource
        {
            Id = "ReleaseSearch_ReleaseStatusColumnHeader",
            Description = "Поиск разрешений на отгрузку. Столбец статуса разрешения"
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
        public static StringResource FirstSetup_PipeNumberFormatLabel = new StringResource
        {
            Id = "FirstSetup_PipeNumberFormatLabel",
            Description = "Начальные установки. Формат номера трубы"
        };
        public static StringResource FirstSetup_ProjectGroup = new StringResource
        {
            Id = "FirstSetup_ProjectGroup",
            Description = "Начальные установки.Надпись группы проекта"
        };

        public static StringResource FirstSetup_MainAdministratorGroup = new StringResource
        {
            Id = "FirstSetup_MainAdministratorGroup",
            Description = "Начальные установки.Надпись главного администратора"
        };

        public static StringResource FirstSetup_FormHeader = new StringResource
        {
            Id = "FirstSetup_FormHeader",
            Description = "Начальные установки.Надпись окна: первичные настройки"
        };
        #endregion

        #region Heat

        public static StringResource Heat_Title = new StringResource
        {
            Id = "Heat_Title",
            Description = "Плавка"
        };
        public static StringResource HeatNumberXtraForm_Title = new StringResource
        {
            Id = "HeatNumberXtraForm_Title",
            Description = "Добавление плавки"
        };
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

        public static StringResource Inspection_ExistingCodeError = new StringResource
        {
            Id = "Inspection_ExistingCodeError",
            Description = "Сообщение об ошибке: Уже существует операция с номером:"
        };

        public static StringResource Inspection_ExistingCodeErrorHeader = new StringResource
        {
            Id = "Inspection_ExistingCodeErrorHeader",
            Description = "Заголовок сообщения о дублировании кода: Дублирование кода контрольной операции"
        };

        #endregion

        #region --- Notification ---

        public static StringResource Notification_PostponeConflict_Critical = new StringResource
        {
            Id = "Notification_PostponeConflict_Critical",
            Description = "Сообщение об отложеном конфликте"
        };

        public static StringResource Notification_PostponeConflict_Warning = new StringResource
        {
            Id = "Notification_PostponeConflict_Warning",
            Description = "Сообщение об отложеном конфликте"
        };
        public static StringResource Notification_InformationForPostponeConflict = new StringResource
        {
            Id = "Notification_InformationForPostponeConflict",
            Description = "Информация для отложенного конфликта"
        };

        public static StringResource Notification_InformationForSelectiveOperation = new StringResource
        {
            Id = "Notification_InformationForSelectiveOperation",
            Description = "Информация для выборочной контрольной операции "
        };
        public static StringResource Notification_InformationForNotRequiredOperation = new StringResource
        {
            Id = "Notification_InformationForNotRequiredOperation",
            Description = "Информация для периодичной контрольной операции "
        };

        public static StringResource Notification_InformationForExpiredCertificate = new StringResource
        {
            Id = "Notification_InformationForExpiredCertificate",
            Description = "Информация для просроченного сертификата"
        };

        public static StringResource Notification_InformationForDublicatePipeNumber = new StringResource
        {
            Id = "Notification_InformationForDublicatePipeNumber",
            Description = "Информация для дубликата номера трубы "
        };

        public static StringResource Notification_InformationForDuplicateLogin = new StringResource
        {
            Id = "Notification_InformationForDuplicateLogin",
            Description = "Информация для дубликта логина"
        };

        public static StringResource Notification_SelectiveInspectionOperation_Critical = new StringResource
        {
            Id = "Notification_SelectiveInspectionOperation_Critical",
            Description = "Сообщение о необязательной контрольной операции: Просрочено выполнение контрольной операции "
        };

        public static StringResource Notification_SelectiveInspectionOperation_Warning = new StringResource
        {
            Id = "Notification_SelectiveInspectionOperation_Warning",
            Description = "Сообщение о необязательной контрольной операции: Приближается срок выполнения контрольной операции "
        };
        
        public static StringResource Notification_NotRequiredInspectionOperation_Critical = new StringResource
        {
            Id = "Notification_NotRequiredInspectionOperation_Critical",
            Description = "Сообщение о необязательной контрольной операции: Просрочено выполнение контрольной операции "
        };

        public static StringResource Notification_NotRequiredInspectionOperation_Warning = new StringResource
        {
            Id = "Notification_NotRequiredInspectionOperation_Warning",
            Description = "Сообщение о необязательной контрольной операции: Приближается срок выполнения контрольной операции "
        };

        public static StringResource NotificationXtraForm_LayoutControlItemNotification = new StringResource
        {
            Id = "NotificationXtraForm_LayoutControlItemNotification",
            Description = "Сообщения"
        };

        public static StringResource NotificationXtraForm_ColDate = new StringResource
        {
            Id = "NotificationXtraForm_ColDate",
            Description = "Данные"
        };

        public static StringResource NotificationXtraForm_ColNotification = new StringResource
        {
            Id = "NotificationXtraForm_ColNotification",
            Description = "Сообщение"
        };

        public static StringResource NotificationXtraForm_ColName = new StringResource
        {
            Id = "NotificationXtraForm_ColName",
            Description = "Регистратор"
        };
        
        
        public static StringResource NotificationXtraForm_Title = new StringResource
        {
            Id = "NotificationXtraForm_Title",
            Description = "Окно уведомлений"
        };
        public static StringResource Notification_DublicatePipeNumber_Critical = new StringResource
        {
            Id = "Notification_DublicatePipeNumber_Critical",
            Description = "Сообщение о дублировании номеров труб: Дубликат номера труб"
        };

        public static StringResource Notification_ExpiredInspectorCertificate_Critical = new StringResource
        {
            Id = "Notification_ExpiredInspectorCertificate_Critical",
            Description = "Сообщение об окончании срока: Сертификат просрочен"
        };

        public static StringResource Notification_ExpiredInspectorCertificate_Warning = new StringResource
        {
            Id = "Notification_ExpiredInspectorCertificate_Warning",
            Description = "Сообщение о приближении окончания срока: Заканчивается срок сертификата"
        };

        public static StringResource Notification_ExpiredWelderCertificate_Critical = new StringResource
        {
            Id = "Notification_ExpiredWelderCertificate_Critical",
            Description = "Сообщение об окончании срока: Сертификат просрочен"
        };

        public static StringResource Notification_ExpiredWelderCertificate_Warning = new StringResource
        {
            Id = "Notification_ExpiredWelderCertificate_Warning",
            Description = "Сообщение об окончании срока: Заканчивается срок сертификата"
        };

        public static StringResource Notification_DuplicateLogin_Critical = new StringResource
        {
            Id = "Notification_DuplicateLogin_Critical",
            Description = "Сообщение о дублировании логинов"
        };

        public static StringResource Notification_DuplicatePipeNumber_Critical = new StringResource
        {
            Id = "Notification_DuplicatePipeNumber_Critical",
            Description = "Сообщение о дублировании"
        };

        public static StringResource Notification_Error_Db_Header = new StringResource
        {
            Id = "Notification_Error_Db_Header",
            Description = "Заголовок ошибки базы данных"
        };

        public static StringResource Notification_Error_Db_Message = new StringResource
        {
            Id = "Notification_Error_Db_Message",
            Description = "Сообщение об ошибке базы данных"
        };
        #endregion //--- Notification ---

        #region --- JointSelectDialog ---
        public static StringResource JointSelectDialog_Header = new StringResource
        {
            Id = "JointSelectDialog_Header",
            Description = "Заголовок: выбор стыка"
        };

        public static StringResource JointSelectDialog_CancelButton = new StringResource
        {
            Id = "JointSelectDialog_CancelButton",
            Description = "Отменить"
        };

        public static StringResource JointSelectDialog_EditButton = new StringResource
        {
            Id = "JointSelectDialog_EditButton",
            Description = "Редактировать"
        };

        public static StringResource JointSelectDialog_ResultsLayout = new StringResource
        {
            Id = "JointSelectDialog_ResultsLayout",
            Description = "Результаты поиска"
        };

        public static StringResource JointSelectDialog_NumberGridColumn = new StringResource
        {
            Id = "JointSelectDialog_NumberGridColumn",
            Description = "Колонка номера стыка"
        };
        #endregion
    }
} 
