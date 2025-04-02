using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL03
{
    public class SquareClass
    {

        private double _lado;

        public SquareClass (double l) { 
            this._lado = l;
        
        }

        double getPerimetro()
        {
            double Perimetro = _lado + _lado + _lado + _lado;

            return Perimetro;
        }

        double getArea()
        {
            double Area = 0;
            Area = Math.Pow(2, _lado);

            return Area;
        }

        double getDiagonal()
        {
            double Diagonal = 0;
            Diagonal = _lado * Math.Sqrt(2);
            return Diagonal;
        }
    }
}
