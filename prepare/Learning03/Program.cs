using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.Display() + " = " + f1.ToDecimal());

        Fraction f2 = new Fraction(6);
        Console.WriteLine(f2.Display() + " = " + f2.ToDecimal());

        Fraction f3 = new Fraction(2, 5);
        Console.WriteLine(f3.Display() + " = " + f3.ToDecimal());

        Fraction f4 = new Fraction(7, 3);
        Console.WriteLine(f4.Display() + " = " + f4.ToDecimal());

        Random random = new Random();
        Fraction f5 = new Fraction();
        
        Console.WriteLine("\nRandom Fractions:");
        for (int i = 0; i < 10; i++)
        {
            int numValue = random.Next(0, 20);
            int denValue = random.Next(1, 20);
            
            f5.SetNum(numValue);
            f5.SetDen(denValue);
            
            Console.WriteLine("Fraction " + (i + 1) + ": " + f5.Display() + " = " + f5.ToDecimal());
        }
    }
}