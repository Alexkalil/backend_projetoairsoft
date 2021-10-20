using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend_projetoairsoft.Models
{
    [Table("Local")]
    public class Local
    {
        [Key]
        public string Rua { get; set; }

        public int Numero { get; set; }

        public string Bairro { get; set; }

        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public  string Estado { get; set; }

        public string UF { get; set; }

    }
}
