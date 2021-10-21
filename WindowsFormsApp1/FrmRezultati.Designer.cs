
namespace WindowsFormsApp1
{
    partial class FrmRezultati
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
            this.components = new System.ComponentModel.Container();
            this.LblNaslovRezultat = new System.Windows.Forms.Label();
            this.LblRezultati = new System.Windows.Forms.Label();
            this.BtnRezultatiNastavak = new System.Windows.Forms.Button();
            this.BtnNatrag = new System.Windows.Forms.Button();
            this.PicPozadinaRezultati = new System.Windows.Forms.PictureBox();
            this.LblRezultatiDrugi = new System.Windows.Forms.Label();
            this.TxtRezultati = new System.Windows.Forms.TextBox();
            this.BtnRezultatiPohrana = new System.Windows.Forms.Button();
            this.DtpRezultati = new System.Windows.Forms.DateTimePicker();
            this.TltRezultati = new System.Windows.Forms.ToolTip(this.components);
            this.CbxPohraniRez = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicPozadinaRezultati)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNaslovRezultat
            // 
            this.LblNaslovRezultat.AutoSize = true;
            this.LblNaslovRezultat.BackColor = System.Drawing.SystemColors.Control;
            this.LblNaslovRezultat.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNaslovRezultat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNaslovRezultat.Location = new System.Drawing.Point(345, 30);
            this.LblNaslovRezultat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNaslovRezultat.Name = "LblNaslovRezultat";
            this.LblNaslovRezultat.Size = new System.Drawing.Size(121, 21);
            this.LblNaslovRezultat.TabIndex = 1;
            this.LblNaslovRezultat.Text = "REZULTAT";
            // 
            // LblRezultati
            // 
            this.LblRezultati.AutoSize = true;
            this.LblRezultati.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRezultati.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblRezultati.Location = new System.Drawing.Point(29, 63);
            this.LblRezultati.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRezultati.Name = "LblRezultati";
            this.LblRezultati.Size = new System.Drawing.Size(58, 19);
            this.LblRezultati.TabIndex = 2;
            this.LblRezultati.Text = "label2";
            this.LblRezultati.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnRezultatiNastavak
            // 
            this.BtnRezultatiNastavak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRezultatiNastavak.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRezultatiNastavak.Location = new System.Drawing.Point(518, 385);
            this.BtnRezultatiNastavak.Name = "BtnRezultatiNastavak";
            this.BtnRezultatiNastavak.Size = new System.Drawing.Size(117, 35);
            this.BtnRezultatiNastavak.TabIndex = 3;
            this.BtnRezultatiNastavak.Text = "Nastavi";
            this.TltRezultati.SetToolTip(this.BtnRezultatiNastavak, "Nastavi s rješavanjem kviza");
            this.BtnRezultatiNastavak.UseVisualStyleBackColor = true;
            this.BtnRezultatiNastavak.Click += new System.EventHandler(this.BtnRezultatiNastavak_Click);
            // 
            // BtnNatrag
            // 
            this.BtnNatrag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNatrag.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNatrag.Location = new System.Drawing.Point(665, 385);
            this.BtnNatrag.Name = "BtnNatrag";
            this.BtnNatrag.Size = new System.Drawing.Size(104, 35);
            this.BtnNatrag.TabIndex = 4;
            this.BtnNatrag.Text = "Natrag";
            this.TltRezultati.SetToolTip(this.BtnNatrag, "Vrati se na odabir kategorija");
            this.BtnNatrag.UseVisualStyleBackColor = true;
            this.BtnNatrag.Click += new System.EventHandler(this.BtnNatrag_Click);
            // 
            // PicPozadinaRezultati
            // 
            this.PicPozadinaRezultati.Image = global::WindowsFormsApp1.Properties.Resources.pic_pozadina_rezultati;
            this.PicPozadinaRezultati.Location = new System.Drawing.Point(0, 0);
            this.PicPozadinaRezultati.Margin = new System.Windows.Forms.Padding(2);
            this.PicPozadinaRezultati.Name = "PicPozadinaRezultati";
            this.PicPozadinaRezultati.Size = new System.Drawing.Size(810, 462);
            this.PicPozadinaRezultati.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPozadinaRezultati.TabIndex = 0;
            this.PicPozadinaRezultati.TabStop = false;
            this.PicPozadinaRezultati.Click += new System.EventHandler(this.PicPozadinaRezultati_Click);
            // 
            // LblRezultatiDrugi
            // 
            this.LblRezultatiDrugi.AutoSize = true;
            this.LblRezultatiDrugi.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRezultatiDrugi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblRezultatiDrugi.Location = new System.Drawing.Point(33, 346);
            this.LblRezultatiDrugi.Name = "LblRezultatiDrugi";
            this.LblRezultatiDrugi.Size = new System.Drawing.Size(58, 19);
            this.LblRezultatiDrugi.TabIndex = 5;
            this.LblRezultatiDrugi.Text = "label1";
            // 
            // TxtRezultati
            // 
            this.TxtRezultati.Location = new System.Drawing.Point(33, 170);
            this.TxtRezultati.Multiline = true;
            this.TxtRezultati.Name = "TxtRezultati";
            this.TxtRezultati.Size = new System.Drawing.Size(155, 138);
            this.TxtRezultati.TabIndex = 6;
            // 
            // BtnRezultatiPohrana
            // 
            this.BtnRezultatiPohrana.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRezultatiPohrana.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRezultatiPohrana.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRezultatiPohrana.Location = new System.Drawing.Point(37, 314);
            this.BtnRezultatiPohrana.Name = "BtnRezultatiPohrana";
            this.BtnRezultatiPohrana.Size = new System.Drawing.Size(141, 26);
            this.BtnRezultatiPohrana.TabIndex = 7;
            this.BtnRezultatiPohrana.Text = "Pohrani Rezultat";
            this.BtnRezultatiPohrana.UseVisualStyleBackColor = true;
            this.BtnRezultatiPohrana.Click += new System.EventHandler(this.BtnRezultatiPohrana_Click);
            // 
            // DtpRezultati
            // 
            this.DtpRezultati.Location = new System.Drawing.Point(33, 144);
            this.DtpRezultati.Name = "DtpRezultati";
            this.DtpRezultati.Size = new System.Drawing.Size(120, 20);
            this.DtpRezultati.TabIndex = 8;
            // 
            // CbxPohraniRez
            // 
            this.CbxPohraniRez.AutoSize = true;
            this.CbxPohraniRez.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxPohraniRez.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CbxPohraniRez.Location = new System.Drawing.Point(33, 119);
            this.CbxPohraniRez.Name = "CbxPohraniRez";
            this.CbxPohraniRez.Size = new System.Drawing.Size(207, 19);
            this.CbxPohraniRez.TabIndex = 9;
            this.CbxPohraniRez.Text = "Želite li pohraniti rezultat";
            this.CbxPohraniRez.UseVisualStyleBackColor = true;
            // 
            // FrmRezultati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CbxPohraniRez);
            this.Controls.Add(this.DtpRezultati);
            this.Controls.Add(this.BtnRezultatiPohrana);
            this.Controls.Add(this.TxtRezultati);
            this.Controls.Add(this.LblRezultatiDrugi);
            this.Controls.Add(this.BtnNatrag);
            this.Controls.Add(this.BtnRezultatiNastavak);
            this.Controls.Add(this.LblRezultati);
            this.Controls.Add(this.LblNaslovRezultat);
            this.Controls.Add(this.PicPozadinaRezultati);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRezultati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezultati";
            this.Load += new System.EventHandler(this.FrmRezultati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicPozadinaRezultati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicPozadinaRezultati;
        private System.Windows.Forms.Label LblNaslovRezultat;
        private System.Windows.Forms.Label LblRezultati;
        private System.Windows.Forms.Button BtnRezultatiNastavak;
        private System.Windows.Forms.Button BtnNatrag;
        private System.Windows.Forms.Label LblRezultatiDrugi;
        private System.Windows.Forms.TextBox TxtRezultati;
        private System.Windows.Forms.Button BtnRezultatiPohrana;
        private System.Windows.Forms.DateTimePicker DtpRezultati;
        private System.Windows.Forms.ToolTip TltRezultati;
        private System.Windows.Forms.CheckBox CbxPohraniRez;
    }
}