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
using DevExpress.DataAccess.Native.EntityFramework;


namespace Hangman
{
    public partial class Form1: Form
    {
        public Form1()
        {
            
            InitializeComponent();
           
        }
        object m;
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
        
            SqlConnection cnt = new SqlConnection("Server = MILAL\\SQLEXPRESS; Database = okul; Trusted_Connection = True;");

            cnt.Open();
        
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 OgrSoyad from ogr ORDER BY NEWID();", cnt);
            SqlDataReader reader = cmd.ExecuteReader();

            m = null;

            if (reader.Read())
                m = reader["OgrSoyad"];

            MessageBox.Show(Convert.ToString(m));
            reader.Close();
            cnt.Close();

           
        }
    }
}
