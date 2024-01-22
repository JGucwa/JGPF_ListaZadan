using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JGPF
{
    public class Zadanie
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public string Priorytet { get; set; }
    }
}
