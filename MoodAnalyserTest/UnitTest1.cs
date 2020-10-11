using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SadMoodCheck()
        {
            //Arrange
            MoodAnalyserApp analyser = new MoodAnalyserApp("I am in a Sad mood");
            //Act
            string mood = analyser.AnalyseMood();
            //Assert
            Assert.AreEqual("HAPPY", mood);
        }

        [TestMethod]
        public void HappyMoodCheck()
        {
            //Arrange
            MoodAnalyserApp analyser = new MoodAnalyserApp("I am in a sad mood");
            //Act
            string mood = analyser.AnalyseMood();
            //Assert
            Assert.AreEqual("SAD", mood);
        }
    }
}
