using System;


namespace DotnetCoding1
{
    class Myclass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("small program");
            int a = Convert.ToInt32(Console.ReadLine());
            bool temp;
            if (a == 10)
            {
                 temp = true;
            }
            else
            {
                temp = false;
                    }
            Console.WriteLine($" a = 10 is {temp}");
            Myfun.Details();
            Console.ReadKey();

        }
    }
    class Myfun
    {
        public static void Details()
        {
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{name} is {age} Years old");
            Console.WriteLine("My name is  {0} and I am {1} years old",name,age);
        }

    }
}
