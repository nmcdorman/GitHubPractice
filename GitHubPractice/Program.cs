﻿using System;
using GitHubPracticeTestNameSpace;

namespace GitHubPractice
{
    class Program
    {
        static void Main(string[] args)
        {            
            TestClass.TestMethodOne();
            var test = new TestClass("Donuts Rock!");            
            TestClass.TestMethodOne();
            test.TestMethodTwo();
            var testTwo = new TestClass("Doughnaughts Rawque!");
            TestClass.TestMethodOne();
            test.TestMethodTwo();
        }
    }
}
