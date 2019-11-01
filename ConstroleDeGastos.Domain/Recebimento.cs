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
        public string Fornecedor { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataRecebimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public Usuario Usuario { get; set; }
        public Recebimento()
        {
            DataCadastro = DateTime.Now;
        }
    }
}
