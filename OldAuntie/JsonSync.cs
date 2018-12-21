using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class JsonSync
    {
        public string Name { get; set; }
        // contiene il lastupdate dell'anagrafica partecipante
        public string Codename { get; set; }
        // contiene l'ultimo ID aggiornato della tabella readings
        public string Version { get; set; }
        // contiene l'ultimo ID aggiornato della tabella option_readings
        public string Build { get; set; }
        public string Url { get; set; }
    }
}
