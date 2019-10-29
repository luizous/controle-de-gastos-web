using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleDeGastos.Models
{
    [Table("Cartao")]
    public class Cartao
    {
        [Key]
        public int IdCartao { get; set; }
        public string NomeSobrenome { get; set; }
        public string Banco { get; set; }
        public string Tipo { get; set; }
        public string Numero { get; set; }
        public string Cvv { get; set; }
        public DateTime DataValidade { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public int DiaVencimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public Usuario Usuario { get; set; }

        public Cartao()
        {
            DataCadastro = DateTime.Now;
        }
    }
}
