namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Programming Language!\n\n");
           
            Console.WriteLine(
                "C#\r\nThe programming language you write in. Example:\r\n\r\ncsharp\r\nConsole.WriteLine(\"Hello World\");\r\n" +
                "Compiler\r\nTranslates your C# code into IL (Intermediate Language).\r\n\r\nIL is not raw 1s and 0s — it’s a portable, assembly-like language that the .NET system understands.\r\n\r\n" +
                "IL (Intermediate Language)\r\nA middle layer between your source code and the CPU.\r\n\r\nStored inside assemblies (.dll or .exe).\r\n\r\nWhen you run the program, IL is converted into machine code by the runtime’s JIT compiler.\r\n\r\n" +
                "CLR (Common Language Runtime)\r\nThe execution engine of .NET.\r\n\r\nTakes IL and uses a JIT (Just-In-Time) compiler to turn it into actual machine code (1s and 0s).\r\n\r\nProvides services like:\r\n\r\n" +
                    "Memory management (garbage collection).\r\n\r\n" +
                    "Error handling (exceptions).\r\n\r\nSecurity checks.\r\n\r\n" +
                    "Cross-language support (C#, VB.NET, F# all compile to IL, and CLR runs them).\r\n\r\n" +
                "BCL (Base Class Library)\r\nA set of ready-made building blocks (classes and methods) for common tasks: strings, files, math, networking, etc.\r\n\r\nYour C# code often calls into the BCL, which the CLR executes.\r\n\r\n" +
                "SDK (Software Development Kit)\r\nThe toolbox you install.\r\n\r\nContains the compiler, runtime (CLR), and libraries (including the BCL).\r\n\r\n" +
                "IDE (Integrated Development Environment)\r\nThe workspace where you write and debug your code.\r\n\r\nExample: Visual Studio or Visual Studio Code.\r\n\r\n" +
                "Flow of Execution\r\n" +
                    "Write code in C# using an IDE.\r\n\r\n" +
                    "Compiler translates C# → IL.\r\n\r\n" +
                    "IL stored in assemblies.\r\n\r\n" +
                    "CLR takes IL, JIT-compiles it into machine code.\r\n\r\n" +
                    "Program runs, using the BCL for common tasks.\r\n\r\n\n" +
                "Analogy:\r\n\r\n" +
                "C# = your spoken language\r\n\r\n" +
                "Compiler = translator into IL\r\n\r\n" +
                "IL = universal script\r\n\r\n" +
                "CLR = director + engine that brings the script to life\r\n\r\n" +
                "Machine code (1s and 0s) = the final performance on the CPU\r\n\r\n" +
                "BCL = props and tools used during the performance\r\n\r\n" +
                "SDK = the full kit with translator + props + stage setup\r\n\r\n" +
                "IDE = the rehearsal room where you prepare everything");
        }
    }
}
