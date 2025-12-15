using Project__part_A_;

namespace TestProject
{
    [TestClass]
    public sealed class TestSong
    {
        private Song song;

        //Setup
        [TestInitialize]
        public void Setup()
        {
            song = new Song();
        }

        [TestCleanup]
        public void Cleanup()
        {
            song = null;
        }

        //Public properties
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}