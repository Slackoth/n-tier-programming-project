using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FV.View
{
    public partial class ReportForm : Form
    {

        public class reportes { 
            public string text { get; set; }
            public int value { get; set; }
        }
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            var dataSource = new List<reportes>();
            dataSource.Add(new reportes() { text = "Libros Registrados", value = 1 });
            dataSource.Add(new reportes() { text = "Prestramos Activos de Libros", value = 2 });

            this.cbReport.DataSource = dataSource;
            this.cbReport.DisplayMember = "text";
            this.cbReport.ValueMember = "value";
        }

        private void Showbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
