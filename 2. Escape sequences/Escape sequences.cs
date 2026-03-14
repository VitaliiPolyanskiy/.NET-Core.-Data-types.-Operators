using System;

namespace CSharpApplication.escape
{
    class MainClass
    {
        static void Main()
        {
            Console.WriteLine("Programming language C#!");
            Console.WriteLine("Programming language \tC#!");
            Console.WriteLine("Programming language \nC#!");
            Console.WriteLine("Programming language \bC#!");
            Console.WriteLine("Programming language \rC#!");
            Console.WriteLine("\"Programming language C#!\"");
            Console.WriteLine("\\Programming language C#!\\");
            Console.WriteLine(@"\Programming language 
            C#!\");   
        }
    }
}

