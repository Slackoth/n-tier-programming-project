using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FV.Data;
using System.Data;

namespace FV.Business
{
    public class BLoans
    {
        public static DataTable List(int id)
        {
            DLoans dLoan = new();

            return dLoan.List(id);
        }

        public static DataTable Search(int id, DateTime date)
        {
            DLoans dLoan = new();

            return dLoan.Search(id, date);
        }

        public static string Insert(int bookId, int teacherId, DateTime loanDate, DateTime returnDate)
        {
            DLoans dLoan = new();

            if (!dLoan.IsBookLoanable(bookId))
                return "La cantidad de libros disponibles para prestar es menor o igual a 1.";

            if (dLoan.TeacherHasLoanedBook(bookId, teacherId))
                return "No se puede prestar un libro que ya ha sido prestado.";

            if (dLoan.Insert(bookId, teacherId, loanDate, returnDate))
                return "El préstamo ha sido completado.";
            else
                return "El préstamo no ha podido ser completado.";
        }

        public static DataTable listall() {
            DLoans dl = new DLoans();

            return dl.Listwithoutfilters();

        }

        public static string Devolution(int id, int copies_id)
        {
            DLoans dLoan = new();
            if (dLoan.update_devolution(id, copies_id)) {
                return "se ha devuelto con exito";
            }
            else{

                return"error";
            }


            
        }
    }
}
