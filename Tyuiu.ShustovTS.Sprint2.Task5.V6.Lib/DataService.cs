using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShustovTS.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string[] suit = new string[4] { "пики", "трефы", "бубны", "червы" };
            string res = "";
            switch (value2)
            {
                case 6:
                    res = $"Шестёрка {suit[value1 - 1]}";
                    break;
                case 7:
                    res = $"Семёрка {suit[value1 - 1]}";
                    break;
                case 8:
                    res = $"Восьмёрка {suit[value1 - 1]}";
                    break;
                case 9:
                    res = $"Девятка {suit[value1 - 1]}";
                    break;
                case 10:
                    res = $"Десятка {suit[value1 - 1]}";
                    break;
                case 11:
                    res = $"Валет {suit[value1 - 1]}";
                    break;
                case 12:
                    res = $"Дама {suit[value1 - 1]}";
                    break;
                case 13:
                    res = $"Король {suit[value1 - 1]}";
                    break;
                case 14:
                    res = $"Туз {suit[value1 - 1]}";
                    break;
                default:
                    res = "Некорректный ввод, попробуйте снова.";
                    break;
            }
            return res;
        }
    }
}
