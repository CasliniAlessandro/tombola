using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    public static void Main(string[] args)
    {
        //dichiarazioni 
  
        Console.WriteLine("TOMBOLA");

        Console.WriteLine("TABELLONE");

        int variabile;
        variabile = 1;
        Random r = new Random();
        int[,] mat = new int[9,10];
        int[,] mat2 = new int[3,5];
        int numestrazione=1;


        //CARICAMENTO DELLA MATRICE TABELLONE

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                
                mat[i, j] = variabile++ ;

                if (mat[i, j] == numestrazione)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                
            }
            Console.WriteLine();


            for (int k = 0; k < 10; k++)
            {
                Console.Write(mat[i,k]+" ") ;

                
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }


        // SCHEDA GIOCATORE 1 
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine();
        Console.WriteLine("CARTELLA GIOCATORE 1");

        //CARICAMENTO DELLA MATRICE SCHEDA1
        for (int i = 0; i < 3; i++)
        {
            
            for (int j = 0; j<5; j++)
            {
                mat2[i, j] = r.Next(1,90);

                if (mat2[i, j] == numestrazione)
                {
                    Console.WriteLine("Il vincitore è il giocatore 1");
                }

            }
            Console.WriteLine();
            for (int k = 0; k < 5; k++)
            {
                Console.Write(mat2[i, k] + " ");
            }
            Console.WriteLine();
        }
        //SCHEDA GIOCATORE 2 
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();
        Console.WriteLine("CARTELLA GIOCATORE 2");

        //CARICAMENTO DELLA MATRICE SCHEDA2
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
             
                mat2[i, j] = r.Next(1,90);

                if (mat2[i, j] == numestrazione)
                {
                    Console.WriteLine("Il vincitore è il giocatore 2") ;
                }

            }
            Console.WriteLine();
            for (int k = 0; k < 5; k++)
            {
                Console.Write(mat2[i, k] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //ESTRAZIONE NUMERI 
        Console.ForegroundColor = ConsoleColor.White;

        for (int i = 1; i < 91; i++)
        {
            Console.WriteLine("Numero estratto: ");
            Console.WriteLine(numestrazione = r.Next(1, 90));
            Console.WriteLine("Premere un tasto per continuare:"); 
            Console.ReadLine();

        }



         





    }

