using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_4_Acient___
{
    internal class KuliahMahasiswa_1302210090_Irfan_Syauqi
    {
        public class MataKuliah
        {
            public string KodeMK { get; set; }
            public string NamaMK { get; set; }
        }

        public class KuliahMahasiswa_1302210090
        {
            public List<MataKuliah> DaftarMK { get; set; }

            public void ReadJSON()
            {
                try
                {
                    string jsonString = File.ReadAllText("tp7_2_1302210090.json");
                    KuliahMahasiswa_1302210090 data = JsonSerializer.Deserialize<KuliahMahasiswa_1302210090>(jsonString);
                    Console.WriteLine("Daftar mata kuliah yang diambil:");
                    int i = 1;
                    foreach (MataKuliah mk in data.DaftarMK)
                    {
                        Console.WriteLine("MK {0} {1} - {2}", i, mk.KodeMK, mk.NamaMK);
                        i++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: {0}", ex.Message);
                }
            }
        }
    }
}

