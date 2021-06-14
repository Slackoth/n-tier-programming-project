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

        public static string insertbooks(string title, int quant, string isbn, int edition, int pages, string ubication, string desc, int editorial, int country, int language, int subject, int authorid) {

            DBooks db = new DBooks();
            DAuthors da = new DAuthors();
            DCopies dc = new DCopies();



            if (db.insertBook(title, quant, isbn, edition, pages, ubication, desc, editorial, country, language, subject)) {
                DataTable data = new DataTable();
                data= db.getid(title);
                int id;

                foreach (DataRow dr in data.Rows) {
                   
                    da.insert_authorsxbooks(int.Parse(dr["id"].ToString()), authorid);
                    id = int.Parse(dr["id"].ToString());

                    for (int i = 0; i < quant; i++)
                    {
                        dc.insertCopies(id);
                    }

                }
                return "Agregado Exitosamente";
            }
            else {
                return "mamma mia here we go again";
            }

        }

        public static string delete_books(int id) {
            DBooks db = new DBooks();
            if (db.delete_book(id)) {
                return "Elimnado Exitosamente"; 
            }
            else
            {
                return "Error Eliminandolo, intentelo de nuevo";
            }
        }

        public static string update_books(int id, string title, int quant, string isbn, int edition, int pages, string ubication, string desc, int editorial, int country, int language, int subject, int authorid)
        {

            DBooks db = new DBooks();

            if (db.updatebook(id, title, quant, isbn, edition, pages, ubication, desc, editorial, country, language, subject, authorid)) {

                return "Actualizado Exitosamente";
            }
            else {

                return "Error Actualizando";
            }
        }
        }
}
