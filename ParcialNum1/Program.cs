using System; 
namespace Simulacro
{
    class Simulacro
    {
        static void Main (string[] args)
        {
            //Console.WriteLine(RotarDigitoA(456822));
            Console.WriteLine("");

            //Console.WriteLine(RotarDigitoMedio(12345));

             ;
             int[] numeros = {2, 8, 10, 3, 3, 3};  //inicializacion del vector
             imprimirVector(numeros); 
             Console.WriteLine(SumarElementosVectorA(numeros));

             Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

             int[,] matriz2 = LlenarMatrizSerpiente(4, 3);
             ImprimirMatriz(matriz2);

            

        }

         static int RotarDigito(int numero)
            {
            // Convertimos el número a una cadena para manipular sus dígitos
            string numeroString = numero.ToString();
            // Tomamos el último dígito y lo movemos a la primera posición
            char ultimoDigito = numeroString[numeroString.Length - 1];
            string nuevoNumeroString = ultimoDigito +
            numeroString.Substring(0, numeroString.Length - 1);
            // Convertimos la cadena resultante de nuevo a un número
            int nuevoNumero = int.Parse(nuevoNumeroString);
            return nuevoNumero;
            }


        /*********************
         *   EJERCICIO 1 (A) *
         *********************/

        static int RotarDigitoA(int numero)
        {
            // Convertimos el número a una cadena para manipular sus dígitos
            string numeroString = numero.ToString();
            // Tomamos el último dígito y lo movemos a la primera posición
            char ultimoDigito = numeroString[numeroString.Length - 1];
            char penultimoDigito = numeroString[numeroString.Length -2 ];

            string nuevoNumeroString = ultimoDigito +
            numeroString.Substring(0, numeroString.Length - 1);

            string nuevoNum2 = penultimoDigito + 
            nuevoNumeroString.Substring(0, nuevoNumeroString.Length -1);

            // Convertimos la cadena resultante de nuevo a un número
            int nuevoNumero = int.Parse(nuevoNum2);
            return nuevoNumero;
        }       

        /*********************
         *   EJERCICIO 1 (B) *
         *********************/

         static int RotarDigitoMedio(int numero)
            {
            // Convertimos el número a una cadena para manipular sus dígitos
            string numeroString = numero.ToString();
            // Tomamos el último dígito y lo movemos a la primera posición
            char ultimoDigito = numeroString[numeroString.Length / 2];
            string nuevoNumeroString = ultimoDigito +
            numeroString.Substring(0, numeroString.Length -1 / 2);
            // Convertimos la cadena resultante de nuevo a un número
            int nuevoNumero = int.Parse(nuevoNumeroString);
            return nuevoNumero;
            }

        /*********************
         *   EJERCICIO 1 (C) *
         *********************/

        /*********************
         *   EJERCICIO 3  *
         *********************/
        static int SumarElementosVector(int[] vector)
        {
        int suma = 0;
        foreach (int elemento in vector)
        {
        suma += elemento; // Acumulamos la suma de cada elemento del vector
        }
        return suma;
        }

        /*********************
         *   EJERCICIO 3 (A) *
         *********************/
        static int SumarElementosVectorA(int[] vector)
        {
        int sumaPar = 0;
        int sumaImpar = 0;
            foreach (int elemento in vector)
            {
            if(elemento % 2 == 0){
                sumaPar += elemento; // Acumulamos la suma de cada elemento del vector
            }else {
                sumaImpar += elemento;
            }
            }
            return sumaPar - sumaImpar;
            }
            
            
            //imprimir vector  
            static void imprimirVector(int[] vector)
            {
                string vectorString = ""; 
                foreach(int elemento in vector)
                {
                    vectorString = vectorString + elemento + " "; 
                }
                Console.WriteLine(vectorString);      
            }

        /*********************
         *   EJERCICIO 4 (A) *
         *********************/

        static int[,] LlenarMatrizSerpiente(int filas, int columnas)
        {
        int[,] matriz = new int[filas, columnas]; // Crear una matrizvacía con las dimensiones especificadas
        int valor = 0;
        int aux = 1;
        for (int fila = 0; fila < filas; fila++)
        {
        // Determinar la dirección de llenado de la fila (izquierdaa derecha o derecha a izquierda)
        bool derecha = fila % 2 == 0;
        // Llenar la fila en la dirección determinada
        if (derecha)
        {
        for (int columna = 0; columna < columnas; columna++)
        {
        matriz[fila, columna] = valor;
        valor+=2;
        }
        }
        else
        {
        for (int columna = columnas - 1; columna >= 0; columna--)
        {
        matriz[fila, columna] = aux;
        aux+=2;
        }
        }
        }
        return matriz;
        }

        //imprimir matriz
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



    }    
}

