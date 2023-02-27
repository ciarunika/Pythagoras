using System;                      
using System.Collections;           // Bagus Suprayogi 4212201022
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp{

    class program{

        static void Main(string[] args){

            hm m = new hm();   
                              
            int u;            
            string p;           
            char o;             

        kembali:
        
            Console.Write("\n\n\t# Pengukuran akan ditampilkan dari dua Objek berikut :");
            Console.Write("\n\n\t\t1. Penggaris");
            Console.Write("\n\t\t2. Meteran");
            Console.Write("\n");
            Console.Write("\n\t\tMasukan Panjang Objek dalam CM = ");

            p = Console.ReadLine();
            u = Convert.ToInt32(p);

            Console.Write("\n\t# Pengukuran dengan Penggaris");
            Console.Write("\n");

            m.hasilM(u);
            m.hasilCM(u);
            m.hasilMM(u);

            Console.Write("\n\n\t# Pengukuran dengan Meteran");
            Console.Write("\n");

            m.hasilM(u);
            m.hasilCM(u);
            m.hasilMM(u);

            Console.Write("\n\n\t# Hasil Pengukuran setelah di Tambah (+) & di Kurang (-) 3 cm");
            Console.Write("\n");

            m.TamKurM();
            m.TamKurCM();
            m.TamKurMM();

            Console.Write("\n\n\t# Apakah anda ingin meng Konversi nilai lagi ? [Y/N] = ");
            
            p = Console.ReadLine();
            o = Convert.ToChar(p);

            if (o == 'Y'    ||   o == 'y'){
                goto kembali;
            }

            Console.Write("\n");
        }
    }
}