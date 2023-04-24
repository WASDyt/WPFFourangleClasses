using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFourangleClasses.Classes
{
    internal class ClsParallelogram: ClsFourangle
    {
        private double sideA;
        private double sideB;
        private double sideC;
        private double sideD;
        private double height;

        public void SidesCalculation()
        {
            sideA = Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2));
            sideB = Math.Sqrt((X2 - X3) * (X2 - X3) + (Y2 - Y3) * (Y2 - Y3));
            sideC = sideA;
            sideD = sideB;
            Console.WriteLine("Стороны параллелограмма");
            Console.WriteLine($"Стороная A={Math.Round(sideA, 2)}");
            Console.WriteLine($"Стороная B={Math.Round(sideB, 2)}");
            Console.WriteLine($"Стороная C={Math.Round(sideC, 2)}");
            Console.WriteLine($"Стороная D={Math.Round(sideD, 2)}");
        }
        public void HeightCalculation()
        {
            height = Math.Sqrt((sideA * 2 + sideB *2));
        }
        public double Perimetr()
        {
            return Math.Sqrt((sideB*sideB) - X1);
        }
        public double Ploshad()
        {
            double s = 0;
            double p = Perimetr() / 2.0;
            s = height * sideA;
            return s;
        }
    }
}
