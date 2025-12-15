using Project__part_A_;

namespace TestProject
{
    [TestClass]
    public sealed class TestBand
    {
        private Band band;

        //Сетап
        [TestInitialize]
        public void Setup()
        {
            band = new Band();
        }

        [TestCleanup]
        public void Cleanup()
        {
            band = null;
        }


        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}