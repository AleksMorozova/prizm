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
        [Test]
        public void TestAllChildFormsAreChild()
        {
            Assert.IsTrue(typeof(MillPipeNewEditXtraForm).IsSubclassOf(typeof(ChildForm)), "MillPipeNewEditXtraForm does not inherit from ChildForm!");
            Assert.IsTrue(typeof(RailcarNewEditXtraForm).IsSubclassOf(typeof(ChildForm)), "RailcarNewEditXtraForm does not inherit from ChildForm!");
            Assert.IsTrue(typeof(MillPipeSearchXtraForm).IsSubclassOf(typeof(ChildForm)), "MillPipeSearchXtraForm does not inherit from ChildForm!");
            Assert.IsTrue(typeof(MillReportsXtraForm).IsSubclassOf(typeof(ChildForm)), "MillReportsXtraForm does not inherit from ChildForm!");
            Assert.IsTrue(typeof(ComponentNewEditXtraForm).IsSubclassOf(typeof(ChildForm)), "ComponentNewEditXtraForm does not inherit from ChildForm!");
            Assert.IsTrue(typeof(InspectionReportsXtraForm).IsSubclassOf(typeof(ChildForm)), "InspectionReportsXtraForm does not inherit from ChildForm!");
            Assert.IsTrue(typeof(ComponentSearchXtraForm).IsSubclassOf(typeof(ChildForm)), "ComponentSearchXtraForm does not inherit from ChildForm!");
            Assert.IsTrue(typeof(JointNewEditXtraForm).IsSubclassOf(typeof(ChildForm)), "JointNewEditXtraForm does not inherit from ChildForm!");
            Assert.IsTrue(typeof(JointSearchXtraForm).IsSubclassOf(typeof(ChildForm)), "JointSearchXtraForm does not inherit from ChildForm!");
            Assert.IsTrue(typeof(ConstructionReportsXtraForm).IsSubclassOf(typeof(ChildForm)), "ConstructionReportsXtraForm does not inherit from ChildForm!");
            Assert.IsTrue(typeof(SettingsXtraForm).IsSubclassOf(typeof(ChildForm)), "SettingsXtraForm does not inherit from ChildForm!");
            Assert.IsTrue(typeof(RailcarSearchXtraForm).IsSubclassOf(typeof(ChildForm)), "RailcarSearchXtraForm does not inherit from ChildForm!");
            Assert.IsTrue(typeof(InspectionPipeSearchEditXtraForm).IsSubclassOf(typeof(ChildForm)), "InspectionPipeSearchEditXtraForm does not inherit from ChildForm!");
            Assert.IsTrue(typeof(SpoolsXtraForm).IsSubclassOf(typeof(ChildForm)), "SpoolsXtraForm does not inherit from ChildForm!");
            Assert.IsTrue(typeof(ComponentSearchXtraForm).IsSubclassOf(typeof(ChildForm)), "ComponentSearchXtraForm does not inherit from ChildForm!");
            Assert.IsTrue(typeof(InspectionPipeSearchEditXtraForm).IsSubclassOf(typeof(ChildForm)), "InspectionPipeSearchEditXtraForm does not inherit from ChildForm!");
            Assert.IsTrue(typeof(AuditXtraForm).IsSubclassOf(typeof(ChildForm)), "AuditXtraForm does not inherit from ChildForm!");
        }
    }

}