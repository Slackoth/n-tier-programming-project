using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FV.Data;


namespace FV.Business
{
    public class BSubjects
    {
        public static DataTable List(){
            DSubjects ds = new DSubjects();
            return ds.List();
        }
    }
}
