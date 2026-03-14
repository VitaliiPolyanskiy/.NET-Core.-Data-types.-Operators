
using System.Text;

namespace CSharpApplication.operator_switch
{
    class MainClass
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            string answer;
            do
            {
                Console.WriteLine("Введіть день тижня українською: ");
                string? str = Console.ReadLine();
                switch (str)
                {
                    case "Понеділок":
                        Console.WriteLine("Monday");
                        break;
                    case "Вівторок":
                        Console.WriteLine("Tuesday");
                        break;
                    case "Середа":
                        Console.WriteLine("Wednesday");
                        break;
                    case "Четвер":
                        Console.WriteLine("Thursday");
                        break;
                    case "П'ятниця":
                        Console.WriteLine("Friday");
                        break;
                    case "Субота":
                        Console.WriteLine("Saturday");
                        break;
                    case "Неділя":
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Такого дня нема.");
                        break;
                }
                Console.WriteLine("Ще раз? Так/ні");
                answer = Console.ReadLine()!;
              } while (answer == "так" || answer == "ТАК");
            
        }

    }
}

