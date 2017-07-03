using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BushiApp.Common.Validation;
using BushiApp.Common.Resources;

namespace BushiApp.Domain.Models
{
    public class Usuario
    {
        protected Usuario() { }
        public Usuario(string name, string email)
        {
            this.Nome = name;
            this.Email = email;
        }

        public int UsuarioId { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
     

        public void SetSenha(string senha, string confirmaSenha)
        {
            AssertionConcern.AssertArgumentNotNull(senha, Errors.InvalidPassword);
            AssertionConcern.AssertArgumentNotNull(confirmaSenha, Errors.InvalidPassword);
            AssertionConcern.AssertArgumentLength(senha, 6, 20, Errors.InvalidPassword);
            AssertionConcern.AssertArgumentEquals(senha, confirmaSenha, Errors.PasswordDoNotMatch);
            this.Senha = PasswordAssertionConcern.Encrypt(senha);
        }
        public string ResetPassword()
        {
            string senha = Guid.NewGuid().ToString().Substring(0, 8);
            this.Senha = PasswordAssertionConcern.Encrypt(senha);

            return senha;
        }
        public void ChangeName(string nome)
        {
            this.Nome = nome;
        }
        public void Validate()
        {
            AssertionConcern.AssertArgumentLength(this.Nome, 3, 250, Errors.InvalidUserName);
            EmailAssertionConcern.AssertIsValid(this.Email);
            PasswordAssertionConcern.AssertIsValid(this.Senha);
        }
    }
}
