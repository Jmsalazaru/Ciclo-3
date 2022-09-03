using System;

namespace CuidadoPorcino.App.Dominio{
    public class Historia{
        public int id { get; set; }
        public int utc_apertura  {get;set;}
        public int id_cerdo  {get;set;}
        public int id_veterinario  {get;set;}
        public int id_propietario  {get;set;}
    }
}