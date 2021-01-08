using System;

namespace OOP_MCC42
{
    class Program
    {

        static void Main(string[] args)
        {
            bool kondisi = true;
            String pilih_menu;
            while (kondisi) 
            {
                menu();
                Console.Write("Masukan menu yang dipilih : ");
                pilih_menu = Console.ReadLine();
                if (pilih_menu == "0")
                {
                    Console.WriteLine("Terimakasih");
                    Environment.Exit(0);
                }
                else if (pilih_menu == "1") {
                    Persegi LP = new Persegi();
                    LP.Luas();
                }
                else if (pilih_menu == "2")
                {
                    PersegiPanjang LPP = new PersegiPanjang();
                    LPP.Luas();
                }
                else if (pilih_menu == "3")
                {
                    Segitiga LStg = new Segitiga();
                    LStg.Luas();
                }
                else if (pilih_menu == "4")
                {
                    Lingkaran LKR = new Lingkaran();
                    LKR.Luas();
                }
                else if (pilih_menu == "5")
                {
                    Trapesium TPR = new Trapesium();
                    TPR.Luas();
                }
                else
                {
                    Console.WriteLine("Menu tidak ada!");
                    Console.WriteLine("Silahkan pilih menu yang tersedia!");
                    continue;
                }

                Console.WriteLine("Apakah anda ingin menggunakan aplikasi lagi?");
                Console.Write("Press y to yes and others for no : ");
                pilih_menu = Console.ReadLine();
                if (pilih_menu == "y") {
                    continue;
                } else{
                    kondisi = false;
                }
            }
        }

        static void menu()
        {
            Console.WriteLine("Pilih Menu : ");
            Console.WriteLine("1. Luas Persegi");
            Console.WriteLine("2. Luas Persegi Panjang");
            Console.WriteLine("3. Luas Segitiga");
            Console.WriteLine("4. Luas Lingkaran");
            Console.WriteLine("5. Luas Trapesium");
            Console.WriteLine("0. Exit ");
        }
    }

    public abstract class BangunDatar {
        
        public abstract void Luas();
    }

    class Persegi : BangunDatar {

        private double sisi;

        public override void Luas()
        {
            Console.Write("Masukan panjang sisi persegi : ");
            sisi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Luas Persegi = "+ sisi* sisi);
        }
    }
    class PersegiPanjang : BangunDatar
    {
        private double sisi1;
        private double sisi2;
        public override void Luas()
        {
            Console.Write("Masukan panjang sisi pertama : ");
            sisi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan panjang sisi kedua : ");
            sisi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Luas Persegi Panjang = " + sisi1 * sisi2);
        }
    }
    class Segitiga : BangunDatar
    {
        private double alas;
        private double tinggi;
        public override void Luas()
        {
            Console.Write("Masukan alas segitiga : ");
            alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan tinggi segitiga : ");
            tinggi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Luas Segitiga = " + alas * tinggi /2 );
            //rumus luas segitiga = ½ × alas × tinggi
        }
    }

    class Lingkaran : BangunDatar
    {
        private double phi = 3.14;
        private double val;
        private double hasil;
        private bool kondisi;
        private String pilihan;
        public override void Luas()
        {
            kondisi = true;
            while (kondisi == true) {
                Console.WriteLine("Apa yang ingin anda gunakan?");
                Console.WriteLine("1. Jari-jari");
                Console.WriteLine("2. Diameter?");
                Console.Write("Pilihan : ");
                pilihan = Console.ReadLine();

                if (pilihan == "1")
                {
                    Console.Write("Masukan jari-jari lingkaran : ");
                    val = Convert.ToDouble(Console.ReadLine());
                    hasil = phi * val * val;
                    kondisi = false;
                }
                else if (pilihan == "2") {
                    Console.Write("Masukan jari-jari lingkaran : ");
                    val = Convert.ToDouble(Console.ReadLine());
                    hasil = phi * (val / 2) * (val / 2);
                    kondisi = false;
                }
                else {
                    Console.WriteLine("Silahkan pilih menu yang tersedia");
                    continue;
                }
            }

            Console.WriteLine("Luas Lingkaran = " + hasil);
        }
     
    }

    class Trapesium : BangunDatar
    {
        private double sisi1;
        private double sisi2;
        private double tinggi;
        public override void Luas()
        {
            Console.Write("Masukan Panjang sisi sejajar pertama : ");
            sisi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan Panjang sisi sejajar kedua : ");
            sisi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan Tinggi : ");
            tinggi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Luas Trapesium = " + (sisi1+sisi2)*tinggi/2);
            //rumus luas trapesium = ½ × jumlah panjang sisi sejajar × tinggi
        }
    }
}
