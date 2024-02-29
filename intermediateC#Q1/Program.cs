using System;

public class Calculator
{
    private static double result;
    public int addition(int a, int b)
    {
        result = a + b;
        return a + b;
    }
    public int addition(int a, int b, int c)
    {
        result = a + b + c;
        return a + b + c;
    }
    public float addition(float a, float b)
    {
        result = a + b;
        return a + b;
    }

    public static double GetResult()
    {
        return result;
    }
}
namespace HelloWorld
{

    class Program
    {
        public static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.addition(10, 20));
            Console.WriteLine(calc.addition(10, 20, 30));
            Console.WriteLine(calc.addition(10.02F, 20.00F));
        }
    }

}