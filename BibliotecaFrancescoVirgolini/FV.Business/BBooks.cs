using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FV.Data;

namespace FV.Business
{
    public class BBooks
    {
        public static DataTable List()
        {
            DBooks dBooks = new DBooks();

            return dBooks.List();
        }

        public static DataTable Search(string value, int type)
        {
            DBooks dBooks = new DBooks();

            return dBooks.Search(value, type);
        }

        public static string insertbooks(string title, int quant, string isbn, int edition, int pages, string ubication, string desc, int editorial, int country, int language, int subject) {

            DBooks db = new DBooks();

            if (db.insertBook(title, quant, isbn, edition, pages, ubication, desc, editorial, country, language, subject)) {
                return "Agregado Exitosamente";
            }
            else {
                return "mamma mia";
            }


            
        
        
        }
    }
}
