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
using System.Data.SqlClient;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Drawing.Text;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraPrinting;
using DevExpress.CodeParser;
using System.Reflection.Emit;
using WinFormsLabel = System.Windows.Forms.Label;
using DevExpress.Drawing.TextFormatter.Internal;




namespace Hangman
{

    public partial class XtraForm2 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm2()
        {
            InitializeComponent();


        }





        public String word;
        WinFormsLabel lbl_letters = new WinFormsLabel();
        String[] letters;
        WinFormsLabel[] lines = new WinFormsLabel[20];
        int wrongRight = 6;
        int wordLength;
        string enteredLetter;





        private void XtraForm2_Load(object sender, EventArgs e)
        {

            btn_confirm.Enabled = false;
            btn_checker.Enabled = false;
            txtBox_Letter.Enabled = false;
            txtBox_quess.Enabled = false;
            lbl_wrong_rights_number.Text = Convert.ToString(wrongRight);
        }


        void WritingLine()
        {

            int xPos = 500;
            for (int i = 0; i < letters.Length; i++)
            {

                lines[i] = new WinFormsLabel();
                lines[i].Name = "lbl" + i;
                lines[i].Text = "_";
                lines[i].Font = new Font("Arial", 18, FontStyle.Bold);
                lines[i].AutoSize = true;
                lines[i].Location = new Point(xPos, 100);
                this.Controls.Add(lines[i]);
                xPos += 30;



            }
        }

        void NewWord()
        {
            SqlConnection cnt = new SqlConnection("Server=MILAL\\SQLEXPRESS;Database=Hung_Man_Words;Trusted_Connection=True");

            cnt.Open();

            SqlCommand value = new SqlCommand("SELECT TOP 1 words FROM Words ORDER BY NEWID();", cnt);
            SqlDataReader dr = value.ExecuteReader();

            dr.Read();


            word = dr["words"].ToString();

            letters = word.Select(c => c.ToString()).ToArray(); //stringi chaarlarına ayırıp diziye atıyor.
            wordLength = word.Length;

            cnt.Close();


        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {

            confirmButton();

        }

        private void chancingImage()
        {

            if (wrongRight == 6)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\MONSTER\\source\\repos\\Hangman\\images\\0.png");
            }
            else if (wrongRight == 5)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\MONSTER\\source\\repos\\Hangman\\images\\1.png");

            }
            else if (wrongRight == 4)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\MONSTER\\source\\repos\\Hangman\\images\\2.png");
            }
            else if (wrongRight == 3)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\MONSTER\\source\\repos\\Hangman\\images\\3.png");

            }

            else if (wrongRight == 2)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\MONSTER\\source\\repos\\Hangman\\images\\4.png");
            }

            else if (wrongRight == 1)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\MONSTER\\source\\repos\\Hangman\\images\\5.png");
            }

            else if (wrongRight == 0)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\MONSTER\\source\\repos\\Hangman\\images\\6.png");
            }


        }

        private void confirmButton()
        {


            enteredLetter = txtBox_Letter.Text.ToLower().Trim();
            letters[0].ToLower();

            if (enteredLetter.Length == 1 && letters.Contains(enteredLetter, StringComparer.OrdinalIgnoreCase)) // contain fonksiyonun çalışma şekli yüzünden letter dizisinin ile harfini büyük kabul ettiğinden algoritma bozuluyordu. Bunu engellemek için StringComparer.OrdinalIgnoreCase kullanıldı
            {


                for (int j = 0; j <= letters.Length - 1; j++)
                {

                    if (letters[j].ToLower() == enteredLetter)
                    {
                        lines[j].Text = enteredLetter.ToUpper();
                        txtBox_Letter.Text = "";
                        wordLength -= 1; //bunun amacı kelimeyi tahmin etmeden kazanmayı sağlamak   

                    }


                }

                if (wordLength == 0)
                {
                    WinnerScreen wnr = new WinnerScreen();
                    this.Hide();
                    wnr.ShowDialog();

                }
            }

            else if (enteredLetter.Length == 1 & letters.Contains(enteredLetter, StringComparer.OrdinalIgnoreCase) == false)
            {
                wrongRight -= 1;
                txtBox_Letter.Text = "upss";


                triedLetters();
                chancingImage();

                lbl_wrong_rights_number.Text = Convert.ToString(wrongRight);

                if (wrongRight == 0)
                {

                    LoserScreen lsr = new LoserScreen();
                    lsr.ShowDialog();
                    btn_confirm.Enabled = false;
                    txtBox_quess.Enabled = false;
                    txtBox_Letter.Enabled = false;
                    txtBox_quess.Enabled = false;

                }
            }

            else
            {
                txtBox_Letter.Text = "eror";
            }






        }

        private void btn_checker_Click(object sender, EventArgs e)
        {
            if (txtBox_quess.Text.ToLower() == word.ToLower())
            {
                WinnerScreen winner = new WinnerScreen();

                this.Hide();
                winner.ShowDialog();
            }
            else
            {
                LoserScreen lsr = new LoserScreen();

                this.Hide();
                lsr.ShowDialog();
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = false;
            btn_checker.Enabled = true;
            btn_confirm.Enabled = true;
            txtBox_quess.Enabled = true;
            txtBox_Letter.Enabled = true;
            NewWord();
            WritingLine();

        }

        private void txtBox_Letter_Click(object sender, EventArgs e)
        {
            txtBox_Letter.Text = "";

        }


        private void triedLetters()
        {
            int xPosition = 729;

            lbl_letters.Font = new Font("Aria", 18, FontStyle.Bold);
            lbl_letters.Location = new Point(xPosition, 378);
            lbl_letters.Text += enteredLetter + "-";
            lbl_letters.Size = new Size(297, 34);
            this.Controls.Add(lbl_letters);
            xPosition += 10;

        }


    }
}
