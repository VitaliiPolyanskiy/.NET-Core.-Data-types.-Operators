
using System.Text;

namespace Interpolation_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            try
            {
                int a = 0, b = 0;
                Console.WriteLine("Enter an integer: ");
                a = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter an integer: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Result {a}/{b}={a / b}");
                Console.WriteLine($"Result {a}%{b}={a % b}");

                // Форматування рядка
                var person = new { Name = "Jeffrey", Surname = "Richter", Age = 61 };
                string output = string.Format("Name: {0, 5}  Surname: {1, 10}  Age: {2, 5}",
                    person.Name, person.Surname, person.Age);
                Console.WriteLine(output);

                Console.WriteLine("Інтерполяція рядків пропонує альтернативу формату рядків");
                output = $"Name: {person.Name,5}  Surname: {person.Surname,10}  Age: {person.Age,5}";
                Console.WriteLine(output);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
