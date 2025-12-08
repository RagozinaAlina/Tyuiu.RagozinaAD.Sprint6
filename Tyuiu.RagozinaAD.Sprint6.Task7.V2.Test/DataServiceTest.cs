using Tyuiu.RagozinaAD.Sprint6.Task7.V2.Lib;
namespace Tyuiu.RagozinaAD.Sprint6.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Алина\Desktop\source\repos\Tyuiu.RagozinaAD.Sprint6\Sprint6Task7\InPutDataFileTask7V2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
