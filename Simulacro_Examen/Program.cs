using System; 
namespace Simulacro
{
    class Simulacro
    {
        static void Main (string[] args)
        {
            int cantidad = 1597186;
            filtrarDigitosImpares(123456);
            filtrarDigitosParesA(123456);
            filtrarDigitosMultiplos3(123456789);
            filtrarDigitosImpares(12345678);
            filtrarPirmos(123456789);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            int[,] matriz = GenerarMatrizPatron(3, 5);
            ImprimirMatriz(matriz);
            Console.WriteLine("");
            Console.WriteLine("");

            int[,] matriz1 = GenerarMatrizPatronA(5 , 5);
            ImprimirMatriz(matriz1);
            Console.WriteLine("");
            Console.WriteLine("");

            int[,] matriz2 = GenerarMatrizPatron(4, 5);
            ImprimirMatriz(matriz2);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("");

            //EJERCICIO 2
            Console.WriteLine("la cantidad de letras de la oracion es: ");
            Console.WriteLine(ContarLetras("holas me llamo angel"));
            Console.WriteLine("");
            Console.WriteLine("");
            
            // A)
            Console.WriteLine("la cantidad de vocales es: ");
            Console.WriteLine(ContarVocales("holas me llamo angel"));







        }


            //----------------inciso de ejemplo EJERCICIO1
            static void filtrarDigitosImpares(int numero)
            {
            int resultado = 0;
            int potencia = 1;
            // Recorrer cada dígito del número
            while (numero != 0)
            {
            int digito = numero % 10; // saco el ultimo digito en una variable
            // Si el dígito es impar, agregarlo al resultado
            if (digito % 2 != 0) //si el el resto entre un numero dividido en 2 es 0, es par
            {
            resultado += digito * potencia; // hace que el numero se vaya colocando delante
            potencia *= 10;
            }
            // Dividir el número por 10 para pasar al siguiente dígito
            numero /= 10;
            }
            Console.WriteLine("El resultado es: " + resultado);
            }


            // ------------------EJERCICIO 1 inciso A
              static void filtrarDigitosParesA(int numero)
            {
            int resultado = 0;
            int potencia = 1;
            // Recorrer cada dígito del número
            while (numero != 0)
            {
            int digito = numero % 10; // saco el ultimo digito en una variable
            // Si el dígito es impar, agregarlo al resultado
            if (digito % 2 == 0) //si el el resto entre un numero dividido en 2 es 0, es par
            {
            resultado += digito * potencia; // hace que el numero se vaya colocando delante
            potencia *= 10;
            }
            // Dividir el número por 10 para pasar al siguiente dígito
            numero /= 10;
            }
            Console.WriteLine("El resultado es: " + resultado);
            }



            //------------------EJERCIOCIO 1 inciso B--------------
              static void filtrarDigitosMultiplos3(int numero)
            {
            int resultado = 0;
            int potencia = 1;
            // Recorrer cada dígito del número
            while (numero != 0)
            {
            int digito = numero % 10; // saco el ultimo digito en una variable
            // Si el dígito es impar, agregarlo al resultado
            if (digito % 3 == 0) //si el el resto entre un numero dividido en 2 es 0, es par
            {
            resultado += digito * potencia; // hace que el numero se vaya colocando delante
            potencia *= 10;
            }
            // Dividir el número por 10 para pasar al siguiente dígito
            numero /= 10;
            }
            Console.WriteLine("El resultado es: " + resultado);
            }


            // ----------------------EJERCICIO 1 inciciso 1c--------------- 
            static void filtrarPirmos(int numero)
            {
            int resultado = 0;
            int potencia = 1;
            // Recorrer cada dígito del número
            while (numero != 0)
            {
            int digito = numero % 10; // saco el ultimo digito en una variable
            // Si el dígito es impar, agregarlo al resultado
            if (digito >1 && esPrimo(digito)) //si el el resto entre un numero dividido en 2 es 0, es par
            {
            resultado += digito * potencia; // hace que el numero se vaya colocando delante
            potencia *= 10;
            }
            // Dividir el número por 10 para pasar al siguiente dígito
            numero /= 10;
            }
             Console.WriteLine("El resultado es: " + resultado);
            }

            // FUNCION PARA SABER SI UN NUMERO ES PRIMO
            static bool esPrimo(int numero) // devuelve true si es primo    
            {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        //-------------------EJERCICIO 2 ---------------------
        static int ContarLetras(string oracion)
        {
            int contador = 0; // Inicializamos un contador para contar las letras
            foreach (char caracter in oracion) // Iteramos sobre cada caracter en la oración
            {
                 if (!char.IsWhiteSpace(caracter)) // Verificamos si el caracter no es un espacio en blanco
                {
                    contador++; // Si el caracter no es un espacio en blanco, incrementamos el contador
                }
            }
                 return contador; // Devolvemos la cantidad total de letras encontradas en la oración
        }

        // oeprador or es = alt + 124
        static int ContarVocales(string oracion)
        {
            int contador = 0; // Inicializamos un contador para contar las letras
            foreach (char caracter in oracion) // Iteramos sobre cada caracter en la oración
            {
                 if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' ||
                    caracter == 'A' || caracter == 'E' ||  caracter == 'I' || caracter == 'O')  
                {
                    contador++; // Si el caracter no es un espacio en blanco, incrementamos el contador
                }
            }
                 return contador; // Devolvemos la cantidad total de letras encontradas en la oración
        }


        // ------------------- EJERCIOCIO 4 -----------------------
         static void ImprimirMatriz<T>(T[,] matriz)
        {
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    Console.Write(matriz[fila, columna] + "\t");
                }
                Console.WriteLine();
            }
        }
            static int[,] GenerarMatrizPatron(int filas, int columnas)
            {
                int[,] matriz = new int[filas, columnas];
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                    matriz[i, j] = i + 1;
                    }
                }
                return matriz;
            }

              static int[,] GenerarMatrizPatronA(int filas, int columnas)
            {
                int[,] matriz = new int[filas, columnas];
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                    matriz[i, j] = i + j + 1;
                    }
                }
                return matriz;
            }           

             static int[,] GenerarMatrizPatronB(int filas, int columnas)
            {
                int[,] matriz = new int[filas, columnas];
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                    matriz[i, j] = (i + 1)  * ( j + 1);
                    }
                }
                return matriz;
            }           

             static void imprimirVector(int[] vector)
                {
                    string vectorString = ""; 
                    foreach(int elemento in vector)
                    {
                        vectorString = vectorString + elemento + " "; 
                    }
                    Console.WriteLine(vectorString);      
                }
                                        
                        
                        
                               
                        
                        
            

        
    }
}