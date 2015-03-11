using Moq;
using NUnit.Framework;

using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using Prizm.Main.Forms.Component.NewEdit;
using Prizm.Main.Forms.Joint.NewEdit;
using Prizm.Main.Forms.Joint.Search;
using Prizm.Main.Forms.PipeMill.NewEdit;
using Prizm.Main.Forms.PipeMill.Search;
using Prizm.Main.Forms.ReleaseNote.NewEdit;
using Prizm.Main.Forms.ReleaseNote.Search;
using Prizm.Main.Forms.Reports.Construction;
using Prizm.Main.Forms.Reports.Incoming;
using Prizm.Main.Forms.Reports.Mill;
using Prizm.Main.Forms.Settings;
using Prizm.Main.Forms.Spool;
using Prizm.Main.Forms.Parts.Search;
using Prizm.Main.Forms.Parts.Inspection;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Forms.Audit;
using PrizmMain.Forms.Notifications;
using Prizm.Main.Forms.Reports.Construction.PipeReport;
using Prizm.Main.Forms.Reports.Construction.WeldDateReports;
using Prizm.Main.Forms.Synch;
using Prizm.Main.Forms.MainChildForm.FirstSetupForm;
using Prizm.Main.Forms.PipeMill.Heat;
using Prizm.Main.Forms.PipeMill.Purchase;
using Prizm.Main.Forms.PipeMill;
using Prizm.Main.Forms.Joint;
using Prizm.Main.Forms.ExternalFile;
using Prizm.Main.Forms.Common;
using Prizm.Main.Languages;
using Prizm.Main.Forms.Settings.Inspections;

namespace Prizm.UnitTests
{
    [TestFixture]
    public class MainChildDocumentsTest
    {
        [TestCase(typeof(AppSplashScreen), typeof(ILocalizable))]
        [TestCase(typeof(AppWaitForm), typeof(ILocalizable))]
        public void ImplementsInterface(System.Type type, System.Type interf)
        {
            Assert.IsTrue(type.GetInterfaces().Contains(interf), string.Format("{0} does not implement {1}!", type.Name, interf.Name));
        }


        [TestCase(typeof(MillPipeNewEditXtraForm), typeof(ChildEditableForm))]
        [TestCase(typeof(MillPipeSearchXtraForm), typeof(ChildForm))]
        [TestCase(typeof(ReleaseNoteNewEditXtraForm), typeof(ChildEditableForm))]
        [TestCase(typeof(ReleaseNoteSearchXtraForm), typeof(ChildForm))]
        [TestCase(typeof(MillReportsXtraForm), typeof(ChildForm))]
        [TestCase(typeof(PartSearchXtraForm), typeof(ChildForm))]
        [TestCase(typeof(InspectionReportsXtraForm), typeof(ChildForm))]
        [TestCase(typeof(ComponentNewEditXtraForm), typeof(ChildEditableForm))]
        [TestCase(typeof(JointNewEditXtraForm), typeof(ChildEditableForm))]
        [TestCase(typeof(JointSearchXtraForm), typeof(ChildForm))]
        [TestCase(typeof(ConstructionReportsXtraForm), typeof(ChildForm))]
        [TestCase(typeof(SettingsXtraForm), typeof(ChildEditableForm))]
        [TestCase(typeof(SpoolsXtraForm), typeof(ChildEditableForm))]
        [TestCase(typeof(AuditXtraForm), typeof(ChildForm))]
        [TestCase(typeof(NotificationXtraForm), typeof(ChildForm))]
        [TestCase(typeof(PartInspectionXtraForm), typeof(ChildForm))]
        [TestCase(typeof(PipeConstractionReportXtraForm), typeof(ChildForm))]
        [TestCase(typeof(WeldDateReportXtraForm), typeof(ChildForm))]
        [TestCase(typeof(ExportForm), typeof(ChildForm))]
        [TestCase(typeof(AboutXtraForm), typeof(PrizmForm))]
        [TestCase(typeof(LoginForm), typeof(PrizmForm))]
        [TestCase(typeof(SaveDialog), typeof(PrizmForm))]
        [TestCase(typeof(ExternalFilesXtraForm), typeof(PrizmForm))]
        [TestCase(typeof(JointCutDialog), typeof(PrizmForm))]
        [TestCase(typeof(SelectDiameterDialog), typeof(PrizmForm))]
        [TestCase(typeof(FirstSetupXtraForm), typeof(PrizmForm))]
        [TestCase(typeof(CreateSpoolComponentDialog), typeof(PrizmForm))]
        [TestCase(typeof(InspectionSelectPartDialog), typeof(PrizmForm))]
        [TestCase(typeof(PurchaseOrderXtraForm), typeof(PrizmForm))]
        [TestCase(typeof(PasswordChangeDialog), typeof(PrizmForm))]
        [TestCase(typeof(ConflictDialog), typeof(PrizmForm))]
        [TestCase(typeof(ImportForm), typeof(PrizmForm))]
        [TestCase(typeof(InspectionAddEditXtraForm), typeof(PrizmForm))]
        [TestCase(typeof(HeatXtraForm), typeof(PrizmForm))]
        [TestCase(typeof(PrizmApplicationXtraForm), typeof(PrizmForm))]
        [TestCase(typeof(HeatNumberXtraForm), typeof(PrizmForm))]
        [TestCase(typeof(MillInspectionXtraForm), typeof(PrizmForm))]
        [TestCase(typeof(MissingPortionsDialog), typeof(PrizmForm))]
        public void TestNonDesignerFormEndSuccessor(System.Type type, System.Type baseForm)
        {
            Assert.IsTrue(type.IsSubclassOf(baseForm), string.Format("{0} does not inherit from {1}!", type.Name, baseForm.Name));

            var attributes = type.GetCustomAttributes(typeof(System.ComponentModel.DesignerCategoryAttribute), false);

            Assert.GreaterOrEqual(attributes.Length, 1, string.Format("No DesignerCategoryAttribute for {0}!", type.Name));

            foreach (var a in attributes)
            {
                Assert.AreEqual(((System.ComponentModel.DesignerCategoryAttribute)a).Category, "Form", type.Name + " does not marked as DesignerCategoryAttribute - Form");
            }
        }

        [TestCase(typeof(ChildForm))]
        [TestCase(typeof(PrizmForm))]
        public void TestNonDesignerForm(System.Type type)
        {
            var attributes = type.GetCustomAttributes(typeof(System.ComponentModel.DesignerCategoryAttribute), false);

            Assert.GreaterOrEqual(attributes.Length, 1, string.Format("No DesignerCategoryAttribute for form {0}!", type.Name));

            foreach (var a in attributes)
            {
                Assert.AreEqual(((System.ComponentModel.DesignerCategoryAttribute)a).Category, "", string.Format("{0} does not marked as empty DesignerCategoryAttribute", type));
            }
        }

        [Test]
        public void ChildFormSuccessorOfPrizmForm()
        {
            Assert.IsTrue(typeof(ChildForm).IsSubclassOf(typeof(PrizmForm)), "ChildForm does not inherit from PrizmForm!");
        }


        [TestCase(typeof(MillPipeNewEditXtraForm))]
        [TestCase(typeof(ReleaseNoteNewEditXtraForm))]
        [TestCase(typeof(ComponentNewEditXtraForm))]
        [TestCase(typeof(JointNewEditXtraForm))]
        [TestCase(typeof(SpoolsXtraForm))]
        public void TestMainForm(System.Type type)
        {
            var filter = new TypeFilter(InterfaceFilter);

            var typeArr = type.FindInterfaces(filter, typeof(INewEditEntityForm));

            Assert.IsTrue(typeArr.Contains<System.Type>(typeof(INewEditEntityForm)));
        }

        public bool InterfaceFilter(System.Type typeObj, System.Object criteriaObj)
        {
            return typeObj.ToString() == criteriaObj.ToString();
        }
    }

}