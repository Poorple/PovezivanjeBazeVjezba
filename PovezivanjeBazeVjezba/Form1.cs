using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PovezivanjeBazeVjezba
{
    public partial class Form1 : Form
    {
        string authType;
        SqlConnection sql;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string conn = "";
                if (authType == "sql")
                {
                    conn = @"Server=" + txtServer.Text + ";database=" + txtBaze.Text + "; user ID=" + (txtUsername.Text) + "; Password=" + (txtPassword.Text);
                }
                else {
                    conn = @"Server=" + txtServer.Text + ";database=" + txtBaze.Text + "; Integrated Security = True";
                }
                sql=new SqlConnection(conn);
                sql.Open();
                MessageBox.Show("Connection successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed" + ex.Message);
            }
        }

        private void DDValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DDValue.SelectedItem == "Windows Auth")
            {
                authType = "win";
                txtUsername.ReadOnly = true;
                txtPassword.ReadOnly = true;

            }
            else {
                authType = "sql";
                txtUsername.ReadOnly = false;
                txtPassword.ReadOnly = false;
            }
        }

        private void Fetch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select Top 50 percent IDKupac, Ime, Prezime, Telefon, Email, ISNULL(Sum(UkupnaCijena),0) as Potrosnja from Kupac left join Racun on KupacID=IDkupac" +
                "" + " left join stavka on RacunID=idRacun where Year(DatumIzdavanja) = "
                + (YofInvoice.Text) + " Group by IDKupac, Ime, Prezime, Telefon, Email having ISNULL(Sum(UkupnaCijena),0) between " + (LowSpendLim.Text) + " AND " + (UpSpendLim.Text) + " order by Potrosnja desc", sql);
                SqlDataReader reader=cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                SqlDataGridView.DataSource=dt;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void CityFetch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Grad", sql);
                SqlDataAdapter sqlad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlad.Fill(dt);
                SqlDataGridView.DataSource = dt;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try {
                SqlCommand cmd = new SqlCommand("Insert into Grad(Naziv) values ('" +(txtCityName.Text)+"')", sql);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
