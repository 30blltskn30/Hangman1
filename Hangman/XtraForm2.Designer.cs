namespace Hangman
{
    partial class XtraForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox_Letter = new System.Windows.Forms.TextBox();
            this.lbl_harfgir = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_WrongRİghts = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_wrong_rights_number = new DevExpress.XtraEditors.LabelControl();
            this.lbl_quess = new System.Windows.Forms.Label();
            this.txtBox_quess = new System.Windows.Forms.TextBox();
            this.btn_checker = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_TriedLetters = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_Letter
            // 
            this.txtBox_Letter.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_Letter.Location = new System.Drawing.Point(761, 291);
            this.txtBox_Letter.Name = "txtBox_Letter";
            this.txtBox_Letter.Size = new System.Drawing.Size(64, 35);
            this.txtBox_Letter.TabIndex = 0;
            this.txtBox_Letter.Click += new System.EventHandler(this.txtBox_Letter_Click);
            // 
            // lbl_harfgir
            // 
            this.lbl_harfgir.AutoSize = true;
            this.lbl_harfgir.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_harfgir.Location = new System.Drawing.Point(577, 294);
            this.lbl_harfgir.Name = "lbl_harfgir";
            this.lbl_harfgir.Size = new System.Drawing.Size(161, 28);
            this.lbl_harfgir.TabIndex = 1;
            this.lbl_harfgir.Text = "Enter A Letter:";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_confirm.Location = new System.Drawing.Point(763, 338);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(89, 35);
            this.btn_confirm.TabIndex = 2;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(517, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 4;
            // 
            // lbl_WrongRİghts
            // 
            this.lbl_WrongRİghts.AutoSize = true;
            this.lbl_WrongRİghts.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_WrongRİghts.Location = new System.Drawing.Point(959, 385);
            this.lbl_WrongRİghts.Name = "lbl_WrongRİghts";
            this.lbl_WrongRİghts.Size = new System.Drawing.Size(219, 34);
            this.lbl_WrongRİghts.TabIndex = 5;
            this.lbl_WrongRİghts.Text = " Wrong Rights =";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Header.Location = new System.Drawing.Point(603, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(222, 38);
            this.lbl_Header.TabIndex = 6;
            this.lbl_Header.Text = "FIND THE WORD";
            // 
            // lbl_wrong_rights_number
            // 
            this.lbl_wrong_rights_number.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_wrong_rights_number.Appearance.Options.UseFont = true;
            this.lbl_wrong_rights_number.Location = new System.Drawing.Point(1184, 382);
            this.lbl_wrong_rights_number.Name = "lbl_wrong_rights_number";
            this.lbl_wrong_rights_number.Size = new System.Drawing.Size(16, 36);
            this.lbl_wrong_rights_number.TabIndex = 7;
            this.lbl_wrong_rights_number.Text = "0";
            // 
            // lbl_quess
            // 
            this.lbl_quess.AutoSize = true;
            this.lbl_quess.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_quess.Location = new System.Drawing.Point(576, 543);
            this.lbl_quess.Name = "lbl_quess";
            this.lbl_quess.Size = new System.Drawing.Size(241, 34);
            this.lbl_quess.TabIndex = 8;
            this.lbl_quess.Text = "Quess The Word :";
            // 
            // txtBox_quess
            // 
            this.txtBox_quess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_quess.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_quess.Location = new System.Drawing.Point(834, 533);
            this.txtBox_quess.Name = "txtBox_quess";
            this.txtBox_quess.Size = new System.Drawing.Size(251, 44);
            this.txtBox_quess.TabIndex = 9;
            // 
            // btn_checker
            // 
            this.btn_checker.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_checker.Location = new System.Drawing.Point(1116, 533);
            this.btn_checker.Name = "btn_checker";
            this.btn_checker.Size = new System.Drawing.Size(110, 44);
            this.btn_checker.TabIndex = 10;
            this.btn_checker.Text = "Check It";
            this.btn_checker.UseVisualStyleBackColor = true;
            this.btn_checker.Click += new System.EventHandler(this.btn_checker_Click);
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_start.Location = new System.Drawing.Point(355, 246);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(156, 76);
            this.btn_start.TabIndex = 11;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Hangman.Properties.Resources._05;
            this.pictureBox1.Location = new System.Drawing.Point(948, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 369);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_TriedLetters
            // 
            this.lbl_TriedLetters.AutoSize = true;
            this.lbl_TriedLetters.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_TriedLetters.Location = new System.Drawing.Point(578, 465);
            this.lbl_TriedLetters.Name = "lbl_TriedLetters";
            this.lbl_TriedLetters.Size = new System.Drawing.Size(297, 34);
            this.lbl_TriedLetters.TabIndex = 12;
            this.lbl_TriedLetters.Text = "You Tried This Letters:";
            // 
            // XtraForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 624);
            this.Controls.Add(this.lbl_TriedLetters);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_checker);
            this.Controls.Add(this.txtBox_quess);
            this.Controls.Add(this.lbl_quess);
            this.Controls.Add(this.lbl_wrong_rights_number);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.lbl_WrongRİghts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.lbl_harfgir);
            this.Controls.Add(this.txtBox_Letter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "XtraForm2";
            this.Text = "XtraForm2";
            this.Load += new System.EventHandler(this.XtraForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Letter;
        private System.Windows.Forms.Label lbl_harfgir;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_WrongRİghts;
        private System.Windows.Forms.Label lbl_Header;
        private DevExpress.XtraEditors.LabelControl lbl_wrong_rights_number;
        private System.Windows.Forms.Label lbl_quess;
        private System.Windows.Forms.TextBox txtBox_quess;
        private System.Windows.Forms.Button btn_checker;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_TriedLetters;
    }
}