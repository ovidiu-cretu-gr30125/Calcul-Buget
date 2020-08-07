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
    public partial class Form3 : Form
    {
        Form opener;
        public Form3(Form parentForm)
        {
            InitializeComponent();
            opener = ParentForm;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_calculbugetDataSet1.Cheltuieli' table. You can move, or remove it, as needed.
            this.cheltuieliTableAdapter1.Fill(this.db_calculbugetDataSet5.Cheltuieli);
            ///dataGridView1.DataSource = Cheltuieli();
            comboBox1.SelectedIndex = 0;
        }
       /* public DataTable Cheltuieli()
        {
            DataTable C = new DataTable();
            string ConnString = ConfigurationManager.ConnectionStrings["db_calculbuget"].ConnectionString;
            using (SqlConnection SqlConn = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Cheltuieli", SqlConn))
                {
                    SqlConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    C.Load(reader);
                    SqlConn.Close();
                }
            }
            return C ;
        }*/
        private void cautareToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void cautareToolStrip_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                    cheltuieliBindingSource1.Filter = string.Empty;
                else
                    try
                    {
                        cheltuieliBindingSource1.Filter = string.Format("{0}='{1}'", comboBox1.Text, textBox1.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Introduceti datele corect!");
                    }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnString = ConfigurationManager.ConnectionStrings["db_calculbuget"].ConnectionString;
            if (dataGridView1.SelectedRows != null)
            {
                if (MessageBox.Show("Sigur stergeti aceasta inregistrare?", "Stergere cheltuieli", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection SqlConn = new SqlConnection(ConnString))
                    {
                        SqlConn.Open();
                        try
                        {
                            int Cont = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                            string Tip_c = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
                            DateTime Data = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[2].Value);
                            decimal Suma = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[3].Value);
                            decimal TVA = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[4].Value);
                            SqlCommand sqlCmd = new SqlCommand("stergere_cheltuieli", SqlConn);
                            sqlCmd.Parameters.Add("@Contul", SqlDbType.Int).Value = Cont;
                            sqlCmd.Parameters.Add("@Tip_c", SqlDbType.VarChar).Value = Tip_c;
                            sqlCmd.Parameters.Add("@Data", SqlDbType.Date).Value = Data;
                            sqlCmd.Parameters.Add("@Suma", SqlDbType.Money).Value = Suma;
                            sqlCmd.Parameters.Add("@TVA", SqlDbType.Money).Value = TVA;
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.ExecuteNonQuery();
                            MessageBox.Show("Stergerea a fost facuta cu succes!");
                            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                        }
                        
                        catch
                        {
                            MessageBox.Show("Stergerea nu s-a efectuat!");
                        }
                       


                    }
                }
            }
        }
    }
}
