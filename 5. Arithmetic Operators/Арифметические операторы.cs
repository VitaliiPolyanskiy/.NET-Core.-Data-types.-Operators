
namespace CSharpApplication.arithmetic_operations
{
    class Arithmetic_operations
    {
        public static void Main()
        {
            try
            {
                int a = 0, b = 0;
                double c = 0, d = 0;
                Console.WriteLine("Enter an integer: ");
                a = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter an integer: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Result {0}/{1}={2}", a, b, a / b);
                Console.WriteLine("Result {0}%{1}={2}", a, b, a % b); 

                Console.WriteLine("Enter a fractional number: ");
                c = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter a fractional number: ");
                d = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Result {0}/{1}={2}", c, d, c / d);
                Console.WriteLine("Result {0}%{1}={2}", c, d, c % d); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }


}

