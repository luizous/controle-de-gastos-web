using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleDeGastos.Domain
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }

        [Required(ErrorMessage = "Digite o titulo da categoria.")]
        public string Titulo { get; set; }
        public DateTime DataCadastro { get; set; }
        public Usuario Usuario { get; set; }

        public Categoria()
        {
            DataCadastro = DateTime.Now;
        }
    }
}
