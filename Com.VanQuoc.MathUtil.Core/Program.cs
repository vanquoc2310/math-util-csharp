
namespace Com.VanQuoc.MathUtil.Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleTest();
            PopupTest();
        }

        public static void ConsoleTest()
        {
            var mathService = new MathService();

            // Test case #1: Check GCD of 54 and 24
            int a = 54;
            int b = 24;
            int expectedResult = 6; // GCD of 54 and 24 is 6
            int actualResult = mathService.GetGCD(a, b);
            Console.WriteLine($"GCD of {a} and {b} = | Expected: {expectedResult} Actual: {actualResult}");
        }

        public static void PopupTest()
        {
            var mathService = new MathService();

            // Test case #1: Check GCD of 54 and 24
            int a = 54;
            int b = 24;
            int expectedResult = 6; // GCD of 54 and 24 is 6
            int actualResult = mathService.GetGCD(a, b);
            string msg = $"GCD of {a} and {b} = | Expected: {expectedResult} Actual: {actualResult}";
            //MessageBox.Show(msg);
            Console.WriteLine(msg);

        }
    }
}
