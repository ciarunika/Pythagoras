using System;                   
using System.Collections;           // Bagus Suprayogi 4212201022
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp{

    class hm{

        int cm, cmTamKur, mm, mmTamKur;
        double m,mTamKur;

        public void hasilM(int u){

            m = (double)u / 100;
            
            Console.Write("\n\t\tUkuran Objek dalam Meter (m)         = {0} m", m);
        }

        public void TamKurM(){

            mTamKur = m + 0.03;
            Console.Write("\n\t\tUkuran Objek setelah di Tambah (+)   = {0} m", mTamKur);
            mTamKur = m - 0.03;
            Console.Write("\n\t\tUkuran Objek setelah di Kurang (-)   = {0} m", mTamKur);
            Console.Write("\n");
        }

        public void hasilCM(int u){

            cm = u;
            Console.Write("\n\t\tUkuran Objek dalam Centi Meter (cm)  = {0} cm", cm);
        }
        
        public void TamKurCM(){

            cmTamKur = cm + 3;
            Console.Write("\n\t\tUkuran Objek setelah di Tambah (+)   = {0} cm", cmTamKur);
            cmTamKur = cm - 3;
            Console.Write("\n\t\tUkuran Objek setelah di Kurang (-)   = {0} cm", cmTamKur);
            Console.Write("\n");
        }

        public void hasilMM(int u){

            mm = u * 10;
            Console.Write("\n\t\tUkuran Objek dalam Mili Meter (mm)   = {0} mm", mm);
        }
        
        public void TamKurMM(){

            mmTamKur = mm + 30;
            Console.Write("\n\t\tUkuran Objek setelah di Tambah (+)   = {0} mm", mmTamKur);
            mmTamKur = mm - 30;
            Console.Write("\n\t\tUkuran Objek setelah di Kurang (-)   = {0} mm", mmTamKur);
            Console.Write("\n");
        }
        
    }
}