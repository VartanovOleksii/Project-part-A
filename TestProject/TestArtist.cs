using Project__part_A_;

namespace TestProject
{
    [TestClass]
    public sealed class TestArtist
    {
        private Artist artist;

        //Сетап
        [TestInitialize]
        public void Setup()
        {
            artist = new Artist();
        }

        [TestCleanup]
        public void Cleanup()
        {
            artist = null;
        }


        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
