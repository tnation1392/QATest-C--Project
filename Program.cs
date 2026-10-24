namespace QATest;

class Program
{
    static void Main()
    {
        TestSuite suite = new TestSuite("Regression Suite");

        suite.AddTest(
            new FunctionalTest("Login Test", TestPriority.High));

        suite.AddTest(
            new PerformanceTest("Load Test", TestPriority.Critical));

        suite.RunAllTests();

        Console.WriteLine($"Suite: {suite.Name}");
        Console.WriteLine();

        foreach (TestCase test in suite.Tests)
        {
            Console.WriteLine(
                $"{test.Name} - {test.Priority} - {test.Status}");
        }

        Console.WriteLine();

        DisplayMenu();
    }

    static void DisplayMenu()
    {
        Console.WriteLine("=== QA Test System ===");
        Console.WriteLine("1. View Tests");
        Console.WriteLine("2. Run Tests");
        Console.WriteLine("3. View Results");
        Console.WriteLine("0. Exit");
    }
}