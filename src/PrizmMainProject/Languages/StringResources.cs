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


        #region --- NewEdit Pipe ---
        public static StringResource NewEditPipe_PipeNumberLabel = new StringResource { Id = "NewEditPipe_PipeNumberLabel", Description = "Труба. Номер трубы" };
        public static StringResource NewEditPipe_PipeSizeLabel = new StringResource { Id = "NewEditPipe_PipeSizeLabel", Description = "Труба. Типоразмер" };
        public static StringResource NewEditPipe_HeatsComboLabel = new StringResource { Id = "NewEditPipe_HeatsComboLabel", Description = "Труба. Плавка" };
        public static StringResource NewEditPipe_PurchaseOrdersComboLabel = new StringResource { Id = "NewEditPipe_PurchaseOrdersComboLabel", Description = "Труба. Номер наряд-заказа" };
        public static StringResource NewEditPipe_PurchaseOrederDateLabel = new StringResource { Id = "NewEditPipe_PurchaseOrederDateLabel", Description = "Труба. Дата наряд-заказа" };
        public static StringResource NewEditPipe_PipeCreationLabel = new StringResource { Id = "NewEditPipe_PipeCreationLabel", Description = "Труба. Дата создания трубы" };
        public static StringResource NewEditPipe_PipeStatusLabel = new StringResource { Id = "NewEditPipe_PipeStatusLabel", Description = "Труба. Статус трубы" };
        public static StringResource NewEditPipe_PlateNumberLabel = new StringResource { Id = "NewEditPipe_PlateNumberLabel", Description = "Труба. Номер листа" };
        public static StringResource NewEditPipe_PlateThicknessLabel = new StringResource { Id = "NewEditPipe_PlateThicknessLabel", Description = "Труба. Толщина листа" };
        public static StringResource NewEditPipe_PlateManufacturerLabel = new StringResource { Id = "NewEditPipe_PlateManufacturerLabel", Description = "Труба. Производитель листа" };
        public static StringResource NewEditPipe_PlateSteelGradeLabel = new StringResource { Id = "NewEditPipe_PlateSteelGradeLabel", Description = "Труба. Марка стали" };
        public static StringResource NewEditPipe_PipeLengthLabel = new StringResource { Id = "NewEditPipe_PipeLengthLabel", Description = "Труба. Длина трубы" };
        public static StringResource NewEditPipe_PipeWeightLabel = new StringResource { Id = "NewEditPipe_PipeWeightLabel", Description = "Труба. Вес трубы" };
        public static StringResource NewEditPipe_TypeSizeLengthLabel = new StringResource { Id = "NewEditPipe_TypeSizeLengthLabel", Description = "Труба. Длина по типоразмеру" };
        public static StringResource NewEditPipe_RailcarNumber_Label = new StringResource { Id = "NewEditPipe_RailcarNumber_Label", Description = "Труба. Номер вагона" };
        public static StringResource NewEditPipe_RailcarCertificate_Label = new StringResource { Id = "NewEditPipe_RailcarCertificate_Label", Description = "Труба. Сертификат вагона" };
        public static StringResource NewEditPipe_RailcarShippedDate_Label = new StringResource { Id = "NewEditPipe_RailcarShippedDate_Label", Description = "Труба. Дата отправки вагона" };
        public static StringResource NewEditPipe_RailcarDestination_Label = new StringResource { Id = "NewEditPipe_RailcarDestination_Label", Description = "Труба. Получатель" };
        public static StringResource NewEditPipe_AttachmentsButton = new StringResource { Id = "NewEditPipe_AttachmentsButton", Description = "Труба. Кнопка добавления файлов" };
        public static StringResource NewEditPipe_DeactivatedCheckBox = new StringResource { Id = "NewEditPipe_DeactivatedCheckBox", Description = "Труба. Деактивация" };
        public static StringResource NewEditPipe_SaveButton = new StringResource { Id = "NewEditPipe_SaveButton", Description = "Труба. Кнопка сохранить" };
        public static StringResource NewEditPipe_SaveAndNewButton = new StringResource { Id = "NewEditPipe_SaveAndNewButton", Description = "Труба. Кнопка сохранить и создать" };
        public static StringResource NewEditPipe_InspectionsAddButton = new StringResource { Id = "NewEditPipe_InspectionsAddButton", Description = "Труба. Кнопка добавления контрольных операций" };
        public static StringResource NewEditPipe_InspectionsEditsButton = new StringResource { Id = "NewEditPipe_InspectionsEditsButton", Description = "Труба. Кнопка редактирования контрольных операций" };
        public static StringResource NewEditPipe_WeldersColumnHeader = new StringResource { Id = "NewEditPipe_WeldersColumnHeader", Description = "Труба. Столбец сварщики" };
        public static StringResource NewEditPipe_WeldingDateColumnHeader = new StringResource { Id = "NewEditPipe_WeldingDateColumnHeader", Description = "Труба. Столбец дата сварки" };
        public static StringResource NewEditPipe_CoatingDateColumnHeader = new StringResource { Id = "NewEditPipe_CoatingDateColumnHeader", Description = "Труба. Столбец дата покрытия" };
        public static StringResource NewEditPipe_CoatingTypeColumnHeader = new StringResource { Id = "NewEditPipe_CoatingTypeColumnHeader", Description = "Труба. Столбец тип покрытия" };
        public static StringResource NewEditPipe_InspectionCodeColumnHeader = new StringResource { Id = "NewEditPipe_InspectionCodeColumnHeader", Description = "Труба. Столбец код контрольной операции" };
        public static StringResource NewEditPipe_InspectionNameColumnHeader = new StringResource { Id = "NewEditPipe_InspectionNameColumnHeader", Description = "Труба. Столбец название контрольной операции" };
        public static StringResource NewEditPipe_InspectionCategoryColumnHeader = new StringResource { Id = "NewEditPipe_InspectionCategoryColumnHeader", Description = "Труба. Столбец группа контрольной операции" };
        public static StringResource NewEditPipe_InspectionExpectedResultColumnHeader = new StringResource { Id = "NewEditPipe_InspectionExpectedResultColumnHeader", Description = "Труба. Столбец ожидаемого результата контрольной операции" };
        public static StringResource NewEditPipe_InspectionValueColumnHeader = new StringResource { Id = "NewEditPipe_InspectionValueColumnHeader", Description = "Труба. Столбец значения контрольной операции" };
        public static StringResource NewEditPipe_InspectionResultColumnHeader = new StringResource { Id = "NewEditPipe_InspectionResultColumnHeader", Description = "Труба. Столбец результата контрольной операции" };
        public static StringResource NewEditPipe_InspectionDateColumnHeader = new StringResource { Id = "NewEditPipe_InspectionDateColumnHeader", Description = "Труба. Столбец даты контрольной операции" };
        public static StringResource NewEditPipe_InspectorsCodeColumnHeader = new StringResource { Id = "NewEditPipe_InspectorsCodeColumnHeader", Description = "Труба. Столбец инспекторы" };
        public static StringResource NewEditPipe_PlateGroup = new StringResource { Id = "NewEditPipe_PlateGroup", Description = "Труба. Группа лист" };
        public static StringResource NewEditPipe_FactSizeGroup = new StringResource { Id = "NewEditPipe_FactSizeGroup", Description = "Труба. Группа фактических параметров" };
        public static StringResource NewEditPipe_TypeSizeGroup = new StringResource { Id = "NewEditPipe_TypeSizeGroup", Description = "Труба. Группа параметров типоразмера" };
        public static StringResource NewEditPipe_ShippingGroup = new StringResource { Id = "NewEditPipe_ShippingGroup", Description = "Труба. Группа отправка" };
        public static StringResource NewEditPipe_CoverGroup = new StringResource { Id = "NewEditPipe_CoverGroup", Description = "Труба. Группа покрытие" };
        public static StringResource NewEditPipe_WeldsGroup = new StringResource { Id = "NewEditPipe_WeldsGroup", Description = "Труба. Группа сварка" };
        public static StringResource NewEditPipe_PipeTabGroup = new StringResource { Id = "NewEditPipe_PipeTabGroup", Description = "Труба. Вкладка трубы" };
        public static StringResource NewEditPipe_InspectionsTabGroup = new StringResource { Id = "NewEditPipe_InspectionsTabGroup", Description = "Труба. Вкладка контрольных операций" };
        public static StringResource NewEditPipe_PipeStatusUndefined = new StringResource { Id = "NewEditPipe_PipeStatusUndefined", Description = "Труба. Статус не определен" };
        public static StringResource NewEditPipe_PipeStatusProduced = new StringResource { Id = "NewEditPipe_PipeStatusProduced", Description = "Труба. Статус в производстве" };
        public static StringResource NewEditPipe_PipeStatusStocked = new StringResource { Id = "NewEditPipe_PipeStatusStocked", Description = "Труба. Статус на складе" };
        #endregion

    }
}
