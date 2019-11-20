using ControleDeGastos.Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConstroleDeGastos.Domain
{
    [Table("Poupanca")]
    public class Poupanca
    {
        [Key]
        public int IdPoupanca { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public Usuario Usuario{ get; set; }
    }
}
