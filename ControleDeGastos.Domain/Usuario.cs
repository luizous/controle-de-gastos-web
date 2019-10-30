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
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
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
