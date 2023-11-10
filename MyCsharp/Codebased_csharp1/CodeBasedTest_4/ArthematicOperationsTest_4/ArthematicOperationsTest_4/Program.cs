using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArthematicOperationsTest_4
{
    public delegate int ArthematicOperations(int a, int b);
    public class Calculator
    {
        public int add(int x, int y)
        {
            return x+y;
        }
        public int sub(int x, int y)
        {
            return x - y;
        }
        public int multiply(int x, int y)
        {
            return x * y;
        }
        public int divide(int x, int y)
        {
            return x / y;
        }
    }
    class Program
    {
        public static void Main()
        {
            int finall_result = 0;
            Calculator calculator = new Calculator();
            ArthematicOperations ArtheAdd = calculator.add;
            ArthematicOperations ArtheSubtract = calculator.sub;
            ArthematicOperations ArtheMultiply = calculator.multiply;
            ArthematicOperations ArtheDivide = calculator.divide;
            Console.Write("enter  number1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("enter number2: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("1. Add\n2. Subtract\n3. Multiply\n4. Divide\n5. All\n6. Exit");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    finall_result = ArtheAdd(n1, n2); 
                    Console.WriteLine("Result after adding: "+finall_result); 
                    //options();
                    break;
                case 2:
                    finall_result = ArtheSubtract(n1, n2); 
                    Console.WriteLine("Result after subtracting: " + finall_result); 
                   // options(); 
                    break;
                case 3:
                    finall_result = ArtheMultiply(n1, n2); 
                    Console.WriteLine("Result after multiplication: " + finall_result); 
                    //options(); 
                    break;
                case 4:
                    finall_result = ArtheDivide(n1, n2); 
                    Console.WriteLine("Result after dividing: " + finall_result); 
                    //options(); 
                    break;
                case 5:
                    Calculator calculator1 = new Calculator(); Console.WriteLine($"Addition: {calculator1.add(n1, n2)} \n" +
                $"Subtraction: {calculator1.sub(n1, n2)} \n" +
                $"Multiplication: {calculator1.multiply(n1, n2)} \n" +
                $"Division: {calculator1.divide(n1, n2)}"); 
                    break;
                case 6: Environment.Exit(0); 
                    break;
                default: 
                    Console.WriteLine("Invalid Choice, please enter valid option");
                    Main();
                    break;
            }
            Console.Read();
        }
    }
}
