using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAssignment
{
    public partial class History : Form
    {
        String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/Asus/OneDrive/Desktop/VIIE Sem 2/Designing Object Oriented Computer Program/FinalAssignment/bin/FinalAssignment.mdb;";
        String username;

        public History()
        {
            InitializeComponent();
        }

        public History(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("Select * From "+comboBox1.Text+" WHERE Username = '"+username+"'", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage(username);
            homePage.ShowDialog();
            this.Close();
        }
    }
}
