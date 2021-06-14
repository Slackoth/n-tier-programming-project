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
    public class DataList { 
        public int value { get; set; }
        public string name { get; set; }        
    }

    public partial class InsertBook : Form
    {
        public InsertBook()
        {
            InitializeComponent();
        }


        private void loadComboBox( ComboBox e, DataTable data) {

            var DataSource = new List<DataList>();

            foreach (DataRow dr in data.Rows)
            {
                DataSource.Add(new DataList() { value = int.Parse(dr["id"].ToString()), name = dr["names"].ToString() });
            }
            e.DataSource = DataSource;
            e.ValueMember = "value";
            e.DisplayMember = "name";
        }
        private void Insertar_Load(object sender, EventArgs e)
        {

            //data for author
            DataTable authordata = new DataTable();
            authordata = BAuthors.list();
            loadComboBox(AuthorList, authordata);
            //data for editorials
            DataTable editorialdata = new DataTable();
            editorialdata = BEditorials.List();
            loadComboBox(EditorialList, editorialdata);
            //data for languages
            DataTable languagesdata = new DataTable();
            languagesdata = BLanguages.List();
            loadComboBox(LanguageList, languagesdata);
            //data for subjects
            DataTable subjectsdata = new DataTable();
            subjectsdata = BSubjects.List();
            loadComboBox(SubjectList, subjectsdata);
            // data for Country
            DataTable countrydata = new DataTable();
            countrydata = BCountries.List();
            loadComboBox(countrieList, countrydata);
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = EditorialList.SelectedIndex;
            
            string response = BBooks.insertbooks(booktitle.Text, Convert.ToInt32(Math.Round(bookquantity.Value, 0)), bookisbn.Text, Convert.ToInt32(Math.Round(boookedition.Value, 0)), Convert.ToInt32(Math.Round(numericUpDown1.Value, 0)), textBox1.Text, bookdesc.Text, EditorialList.SelectedIndex+1, countrieList.SelectedIndex+1, LanguageList.SelectedIndex+1, SubjectList.SelectedIndex+1, AuthorList.SelectedIndex+1);
            MessageBox.Show(response);
            Close();

        }


    }
}
