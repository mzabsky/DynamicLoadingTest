using System;
using System.Reflection;

namespace Loader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var assembly = Assembly.LoadFrom("../../../../DynamicLoadingTest/bin/Debug/netcoreapp3.1/DynamicLoadingTest.dll");
            var references = assembly.GetExportedTypes();
            var type = assembly.GetType("Program");

        }
    }
}
