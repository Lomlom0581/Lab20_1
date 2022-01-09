using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_1
{
    class Program
    {        
        delegate double CalcDelegate(double d);
                
        private static double GetCircleLength(double r) => 2 * Math.PI * r;
                
        private static double GetCircleArea(double r) => Math.PI * r * r;

        private static double GetBallVolume(double r) => (4d / 3d) * Math.PI * r * r * r;

        static void Main(string[] args)
        {
            CalcDelegate Calc;

        begin:
            Console.WriteLine("Что будем считать?\n 1 - длину окружности\n 2 - площадь круга \n 3 - объем шара\n 4 - выход\n");
            switch (Console.ReadLine())
            {
                case "1":
                    Calc = GetCircleLength;
                    break;
                case "2":
                    Calc = GetCircleArea;
                    break;
                case "3":
                    Calc = GetBallVolume;
                    break;

                case "4": return;
                default:
                    Console.WriteLine("Неверный ввод");
                    goto begin;
            }
            Console.Write("Введите радиус: ");
            Console.WriteLine("Результат: " + Calc(double.Parse(Console.ReadLine())));
            goto begin;

        }
    }
}
