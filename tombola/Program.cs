using System;
using System.Collections.Generic;
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
        int estrazione;
        Random r = new Random();
        int[,] mat = new int[9,10];
        int[,] mat2 = new int[3,5];
        
        //CARICAMENTO DELLA MATRICE TABELLONE
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                
                mat[i, j] = variabile++ ;
                
               
            }
            Console.WriteLine();

            for (int k = 0; k < 10; k++)
            {
                Console.Write(mat[i,k]+" ") ;
            }
            Console.WriteLine();
        }


        // SCHEDA GIOCATORE 1 
        Console.WriteLine();
        Console.WriteLine("CARTELLA GIOCATORE 1");

        //CARICAMENTO DELLA MATRICE SCHEDA1
        for (int i = 0; i < 3; i++)
        {
            
            for (int j = 0; j<5; j++)
            {

                mat2[i, j] = r.Next(1,90);


            }
            Console.WriteLine();
            for (int k = 0; k < 5; k++)
            {
                Console.Write(mat2[i, k] + " ");
            }
            Console.WriteLine();
        }

        // SCHEDA GIOCATORE 2 
        Console.WriteLine();
        Console.WriteLine("CARTELLA GIOCATORE 2");

        //CARICAMENTO DELLA MATRICE SCHEDA2
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {

                mat2[i, j] = r.Next(1,90);


            }
            Console.WriteLine();

            for (int k = 0; k < 5; k++)
            {
                Console.Write(mat2[i, k] + " ");
            }
            Console.WriteLine();
        }
        
        //ESTRAZIONE NUMERI 
        for (int i = 0; i < 91; i++)
        {
            Console.WriteLine("Numero estratto: ");
            Console.WriteLine(estrazione = r.Next(1, 90));
            Console.WriteLine("Premere un tasto per continuare:"); 
            Console.ReadLine();
        }


    }
}
