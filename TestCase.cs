using System;
using System.Collections.Generic;
using System.Text;

namespace QATest;

public abstract class TestCase
{
    public string Name { get; set; }

    public TestPriority Priority { get; set; }

    public TestStatus Status { get; set; }

    public TestCase(string name, TestPriority priority)
    {
        Name = name;
        Priority = priority;
        Status = TestStatus.NotRun;
    }

    public abstract void RunTest();
}
