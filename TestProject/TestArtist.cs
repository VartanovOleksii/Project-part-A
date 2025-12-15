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
        public void Name_empty_input()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentNullException>(() => artist.Name = "");
        }

        [TestMethod]
        [DataRow ("a")] //less than 3 symbols
        [DataRow ("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa")] //more than 50 symbols
        public void Name_incorrect_name(string s)
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => artist.Name = s);
        }

        [TestMethod]
        public void Name_correct_name()
        {
            //Arrange
            string name = "Long Afternoon";
            string expected = name;

            //Act
            artist.Name = name;

            //Assert
            Assert.AreEqual(expected, artist.Name);
        }
        
        [TestMethod]
        [DataRow (16)] //less than 18
        [DataRow (100)] //more than 95
        public void Age_incorrect_age(int age)
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => artist.Age = age);
        }

        [TestMethod]
        public void Age_correct_age()
        {
            //Arrange
            int age = 21;
            int expected = age;

            //Act
            artist.Age = age;

            //Assert
            Assert.AreEqual(expected, artist.Age);
        }

        [TestMethod]
        [DataRow (-20)] //less or equal 0
        [DataRow (0)] //less or equal 0
        public void Salary_incorrect_salary(double salary)
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => artist.Salary = salary);
        }

        [TestMethod]
        public void Salary_correct_salary()
        {
            //Arrange
            double salary = 150000;
            double expected = salary;

            //Act
            artist.Salary = salary;

            //Assert
            Assert.AreEqual(expected, artist.Salary, 0.001);
        }
    }
}
