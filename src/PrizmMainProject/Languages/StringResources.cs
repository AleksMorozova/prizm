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

    }
}
