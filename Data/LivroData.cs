using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using second_app.Model;
using SQLite;

namespace second_app.Data
{
    
    internal class LivroData
    {
        private SQLiteAsyncConnection connection;

        public LivroData(SQLiteAsyncConnection connection) => connection = connection;

        public Task<List<Livro>> GetLivros() {
            var lista = connection.Table<Livro>().ToListAsync();
            if (lista.IsCompleted) { return lista; } else { throw new Exception("Erro in getLivros"); };
        }


        public Task<Livro> getLivro(int id)
        {
            var livro = connection.Table<Livro>().Where(l => l.Id == id).FirstOrDefaultAsync();
            return livro;
        }

        public async Task<int> salvarLivro(Livro livro)
        {
            var livroBanco = await getLivro(livro.Id);
            if (livroBanco == null)
            {

                return await connection.InsertAsync(livro);
                
            }
            else
            {
                throw new Exception("Erro salvando livro");
            };
        }
    }
}
