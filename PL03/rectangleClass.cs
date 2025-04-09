using System;

/// <summary>
/// Represents a rectangle with a base and height.
/// Provides methods to calculate perimeter and area.
/// </summary>
public class Rectangulo
{
    private double _base;
    private double _altura;

    /// <summary>
    /// Initializes a new instance of the <see cref="Rectangulo"/> class with the specified base and height.
    /// </summary>
    /// <param name="baseValue">The base of the rectangle. Must be greater than 0.</param>
    /// <param name="alturaValue">The height of the rectangle. Must be greater than 0.</param>
    /// <exception cref="ArgumentException">Thrown when base or height is less than or equal to 0.</exception>
    public Rectangulo(double baseValue, double alturaValue)
    {
        Base = baseValue;
        Altura = alturaValue;
    }

    /// <summary>
    /// Gets or sets the base of the rectangle.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when value is less than or equal to 0.</exception>
    public double Base
    {
        get => _base;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Base must be greater than 0.");
            _base = value;
        }
    }

    /// <summary>
    /// Gets or sets the height of the rectangle.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when value is less than or equal to 0.</exception>
    public double Altura
    {
        get => _altura;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Height must be greater than 0.");
            _altura = value;
        }
    }

    /// <summary>
    /// Calculates the perimeter of the rectangle.
    /// </summary>
    /// <returns>The perimeter of the rectangle.</returns>
    public double Perimetro()
    {
        return 2 * (Base + Altura);
    }

    /// <summary>
    /// Calculates the area of the rectangle.
    /// </summary>
    /// <returns>The area of the rectangle.</returns>
    public double Area()
    {
        return Base * Altura;
    }
}
