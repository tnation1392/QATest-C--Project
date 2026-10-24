using System;
using System.Collections.Generic;
using System.Text;

namespace QATest;

public class ManualTestRunner : ITestRunner
{
    public void RunTests(TestSuite suite)
    {
        suite.RunAllTests();

        Console.WriteLine("Manual test execution completed.");
    }
}
