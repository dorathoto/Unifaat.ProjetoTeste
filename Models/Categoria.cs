using System.ComponentModel.DataAnnotations;

namespace Unifaat.ProjetoTeste.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [MaxLength(100, ErrorMessage = "O campo {0} suporta no máximo {1} caracteres!")]
        public string Nome { get; set; }

        public virtual ICollection<Produto>? Produtos { get; set; }
    }
}
