﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SungurovSV.Sprint4.Task2.V25.Lib
{
    public class DataService : ISprint4Task2V25
    {
        public int Calculate(int[] array)
        {
            int count = 1;

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count *= array[i];
                }
            }
            return count;
        }
    }
}
