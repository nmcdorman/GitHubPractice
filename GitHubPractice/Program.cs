using System;
using GitHubPracticeTestNameSpace;

namespace GitHubPractice
{
    class Program
    {
        static void Main(string[] args)
        {            
            TestClass.TestMethodOne();
            var test = new TestClass("Donuts Rock!");            
            var testTwo = new TestClass("Doughnaughts Rawque!");
            TestClass.TestMethodOne();
            test.TestMethodTwo();
        }
    }
}
