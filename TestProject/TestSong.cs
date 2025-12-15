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
        public void SongName_empty_input()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentNullException>(() => song.SongName = "");
        }

        [TestMethod]
        [DataRow("a")] //less than 3 symbols
        [DataRow("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa")] //more than 50 symbols
        public void SongName_incorrect_input(string s)
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => song.SongName = s);
        }

        [TestMethod]
        public void SongName_correct_input()
        {
            //Arrange
            string name = "Come as you are";
            string expected = name;

            //Act
            song.SongName = name;
            string actual = song.SongName;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}