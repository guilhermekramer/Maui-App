using second_app.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_app.Data
{
    internal class SQLiteData
    {
        readonly SQLiteAsyncConnection connection;

        //public LivroData LivroDataTable { get; set; }

        public SQLiteData(string path)
        {
            connection = new SQLiteAsyncConnection(path);

            connection.CreateTableAsync<Livro>().Wait();
        }

    }
}
