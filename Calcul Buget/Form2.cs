using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Calcul_Buget
{
    public partial class Form2 : Form
    {
        Form opener;
        public Form2(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }
        public void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_calculbugetDataSet.Venituri' table. You can move, or remove it, as needed.
            this.venituriTableAdapter.Fill(this.db_calculbugetDataSet.Venituri);
            ///dataGridView1.DataSource = Venituri();
            comboBox1.SelectedIndex = 0;
        }
       /* public DataTable Venituri()
        {

            DataTable V = new DataTable();
            string ConnString = ConfigurationManager.ConnectionStrings["db_calculbuget"].ConnectionString;
            using (SqlConnection SqlConn = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Venituri", SqlConn))
                {
                    SqlConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    V.Load(reader);
                    SqlConn.Close();
                }
            }
            return V; 
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
            if(e.KeyCode==Keys.Enter)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                    venituriBindingSource.Filter = string.Empty;
                else
                {
                    try
                    {
                        venituriBindingSource.Filter = string.Format("{0}='{1}'", comboBox1.Text, textBox1.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Introduceti datele corect!");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnString = ConfigurationManager.ConnectionStrings["db_calculbuget"].ConnectionString;
            if (dataGridView1.SelectedRows != null)
            {
                if (MessageBox.Show("Sigur stergeti aceasta inregistrare?", "Stergere venit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection SqlConn = new SqlConnection(ConnString))
                    {
                        SqlConn.Open();
                        try
                        {
                            int Cont = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                            string Tip_v = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
                            DateTime Data = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[2].Value);
                            decimal Suma = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[3].Value);
                            decimal TVA = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[4].Value);
                            SqlCommand sqlCmd = new SqlCommand("stergere_venit", SqlConn);
                            sqlCmd.Parameters.Add("@Contul", SqlDbType.Int).Value = Cont;
                            sqlCmd.Parameters.Add("@Tip_v", SqlDbType.VarChar).Value = Tip_v;
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
