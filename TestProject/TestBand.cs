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
        public void BandName_empty_input()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentNullException>(() => band.BandName = "");
        }

        [TestMethod]
        [DataRow("a")] //less than 3 symbols
        [DataRow("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa")] //more than 50 symbols
        public void BandName_incorrect_input(string s)
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => band.BandName = s);
        }

        [TestMethod]
        public void BandName_correct_input()
        {
            //Arrange
            string name = "Nirvana";
            string expected = name;

            //Act
            band.BandName = name;
            string actual = band.BandName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(-20)] //less than 0
        public void MonthlyListening_incorrect_input(int count)
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => band.MonthlyListening = count);
        }

        [TestMethod]
        public void MonthlyListening_correct_input()
        {
            //Arrange
            int count = 1500;
            int expected = count;

            //Act
            band.MonthlyListening = count;
            int actual = band.MonthlyListening;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}