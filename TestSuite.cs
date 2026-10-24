using System;
using System.Collections.Generic;
using System.Text;

namespace QATest;

public class TestSuite
{
    public string Name { get; set; }

    public List<TestCase> Tests { get; set; }

    public TestSuite(string name)
    {
        Name = name;
        Tests = new List<TestCase>();
    }

    public void AddTest(TestCase test)
    {
        Tests.Add(test);
    }

    public void RunAllTests()
    {
        foreach (TestCase test in Tests)
        {
            test.RunTest();
        }
    }

    public List<TestResult> GetResults()
    {
        List<TestResult> results = new List<TestResult>();

        foreach (TestCase test in Tests)
        {
            results.Add(
                new TestResult(test.Name, test.Status));
        }

        return results;
    }

}
