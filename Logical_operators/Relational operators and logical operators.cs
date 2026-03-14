namespace CSharpApplication.Logical_Relation_operators
{
    class Logical_Relation_operators
    {
        public static void Main()
        {
            int a = 10, b = 5, c = 7, d = 8; // &&  ||
            if (a < b && ++c <= d) //++c не виконається, т.к. скорочена схема
            {
                Console.WriteLine("The line will not be displayed on the screen.");
            }
            else
            {
                Console.WriteLine("a = {0} b = {1} c = {2} d = {3}", a, b, c, d);
            }

            if (a < b & ++c <= d) // &  |  ^
            {
                Console.WriteLine("The line will not be displayed on the screen.");
            }
            else
            {
                Console.WriteLine("a = {0} b = {1} c = {2} d = {3}", a, b, c, d);
            }

            if (a < b ^ --c <= d)
            {
                Console.WriteLine("a = {0} b = {1} c = {2} d = {3}", a, b, c, d);
            }
            else
            {
                Console.WriteLine("The line will not be displayed on the screen.");
            }

            if (a > 0)
            {
                Console.WriteLine("The value of variable a is different from zero!");
            }

            /*
             // помилка компіляції: вираз у дужках повинен мати тип bool
             if(a) 
             {
               Console.WriteLine("The value of variable a is different from zero!");
             }
             
             // помилка компіляції: до типу bool перетворення немає
            if ((bool)a)
            {
                Console.WriteLine("The value of variable a is different from zero!");
            }
            */

        }
    }


}

