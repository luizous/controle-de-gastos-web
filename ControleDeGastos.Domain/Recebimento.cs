using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleDeGastos.Domain
{
    [Table("Recebimento")]
    public class Recebimento
    {
        [Key]
        public int IdRecebimento { get; set; }

        [Required(ErrorMessage = "Da onde veio o dinheiro?")]
        public string Fornecedor { get; set; }

        [Required(ErrorMessage = "Descreva um pouco sobre esse recebimento.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Digite o valor do recebimento.")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "A data do recebimento é essencial.")]
        public DateTime DataRecebimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public Usuario Usuario { get; set; }
        public Recebimento()
        {
            DataCadastro = DateTime.Now;
        }
    }
}
