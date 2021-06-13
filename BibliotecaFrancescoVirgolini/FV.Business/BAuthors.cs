using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FV.Data;


namespace FV.Business
{
    public class BAuthors
    {
        
        public static  DataTable list() {
            Data.DAuthors da = new DAuthors();
                return da.List();
        }
    }
}
