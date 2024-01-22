using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JGPF
{
    public class Database
    {
        readonly string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "baza.json");

        public List<Zadanie> WyswietlWszystko()
        {
            try
            {
                string tekst = File.ReadAllText(dbPath);
                return JsonConvert.DeserializeObject<List<Zadanie>>(tekst);
            }
            catch
            {
                return new List<Zadanie>();
            }
        }

    }
}
