using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace cestino3caslo
{
    internal class Program
    {
        static void Main()
        {
            //dichiarazioni 

            Console.WriteLine("TOMBOLA");

            Console.WriteLine("TABELLONE");

            Console.ReadKey();
            //int variabile = 1;
            Random r = new Random();
            int[,] tab = new int[9, 10];
            int[,] cartella1 = new int[3, 9];
            int[,] cartella2 = new int[3, 9];
            int numestrazione = r.Next(1, 91);


            //CARICAMENTO DELLA MATRICE TABELLONE
            int s = 0;
            for (int j = 0; j < 9; j++) for (int i = 0; i < 10; i++)
                {
                    s++;
                    tab[j, i] = s;
                    Console.SetCursorPosition(1 + i * 4, 3 + j * 2);
                    Console.Write(s);
                }

            Console.WriteLine();

            for (int i = 0; i < 10; i++) for (int j = 0; j < 9; j++) if (tab[j, i] == numestrazione)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(i * 4, 3 + j * 2);
                        Console.Write($" {numestrazione} ");
                    }
            Console.BackgroundColor = ConsoleColor.Black;


            // SCHEDA GIOCATORE 1 
            Console.SetCursorPosition(0, 22);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("CARTELLA GIOCATORE 1");

            //CARICAMENTO DELLA MATRICE SCHEDA1
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 9; j++)
                {
                    //prima colonna 
                    cartella1[0, 0] = r.Next(1, 9);
                    cartella1[1, 0] = r.Next(1, 9);
                    cartella1[2, 0] = 0;
                    //seconda colonna
                    cartella1[0, 1] = r.Next(10, 19);
                    cartella1[1, 1] = 0;
                    cartella1[2, 1] = r.Next(10, 19);
                    //terza colonna 
                    cartella1[0, 2] = 0;
                    cartella1[1, 2] = r.Next(20, 29);
                    cartella1[2, 2] = 0;
                    //quarta colonna 
                    cartella1[0, 3] = 0;
                    cartella1[1, 3] = r.Next(30, 39);
                    cartella1[2, 3] = r.Next(30, 39);
                    //quinta colonna 
                    cartella1[0, 4] = r.Next(40, 49);
                    cartella1[1, 4] = 0;
                    cartella1[2, 4] = 0;
                    //sesta colonna 
                    cartella1[0, 5] = 0;
                    cartella1[1, 5] = 0;
                    cartella1[2, 5] = r.Next(50, 59);
                    //settima colonna 
                    cartella1[0, 6] = r.Next(60, 69);
                    cartella1[1, 6] = r.Next(60, 69);
                    cartella1[2, 6] = 0;
                    //ottava colonna 
                    cartella1[0, 7] = 0;
                    cartella1[1, 7] = r.Next(70, 79);
                    cartella1[2, 7] = r.Next(70, 79);
                    //nona colonna 
                    cartella1[0, 8] = r.Next(80, 90);
                    cartella1[1, 8] = 0;
                    cartella1[2, 8] = r.Next(80, 90);
                }

            }

            //STAMPA SCHEDA1
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.SetCursorPosition(j * 4, i + 25);
                    Console.Write(cartella1[i, j]);
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
                    cartella2[0, 0] = r.Next(1, 9);
                    cartella2[1, 0] = r.Next(1, 9);
                    cartella2[2, 0] = 0;
                    //seconda colonna
                    cartella2[0, 1] = r.Next(10, 19);
                    cartella2[1, 1] = 0;
                    cartella2[2, 1] = r.Next(10, 19);
                    //terza colonna 
                    cartella2[0, 2] = 0;
                    cartella2[1, 2] = r.Next(20, 29);
                    cartella2[2, 2] = 0;
                    //quarta colonna 
                    cartella2[0, 3] = 0;
                    cartella2[1, 3] = r.Next(30, 39);
                    cartella2[2, 3] = r.Next(30, 39);
                    //quinta colonna 
                    cartella2[0, 4] = r.Next(40, 49);
                    cartella2[1, 4] = 0;
                    cartella2[2, 4] = 0;
                    //sesta colonna 
                    cartella2[0, 5] = 0;
                    cartella2[1, 5] = 0;
                    cartella2[2, 5] = r.Next(50, 59);
                    //settima colonna 
                    cartella2[0, 6] = r.Next(60, 69);
                    cartella2[1, 6] = r.Next(60, 69);
                    cartella2[2, 6] = 0;
                    //ottava colonna 
                    cartella2[0, 7] = 0;
                    cartella2[1, 7] = r.Next(70, 79);
                    cartella2[2, 7] = r.Next(70, 79);
                    //nona colonna 
                    cartella2[0, 8] = r.Next(80, 90);
                    cartella2[1, 8] = 0;
                    cartella2[2, 8] = r.Next(80, 90);
                }
            }

            //STAMPA SCHEDA2
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.SetCursorPosition(j * 4, i + 31);
                    Console.Write(cartella2[i, j]);
                }
                Console.WriteLine();
            }

            //ESTRAZIONE NUMERI 
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                Console.WriteLine("Numero estratto: ");
                Console.WriteLine(numestrazione);
                Console.WriteLine("Premere un tasto per continuare:");
                Console.ReadLine();
            }
            Console.ReadKey();

            int s = 0;
            for (int j = 0; j < 9; j++) for (int i = 0; i < 10; i++)
                {
                    s++;
                    tab[j, i] = s;
                    Console.SetCursorPosition(1 + i * 4, 3 + j * 2);
                    Console.Write(s);
                }

            Console.WriteLine();

            for (int i = 0; i < 10; i++) for (int j = 0; j < 9; j++) if (tab[j, i] == numestrazione)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(i * 4, 3 + j * 2);
                        Console.Write($" {numestrazione} ");
                    }
            Console.BackgroundColor = ConsoleColor.Black;


           
        }
    }
}
    








