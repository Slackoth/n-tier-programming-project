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
    public class Authors { 
        public int value { get; set; }
        public string name { get; set; }
    
    }

    
    public partial class InsertBook : Form
    {
        public InsertBook()
        {
            InitializeComponent();
        }


        private void Insertar_Load(object sender, EventArgs e)
        {

            
            DataTable data = new DataTable();
            data = BAuthors.list();
            var dataSource = new List<Authors>();

            foreach (DataRow dr in data.Rows) {
                dataSource.Add(new Authors() { value = int.Parse(dr["id"].ToString()), name = dr["names"].ToString() });
            }
            AuthorList.DataSource = dataSource;
            AuthorList.ValueMember = "value";
            AuthorList.DisplayMember = "name";

            
        }
            

    }
}
