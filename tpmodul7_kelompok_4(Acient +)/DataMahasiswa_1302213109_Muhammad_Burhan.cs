using System;
using System.IO;
using System.Text.Json;

namespace tpmodul7_kelompok_4_Acient___
{
    internal class DataMahasiswa_1302213109_Muhammad_Burhan
    {
        public string Nama { get; set; }
        public string NIM { get; set; }
        public string Fakultas { get; set; }

        public void ReadJSON()
        {
            try
            {
                string jsonString = File.ReadAllText("tp7_1_1302213109.json");
                DataMahasiswa_1302213109_Muhammad_Burhan data = JsonSerializer.Deserialize<DataMahasiswa_1302213109_Muhammad_Burhan>(jsonString);
                Console.WriteLine("Nama {0} dengan NIM {1} dari fakultas {2}", data.Nama, data.NIM, data.Fakultas);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
        } 

    }
}
