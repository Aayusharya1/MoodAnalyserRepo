using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyserApp
    {
        public string message;
        public MoodAnalyserApp() { }
        public MoodAnalyserApp(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            string mood;
            if (message == "I am in a Happy mood")
                mood = "Happy";
            else if (message == "I am in a Sad mood")
                mood = "Sad";
            else
                mood = null;
            return mood;
        }
    }
}