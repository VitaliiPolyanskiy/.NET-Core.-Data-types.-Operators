
class Hello
{
    // Точка входу до програми
    static void Main() 
    {
        // Логічні літерали
        System.Console.WriteLine(true); 
        System.Console.WriteLine(false);

        // Цілочисленні літерали
        System.Console.WriteLine(-7);
        System.Console.WriteLine(7);
        System.Console.WriteLine(0b111);  
        System.Console.WriteLine(0b1001);
        System.Console.WriteLine(0x1A);   
        System.Console.WriteLine(0xFF);

        // Речовинні літерали
        System.Console.WriteLine(0.92e4);   
        System.Console.WriteLine(7.2E-1);

        // Символьні літерали
        System.Console.Write('C');
        System.Console.WriteLine('#');

        // Рядкові літерали
        System.Console.WriteLine("The .NET platform and the C# programming language\n");
        System.Console.WriteLine("Hello, world\n");
    }
}