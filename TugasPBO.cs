using System;

namespace gajikaryawan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pilih jenis karyawan:");
            Console.WriteLine("1. Karyawan Tetap");
            Console.WriteLine("2. Karyawan Kontrak");
            Console.WriteLine("3. Karyawan Magang");
            Console.Write("Masukkan Pilihan :");
            string pilihan = Console.ReadLine();

            Console.Write("masukkan nama karyawan: ");
            string nama = Console.ReadLine();

            Console.Write("masukkan id karyawan:");
            string idnama = Console.ReadLine();

            Karyawan karyawan;
            switch (pilihan)
            {
                case "1":
                    karyawan = new Karyawantetap(nama, idnama, 5000000);
                    break;
                case "2":
                    karyawan = new Karyawankontrak(nama, idnama, 5000000);
                    break;
                case "3":
                    karyawan = new Karyawanmagang(nama, idnama, 1000000);
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    return;
            }
            Console.WriteLine($"\nNama: {karyawan.Nama}");
            Console.WriteLine($"ID: {karyawan.Idnama}");
            Console.WriteLine($"Gaji Akhir: {karyawan.Hitunggaji()}");

        }
        class Karyawan
        {
            private string nama;
            private string idnama;
            private double gajipokok;

            public Karyawan(string nama, string idnama, double gajipokok)
            {
                this.nama = nama;
                this.idnama = idnama;
                this.gajipokok = gajipokok;
            }

            public string Nama
            {
                get { return nama; }
                set { nama = value; }
            }
            public string Idnama
            {
                get { return idnama; }
                set { idnama = value; }
            }
            public double Gajipokok
            {
                get { return gajipokok; }
                set { gajipokok = value; }

            }
            public virtual double Hitunggaji()
            {
                return gajipokok;
            }
        }

        class Karyawantetap : Karyawan
        {
            public Karyawantetap(string nama, string idnama, double gajipokok) : base(nama, idnama, gajipokok) { }
            public override double Hitunggaji()
            {
                return Gajipokok + 500000;
            }
        }
        class Karyawankontrak : Karyawan
        {
            public Karyawankontrak(string nama, string idnama, double gajipokok) : base(nama, idnama, gajipokok) { }
            public override double Hitunggaji()
            {
                return Gajipokok - 200000;
            }
        }
        class Karyawanmagang : Karyawan
        {
            public Karyawanmagang(string nama, string idnama, double gajipokok) : base(nama, idnama, gajipokok) { }
        }
    }
}
