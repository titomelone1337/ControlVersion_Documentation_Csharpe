/**
 * @class SquareClass
 * @brief Representa um quadrado e fornece métodos para calcular suas propriedades.
 */
public class SquareClass
{
    private double _lado; ///< Armazena o valor do lado do quadrado.

    /**
     * @brief Construtor da classe SquareClass.
     * @param l O comprimento do lado do quadrado.
     */
    public SquareClass(double l)
    {
        this._lado = l;
    }

    /**
     * @brief Propriedade para acessar e modificar o lado do quadrado.
     * @throws ArgumentException Se o valor atribuído for menor ou igual a 0.
     */
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

    /**
     * @brief Calcula o perímetro do quadrado.
     * @return O perímetro do quadrado.
     */
    public double GetPerimeter() => _lado * 4;

    /**
     * @brief Calcula a área do quadrado.
     * @return A área do quadrado.
     */
    public double GetArea() => _lado * _lado;

    /**
     * @brief Calcula a diagonal do quadrado.
     * @return O comprimento da diagonal do quadrado.
     */
    public double GetDiagonal() => _lado * Math.Sqrt(2);
}
