using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FV.Entities
{
    public class Loans
    {
        public int LoanId { get; set; }
        public string Teacher { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DevolutionDate { get; set; }
    }
}
