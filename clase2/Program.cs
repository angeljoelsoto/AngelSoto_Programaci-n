using System; 

namespace NotaAlumno
{
    class program{
        static void Main (string[] args)
        {
            /*
            Console.WriteLine("Por favor, ingrese la pirmera nota: ");  
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, ingrese la segunda nota: ");
            int nota2 = int.Parse(Console.ReadLine());

            int notaFinal = ((nota1 + nota2)/2);

            EvaluarNota(notaFinal);
            //EvaluarNota(((nota1 + nota2)/2))*/
            rota(); 
            //rotaDos();

        }

        static void EvaluarNota(int notaFinal)
        {
            if(notaFinal > 50)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROBADO");
            }
        }
        
        static void rota()
        {
            string numero = Console.ReadLine();
            char ultimo = numero [numero.Length - 1];
            String resto = numero.Substring(0, numero.Length -1);
            string resultado = ultimo + resto;
            Console.WriteLine(resultado);
        }
         static void rotaDos()
        {
            string numero = Console.ReadLine();
            char primero = numero [0];
            char segundo = numero[1];
            String resto = numero.Substring(2, numero.Length -2);
            string resultado = resto + primero + segundo;
            Console.WriteLine(resultado);
        }
    }
     
}
