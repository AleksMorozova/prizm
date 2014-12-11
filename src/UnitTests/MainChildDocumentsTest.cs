using Moq;
using NUnit.Framework;

using PrizmMain.Forms.Component.NewEdit;
using PrizmMain.Forms.Component.Search;
using PrizmMain.Forms.Joint.NewEdit;
using PrizmMain.Forms.Joint.Search;
using PrizmMain.Forms.PipeIncoming;
using PrizmMain.Forms.PipeMill.NewEdit;
using PrizmMain.Forms.PipeMill.Search;
using PrizmMain.Forms.Railcar.NewEdit;
using PrizmMain.Forms.Railcar.Search;
using PrizmMain.Forms.Reports.Construction;
using PrizmMain.Forms.Reports.Incoming;
using PrizmMain.Forms.Reports.Mill;
using PrizmMain.Forms.Settings;
using PrizmMain.Forms.Spool;

using PrizmMain.Forms.MainChildForm;
using PrizmMain.Forms.Audit;

namespace UnitTests
{
    [TestFixture]
    public class MainChildDocumentsTest
    {
        [TestCase(typeof(MillPipeNewEditXtraForm))]
        [TestCase(typeof(RailcarNewEditXtraForm))]
        [TestCase(typeof(MillPipeSearchXtraForm))]
        [TestCase(typeof(MillReportsXtraForm))]
        [TestCase(typeof(ComponentNewEditXtraForm))]
        [TestCase(typeof(InspectionReportsXtraForm))]
        [TestCase(typeof(ComponentSearchXtraForm))]
        [TestCase(typeof(JointNewEditXtraForm))]
        [TestCase(typeof(JointSearchXtraForm))]
        [TestCase(typeof(ConstructionReportsXtraForm))]
        [TestCase(typeof(SettingsXtraForm))]
        [TestCase(typeof(RailcarSearchXtraForm))]
        [TestCase(typeof(InspectionPipeSearchEditXtraForm))]
        [TestCase(typeof(SpoolsXtraForm))]
        [TestCase(typeof(ComponentSearchXtraForm))]
        [TestCase(typeof(InspectionPipeSearchEditXtraForm))]
        [TestCase(typeof(AuditXtraForm))]
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