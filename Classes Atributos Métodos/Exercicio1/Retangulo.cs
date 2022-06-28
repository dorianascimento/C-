using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return (Largura * 2) + (Altura * 2);
        }
        public double Diagonal()
        {
            return Math.Sqrt((Largura * 2) + (Altura * 2));
        }
    }
}
