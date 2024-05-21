﻿public class Program
{
    static void Main(string[] args)
    {
        // No 1
        // PrintYesOrOK(15);

        // No 2
        // A
        // PyramidA(5);

        //B
        // PyramidB(5);

        // C
        // PyramidC(5);

        // D
        PyramidD(5);
    }

    static void PrintYesOrOK(int n)
    {
        for (int i = 1; i <= n; i++) // melakukan perulangan sebanyak n dari parameter
        {
            if (i % 3 == 0) // mengecek kondisi yang sesuai jika merupakan kelipatan 3 maka masuk kedalam kondisi
            {
                if (i % 3 == 0 && i % 4 == 0) // dicek lagi apakah kelipatan 3 dan 4 maka melakukan print "OKYES"
                {
                    System.Console.Write("OKYES ");
                }
                else // jika tidak kelipatan 3 dan 4 maka hanya print "OK"
                {
                    System.Console.Write("OK ");
                }
            }
            else if (i % 4 == 0) // jika kondisi pertama tidak terpenuhi maka kondisi ini yang akan dieksekui jika sesuai
            {
                if (i % 3 == 0 && i % 4 == 0)
                {
                    System.Console.Write("OKYES ");
                }
                else
                {
                    System.Console.Write("YES ");
                }
            }
            else // jika tidak ada yang sesuai dengan kondisi-kondisinya maka melakukan print terhadap i
            {
                System.Console.Write($"{i} ");
            }
        }
    }


    static void PyramidA(int n)
    {
        for (int i = 1; i <= n; i++) // melakukan perulangan sebanyak n dari parameter
        {
            System.Console.WriteLine(""); // melakukan print space ketika baris bertambah (i)
            for (int j = 1; j <= i; j++) // melakukan perulangan untuk mengisi kolom
            {
                System.Console.Write(i); // melakukan print terhadap nilai i
            }
        }
    }

    static void PyramidB(int n)
    {
        for (int i = 1; i <= n; i++) // perulangan sebanyak n
        {
            System.Console.WriteLine(""); // melakukan print space ketika baris bertambah (i)
            for (int j = i; j <= i; j--) // melakukan perulangan untuk melakukan print nilai secara decrement
            {
                if (j == 0) // kondisi jika nilai j sama dengan 0 maka akan dibreak perulangannya
                {
                    break;
                }
                else
                {
                    System.Console.Write(j); // jika tidak maka akan melakukan print nilai j
                }
            }
        }
    }

    static void PyramidC(int n)
    {
        int val = 1; // melakukan inisiasi nilai awal
        bool isMax = true; // variable untuk mengecek apakah nilai val sama dengan n dari parameter
        for (int i = 1; i <= n; i++) // perulangan sebanyak n
        {
            System.Console.WriteLine(""); // melakukan print space ketika baris bertambah (i)
            for (int j = 1; j <= i; j++) // melakukan perulangan untuk mengisi setiap kolom
            {
                System.Console.Write(val); // print nilai val

                if (val == n) // melakukan pengecekan jika val sama dengan n maka variable isMax akan diset menjadi false
                {
                    isMax = false;
                }
                else if (val == 1) // jika val sama dengan 1 variable isMax akan diset menjadi true 
                {
                    isMax = true;
                }

                if (isMax) // jika variable val tidak sama dengan n maka nilai val akan terus bertambah
                {
                    val++;
                }
                else // jika variable val sama dengan n maka nilai val akan berkurang (decrement)
                {
                    val--;
                }

            }
        }
    }

    static void PyramidD(int n)
    {

        for (int i = 1; i <= n; i++)
        {
            int range = (n * 2) - (i * 2 - 1);
            int val = i;
            System.Console.WriteLine();
            for (int j = 1; j <= n; j++)
            {
                System.Console.Write(val + "  ");

                if (j % 2 == 0)
                {
                    val = n * j + i;
                }
                else
                {
                    val = n * (j + 1) - i + 1;
                }
            }
        }
    }
}
