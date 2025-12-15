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
        public void RecordLabelName_empty_input()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentNullException>(() => recordLabel.RecordLabelName = "");
        }

        [TestMethod]
        [DataRow("a")] //less than 3 symbols
        [DataRow("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa")] //more than 50 symbols
        public void RecordLabelName_incorrect_input(string s)
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => recordLabel.RecordLabelName = s);
        }

        [TestMethod]
        public void RecordLabelName_correct_input()
        {
            //Arrange
            string name = "Sub Pop";
            string expected = name;

            //Act
            recordLabel.RecordLabelName = name;
            string actual = recordLabel.RecordLabelName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Bands()
        {
            //Arrange
            Producer producer1 = new Producer("Butch Vig", 70, 100000, "Architecture of grunge sound");
            List<Producer> producers = new List<Producer>() { producer1 };

            Artist artist1 = new Artist("Kurt Cobain", 27, 150000, "Electric guitar");
            List<Artist> artists = new List<Artist>() { artist1 };

            //Act
            Band band1 = new Band("Nirvana", producers);
            band1.Artists.AddRange(artists);

            List<Band> bands = new List<Band>() { band1 };
            recordLabel.Bands = bands;

            List<Band> expected = bands;
            List<Band> actual = recordLabel.Bands;

            //Assert
            Assert.HasCount(expected.Count, actual);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.HasCount(expected[i].Producers.Count, actual); 
                for (int j = 0; j < expected[i].Producers.Count; j++)
                {
                    Assert.AreEqual(expected[i].Producers[j].Name, actual[i].Producers[j].Name);
                    Assert.AreEqual(expected[i].Producers[j].Age, actual[i].Producers[j].Age);
                    Assert.AreEqual(expected[i].Producers[j].Salary, actual[i].Producers[j].Salary);
                    Assert.AreEqual(expected[i].Producers[j].YearsOfExperience, actual[i].Producers[j].YearsOfExperience);
                    Assert.AreEqual(expected[i].Producers[j].Specialization, actual[i].Producers[j].Specialization);
                }

                Assert.HasCount(expected[i].Artists.Count, actual);
                for (int j = 0; j < expected[i].Artists.Count; j++)
                {
                    Assert.AreEqual(expected[i].Artists[j].Name, actual[i].Artists[j].Name);
                    Assert.AreEqual(expected[i].Artists[j].Age, actual[i].Artists[j].Age);
                    Assert.AreEqual(expected[i].Artists[j].Salary, actual[i].Artists[j].Salary);
                    Assert.AreEqual(expected[i].Artists[j].Instrument, actual[i].Artists[j].Instrument);
                    Assert.AreEqual(expected[i].Artists[j].IsActive, actual[i].Artists[j].IsActive);
                    Assert.AreEqual(expected[i].Artists[j].FanCount, actual[i].Artists[j].FanCount);
                }
            }
        }
    }
}