using System;

namespace GitHubPracticeTestNameSpace
{
    public class TestClass
    {
        static string message = "I'm scared of donuts.";

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
            try
            {
                Console.WriteLine(message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }
        }
    }    
}