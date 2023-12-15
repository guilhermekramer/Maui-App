using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_app.Model
{
    [Table ("Livro")]
    public class Livro 
    {
   

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(200), NotNull]
        public  String Nome { get; set; }

        [MaxLength(200), NotNull]
        public  String Autor { get; set; }

        public int Ano { get; set; }


    
    }
}
