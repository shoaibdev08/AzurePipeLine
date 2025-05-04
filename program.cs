using System;
using AzurePipeLine;

namespace SeleniumRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Starting Selenium Test...");
                var test = new UnitTest1();
                test.TestMethod1();
                Console.WriteLine("Test completed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Test failed with exception:");
                Console.WriteLine(ex.Message);
            }
;
        }
    }
}
