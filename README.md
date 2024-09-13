# oop-warmup-csharp

## Capaian Pembelajaran

1. Mahasiswa mampu menggunakan git untuk mengerjakan soal-soal yang diberikan.
2. Mahasiswa mampu mengeksekusi unit test untuk memvalidasi solusi.

## Lingkungan Pengembangan

1. Platform: .NET 6.0
2. Bahasa: C# 10
3. IDE: Visual Studio 2022

## Cara membuka project menggunakan Visual Studio

1. Clone repositori project `oop-warmup` ke direktori lokal git Anda.
2. Buka Visual Studio, pilih menu File > Open > Project/Solution > Pilih file *.sln.
3. Tekan tombol Open untuk  untuk membuka solusi.
4. Baca soal dengan seksama. Buat implementasi kode sesuai dengan petunjuk.
6. Jalankan unit test di project *.Tests

> PERINGATAN: Push kode program ke remote repository jika hanya seluruh test case sudah lolos/passed (bertanda hijau).

### Soal: Kalkulator Sederhana dengan OOP di C#

Buat solusi dari soal ini di project `Warmup` folder `HelloCalculator` dengan namespace `Warmup.HelloCalculator`.

Anda diminta untuk membuat aplikasi kalkulator sederhana yang mampu melakukan operasi dasar seperti penjumlahan, pengurangan, perkalian, dan pembagian.

Langkah-langkah:

1. **Kelas Calculator**: Buat kelas publik `Calculator` yang menyediakan metode untuk operasi aritmatika dasar, yaitu:
   - `Tambah(double a, double b)`: Mengembalikan hasil penjumlahan dari `a` dan `b`.
   - `Kurang(double a, double b)`: Mengembalikan hasil pengurangan dari `a` dan `b`.
   - `Kali(double a, double b)`: Mengembalikan hasil perkalian dari `a` dan `b`.
   - `Bagi(double a, double b)`: Mengembalikan hasil pembagian dari `a` dan `b`. Jika nilai `b` adalah 0, kembalikan pesan kesalahan.

2. **Metode Helper**: Buat metode privat `TampilkanHasil(string operasi, double hasil)` di dalam kelas `Calculator` yang menampilkan hasil dari operasi yang dilakukan dengan format sebagai berikut:
   
   ```
   Hasil operasi {operasi}: {hasil}
   ```

   Contoh:  
   ```
   Hasil operasi Penjumlahan: 10
   ```

3. **Validasi Pembagian**: Pada metode `Bagi`, jika pengguna mencoba membagi dengan angka 0, kembalikan nilai double `NaN` (Not a Number) dan cetak pesan: `"Kesalahan: Pembagian dengan nol tidak diperbolehkan."`

4. **Kelas Program**: Buat kelas `Program` yang berisi `Main` method. Di dalam `Main`, buat objek dari kelas `Calculator` dan demonstrasikan setiap fungsi yang telah Anda implementasikan. Ambil input dari pengguna untuk nilai `a`, `b`, dan operasi yang diinginkan, kemudian panggil metode kalkulator yang sesuai.

5. **Membaca Input Pengguna**: Tambahkan logika untuk membaca input dari pengguna terkait dua angka dan operasi yang diinginkan. Lakukan operasi berdasarkan input yang diberikan.

#### Contoh Output:

```
Masukkan angka pertama: 5
Masukkan angka kedua: 3
Pilih operasi (Tambah, Kurang, Kali, Bagi): Tambah
Hasil operasi Penjumlahan: 8

Masukkan angka pertama: 10
Masukkan angka kedua: 0
Pilih operasi (Tambah, Kurang, Kali, Bagi): Bagi
Kesalahan: Pembagian dengan nol tidak diperbolehkan.
```

### Spesifikasi Tambahan:

- Program harus terus berjalan sampai pengguna mengetik "exit" untuk menghentikan program.
  
- Jika pengguna memasukkan operasi yang tidak valid, tampilkan pesan kesalahan: `"Operasi tidak valid. Silakan pilih Tambah, Kurang, Kali, atau Bagi."`

### Implementasi Kode

1. **Kelas `Calculator`**:

```csharp
using System;

namespace Warmup.HelloCalculator
{
    public class Calculator
    {
        public double Tambah(double a, double b)
        {
            double hasil = a + b;
            TampilkanHasil("Penjumlahan", hasil);
            return hasil;
        }

        public double Kurang(double a, double b)
        {
            double hasil = a - b;
            TampilkanHasil("Pengurangan", hasil);
            return hasil;
        }

        public double Kali(double a, double b)
        {
            double hasil = a * b;
            TampilkanHasil("Perkalian", hasil);
            return hasil;
        }

        public double Bagi(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Kesalahan: Pembagian dengan nol tidak diperbolehkan.");
                return double.NaN;
            }
            else
            {
                double hasil = a / b;
                TampilkanHasil("Pembagian", hasil);
                return hasil;
            }
        }

        private void TampilkanHasil(string operasi, double hasil)
        {
            Console.WriteLine($"Hasil operasi {operasi}: {hasil}");
        }
    }
}
```

2. **Kelas `Program`**:

```csharp
using System;

namespace Warmup.HelloCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            string input = "";
            
            while (input != "exit")
            {
                Console.WriteLine("Masukkan angka pertama:");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Masukkan angka kedua:");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Pilih operasi (Tambah, Kurang, Kali, Bagi):");
                string operasi = Console.ReadLine();

                switch (operasi.ToLower())
                {
                    case "tambah":
                        calculator.Tambah(a, b);
                        break;
                    case "kurang":
                        calculator.Kurang(a, b);
                        break;
                    case "kali":
                        calculator.Kali(a, b);
                        break;
                    case "bagi":
                        calculator.Bagi(a, b);
                        break;
                    default:
                        Console.WriteLine("Operasi tidak valid. Silakan pilih Tambah, Kurang, Kali, atau Bagi.");
                        break;
                }

                Console.WriteLine("Ketik 'exit' untuk keluar, atau tekan Enter untuk melanjutkan.");
                input = Console.ReadLine();
            }
        }
    }
}
```

### Penjelasan:

1. **Calculator**: Kelas ini menyediakan metode dasar untuk operasi aritmatika: `Tambah`, `Kurang`, `Kali`, dan `Bagi`. Setiap metode menghitung hasil dan menampilkannya menggunakan metode privat `TampilkanHasil`.

2. **Program**: Di dalam metode `Main`, program berinteraksi dengan pengguna, menerima input untuk dua angka, memilih operasi, dan kemudian memanggil metode kalkulator yang sesuai. Program akan terus meminta input sampai pengguna mengetik "exit".

3. **Validasi Pembagian dengan Nol**: Jika pengguna mencoba membagi dengan 0, program akan menampilkan pesan kesalahan dan mengembalikan nilai `NaN`.

### Contoh Output:

```
Masukkan angka pertama: 5
Masukkan angka kedua: 3
Pilih operasi (Tambah, Kurang, Kali, Bagi): Tambah
Hasil operasi Penjumlahan: 8
Ketik 'exit' untuk keluar, atau tekan Enter untuk melanjutkan.

Masukkan angka pertama: 10
Masukkan angka kedua: 0
Pilih operasi (Tambah, Kurang, Kali, Bagi): Bagi
Kesalahan: Pembagian dengan nol tidak diperbolehkan.
Ketik 'exit' untuk keluar, atau tekan Enter untuk melanjutkan.
```