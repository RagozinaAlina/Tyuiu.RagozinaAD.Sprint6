using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RagozinaAD.Sprint6.Task6.V4.Lib
{
    public class DataService : ISprint6Task6V4
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] itog = line.Split(' ');
                    for (int i = 0; i < itog.Length; i++)
                    {
                        if (itog[i].Contains("n"))
                        {
                            resStr = resStr + " " + itog[i];
                        }
                    }
                }
                return resStr;
            }
        }
    }
}
