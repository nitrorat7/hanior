
using System;
using System.Collections.Generic;
class App

{

    /*Zrób aplikacje konsolowa która poprosi użytkownika o podanie 20 liczb calkowitych(musisz je 
     * jakoś przechować) następnie po wpisaniu ostatniej liczby aplikacja w konsoli wypisze 
     * wszystkie liczby nieparzyste posortowane od najwyższej do najniższej następnie parzyste od najniższej do najwyższej */

    public static void Main()
    {


        int UserNumbers = 5;
        List<int> Nieparzyste = new List<int>();
        List<int> Parzyste = new List<int>();

        Console.WriteLine("Wpisz {0} liczb calkowitych", UserNumbers);
        for (int l = 0; l < UserNumbers; l++)
        {
            Console.WriteLine("Liczba nr {0}", (l + 1));
            int z = int.Parse(Console.ReadLine());
            if (z % 2 == 0)
            {
                Parzyste.Add(z);

            }
            else if (z % 2 > 0)
            {
                Nieparzyste.Add(z);
            }
        }
        int W = 0;
        int M = 0;
        for (int j = 0; j < Parzyste.Count; j++)
        {

            for (int k = 0; k < Parzyste.Count; k++)
            {


                if (Parzyste[j] > Parzyste[k])
                {
                    W = Parzyste[j];
                    M = Parzyste[k];
                    //swap sort
                    Parzyste[j] = M;
                    Parzyste[k] = W;
                }
                else
                {
                    continue;
                }
            }
        }
        int w = 0;
        int m = 0;
        for (int p = 0; p < Nieparzyste.Count; p++)
        {

            for (int v = 0; v < Nieparzyste.Count; v++)
            {


                if (Nieparzyste[p] > Nieparzyste[v])
                {
                    w = Nieparzyste[p];
                    m = Nieparzyste[v];
                    //swap sort
                    Nieparzyste[p] = m;
                    Nieparzyste[v] = w;
                }
                else
                {
                    continue;
                }
            }
        }
        Console.WriteLine("");
        if (Nieparzyste.Count > 0)
        {
            Console.WriteLine("Wypisuje Nieparzyste od najwiekszej do najmniejszej");
            for (int g = 0; g < Nieparzyste.Count; g++)
            {
                Console.WriteLine(Nieparzyste[g]);
            }
        }
        else
        {
            Console.WriteLine("Brak liczb nieparzystych");
        }
        if (Parzyste.Count > 0)
        {
            Console.WriteLine("Wypisuje Parzyste od najmnijeszej do najwiekszej");
            for (int b = Parzyste.Count - 1; b >= 0; b--)
            {
                Console.WriteLine(Parzyste[b]);
            }
        }
        else
        {
            Console.WriteLine("Brak liczb parzystych");
        }
    }
}
            
          

    

