using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RagozinaAD.Sprint6.Task3.V29.Lib
{
    public class DataService : ISprint6Task3V29
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int[] temp = new int[rows];
            for (int i=0;i<rows;i++)
            {
                temp[i] = matrix[i, columns - 1];
            }
            Array.Sort(temp);
            for (int i = 0; i < rows; i++)
            {
                matrix[i, columns - 1] = temp[i];
            }
            return matrix;
        }
    }
}


