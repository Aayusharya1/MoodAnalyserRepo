using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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
            string regexStr = "^(.*[ ])*[s][a][d]([ ].*)*";
            Regex regexExp = new Regex(regexStr);

            try
            {
                mood = regexExp.IsMatch(this.message) ? "SAD" : "HAPPY";
            }
            catch (Exception e)
            {
                return "HAPPY";
            }
            return mood;
        }
    }
}