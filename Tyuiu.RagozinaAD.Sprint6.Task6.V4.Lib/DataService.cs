using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RagozinaAD.Sprint6.Task6.V4.Lib
{
    public class DataService : ISprint6Task6V4
    {
        public string CollectTextFromFile(string path)
        {
            string[] liner;
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    liner = line.Trim().Split(' ');
                    foreach (string c in liner)
                    {
                        if (c.Contains('n'))
                        {
                            resStr += " " + c;
                        }
                    }

                }
            }
            return resStr.Trim();
        }
    }
}

