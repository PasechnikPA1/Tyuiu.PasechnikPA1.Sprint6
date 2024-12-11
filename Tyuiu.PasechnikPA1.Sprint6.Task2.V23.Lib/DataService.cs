using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PasechnikPA1.Sprint6.Task2.V23.Lib
{
    public class DataService : ISprint6Task2V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[stopValue - startValue + 1];
            for (int x = startValue, i = 0; x <= stopValue; i++, x++)
            {
                if (2 * x - 2 != 0)
                {
                    result[i] = Math.Round(4 - 2 * x + (2 + Math.Cos(x)) / (2 * x - 2), 2);
                }
                else
                {
                    result[i] = 0;
                }
            }
            return result;
        }
    }
}
