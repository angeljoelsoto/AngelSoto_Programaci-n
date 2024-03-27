using System;

namespace Errores
{
    class Program
    {
        static void Main(string[] args)
        {
         int numero = 2;
         try
         {
            if((numero % 2) == 0)
            {
                throw new ExepcionPar("es un numero par"); 
            }

         }
         catch(ExepcionPar e)
         {
            Console.WriteLine(e.Message);
         }
        
        }

        public class ExepcionPar : Exception
        {
            public ExepcionPar(string message) : base(message)
            {

            }
        }
    }   
}     