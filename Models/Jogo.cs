using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend_projetoairsoft.Models
{
    public class Jogo
    {
        
        public Equipe equipe { get; set; }
        [Key]

        public int id { get; set; }
    }
}
