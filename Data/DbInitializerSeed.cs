using Microsoft.EntityFrameworkCore;
using Unifaat.ProjetoTeste.Models;

namespace Unifaat.ProjetoTeste.Data
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/ef/core/modeling/data-seeding
    /// </summary>
    public class DbInitializerSeed
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializerSeed(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {

            modelBuilder.Entity<Categoria>().HasData(
                new Categoria
                {
                    CategoriaId = 1,
                    Nome = "Categoria 1"
                });

            modelBuilder.Entity<Produto>().HasData(
                   new Produto
                   {
                       ProdutoId = 1,
                       Nome = "Produto 1",
                       Preco = 10,
                       CategoriaId = 1
                   });
    

        }
    }
}
