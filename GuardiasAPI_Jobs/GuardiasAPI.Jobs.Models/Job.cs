using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GuardiasAPI.Jobs.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Sigla { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public string PreRequisitos { get; set; }

        public string PostRequisitos { get; set; }

        [Required]
        public string Horario { get; set; }
    }
}
