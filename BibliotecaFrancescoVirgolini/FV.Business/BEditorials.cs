using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FV.Data;

namespace FV.Business
{
    public class BEditorials
    {
        public static DataTable List() {
            DEditorials de = new DEditorials();
            return de.List();
        }
    }
}
