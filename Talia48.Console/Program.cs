using System;

namespace Talia48Console
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello from .NET Framework 4.8!");
            Console.WriteLine("Args: " + string.Join(", ", args ?? Array.Empty<string>()));
        }
    }
}
