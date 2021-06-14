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
    public partial class UpdateBooks : Form
    {
        string title;
        int id;
        public UpdateBooks()
        {
            InitializeComponent();
        }

        public void settitle(string idc) {
            title = idc;
        }
        public void setid(int idk) {
            id = idk;
        }
        private void loadComboBox(ComboBox e, DataTable data)
        {

            var DataSource = new List<DataList>();

            foreach (DataRow dr in data.Rows)
            {
                DataSource.Add(new DataList() { value = int.Parse(dr["id"].ToString()), name = dr["names"].ToString() });
            }
            e.DataSource = DataSource;
            e.ValueMember = "value";
            e.DisplayMember = "name";
        }

        private void UpdateBooks_Load(object sender, EventArgs e)
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

            DataTable datas = new DataTable();
            datas= BBooks.Search(title, 6);

            foreach (DataRow dr in datas.Rows) {
                setid(int.Parse(dr["book_id"].ToString()));
                booktitle.Text = dr["title"].ToString();
                bookisbn.Text = dr["isbn"].ToString();
                boookedition.Value = Decimal.Parse(dr["no_edition"].ToString());
                bookquantity.Value = Decimal.Parse(dr["quantity"].ToString());

                bookpages.Value = Decimal.Parse(dr["no_pages"].ToString());
                bookubication.Text = dr["ubication"].ToString();
                bookdesc.Text = dr["bookdescription"].ToString();

                EditorialList.SelectedIndex = int.Parse(dr["editorial_id"].ToString())-1;
                countrieList.SelectedIndex = int.Parse(dr["countries_id"].ToString())-1;
                LanguageList.SelectedIndex = int.Parse(dr["languages_id"].ToString())-1;
                SubjectList.SelectedIndex = int.Parse(dr["subject_id"].ToString())-1;
                AuthorList.SelectedIndex = int.Parse(dr["authors_id"].ToString())-1;
            }


            //autofill slots



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string response = BBooks.update_books(id,booktitle.Text, Convert.ToInt32(Math.Round(bookquantity.Value, 0)), bookisbn.Text, Convert.ToInt32(Math.Round(boookedition.Value, 0)), Convert.ToInt32(Math.Round(bookpages.Value, 0)), bookubication.Text, bookdesc.Text, EditorialList.SelectedIndex + 1, countrieList.SelectedIndex + 1, LanguageList.SelectedIndex + 1, SubjectList.SelectedIndex + 1, AuthorList.SelectedIndex + 1);
            MessageBox.Show(response);
            Close();
        }
    }
}
