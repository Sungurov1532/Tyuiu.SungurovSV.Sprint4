using Tyuiu.SungurovSV.Sprint4.Task3.V4.Lib;
namespace Tyuiu.SungurovSV.Sprint4.Task3.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
            {
                {6, 5, 4, 1, 5},
                {8, 2, 3, 4, 2},
                {3, 7, 7, 1, 3},
                {3, 4, 8, 1, 3},
                {4, 3, 5, 5, 2},
            };

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            Console.Title = "Спринт #4 | Выполнил: Сунгуров В.А. | СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:4.3 Двумерные массивы(статический ввод)                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Сунгуров Владислав Александрович | СМАРТб-24-1                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 8. Найдите минимальный      *");
            Console.WriteLine("* элемент в последнем столбце массива.                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Massive: ");

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(matrix);

            Console.WriteLine($"Минимальное значение в последнем столбце: {res}");
            Console.ReadKey();
        }
    }
}
