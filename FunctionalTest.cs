using System;
using System.Collections.Generic;
using System.Text;

namespace QATest;

public class FunctionalTest : TestCase
{
    public FunctionalTest(string name, TestPriority priority)
        : base(name, priority)
    {
    }

    public override void RunTest()
    {
        Status = TestStatus.Passed;
    }
}
