using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KarandaAR.Sprint4.Task2.V19.Lib
{
    public class DataService : ISprint4Task2V19
    {
        public int Calculate(int[] array)
        {
            int count = 0;
            foreach (var item in array)
            {
                if (item % 2 == 1)
                {
                    count += item;
                }
            }
            return count;
        }
    }
}
