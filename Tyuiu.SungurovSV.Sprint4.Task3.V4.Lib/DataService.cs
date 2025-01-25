using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SungurovSV.Sprint4.Task3.V4.Lib
{
    public class DataService : ISprint4Task3V4
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int minVal = matrix[0, 4];

            for (int i = 0; i < rows; i++)
            {
                for(int j = 4; j < cols; j++)
                {
                    if (minVal > matrix[i, j])
                    {
                        minVal = matrix[i, j];
                    }
                }
            }
            return minVal;
        }
    }
}
