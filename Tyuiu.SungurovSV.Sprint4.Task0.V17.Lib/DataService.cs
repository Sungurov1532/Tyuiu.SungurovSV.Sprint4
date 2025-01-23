using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SungurovSV.Sprint4.Task0.V17.Lib
{
    public class DataService : ISprint4Task0V17
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count += array[i];
                }
            }
            return count;
        }
    }
}
