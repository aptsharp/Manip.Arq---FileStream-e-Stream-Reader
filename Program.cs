using System;
using System.IO;

namespace Manip.Arq
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\aff-o\source\repos\Manip.Arq\Msg.txt";
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path); //estancia o streamReader de uma forma automatica
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                    //para ler o arquivo ate o fim.
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                //para fechar o streamReader automaticamente.
            }
        }
    }
}
