using System;
using System.Linq.Expressions;
namespace Pruebas{
    public class Errores{
static void Main(string[] args)
        {
        /*
         try
         {

         Console.WriteLine("Suma de dos numeros");
         Console.WriteLine("ingrese el pirmer número");   
         int num1 = Int32.Parse(Console.ReadLine());
         Console.WriteLine("ingrese el segundo número");
         int num2 = Int32.Parse(Console.ReadLine());
         int resultado = suma_elementos(num2, num1);

            if(resultado > 10 )
            {
                throw new ExepcionSuma("La suma es mayor a 10");
            } 
        }
            catch(ExepcionSuma e)
            {
                Console.WriteLine(e.Message);
            }
            
            catch(Exception e)
            {
                Console.WriteLine(e.Message); 
            }
            */


        /*
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
        
        try
        {
            int[] numeros = {1,2,3,2,1}; 
            ImprimirVector(numeros); 
            int[] Vect = VoltearVector(numeros); 
            ImprimirVector(Vect);
            bool sonIguales = numeros.SequenceEqual(Vect);
            if(sonIguales)
            {
                throw new Exception("El vector es capicúa");
            }
        }
        catch(ExepcionCapicua e)
        {
            Console.WriteLine(e.Message);
        }
        catch(Exception e)
        {
              Console.WriteLine(e.Message); 
        }
        finally
        {
            Console.WriteLine("Gracias por el uso");
        }
        */

        string ruta = "C:/UPC/AngelSoto_Programaci-n/Expeciones Errores.tct";
        
        } // MAIN
          static int suma_elementos(int elemento1, int elemento2) //sumar dos numeros
        {
            int suma = elemento1 + elemento2;
            return suma;

        }
      
          ///cuenta la cantidad de vocales de una palabra
        static void contarVocales()
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine().ToLower(); // Convertir la palabra a minúsculas para comparar

            int contadorVocales = 0;

            foreach (char letra in palabra)
            {
                if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                {
                    contadorVocales++;
                }
            }

            Console.WriteLine("La palabra ingresada tiene " + contadorVocales + " vocales.");

        }
        //VOLTEAR VECTOR 
         static int[] VoltearVector(int[] vector)
        {
        int[] vectorVolteado = new int[vector.Length];
        for (int i = 0; i < vector.Length; i++)
        {
            vectorVolteado[i] = vector[vector.Length - 1 - i];
        }
            return vectorVolteado;
        }
        //IMPRIMIR VECTOR 
        static void ImprimirVector(int[] vector)
        {
        foreach (int elemento in vector)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }


    }//CLASE ERRORES 
    
        public class ExepcionPar : Exception
        {
            public ExepcionPar(string message) : base(message)
            {

            }
        }
          public class ExepcionSuma : Exception
        {
            public ExepcionSuma(String message) : base(message)
            {

            }

        }
         public class ExepcionCapicua : Exception
        {
            public ExepcionCapicua(String message) : base(message)
            {

            }

        }
    
    

}    
