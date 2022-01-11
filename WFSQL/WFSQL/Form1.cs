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

namespace WFSQL
{
    public partial class Form1 : Form
       
    {
        const string connstr = "Data Source=AULA1D-06\\MSSQLSERVERNEW;Initial Catalog=Prova;Integrated Security=True";
    

        public Form1()
        {
            InitializeComponent();
        }



        private void Invia_Click(object sender, EventArgs e)
        {

             
        System.Data.SqlClient.SqlConnection conn = new SqlConnection(connstr);
            conn.ConnectionString = connstr;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Insert Into Proprietari(CF, nome, cognome, telefono) values(@CF, @nome, @cognome, @telefono)";
            cmd.Parameters.AddWithValue("@CF",textBox2.Text );
            cmd.Parameters.AddWithValue("@nome",textBox3.Text);
            cmd.Parameters.AddWithValue("@cognome",textBox4.Text);
            cmd.Parameters.AddWithValue("@telefono",textBox5.Text);
            int i = cmd.ExecuteNonQuery();
            if (i != null)
            {
                MessageBox.Show("Proprietario inserito con successo");
            }
        }
    }
}

