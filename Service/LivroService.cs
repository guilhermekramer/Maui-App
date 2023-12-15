using second_app.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_app.Service
{
    public class LivroService : ILivroService

    {
        private SQLiteAsyncConnection _dbConnection;
        public async Task InitializeAsync()
        {
            await SetUpDb();
        }

        private async Task SetUpDb()
        {
            if(_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Livro.db");

                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<Livro>();
            }
        }

        public async Task<int> AddLivro(Livro livro)
        {
            return await _dbConnection.InsertAsync(livro);
        }

        public async Task<int> DeleteLivro(Livro livro)
        {
            return await _dbConnection.DeleteAsync(livro);
        }


        public async Task<int> UpdateLivro(Livro livro)
        {
            return await _dbConnection.UpdateAsync(livro);
        }


        public async Task<List<Livro>> GetLivros()
        {
            return await _dbConnection.Table<Livro>().ToListAsync();
        }

        public Task<Livro> GetLivro(int id)
        {
            throw new NotImplementedException();
        }

     
    }
}
