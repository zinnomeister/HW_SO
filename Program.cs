using System;


namespace VideoLes007
{

    class program
    {
        static void Main(string[] args)
        {
                fuelConsReadingPoint:
            double fuelConsumption;

            Console.WriteLine("Укажите расход топлива (кг/час)");


            fuelConsumption = int.Parse(Console.ReadLine());

            if (fuelConsumption <= 0)
            {
                Console.WriteLine("Введено неверное значение");
                goto fuelConsReadingPoint;
            }
            else
                Console.WriteLine(String.Format("Расход топлива {0} кг/час", fuelConsumption));

            avgSpeedReadingPoint:
            double averagespeed;

            Console.WriteLine("Укажите среднюю скорость полёта (км/ч)");
            averagespeed = int.Parse(Console.ReadLine());
            if (averagespeed <= 0)
            {
                Console.WriteLine("Введено неверное значение");

                goto avgSpeedReadingPoint;

            }
            else

                Console.WriteLine(String.Format("Средняя скорость полёта {0} км/час", averagespeed));
            fuelRemainReadingPoint:
            double remain;
            Console.WriteLine("Укажите остаток топлива (кг)");
            remain = int.Parse(Console.ReadLine());
            if (remain < 0)
            {
                Console.WriteLine("Введено неверное значение");

                goto fuelRemainReadingPoint;

            }
            else if (remain == 0)
            {
                Console.WriteLine("Топливо не залито! Проверьте прокачку системы!!!");
            
            }
            else
                Console.WriteLine(string.Format("Остаток топлива {0} кг", remain));

            distanceReadingPoint:
            double distance;
            Console.WriteLine("Укажите расстояние от аэродрома вылета до аэродрома посадки (км)");
            distance = int.Parse(Console.ReadLine());
            if (distance <= 300)
            {
                Console.WriteLine("Введено неверное значение. Расстояние не может быть менее 300 км");
                goto distanceReadingPoint;
            }
            else Console.WriteLine(String.Format("Расстояние от аэродрома вылета до аэродрома посадки {0} км", distance));

            double needfuel, reserve;
            reserve = distance / averagespeed * fuelConsumption / 10;
            needfuel = Math.Round ( distance / averagespeed * fuelConsumption - remain + reserve);
            if (needfuel <= 0)
            {
                Console.WriteLine("Топлива для выполнения полёта достаточно. Заправка не требуется");
            }
            else

                Console.WriteLine("Вам потребуется " + needfuel + " кг топлива");


                Console.ReadLine();









        }













    }











}