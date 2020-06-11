using System;
using System.IO;

public class ProcessFile
{
    public static void Verificacao()
    {
        {
            try
            {
                using (StreamReader sr = File.OpenText("data.txt"))
                {
                    Console.WriteLine($"A primeira linha do seu arquivo é {sr.ReadLine()}");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Arquivo não encontado");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"O diretório não foi encontrado");
            }
            catch (IOException)
            {
                Console.WriteLine($"O arquivo não pode ser carregado");
            }
        }
    }
}