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

        //test result types
        public static StringResource TestResultTypeBoolean = new StringResource { 
            Id = "TestResultTypeBoolean", 
            Description = "Тип результата контрольной операции. Логический"};

        public static StringResource TestResultTypeRange = new StringResource { 
            Id = "TestResultTypeRange", 
            Description = "Тип результата контрольной операции. Диапазон"};

        public static StringResource TestResultTypeString = new StringResource { 
            Id = "TestResultTypeString", 
            Description = "Тип результата контрольной операции. Строка"};

        //test control type
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

        #endregion // --- Common

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

        #region --- MillInspectionXtraForm ---
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

        public static StringResource MillInspection_IsRequiredCheckbox = new StringResource { 
            Id = "MillInspection_IsRequiredCheckbox", 
            Description = "Настройка контрольных опрераций завода. Надпись чекбокса Обязательна"};

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
            Description = "Настройка контрольных опрераций завода. Надпись панели частоты"};

        #endregion
    }
}
