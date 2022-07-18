using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Diretorio
{
    // Arquivo que faz a leitura e apaga as pastas
    public class Arquivos 
    { 
        // Ler arquivos
        public void GetReadingFile(string nameFile, string formatFile)
        {
            string Path = $@"C:\ClinicaFulano\{nameFile}.{formatFile}";
            using(StringReader reading = new StringReader(Path))
            {
                reading.ReadLine();
            }
        }

        // lendo varios Arquivos
        public void GetReadingManyFiles(string nameFile, int NumberFile, string formatFile)
        {
            string Path = $@"C:\ClinicaFulano\{nameFile}_{NumberFile}.{formatFile}";
            using (StreamReader arquivo = File.OpenText(Path))
            {
                string line;
                while ((line = arquivo.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            string Path2 = $@"C:\ClinicaFulano\{nameFile}_{NumberFile}.{formatFile}";
            if (File.Exists(Path2))
            {
                GetReadingManyFiles(Path2, NumberFile+1, formatFile);
            }
        }
        // Deleta o arquivo desejado
        public void SetDeleteFile(string nameFile, string formatFile)
        {
            string Path = $@"C:\ClinicaFulano\{nameFile}.{formatFile}";

            if (File.Exists(Path))
            {
                try
                {
                    File.Delete(Path);
                }
                catch (Exception e)
                {
                    Console.WriteLine("The deletion failed: {0}", e.Message);
                }
            }
            else
            {
                Console.WriteLine("Specified file doesn't exist");
            }
        }
    }
}
