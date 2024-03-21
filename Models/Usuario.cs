using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Unifaat.ProjetoTeste.Models
{
    public class Usuario : IdentityUser
    {
        [MaxLength(100)]
        public string NomeCompleto { get; set; }

        [MaxLength(8)]
        public string RA { get; set; } //89012457

        public DateTime? DataAniversario { get; set; }
    }
}
