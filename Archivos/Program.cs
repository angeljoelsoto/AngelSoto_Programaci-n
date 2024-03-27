using System;
namespace Archivos
{
    public class Program
    {
        static void Main(String[] args)
        {
            string ruta = "C:/UPC/AngelSoto_Programaci-n/Archivos/clase2.txt";
            FileStream archivo = null; 

            string ruta2 = "C:/UPC/AngelSoto_Programaci-n/Archivos/AngelJoel.txt";
            FileStream archivo2 = null;

            string ruta3 = @"Joel.text";
            FileStream archivo3 = null; 

            archivo = File.Open(ruta, FileMode.OpenOrCreate);
            archivo2 = File.Open(ruta2, FileMode.OpenOrCreate);
            archivo3 = File.Open(ruta3, FileMode.OpenOrCreate);
        }
    }
}