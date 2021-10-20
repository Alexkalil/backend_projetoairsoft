using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend_projetoairsoft.Models
{
    [Table("Jogador")]
    public class Jogador
    {       
        
        private int Id { get; set; }

        [Key]
        [Required(ErrorMessage ="Favor informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Favor informar o email")]
        private string Email { get; set; }
        public string Modalidade { get; set; }
        


    }
}
