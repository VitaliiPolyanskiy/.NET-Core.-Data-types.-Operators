
namespace CSharpApplication.format_output
{
    class MainClass
    {
        static void Main()
        {
            int number = 1234567;
            Console.WriteLine("{0:D}", number); //Decimal (десятковий)
            Console.WriteLine("{0:D4}", number); //Decimal (десятковий)
            Console.WriteLine("{0:D8}", number); //Decimal (десятковий)
            Console.WriteLine("{0:E}", number); //Exponential (експоненційний) 
            Console.WriteLine("{0:E4}", number); //Exponential (експоненційний) 
            Console.WriteLine("{0:E8}", number); //Exponential (експоненційний) 
            Console.WriteLine("{0:F}", number); //Fixed point (з фіксованою точкою) 
            Console.WriteLine("{0:F3}", number); //Fixed point (з фіксованою точкою) 
            Console.WriteLine("{0:N}", number); //Number (числовий)  
            Console.WriteLine("{0:N0}", number); //Number (числовий) 
            Console.WriteLine("{0:N8}", number); //Number (числовий) 
            Console.WriteLine("{0:X}", number); //Hexadecimal (шістнадцятковий)   
            Console.WriteLine("{0:X5}", number); //Hexadecimal (шістнадцятковий)   
            Console.WriteLine("{0:X8}", number); //Hexadecimal (шістнадцятковий)   
            Console.WriteLine("{0,4} {1,4} {2,4}", 15, 20, 25);
            Console.WriteLine("{0:###.##} {1:#.###}", 56.3678, 345.2356);
        }
    }
}

