using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class ConversorDeMoeda
    {
        static int iof = 6;
        public static double Cambio(double dolar, double quantidade)
        {
            double reais = (dolar * quantidade);
            reais = reais + (reais * 0.08);
            return reais;
        }
    }
}
