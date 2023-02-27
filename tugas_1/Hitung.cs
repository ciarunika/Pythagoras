using System;                   
using System.Collections;           // Bagus Suprayogi 4212201022
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp{

    class hitung{

        int cm, mm,CM,MM;
        double m,M;

        public void getUkuranMM(int u){
            mm = u * 10;
            Console.Write("\n\t\tUkuran Objek dalam Meter (m)         = {0} mm", mm);
        }
        public void getUkuranCM(int u){
            cm = u;
            Console.Write("\n\t\tUkuran Objek dalam Centi Meter (cm)  = {0} cm", cm);
        }
        public void getUkuranM(int u){
            m = (double)u / 100;
            Console.Write("\n\t\tUkuran Objek dalam Mili Meter (mm)   = {0} m", m);
        }
        public void tambahkan(){
            MM = mm + 30;
            Console.Write("\n\t\tUkuran Objek setelah di Tambah (+)   = {0} mm", MM);
            CM = cm + 3;
            Console.Write("\n\t\tUkuran Objek setelah di Tambah (+)   = {0} cm", CM);
            M = m + 0.03;
            Console.Write("\n\t\tUkuran Objek setelah di Tambah (+)   = {0} m", M);
            Console.Write("\n");
        }
        public void kurangi(){
            MM = mm - 30;
            Console.Write("\n\t\tUkuran Objek setelah di Kurang (-)   = {0} mm", MM);
            CM = cm - 3;
            Console.Write("\n\t\tUkuran Objek setelah di Kurang (-)   = {0} cm", CM);
            M = m - 0.03;
            Console.Write("\n\t\tUkuran Objek setelah di Kurang (-)   = {0} m", M);
            Console.Write("\n");
        }
    }
}