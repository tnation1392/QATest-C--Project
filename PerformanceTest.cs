using System;
using System.Collections.Generic;
using System.Text;

namespace QATest;

public class PerformanceTest : TestCase
{
    public PerformanceTest(string name, TestPriority priority)
        : base(name, priority)
    {
    }

    public override void RunTest()
    {
        Status = TestStatus.Blocked;
    }
}