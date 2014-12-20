using Moq;
using NUnit.Framework;

using Prizm.Main.Forms.Component.NewEdit;
using Prizm.Main.Forms.Joint.NewEdit;
using Prizm.Main.Forms.Joint.Search;
using Prizm.Main.Forms.PipeMill.NewEdit;
using Prizm.Main.Forms.PipeMill.Search;
using Prizm.Main.Forms.Railcar.NewEdit;
using Prizm.Main.Forms.Railcar.Search;
using Prizm.Main.Forms.Reports.Construction;
using Prizm.Main.Forms.Reports.Incoming;
using Prizm.Main.Forms.Reports.Mill;
using Prizm.Main.Forms.Reports.Custom;
using Prizm.Main.Forms.Settings;
using Prizm.Main.Forms.Spool;
using Prizm.Main.Forms.Parts.Search;
using Prizm.Main.Forms.Parts.Inspection;

using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Forms.Audit;
using PrizmMain.Forms.Notifications;

namespace Prizm.UnitTests
{
    [TestFixture]
    public class MainChildDocumentsTest
    {
        [TestCase(typeof(MillPipeNewEditXtraForm))]
        [TestCase(typeof(MillPipeSearchXtraForm))]
        [TestCase(typeof(RailcarNewEditXtraForm))]
        [TestCase(typeof(RailcarSearchXtraForm))]
        [TestCase(typeof(MillReportsXtraForm))]
        [TestCase(typeof(PartSearchXtraForm))]
        [TestCase(typeof(InspectionReportsXtraForm))]
        [TestCase(typeof(ComponentNewEditXtraForm))]
        [TestCase(typeof(CustomReportsXtraForm))]
        [TestCase(typeof(JointNewEditXtraForm))]
        [TestCase(typeof(JointSearchXtraForm))]
        [TestCase(typeof(ConstructionReportsXtraForm))]
        [TestCase(typeof(SettingsXtraForm))]
        [TestCase(typeof(SpoolsXtraForm))]
        [TestCase(typeof(AuditXtraForm))]
        [TestCase(typeof(NotificationXtraForm))]
        [TestCase(typeof(PartInspectionXtraForm))]
        public void TestChildFormSuccessor(System.Type type)
        {
            Assert.IsTrue(type.IsSubclassOf(typeof(ChildForm)), type.Name + " does not inherit from ChildForm!");

            var attributes = type.GetCustomAttributes(typeof(System.ComponentModel.DesignerCategoryAttribute), false);

            Assert.GreaterOrEqual(attributes.Length, 1, string.Format("No DesignerCategoryAttribute for {0}!", type.Name));

            foreach (var a in attributes)
            {
                Assert.AreEqual(((System.ComponentModel.DesignerCategoryAttribute)a).Category, "Form", type.Name + " does not marked as DesignerCategoryAttribute - Form");
            }
        }

        [Test]
        public void TestChildForm()
        {
            var attributes = typeof(ChildForm).GetCustomAttributes(typeof(System.ComponentModel.DesignerCategoryAttribute), false);

            Assert.GreaterOrEqual(attributes.Length, 1, "No DesignerCategoryAttribute for child form!");

            foreach (var a in attributes)
            {
                Assert.AreEqual(((System.ComponentModel.DesignerCategoryAttribute)a).Category, "", typeof(ChildForm) + " does not marked as empty DesignerCategoryAttribute");
            }

        }
    }

}