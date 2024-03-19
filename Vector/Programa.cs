using System;
using System.Diagnostics.Contracts;
using System.Reflection.PortableExecutable;
using System.Runtime.Serialization.Formatters;

namespace Vectores{
public class Vectores
{
static void Main(string[] args)
  { 
    /*int[] numeros = new int []{1, 2, 3, 4 5};

    char[] letras = new char[]{'a', 'b', 'c', 'd', 'e'};

    string[] palabras = new string[]{"hola", "mundo", "es", "genial"};
    */

    
    int[] numeros = {11,  5, 3, 4, 5, 6, 7, 8};  //inicializacion del vector

    imprimirVector(numeros); 
    //cambiosDeDatos();

    //sumaNumeroImpares(numeros);

    //sumaNumParImp(numeros);

    m3(numeros);    //multiplos de 3
    



  }

  //----------------FUNCIONES Y MÉTODOS -----------------------------------

  //imprime le vector en forma de cadena de texto
  static void imprimirVector(int[] vector)
  {
    string vectorString = ""; 
    foreach(int elemento in vector)
    {
        vectorString = vectorString + elemento + " "; 
    }
    Console.WriteLine(vectorString);      
  }

     //sumar elementos de los vectores  
    static void sumaVectores(int[] vector)
    {
      int suma = 0; 
      foreach(int elemento in vector)
      {
        suma = suma + elemento;
      }
    }

    static void sumaVectores2(int[] vectores)
    {
      int suma = 0;
      foreach(int elemento in vectores)
      {
        suma = suma + elemento;
        if(elemento > 4)
        {
          break;
        }
      }
      Console.WriteLine(suma);
    }
    static void sumaNumeroImpares(int[] vectores)
    {
      int suma = 0;
      foreach(int elemento in vectores)
      {
        if((elemento % 2) !=0)
        {
          suma = suma + elemento;
        }
      }
      Console.WriteLine(suma);
    }

     static void sumaNumeroPares(int[] vectores)
    {
      int suma = 0;
      foreach(int elemento in vectores)
      {
        if((elemento % 2) == 0)
        {
          suma = suma + elemento;
        }
      }
      Console.WriteLine(suma);
    }


      //suma los numeros pares y los numeros impares de forma separada 
     static void sumaNumParImp(int[] vectores)
    {
      int par = 0;
      int impar = 0;

         foreach(int elemento in vectores)
        {
            if((elemento % 2) !=0)
          {
              impar = impar + elemento;
          }
        }
          Console.WriteLine("la suma de los impares es : " + impar);

          foreach(int elemento in vectores)
      {
        if((elemento % 2) ==0)
        {
          par = par + elemento;
        }
      }
      Console.WriteLine("la suma de los pares es: " + par);
      }


       //Variante que hizo diego con la funcion que suma los pares e impares de un vector (elegante)
    static void sumaDeDiego(int[] vectores)
    {
      int par = 0;
      int impar = 0;

         foreach(int elemento in vectores)
        {
            if((elemento % 2) !=0)
            {
                impar = impar + elemento;
            }
            if((elemento % 2) == 0)
            {
                par = par + elemento;
            }
          
          Console.WriteLine("la suma de los impares es : " + impar);
          Console.WriteLine("la suma de los pares es: " + par);
        
        }
    }

    static void cambiosDeDatos()
     {
    int[] numeros = {1, 2 , 3, 4, 5, 6, 7, 8};
    imprimirVector(numeros);

    numeros[2] = 100;
    imprimirVector(numeros);
    }


    static void inetrcambiarPoscion(int[] cambio )
    {
      int temp = cambio[3];
      cambio[3] = cambio[2];
      cambio[2] = temp;
      Console.WriteLine("");
    }

      //cuenta cuantos elementos del vector son multiplos de 3 
       static void m3 (int[] vectores)
    {
      int contador = 0;
        foreach(int elemento in vectores)
        {
          if((elemento % 3) == 0)
          { 
            contador = contador + 1; 

          }
        }
      Console.WriteLine(contador);
    }

    //recorrer vectores, ingresa un nuvo dato y recogern los demas 

    static int[] ingresar(int[] vector, int nuevoElemento, int posicion)
    {
       

        return vector ; 
    }
  }

}
 
