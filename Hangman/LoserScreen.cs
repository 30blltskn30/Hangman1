using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Hangman
{
	public partial class LoserScreen: DevExpress.XtraEditors.XtraForm
	{
        XtraForm2 xtr = new XtraForm2();
        string gelenmesaj;
        
        public LoserScreen()
		{
            
            InitializeComponent();
           
		}

        private void LoserScreen_Load(object sender, EventArgs e) {
            gelenmesaj = xtr.word;
            MessageBox.Show($"WORD WAS {gelenmesaj}");
        }
        
        private void btn_Restart_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            xtr.ShowDialog();
        }

        private void btn_Exıt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}