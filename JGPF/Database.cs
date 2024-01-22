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
        public void DodajZadanie(Zadanie zadanie)
        {
            List<Zadanie> tmp = WyswietlWszystko();

            if (tmp.Count > 0) zadanie.Id = tmp[tmp.Count - 1].Id; else zadanie.Id = 0;

            tmp.Add(zadanie);

            string tekst = JsonConvert.SerializeObject(tmp);
            File.WriteAllText(dbPath, tekst);
        }
        public void EdytujZadanie(Zadanie zadanie)
        {
            List<Zadanie> tmp = WyswietlWszystko();

            for (int i = 0; i < tmp.Count; i++)
            {
                if (tmp[i].Id == zadanie.Id)
                {
                    tmp[i] = zadanie;
                }
            }

            string tekst = JsonConvert.SerializeObject(tmp);
            File.WriteAllText(dbPath, tekst);
        }
    }
}
