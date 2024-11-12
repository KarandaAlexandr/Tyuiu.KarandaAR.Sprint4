using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KarandaAR.Sprint4.Task3.V26.Lib
{
    public class DataService : ISprint4Task3V26
    {
        public int Calculate(int[,] array)
        {

            int maxInSecondRow = array[1, 0];
            for (int j = 1; j < 5; j++)
            {
                if (array[1, j] > maxInSecondRow)
                {
                    maxInSecondRow = array[1, j];
                }
            }

            return maxInSecondRow;
        }
    }
}
