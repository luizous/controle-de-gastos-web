using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleDeGastos.Domain
{
    [Table("Lancamento")]
    public class Lancamento
    {
        [Key]
        public int IdLancamento { get; set; }

        [Required(ErrorMessage = "Digite o valor do lançamento.")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "A data de lançamento é essencial.")]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "Campo descrição obrigatório!")]
        public string Descricao { get; set; }

        public Categoria Categoria { get; set; }

        [Required(ErrorMessage = "Digite a quantidade de parcelas terá o lançamento. Se não tiver, digite apenas 1.")]
        public int Parcelas { get; set; }

        public Cartao Cartao { get; set; }
        public DateTime DataCadastro { get; set; }
        public Usuario Usuario { get; set; }

        public Lancamento()
        {
            DataCadastro = DateTime.Now;
        }
    }
}
