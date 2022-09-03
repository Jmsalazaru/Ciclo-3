using System;

namespace CuidadoPorcino.App.Dominio{
    public class Visita{
        public int id { get; set; }
        public double temperatura { get; set; }
        public double peso { get; set; }
        public int frecuenciaRespiratoria { get; set; }
        public int frecuenciaCardiaca { get; set; }
        public string estadoAnimo {get;set;}
        public int utc_visita {get;set;}
        public string recomendaciones {get;set;}
        public int id_historia {get;set;}
    }
}