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
    public partial class Form6 : Form
    {
        Form opener;
        public Form6(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_calculbugetDataSet7.venituri_financiare_view' table. You can move, or remove it, as needed.
            this.venituri_financiare_viewTableAdapter.Fill(this.db_calculbugetDataSet7.venituri_financiare_view);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Decimal s = 0;
            string ConnString = ConfigurationManager.ConnectionStrings["db_calculbuget"].ConnectionString;
            using (SqlConnection SqlConn = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("select sum(Suma+TVA) from venituri_financiare;", SqlConn))
                {
                    SqlConn.Open();
                    SqlDataReader reader = null;
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    s = reader.GetDecimal(0);
                    textBox1.Text = reader[0].ToString();
                    reader.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ConnString = ConfigurationManager.ConnectionStrings["db_calculbuget"].ConnectionString;
            using (SqlConnection SqlConn = new SqlConnection(ConnString))
            {
                SqlConn.Open();
                SqlDataAdapter v1 = new SqlDataAdapter("venituri_financiare_insert", SqlConn);
                v1.SelectCommand.CommandType = CommandType.StoredProcedure;
                try
                {

                    try
                    {
                        v1.SelectCommand.Parameters.Add("@Contul", SqlDbType.Int).Value = textBox2.Text;
                        v1.SelectCommand.ExecuteNonQuery();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Introduceti contul corect!");

                    }
                }
                catch (Exception)
                {
                    
                }
                v1.SelectCommand.Parameters.Add("@Tip_v", SqlDbType.VarChar, (50)).Value = textBox3.Text;
                try
                {
                    try
                    {
                        v1.SelectCommand.Parameters.Add("@Data", SqlDbType.Date).Value = textBox4.Text;
                        v1.SelectCommand.ExecuteNonQuery();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Introduceti data corect!");
                    }
                }
                catch (Exception)
                {

                }
                v1.SelectCommand.Parameters.Add("@Document", SqlDbType.VarChar, (50)).Value = textBox5.Text;

                try
                {
                    try
                    {
                        v1.SelectCommand.Parameters.Add("@Suma", SqlDbType.Money).Value = textBox6.Text;
                        v1.SelectCommand.ExecuteNonQuery();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Introduceti suma corect!");
                    }
                }
                catch (Exception)
                {

                }
                try
                {
                    try
                    {
                        v1.SelectCommand.Parameters.Add("@TVA", SqlDbType.Money).Value = textBox7.Text;
                        v1.SelectCommand.ExecuteNonQuery();
                        MessageBox.Show("Adaugare reusita!");
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Introduceti TVA-ul corect!");
                    }
                }
                catch (Exception )
                {

                }
                SqlConn.Close();
            }
        }
    }
}
    

