using Tyuiu.RagozinaAD.Sprint6.Task6.V4.Lib;
namespace Tyuiu.RagozinaAD.Sprint6.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Алина\Desktop\source\repos\Tyuiu.RagozinaAD.Sprint6\Sprint6Task6\InPutDataFileTask6V4.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
