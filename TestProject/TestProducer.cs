using Project__part_A_;

namespace TestProject
{
    [TestClass]
    public sealed class TestProducer
    {
        private Producer producer;

        //Сетап
        [TestInitialize]
        public void Setup()
        {
            producer = new Producer();
        }

        [TestCleanup]
        public void Cleanup()
        {
            producer = null;
        }


        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}