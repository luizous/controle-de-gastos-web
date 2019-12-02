using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleDeGastos.Domain
{
    [Table("Cartao")]
    public class Cartao
    {
        [Key]
        public int IdCartao { get; set; }

        [Required(ErrorMessage = "Digite o nome impresso no cartão.")]
        public string NomeSobrenome { get; set; }

        [Required(ErrorMessage = "Digite o nome no banco do cartão.")]
        public string Banco { get; set; }

        [Required(ErrorMessage = "Descriva qual do tipo do cartão. (Débito / Crédito / Débito & Crédito)")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Digite o número do cartão.")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Digite o CVV do cartão.")]
        public string Cvv { get; set; }

        [Required(ErrorMessage = "Escolha a data de validade do cartão.")]
        public DateTime DataValidade { get; set; }

        [Required(ErrorMessage = "Digite o número da agencia do cartão.")]
        public string Agencia { get; set; }

        [Required(ErrorMessage = "Digite o número da sua conta.")]
        public string Conta { get; set; }

        [Required(ErrorMessage = "Digite qual o dia em que a fautura vence.")]
        public int DiaVencimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public Usuario Usuario { get; set; }

        public Cartao()
        {
            DataCadastro = DateTime.Now;
        }
    }
}
