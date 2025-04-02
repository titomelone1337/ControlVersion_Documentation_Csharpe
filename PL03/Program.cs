using System;

class Program
{
    static void Main()
    {
       Console.Write("base do retangulo ");
       double baseValue = double.Parse(Console.ReadLine());

        Console.Write("altura do retangulo ");
        double heightValue = double.Parse(Console.ReadLine());
        Rectangulo rect = new Rectangulo(baseValue, heightValue);

        Console.WriteLine($"\nPerimetro: {rect.Perimetro()}");
        Console.WriteLine($"Area: {rect.Area()}");
 
    }
}