<<<<<<< Updated upstream
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
=======
﻿using System;

public class Program
{
    static void Main()
    {
        // Testes com a classe Rectangulo...
        Console.WriteLine("--- Testes com a classe Rectangulo ---");
        try
        {
            Console.Write("Digite a base do retângulo: ");
            double baseValue = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura do retângulo: ");
            double alturaValue = double.Parse(Console.ReadLine());

            Rectangulo ret = new Rectangulo(baseValue, alturaValue);
            Console.WriteLine($"\nRetângulo - Base: {ret.Base}, Altura: {ret.Altura}");
            Console.WriteLine($"  Perímetro: {ret.Perimetro()}");
            Console.WriteLine($"  Área: {ret.Area()}");
        }
        catch (FormatException)
        {
            Console.WriteLine("\nErro: Por favor, digite números válidos para a base e altura.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"\nErro ao criar retângulo: {ex.Message}");
        }

        // Testes com a classe Quadrado
        Console.WriteLine("\n--- Testes com a classe Quadrado ---");
        try
        {
            Console.Write("Digite o lado do quadrado: ");
            double ladoQuadrado = double.Parse(Console.ReadLine());

            SquareClass quadrado = new SquareClass(ladoQuadrado);
            Console.WriteLine($"\nQuadrado - Lado: {ladoQuadrado}");
            Console.WriteLine($"  Perímetro: {quadrado.GetPerimeter()}");
            Console.WriteLine($"  Área: {quadrado.GetArea()}");
            Console.WriteLine($"  Diagonal: {quadrado.GetDiagonal()}");
        }
        catch (FormatException)
        {
            Console.WriteLine("\nErro: Por favor, digite um número válido para o lado do quadrado.");
        }
        catch (ArgumentException ex) // Se você adicionar validação na SquareClass
        {
            Console.WriteLine($"\nErro ao criar quadrado: {ex.Message}");
        }
    }
}
>>>>>>> Stashed changes
