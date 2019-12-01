using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleDeGastos.Domain
{
    [Table("Meta")]
    public class Meta
    {
        [Key]
        public int IdMeta { get; set; }
        public string Texto { get; set; }
        public bool Conquistada { get; set; }
        public DateTime DataFinal { get; set; }
        public DateTime DataCadastro { get; set; }
        public Usuario Usuario { get; set; }

        public Meta()
        {
            DataCadastro = DateTime.Now;
        }
    }
}
