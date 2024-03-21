﻿using System.ComponentModel.DataAnnotations;

namespace Unifaat.ProjetoTeste.Models
{
    public class Produto
    {

        public int ProdutoId { get; set; }

        public int CategoriaId { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        [DataType(DataType.Currency)]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Required]
        [MaxLength(100)]    //Truncamento
       // [StringLength(100)]  //Exception
        public string Nome { get; set; } //varchar(max)

        public virtual Categoria? Categoria { get; set; }
    }
}
