namespace CSharpApplication.visibility_scope
{
    class MainClass
    {
        public static void Main()
        {
            Visibility_scope obj = new();
            obj.Test();
        }
    }

    class Visibility_scope
    {
        int A = 10, B = 5;
        
        public void Test()
        {
            int C;
            int A = 20;
            {
                int D;
                //int A; // неприпустимо: конфлікт із локальною змінною у зовнішньому блоці
                C = B;
                D = this.A;
                Console.WriteLine("Variable A = " + A + "\nField B = " + 
                    B + "\nVariable C = " + C + "\nVariable D = " + 
                    D + "\nField A = " + this.A);
            }
            {
                int D = 20;
                Console.WriteLine("Variable D = " + D);
                // int E; // змінна не ініціалізована
                // E += 10; // помилка компіляції
            }
        }
    }
}

