using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShustovTS.Sprint2.Task3.V28.Lib
{
    public class DataService : ISprint2Task3V28
    {
        public double Calculate(double x)
        {
            double res;
            if (x > 1)
            {
                res = x + Math.Pow((Math.Cos(Math.Pow(x, 2))) / (x - 1), x + 3);
            }
            else if (x == 0)
            {
                res = (Math.Pow(x, 2) + Math.Cos(Math.Pow(x, 2)) - 11) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 2);
            }
            else if (x > -32 && x < -1)
            {
                res = Math.Pow((Math.Cos(x)) / (Math.PI - x), 2);
            }
            else
            {
                res = x + 10 * x - (7 / x);
            }
            return Math.Round(res, 3);
        }
    }
}

