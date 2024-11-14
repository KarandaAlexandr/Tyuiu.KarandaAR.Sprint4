using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KarandaAR.Sprint4.Task7.V12.Lib
{
    public class DataService : ISprint4Task7V12
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix =  new int[n, m];

            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }

            int summ = 0;

            for (int i = 0;i < n; i++)
            {
                for(int j = 0;j < m; j++)
                {
                    if (matrix[i, j] % 2 == 1)
                    {
                        summ += matrix[i, j];
                    }
                }
            }
            return summ;
        }
    }
}
