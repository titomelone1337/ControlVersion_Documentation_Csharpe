public class SquareClass
{
    private double _lado;

    public SquareClass(double l)
    {
        this._lado = l;
    }

    public double GetPerimeter() => _lado * 4;

    public double GetArea() => _lado * _lado;

    public double GetDiagonal() => _lado * Math.Sqrt(2);
}
