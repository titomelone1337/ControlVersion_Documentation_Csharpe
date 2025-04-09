/// <summary>
/// Representa um quadrado e fornece métodos para calcular suas propriedades.
/// </summary>
public class SquareClass
{
    private double _lado; ///< Armazena o valor do lado do quadrado.

    /// <summary>
    /// Inicializa uma nova instância da classe <see cref="SquareClass"/>.
    /// </summary>
    /// <param name="l">O comprimento do lado do quadrado.</param>
    public SquareClass(double l)
    {
        this._lado = l;
    }

    /// <summary>
    /// Obtém ou define o comprimento do lado do quadrado.
    /// </summary>
    /// <exception cref="ArgumentException">
    /// Lançado se o valor atribuído for menor ou igual a 0.
    /// </exception>
    public double Lado
    {
        get => _lado;
        set
        {
            if (value <= 0)
                throw new ArgumentException("O valor do lado deve ser maior que 0");
            _lado = value;
        }
    }

    /// <summary>
    /// Calcula o perímetro do quadrado.
    /// </summary>
    /// <returns>O perímetro do quadrado.</returns>
    public double GetPerimeter() => _lado * 4;

    /// <summary>
    /// Calcula a área do quadrado.
    /// </summary>
    /// <returns>A área do quadrado.</returns>
    public double GetArea() => _lado * _lado;

    /// <summary>
    /// Calcula o comprimento da diagonal do quadrado.
    /// </summary>
    /// <returns>O comprimento da diagonal do quadrado.</returns>
    public double GetDiagonal() => _lado * Math.Sqrt(2);
}
