using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Math;


namespace WpfApp1.Physic
{
    public class Pifagor
    {
        static double CalculateHypotenuse(int a, int b, int angel) 
        {
            double c = Math.Pow(a, 2) + Math.Pow(b, 3) - (2 * b * a) * Math.Cos(angel);
            return Math.Sqrt(c);
        }
    }
}
