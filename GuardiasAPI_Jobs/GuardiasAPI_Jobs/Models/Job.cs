using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuardiasAPI_Jobs.Models
{
    public class Job
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Sigla { get; set; }
        public string Descripcion { get; set; }
        public string Pre_Requisitos { get; set; }
        public string Post_Requisitos { get; set; }
        public string Horario_Ejecucion { get; set; }
    }
}
