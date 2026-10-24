using System;
using System.Collections.Generic;
using System.Text;

namespace QATest;

public class AutomatedTestRunner : ITestRunner
{
    public void RunTests(TestSuite suite)
    {
        suite.RunAllTests();

        Console.WriteLine("Automated test execution completed.");
    }
}
