using Project__part_A_;

namespace TestProject
{
    [TestClass]
    public sealed class TestRecordLabel
    {
        private RecordLabel recordLabel;

        //Сетап
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


        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}