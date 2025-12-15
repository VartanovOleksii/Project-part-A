using Project__part_A_;

namespace TestProject
{
    [TestClass]
    public sealed class TestRecordLabel
    {
        private RecordLabel recordLabel;

        //Setup
        [TestInitialize]
        public void Setup()
        {
            recordLabel = new RecordLabel();
        }

        [TestCleanup]
        public void Cleanup()
        {
            recordLabel = null;
        }

        //Public properties
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}