using System;
using System.IO;

namespace Fundamentos.Api
{

    public static class ExtensaoString { 
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ? Environment.GetEnvironmentVariable("Home") : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%"));


            return path.Replace("~", home);
        }
    }

    public class PrimeiroArquivo
    {
        public void Main()
        {
            var path = @"~/primeiro_arquivo.txt".ParseHome();
            


            if (!File.Exists(path))
            {
                using(StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("esse é");
                    sw.WriteLine("O aquivo");
                    sw.WriteLine("Sendo o primeiro");
                    sw.WriteLine("!");                    
                }
            }
            using (StreamWriter sw = File.AppendText(path)) {

                sw.WriteLine("esse é");
                sw.WriteLine("A continuação");
                sw.WriteLine("Do primeiro primeiro arquivo");
                sw.WriteLine("!");
            }


        }




    }
}
