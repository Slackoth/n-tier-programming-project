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
    }
}
