using second_app.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_app.Service
{
    public interface ILivroService
    {
       
        Task<List<Livro>> GetLivros();
        Task<Livro> GetLivro(int id);
        Task<int> AddLivro(Livro livro);
        Task<int> DeleteLivro(Livro livro);
        Task<int> UpdateLivro(Livro livro);
        Task InitializeAsync();
    }
}
