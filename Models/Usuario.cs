
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trab001.Models
{
    [Table("Usuarios")]
    public class Usuario 
    {
        [Column("Id")]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column ("Email")]
        [Display(Name = "Email")]
        public string Email { get; set;}

        [Column("Senha")]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Column("ConfirmSenha")]
        [Display(Name = "ConfirmSenha")]
        public string ConfirmSenha { get; set; }

        public bool validarSenha(string senha)
        {
            return Senha == senha;
        }
    }
}
