using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuardiasAPI_Incidentes.Models
{
    public class Incidente
    {
        public int ID { get; set; }
        public int ID_Job { get; set; }
        public string descripcion { get; set; }
        public string solucion { get; set; }
        public DateTime fecha { get; set; }
    }
}
