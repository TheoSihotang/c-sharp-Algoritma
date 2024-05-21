public class Program
{
    static void Main(string[] args)
    {
        // No 1
        System.Console.WriteLine("============== No 1 ================");
        PrintYesOrOK(15);
        System.Console.WriteLine();

        // No 2
        // A
        System.Console.WriteLine("============== No 2 A ================");
        PyramidA(5);
        System.Console.WriteLine();

        // B
        System.Console.WriteLine("============== No 2 B ================");
        PyramidB(5);
        System.Console.WriteLine();

        // C
        System.Console.WriteLine("============== No 2 C ================");
        PyramidC(5);
        System.Console.WriteLine();

        // D
        System.Console.WriteLine("============== No 2 D ================");
        PyramidD(5);
        System.Console.WriteLine();

        // No 3
        System.Console.WriteLine("============== No 3 ================");
        int[] arr = {12, 9, 13, 6, 10, 4, 7, 2};
        SortArr(arr);
        System.Console.WriteLine();
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

        for (int i = 1; i <= n; i++) // melakukan perulangan sebanyak n
        {
            int val = i; // melakukan inisiasi untuk nilai val
            System.Console.WriteLine();
            for (int j = 1; j <= n; j++) // melakukan perulangan untuk mengisi setiap kolom
            {
                System.Console.Write(val + "  ");

                if (j % 2 == 0) // mengecek apakah j genap atau ganjil
                {
                    val = n * j + i; // jika j genap rumusnya seperti ini
                }
                else
                {
                    val = n * (j + 1) - i + 1; // jika j ganjil rumusnya seperti ini
                }
            }
        }
    }

    static void SortArr(int[] arr){
        int count = 0; // inisiasi variable untuk mengecek apakah ada angka yang tidak kelipatan 3
        for (int i = 0; i < arr.Length ; i++) // melakukan perulangan untuk melakukan increment terhadap count
        {
            if (arr[i] % 3 != 0){
                count++;
            }
        }
        int?[] newArr = new int?[count]; // membuat array baru untuk menampung angka yang tidak kelipatan 3
        int index = 0; // inisiasi index
        for(int i = 0; i<arr.Length; i++){ // perulangan untuk membuang bilangan kelipatan 3
            if (arr[i] % 3 != 0){
                newArr[index] = arr[i];
                index++;
            }
        }
        Array.Sort(newArr); // mengurutkan array baru

        foreach (var item in newArr){ // perulangan untuk melakukan print terhadap array baru
            System.Console.Write($"{item} ");
        }
    }
}
