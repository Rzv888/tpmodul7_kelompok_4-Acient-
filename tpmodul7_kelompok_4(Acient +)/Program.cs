using System;

namespace tpmodul7_kelompok_4_Acient___
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_1302213109_Muhammad_Burhan data = new DataMahasiswa_1302213109_Muhammad_Burhan();
            data.ReadJSON();
            Console.ReadKey();
        }
    }
}