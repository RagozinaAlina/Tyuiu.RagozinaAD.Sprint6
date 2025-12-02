using Tyuiu.RagozinaAD.Sprint6.Task3.V29.Lib;
namespace Tyuiu.RagozinaAD.Sprint6.Task3.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 5;
            int columns = 5;
            int[,] mtrx = new int[rows, columns];
            int[,] start = new int[5, 5] { { -2, -13, -15, -9, -17 },
                                           { 13, -20, -15, 27, 18 },
                                           { -12, -1, -20, 13, 0 },
                                           { 15, 32, 18, -12, -18 },
                                           { 16, 5, 3, -5, -8 } };
            DataService ds = new DataService();
            int[,] res = ds.Calculate(start);
            int[,] wait = new int[5, 5] { { -2, -13, -15, -9, -18 },
                                           { 13, -20, -15, 27, -17 },
                                           { -12, -1, -20, 13, -8 },
                                           { 15, 32, 18, -12, 0 },
                                           { 16, 5, 3, -5, 18 } }; ;
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
