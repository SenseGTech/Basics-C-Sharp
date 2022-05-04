using System;

namespace MyFirstprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; //declaration
            x = 123; //initalizaition

            int y = 321; //declaration + initialization
            int z = x + y;
            int age = 21;
            double height = 180.2;
            bool alive = true;
            char symbol = '@';
            String name = "George";

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your age is " +  age);
            Console.WriteLine("Your height is " +  height);
            Console.WriteLine("Are you alive " +  alive);
            Console.WriteLine("Your symbol is " +  symbol);
            String userName = symbol + name;
            Console.WriteLine("Your username is: " + userName);
           
            Console.ReadKey();

        }
    }
}