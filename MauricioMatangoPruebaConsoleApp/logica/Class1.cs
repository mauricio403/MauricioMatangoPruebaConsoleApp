using System;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;




namespace logica
{
    public class logicaParalelismo
    {
        public static void numeroPersonas()
        {
            int[,] Matriza = new int[12, 8];

            for (int filas = 0; filas < Matriza.GetLength(0); filas++)
            {
                for (int columna = 0; columna < Matriza.GetLength(1); columna++)
                {
                    var numero = new Random();

                    var aleatorio = numero.Next(1, 6);

                    Matriza[filas, columna] = aleatorio;
                }

            }

            Parallel.for (int filas = 0; filas < Matriza.GetLength(0); filas++)
            {
                for (int columna = 0; columna < Matriza.GetLength(1); columna++)
                {
                    Console.WriteLine("El numero de pisos es " + filas);
                    Console.WriteLine("El numero de apartamentos dentro de cada piso es " + columna);

                    Console.WriteLine("Ël numero de personas en dicho piso es " + Matriza[filas, columna].ToString());
                }

            }



        }
    }
}
