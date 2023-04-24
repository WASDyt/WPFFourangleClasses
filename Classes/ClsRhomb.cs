using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFourangleClasses.Classes
{
    internal class ClsRhomb : ClsParallelogram

    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        private int x3;
        private int y3;
        private int x4;
        private int y4;
        private double sideA;
        private double diagonal1;
        private double diagonal2;

        public void SidesCalculation()
        {
            sideA = Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2));
            Console.WriteLine("Сторона ромба");
            Console.WriteLine($"Стороная A={Math.Round(sideA, 2)}");
        }
        public void DiagonalsCalculation()
        {
            diagonal1 = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
            diagonal2 = Math.Sqrt((x2 - x4) * (x2 - x4) + (y2 - y4) * (y2 - y4));
            Console.WriteLine($"Диагональ1 ={Math.Round(diagonal1, 2)}");
            Console.WriteLine($"Диагональ2 ={Math.Round(diagonal2, 2)}");
        }
        public double Perimetr()
        {
            return 4 * sideA;
        }
        public double Ploshad()
        {
            double s = 0;
            double p = Perimetr() / 2.0;
            s = (diagonal1*diagonal2)/2;
            return s;
        }
    }
}
