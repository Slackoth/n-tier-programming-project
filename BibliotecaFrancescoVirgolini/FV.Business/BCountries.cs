using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FV.Data;

namespace FV.Business
{
    public class BCountries
    {
        public static DataTable List() {
            DCountries dc = new DCountries();
            return dc.List();
        }
    }
}
