using System;

public class Rectangulo
{
    private double _base;
    private double _altura;

    public Rectangulo(double baseValue, double alturaValue)
    {
        Base = baseValue; 
        Altura = alturaValue;
    }

    public double Base
    {
        get => _base;
        set
        {
            if (value <= 0)
                throw new ArgumentException("base deve ser maior que 0");
            _base = value;
        }
    }

    public double Altura
    {
        get => _altura;
        set
        {
            if (value <= 0)
                throw new ArgumentException("altura deve ser maior que 0");
            _altura = value;
        }
    }

    public double Perimetro()
    {
        return 2 * (Base + Altura);
    }

    public double Area()
    {
        return Base * Altura;
    }
}