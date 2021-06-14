using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FV.Business;

namespace FV.View
{
    public partial class CrudBooks : Form
    {
        public CrudBooks()
        {
            InitializeComponent();
        }

        private void refreshdata() {
            
             
            //evitar que sea editable el GridView

            bookgv.ReadOnly = true;
            bookgv.DataSource= BBooks.List(); 
                
            
        }


        private void CrudBooksFrm_Load(object sender, EventArgs e)
        {
            refreshdata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void createBook_Click(object sender, EventArgs e)
        {
            InsertBook ib = new InsertBook();
            

            ib.ShowDialog();
            refreshdata();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string row = bookgv.SelectedRows[0].Cells[0].Value.ToString();
            
        }


        private void Delete_Click(object sender, EventArgs e)

        {

            if ( bookgv.SelectedRows[0].Cells[0].Value.ToString()!=null){
                string response=BBooks.delete_books(int.Parse(bookgv.SelectedRows[0].Cells[0].Value.ToString()));
                MessageBox.Show(response);
            }
            else {
                MessageBox.Show("seleccione una linea completa!!");
            }
            refreshdata();
        }
    }
}
