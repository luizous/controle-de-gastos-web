using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleDeGastos.Domain
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        public Guid Token { get; set; }

        [Required(ErrorMessage = "Digite seu nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite seu sobrenome.")]
        public string Sobrenome { get; set; }

        public string Cpf { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Digite o e-mail para continuar com o acesso.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo username é obrigatório!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite a senha para continuar com o acesso.")]
        public string Senha { get; set; }

        [NotMapped]
        [Compare("Senha", ErrorMessage = "Os campos não coincidem!")]
        public string ConfirmacaoSenha { get; set; }

        public double Salario { get; set;  }
        public DateTime DataCadastro { get; set; }

        public Usuario()
        {
            DataCadastro = DateTime.Now;
        }
     
        public override bool Equals(object obj)
        {
            Usuario u = (Usuario)obj;
            if (u.Nome.Equals(Nome) && u.Cpf.Equals(Cpf))
            {
                return true;
            }
            return false;
        }
    }
}
