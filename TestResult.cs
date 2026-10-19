using System;
using System.Collections.Generic;
using System.Text;

namespace QATest;

public class TestResult
{
    public string TestName { get; set; }

    public TestStatus Status { get; set; }

    public TestResult(string testName, TestStatus status)
    {
        TestName = testName;
        Status = status;
    }
}

