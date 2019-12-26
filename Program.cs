using System;
using System.IO;

namespace Manip.Arq
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\aff-o\source\repos\Manip.Arq\Msg.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                //duas linhas de codigo não são viaveis para fazer a instanciação
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}
