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
	public partial class WinnerScreen: DevExpress.XtraEditors.XtraForm
	{
        public WinnerScreen()
		{
            InitializeComponent();
		}
        XtraForm2 xtr = new XtraForm2();
        private void WinnerScreen_Load(object sender, EventArgs e)
        {
          
            
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            xtr.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void pictureBox_winner_Click(object sender, EventArgs e)
        {

        }
    }
}