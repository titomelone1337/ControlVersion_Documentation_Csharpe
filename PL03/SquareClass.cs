public class SquareClass
{
    private double _lado;

    public SquareClass(double l)
    {
        this._lado = l;
    }

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

    public double GetPerimeter() => _lado * 4;

    public double GetArea() => _lado * _lado;

    public double GetDiagonal() => _lado * Math.Sqrt(2);
}
