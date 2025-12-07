using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RagozinaAD.Sprint6.Task4.V1.Lib
{
    public class DataService : ISprint6Task4V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int c = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((Math.Sin(x) / (x + 1.2)) + Math.Cos(x) * 7 * x - 2), 2);
                valueArray[c] = y;
                c++;
            }
            return valueArray;
        }
    }
}
