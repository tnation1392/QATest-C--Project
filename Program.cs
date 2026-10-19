namespace QATest;

class Program
{
    static void Main()
    {
        TestCase loginTest =
            new FunctionalTest("Login Test", TestPriority.High);

        TestCase loadTest =
            new PerformanceTest("Load Test", TestPriority.Critical);

        loginTest.RunTest();
        loadTest.RunTest();

        Console.WriteLine($"{loginTest.Name}: {loginTest.Status}");
        Console.WriteLine($"{loadTest.Name}: {loadTest.Status}");

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