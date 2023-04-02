using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_4_Acient___
{
    internal class DataMahasiswa_1302210090_Irfan_Syauqi
    {
        public string Nama { get; set; }
        public string NIM { get; set; }
        public string Fakultas { get; set; }

        public void ReadJSON()
        {
            try
            {
                string jsonString = File.ReadAllText("tp7_1_1302210090.json");
                DataMahasiswa_1302210090_Irfan_Syauqi data = JsonSerializer.Deserialize<DataMahasiswa_1302210090_Irfan_Syauqi>(jsonString);
                Console.WriteLine("Nama {0} dengan nim {1} dari fakultas {2}", data.Nama, data.NIM, data.Fakultas);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
        }
    }
}
