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

        string? choice = DisplayMenu();

        if (choice == "1")
        {
            DisplayTests(suite);
        }
        else if (choice == "2")
        {
            RunTests(suite);
        }
    }
    

    static string? DisplayMenu()
    {
        Console.WriteLine("=== QA Test System ===");
        Console.WriteLine("1. View Tests");
        Console.WriteLine("2. Run Tests");
        Console.WriteLine("3. View Results");
        Console.WriteLine("0. Exit");

        Console.Write("Enter selection: ");

        string? choice = Console.ReadLine();

        Console.WriteLine();

        return choice;
    }

    static void DisplayTests(TestSuite suite)
    {
        Console.WriteLine($"Suite: {suite.Name}");
        Console.WriteLine();
        foreach (TestCase test in suite.Tests)
        {
            Console.WriteLine(
                $"{test.Name} - {test.Priority} - {test.Status}");
        }
        
    }

    static void RunTests(TestSuite suite)
    {
        suite.RunAllTests();

        Console.WriteLine("All tests executed.");
    }
}