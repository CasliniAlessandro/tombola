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
        int[,] mat = new int[9, 10];
        int[,] mat2 = new int[3, 9];
        int numestrazione=1;


        //CARICAMENTO DELLA MATRICE TABELLONE

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                mat[i, j] = variabile++;
            }
        }

        //STAMPA TABELLONE 
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.SetCursorPosition(j * 3, i + 4);
                Console.Write(mat[i, j]);


            }
            Console.WriteLine();
        }





        // SCHEDA GIOCATORE 1 
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine();
        Console.WriteLine("CARTELLA GIOCATORE 1");

        //CARICAMENTO DELLA MATRICE SCHEDA1
        for (int i = 0; i < 3; i++)
        {
            
            for (int j = 0; j < 9; j++)
            {
                //prima colonna 
                mat2[0, 0] = r.Next(1, 9);
                mat2[1, 0] = r.Next(1, 9);
                mat2[2, 0] = 0;
                //seconda colonna
                mat2[0, 1] = r.Next(10, 19);
                mat2[1, 1] = 0;
                mat2[2, 1] = r.Next(10, 19);
                //terza colonna 
                mat2[0, 2] = 0;
                mat2[1, 2] = r.Next(20, 29);
                mat2[2, 2] = 0;
                //quarta colonna 
                mat2[0, 3] = 0;
                mat2[1, 3] = r.Next(30, 39);
                mat2[2, 3] = r.Next(30, 39);
                //quinta colonna 
                mat2[0, 4] = r.Next(40, 49);
                mat2[1, 4] = 0;
                mat2[2, 4] = 0;
                //sesta colonna 
                mat2[0, 5] = 0;
                mat2[1, 5] = 0;
                mat2[2, 5] = r.Next(50, 59);
                //settima colonna 
                mat2[0, 6] = r.Next(60, 69);
                mat2[1, 6] = r.Next(60, 69);
                mat2[2, 6] = 0;
                //ottava colonna 
                mat2[0, 7] = 0;
                mat2[1, 7] = r.Next(70, 79);
                mat2[2, 7] = r.Next(70, 79);
                //nona colonna 
                mat2[0, 8] = r.Next(80, 90);
                mat2[1, 8] = 0;
                mat2[2, 8] = r.Next(80, 90);
            }

        }

        //STAMPA SCHEDA1
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.SetCursorPosition(j * 3, i + 16);
                Console.Write(mat2[i, j]);
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
                //prima colonna 
                mat2[0, 0] = r.Next(1, 9);
                mat2[1, 0] = r.Next(1, 9);
                mat2[2, 0] = 0;
                //seconda colonna
                mat2[0, 1] = r.Next(10, 19);
                mat2[1, 1] = 0;
                mat2[2, 1] = r.Next(10, 19);
                //terza colonna 
                mat2[0, 2] = 0;
                mat2[1, 2] = r.Next(20, 29);
                mat2[2, 2] = 0;
                //quarta colonna 
                mat2[0, 3] = 0;
                mat2[1, 3] = r.Next(30, 39);
                mat2[2, 3] = r.Next(30, 39);
                //quinta colonna 
                mat2[0, 4] = r.Next(40, 49);
                mat2[1, 4] = 0;
                mat2[2, 4] = 0;
                //sesta colonna 
                mat2[0, 5] = 0;
                mat2[1, 5] = 0;
                mat2[2, 5] = r.Next(50, 59);
                //settima colonna 
                mat2[0, 6] = r.Next(60, 69);
                mat2[1, 6] = r.Next(60, 69);
                mat2[2, 6] = 0;
                //ottava colonna 
                mat2[0, 7] = 0;
                mat2[1, 7] = r.Next(70, 79);
                mat2[2, 7] = r.Next(70, 79);
                //nona colonna 
                mat2[0, 8] = r.Next(80, 90);
                mat2[1, 8] = 0;
                mat2[2, 8] = r.Next(80, 90);
            }
        }

        //STAMPA SCHEDA2
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.SetCursorPosition(j * 3, i + 22);
                Console.Write(mat2[i, j]);
            }
            Console.WriteLine();
        }

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


}
    








