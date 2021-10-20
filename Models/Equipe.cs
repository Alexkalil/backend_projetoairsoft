using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend_projetoairsoft.Models
{
    [Table("Equipe")]
    public class Equipe
    {
        [Key]
        [Required(ErrorMessage = "Favor informar o local")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Favor informar o local")]
        public string Jogador { get; set; }
    }
}
