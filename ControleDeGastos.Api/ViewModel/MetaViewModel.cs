using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleDeGastos.Api.ViewModel
{
    [Table("Meta")]
    public class MetaViewModel
    {
        [Key]
        public int IdMeta { get; set; }
        [Required(ErrorMessage = "Descreva sua meta.")]
        public string Texto { get; set; }
        public bool Conquistada { get; set; }
        [Required(ErrorMessage = "Escolha a data final da meta.")]
        public DateTime DataFinal { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdUsuario { get; set; }

        public MetaViewModel()
        {
            DataCadastro = DateTime.Now;
        }
    }
}
