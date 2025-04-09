using System;

/// <summary>
/// Main program class that tests the functionality of the Rectangulo and SquareClass classes.
/// </summary>
public class Program
{
    /// <summary>
    /// Entry point of the application.
    /// </summary>
    static void Main()
    {
        // Tests with the Rectangulo class...
        Console.WriteLine("--- Tests with the Rectangulo class ---");
        try
        {
            Console.Write("Enter the base of the rectangle: ");
            double baseValue = double.Parse(Console.ReadLine());

            Console.Write("Enter the height of the rectangle: ");
            double alturaValue = double.Parse(Console.ReadLine());

            /// <summary>
            /// Creates a new instance of Rectangulo with the given values.
            /// </summary>
            Rectangulo ret = new Rectangulo(baseValue, alturaValue);
            Console.WriteLine($"\nRectangle - Base: {ret.Base}, Height: {ret.Altura}");
            Console.WriteLine($"  Perimeter: {ret.Perimetro()}");
            Console.WriteLine($"  Area: {ret.Area()}");
        }
        catch (FormatException)
        {
            Console.WriteLine("\nError: Please enter valid numbers for base and height.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"\nError creating rectangle: {ex.Message}");
        }

        // Tests with the SquareClass
        Console.WriteLine("\n--- Tests with the SquareClass ---");
        try
        {
            Console.Write("Enter the side of the square: ");
            double ladoQuadrado = double.Parse(Console.ReadLine());

            /// <summary>
            /// Creates a new instance of SquareClass with the given side length.
            /// </summary>
            SquareClass square = new SquareClass(ladoQuadrado);
            Console.WriteLine($"\nSquare - Side: {ladoQuadrado}");
            Console.WriteLine($"  Perimeter: {square.GetPerimeter()}");
            Console.WriteLine($"  Area: {square.GetArea()}");
            Console.WriteLine($"  Diagonal: {square.GetDiagonal()}");
        }
        catch (FormatException)
        {
            Console.WriteLine("\nError: Please enter a valid number for the square's side.");
        }
        catch (ArgumentException ex) // In case validation is added in SquareClass
        {
            Console.WriteLine($"\nError creating square: {ex.Message}");
        }
    }
}
