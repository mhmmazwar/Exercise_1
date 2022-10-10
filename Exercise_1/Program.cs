using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {

        //deklrasi array int dengan ukuran 69
        private int[] a = new int[69];

        //deklarasi variabel int untuk menyimpan banyaknya data yang disimpan pada array
        private int n;

        //fungsi / method untuk menerima masukan
        public void read()
        {
            //menrima angka untuk menentukan banyaknya data yang disimpan pada array 
            while (true)
            {
                Console.Write("masukkan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 69)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-----------------------");

            // Pengguna memasukkan elemen pada array 
            for (int aj = 0; aj < n; aj++)
            {
                Console.Write("<" + (aj + 1) + ">");
                string s1 = Console.ReadLine();
                a[aj] = Int32.Parse(s1);
            }

        }
        public void display()
        {
            // Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("-----------------------------------");
            for (int aj = 0; aj < n; aj++)
            {
                Console.WriteLine(a[aj]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) // for n - 1 passes
            {
                //pada pass i, bandingkan n - 1 elemen pertama dengan elemen selanjutnya
                for (int aj = 0; aj < n; aj++)
                {
                    if (a[aj] > a[aj + 1]) // jika elmen tidak dalam urutan yang benar
                    {
                        // tukar elemen
                        int temp;
                        temp = a[aj];
                        a[aj] = a[aj + 1];
                        a[aj + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // creating the object of the BubbleSort class
            Program mylist = new Program();

            //pemanggilan fungsi untuk menerima elemen array
            mylist.read();

            //pemanggilan fungsi untuk mengurutkan array 
            mylist.BubbleSortArray();

            //pemanggilan fungsi untuk menampilkan array yang tersusun
            mylist.display();

            //exit
            Console.WriteLine("\n\n Tekan tombol apa saja untuk keluar.");
            Console.Read();
        }
    }

}
