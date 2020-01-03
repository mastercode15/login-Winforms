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

namespace WindowsFormsApp1
{
    public partial class Inicio_de_sesion : Form
    {
        Form1 vistas;
        public Inicio_de_sesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_de_sesion_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=MSI;Initial Catalog=NORTHWIND;User ID=team;Password=12345");
            SqlCommand cmd = new SqlCommand("select * from login where UserName=@UserName and pwd =@Password", sqlcon);
            cmd.Parameters.AddWithValue("@UserName", textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            sqlcon.Open();
            int i = cmd.ExecuteNonQuery();
            sqlcon.Close();
            if (dtbl.Rows.Count==1)
            {
                        vistas = new Form1();
                        vistas.Show();
                        
            }
            else
            {
                MessageBox.Show("verifica tu usuario o contraseña");
            }

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
