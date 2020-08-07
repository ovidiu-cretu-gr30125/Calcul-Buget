using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcul_Buget
{
    public partial class Form4 : Form
    {
        Form opener;
        public Form4(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            decimal v = 0;
            // TODO: This line of code loads data into the 'db_calculbugetDataSet4.Cheltuieli' table. You can move, or remove it, as needed.
            this.cheltuieliTableAdapter.Fill(this.db_calculbugetDataSet4.Cheltuieli);
            // TODO: This line of code loads data into the 'db_calculbugetDataSet3.Venituri' table. You can move, or remove it, as needed.
            this.venituriTableAdapter1.Fill(this.db_calculbugetDataSet3.Venituri);
            // TODO: This line of code loads data into the 'db_calculbugetDataSet2.Venituri' table. You can move, or remove it, as needed.
            this.venituriTableAdapter.Fill(this.db_calculbugetDataSet2.Venituri);
            
            string ConnString = ConfigurationManager.ConnectionStrings["db_calculbuget"].ConnectionString;
            using (SqlConnection SqlConn = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("select sum(Suma+TVA) from Venituri;", SqlConn))
                {
                    SqlConn.Open();
                    SqlDataReader reader = null;
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    v = reader.GetDecimal(0);
                    textBox1.Text = reader[0].ToString();
                    reader.Close();
                }
            }

           
            decimal c = 0;
            using (SqlConnection SqlConn = new SqlConnection(ConnString))
            {
                
                using (SqlCommand cmd = new SqlCommand("select sum(Suma+TVA) from Cheltuieli;", SqlConn))
                {
                    SqlConn.Open();
                    SqlDataReader reader = null;
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    c = reader.GetDecimal(0);
                    textBox2.Text = reader[0].ToString();
                    reader.Close();
                }
            }
            textBox3.Text = (v - c).ToString();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
