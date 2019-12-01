using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleDeGastos.Domain
{
    [Table("Poupanca")]
    public class Poupanca
    {
        [Key]
        public int IdPoupanca { get; set; }
        public Cartao Cartao { get; set; }
        public double Valor { get; set; }
        public DateTime DataDeposito { get; set; }
        public DateTime DataCadastro { get; set; }
        public Usuario Usuario { get; set; }

        public Poupanca()
        {
            DataCadastro = DateTime.Now;
        }
    }
}
