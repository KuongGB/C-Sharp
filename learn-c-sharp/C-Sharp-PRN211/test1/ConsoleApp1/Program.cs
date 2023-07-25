// See https://aka.ms/new-console-template for more information
using System;

namespace testing
{
    class Program { 
        static void Main() {
            Action<String> hi = (String mg) => {
                Console.WriteLine(mg.Length);
            };
            hi("nice");
        }
    }
}