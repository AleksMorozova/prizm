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
            Description = "Active"
        };
                
        public static StringResource JointSearch_ActivityCriteria_StatusUnactive = new StringResource {
            Id = "JointSearch_ActivityCriteria_StatusUnactive",
            Description = "UnActive"
        };
                        
        public static StringResource JointSearch_ActivityCriteria_StatusAll = new StringResource {
            Id = "JointSearch_ActivityCriteria_StatusAll",
            Description = "All"
        };
                   
        public static StringResource JointSearch_JointStatus_Welded = new StringResource {
            Id = "JointSearch_JointStatus_Welded",
            Description = "Welded"
        };
                                        
        public static StringResource JointSearch_JointStatus_Lowered = new StringResource {
            Id = "JointSearch_JointStatus_Lowered",
            Description = "Lowered"
        };
                                             
        public static StringResource JointSearch_JointStatus_Withdrawn = new StringResource {
            Id = "JointSearch_JointStatus_Withdrawn",
            Description = "Withdrawn"
        };        


        #endregion // --- Common

        #region --- Audit ---

        public static StringResource Audit_ElementNumberLabel = new StringResource {
            Id = "Audit_ElementNumberLabel",
            Description = "Аудит. Надпись номера элемента."
        };

        #endregion //--- Audit ---

        #region --- About ---

        public static StringResource AboutForm_TitleLabel = new StringResource {
            Id = "AboutForm_TitleLabel",
            Description = "Текст в окне \"О программе \""
        };

        #endregion // --- About ---

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
    }
} 