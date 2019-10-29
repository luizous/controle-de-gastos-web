using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleDeGastos.Models
{
    [Table("Lancamento")]
    public class Lancamento
    {
        [Key]
        public int IdLancamento { get; set; }
        public double Valor { get; set; }
        public DateTime DataLancamento { get; set; }
        public string Descricao { get; set; } // Lugar alterado para Descricao
        public Categoria Categoria { get; set; }
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
