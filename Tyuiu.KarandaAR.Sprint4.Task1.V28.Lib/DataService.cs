using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KarandaAR.Sprint4.Task1.V28.Lib
{
    public class DataService : ISprint4Task1V28
    {
        public int Calculate(int[] array)
        {
            int count = 1;
            foreach (var item in array)
            {
                if (item % 2 == 1)
                {
                    count *= item;
                }
            }
            return count;
        }
    }
}
