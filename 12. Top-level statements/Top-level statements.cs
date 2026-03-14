
/*
    Починаючи з версії C# 9, метод Main не потрібно явно включати проект консольного додатка.
    Натомість можна використовувати оператори верхнього рівня для мінімізації обсягу створюваного коду.
    У цьому випадку компілятор створює клас і точку входу методу Main додатку.
*/


Book book = new Book("CLR via C#. Programming on Microsoft .NET Framework 4.5 platform in C#.",
                "Jeffrey Richter");
book.Print();

class Book
{
    string Name;
    string Author;

    public Book(string name, string author)
    {
        Name = name;
        Author = author;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name} \nAuthor: {Author}");
    }
}


