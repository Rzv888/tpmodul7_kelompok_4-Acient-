using System;
using static tpmodul7_kelompok_4_Acient___.KuliahMahasiswa_1302210090_Irfan_Syauqi;

namespace tpmodul7_kelompok_4_Acient___
{
    class Program
{
    static void Main(string[] args)
    {
        KuliahMahasiswa_1302210090 data = new KuliahMahasiswa_1302210090 ();
        data.ReadJSON();
        Console.ReadKey();
    }
}
}
