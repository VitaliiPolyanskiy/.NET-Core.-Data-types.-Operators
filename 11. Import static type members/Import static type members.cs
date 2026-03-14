// Імпорт членів статичних типів у простір імен

// Вираз using static включає в програму всі статичні методи та властивості, а також константи.
// І після цього ми можемо не вказувати назву класу під час виклику методу.

using static System.Console;

namespace New_in_CSharp_6
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello from C#");
            Read();
        }
    }
}
