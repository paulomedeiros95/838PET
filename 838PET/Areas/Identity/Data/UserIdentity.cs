using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace _838PET.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the UserIdentity class
    public class UserIdentity : IdentityUser
    {
        public string Perfil { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string  NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Document { get; set; }
        public string Responsavel { get; set; }
        public string  CRVM { get; set; }
        public string  Telefone { get; set; }
        public string AlternativoTelefone { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public int NumeroDoEndereco { get; set; }
        public  string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
