using System;
using System.Diagnostics.CodeAnalysis;

namespace RotarNumeros
{
    class program
    {
        static void Main (string[] args)
        {
            string nota = "";
            Console.WriteLine("ingrese valores: ");
            rota();
        }

        static void rota()
        {
            string numero = Console.ReadLine();
            char ultimo = numero [numero.Length - 1];
            String resto = numero.Substring(0, numero.Length -1);
            string resultado = ultimo + resto;
            Console.WriteLine(resultado);
        }
    }
}