using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FV.Data;


namespace FV.Business
{
    public class BLanguages
    {
        public static DataTable List(){
            DLanguages dl = new DLanguages();

            return dl.List();
        }

    }
}
