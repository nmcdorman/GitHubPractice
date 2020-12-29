using System;

namespace GitHubPracticeTestNameSpace
{
    public class TestClass
    {
        static string message = "I'm scared of you.";

        public TestClass(string msg)
        {
            message = msg;
        }

        static public void TestMethodOne()
        {
            Console.WriteLine(message);
        }
        
        public void TestMethodTwo()
        {
            Console.WriteLine(message);
        }
    }    
}