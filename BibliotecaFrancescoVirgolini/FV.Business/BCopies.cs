using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FV.Data;

namespace FV.Business
{
    class BCopies
    {
        public static void insertCopies(int id) {
            DCopies dc = new DCopies();

            dc.insertCopies(id);
        }
    }
}
