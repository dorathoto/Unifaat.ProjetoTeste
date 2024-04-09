using Unifaat.ProjetoTeste.Models;

namespace Unifaat.ProjetoTeste.Data
{
    public class DataSeeder
    {
        private readonly ApplicationDbContext _context;

        public DataSeeder(ApplicationDbContext context)
        {
            this._context = context;
        }

        public void Seed()
        {
            if (!_context.Categorias.Any())
            {
                for (int i = 0; i < 3; i++)
                {
                    var catnew = new Categoria()
                    {
                        Nome = $"Categoria By Seed  {i}"
                    };
                    _context.Categorias.Add(catnew);
                }
            }
            if (!_context.Produtos.Any())
            {
                Random rnd = new Random();
                for (int i = 0; i < 50; i++)
                {
                    var prod = new Produto()
                    {
                        Nome = $"Produto {i}",
                        Preco = 10 * i,
                        CategoriaId = rnd.Next(1, 4)
                    };

                    _context.Produtos.Add(prod);
                }

            }


            _context.SaveChanges();

        }
    }

}