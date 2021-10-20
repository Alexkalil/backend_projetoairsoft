using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend_projetoairsoft.Models
{
    [Table("Eventos")]
    public class Evento
    {
        [Key]
        [Required(ErrorMessage = "Favor informar o nome do evento")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Favor informar o local")]
        public Local local { get; set; }

         public string Descricao { get; set; }

        public string Modalidade { get; set; }

        public string Jogador { get; set; }

    }
}
