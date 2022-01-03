using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Net;
using static ClientRest_20190140026_Muhammad_Risqullah_Zarvino.Program;

namespace ClientRest_20190140026_Muhammad_Risqullah_Zarvino
{
    class ClassData
    {
        public void getData()
        {
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

            foreach(var mhs in data)
            {
                Console.WriteLine("Nama :" + mhs.nama);
                Console.WriteLine("Nim :" + mhs.nim);
                Console.WriteLine("Prodi :" + mhs.prodi);
                Console.WriteLine("Angkatan :" + mhs.angkatan);
            }
            Console.ReadLine();
        }
    }
}
