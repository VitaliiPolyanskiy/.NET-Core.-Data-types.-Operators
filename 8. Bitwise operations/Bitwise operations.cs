namespace CSharpApplication.bitwise
{
    class MainClass
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter the number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                // Перевірка на парність
                if ((a & 1) == 1)
                    Console.WriteLine(a + " - odd value");
                else
                    Console.WriteLine(a + " - even value");
                int b = 2, c = 5;
                int f = b | c;
                Console.WriteLine(f); // 7
                Console.WriteLine("{0} X 2 = {1}" , a, (a << 1));
                Console.WriteLine("{0} X 4 = {1}", a, (a << 2));
                Console.WriteLine("{0} X 8 = {1}", a, (a << 3));

                int x = 7;
                int y = ~x;
                y += 1;
                Console.WriteLine(y);   // -7
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }

    }
}

