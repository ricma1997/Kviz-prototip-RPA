
namespace WindowsFormsApp1
{
    partial class FrmGradovi
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
            this.BtnGradoviTreci = new System.Windows.Forms.Button();
            this.BtnGradoviCetvrti = new System.Windows.Forms.Button();
            this.BtnGradoviDrugi = new System.Windows.Forms.Button();
            this.BtnGradoviPrvi = new System.Windows.Forms.Button();
            this.LblPitanjeGradovi = new System.Windows.Forms.Label();
            this.BtnNazadGradovi = new System.Windows.Forms.Button();
            this.PicGradovi = new System.Windows.Forms.PictureBox();
            this.PicPozadinaGradovi = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PbrGradovi = new System.Windows.Forms.ProgressBar();
            this.LblProgressGradovi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicGradovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPozadinaGradovi)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGradoviTreci
            // 
            this.BtnGradoviTreci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGradoviTreci.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGradoviTreci.Location = new System.Drawing.Point(226, 399);
            this.BtnGradoviTreci.Name = "BtnGradoviTreci";
            this.BtnGradoviTreci.Size = new System.Drawing.Size(150, 23);
            this.BtnGradoviTreci.TabIndex = 14;
            this.BtnGradoviTreci.Tag = "0";
            this.BtnGradoviTreci.Text = "button3";
            this.BtnGradoviTreci.UseVisualStyleBackColor = true;
            this.BtnGradoviTreci.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // BtnGradoviCetvrti
            // 
            this.BtnGradoviCetvrti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGradoviCetvrti.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGradoviCetvrti.Location = new System.Drawing.Point(407, 399);
            this.BtnGradoviCetvrti.Name = "BtnGradoviCetvrti";
            this.BtnGradoviCetvrti.Size = new System.Drawing.Size(150, 23);
            this.BtnGradoviCetvrti.TabIndex = 13;
            this.BtnGradoviCetvrti.Tag = "0";
            this.BtnGradoviCetvrti.Text = "button4";
            this.BtnGradoviCetvrti.UseVisualStyleBackColor = true;
            this.BtnGradoviCetvrti.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // BtnGradoviDrugi
            // 
            this.BtnGradoviDrugi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGradoviDrugi.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGradoviDrugi.Location = new System.Drawing.Point(407, 350);
            this.BtnGradoviDrugi.Name = "BtnGradoviDrugi";
            this.BtnGradoviDrugi.Size = new System.Drawing.Size(150, 23);
            this.BtnGradoviDrugi.TabIndex = 12;
            this.BtnGradoviDrugi.Tag = "0";
            this.BtnGradoviDrugi.Text = "button2";
            this.BtnGradoviDrugi.UseVisualStyleBackColor = true;
            this.BtnGradoviDrugi.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // BtnGradoviPrvi
            // 
            this.BtnGradoviPrvi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGradoviPrvi.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGradoviPrvi.Location = new System.Drawing.Point(226, 350);
            this.BtnGradoviPrvi.Name = "BtnGradoviPrvi";
            this.BtnGradoviPrvi.Size = new System.Drawing.Size(150, 23);
            this.BtnGradoviPrvi.TabIndex = 11;
            this.BtnGradoviPrvi.Tag = "0";
            this.BtnGradoviPrvi.Text = "button1";
            this.BtnGradoviPrvi.UseVisualStyleBackColor = true;
            this.BtnGradoviPrvi.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // LblPitanjeGradovi
            // 
            this.LblPitanjeGradovi.AutoSize = true;
            this.LblPitanjeGradovi.BackColor = System.Drawing.Color.Gray;
            this.LblPitanjeGradovi.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPitanjeGradovi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPitanjeGradovi.Location = new System.Drawing.Point(203, 30);
            this.LblPitanjeGradovi.Name = "LblPitanjeGradovi";
            this.LblPitanjeGradovi.Size = new System.Drawing.Size(302, 23);
            this.LblPitanjeGradovi.TabIndex = 9;
            this.LblPitanjeGradovi.Text = "Koji grad je prikazan na slici?";
            // 
            // BtnNazadGradovi
            // 
            this.BtnNazadGradovi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNazadGradovi.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNazadGradovi.Location = new System.Drawing.Point(705, 394);
            this.BtnNazadGradovi.Name = "BtnNazadGradovi";
            this.BtnNazadGradovi.Size = new System.Drawing.Size(75, 23);
            this.BtnNazadGradovi.TabIndex = 16;
            this.BtnNazadGradovi.Text = "Nazad";
            this.BtnNazadGradovi.UseVisualStyleBackColor = true;
            this.BtnNazadGradovi.Click += new System.EventHandler(this.BtnNazadGradovi_Click);
            // 
            // PicGradovi
            // 
            this.PicGradovi.Image = global::WindowsFormsApp1.Properties.Resources.NY;
            this.PicGradovi.Location = new System.Drawing.Point(196, 66);
            this.PicGradovi.Name = "PicGradovi";
            this.PicGradovi.Size = new System.Drawing.Size(397, 268);
            this.PicGradovi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicGradovi.TabIndex = 10;
            this.PicGradovi.TabStop = false;
            // 
            // PicPozadinaGradovi
            // 
            this.PicPozadinaGradovi.Image = global::WindowsFormsApp1.Properties.Resources._148539;
            this.PicPozadinaGradovi.Location = new System.Drawing.Point(-1, 0);
            this.PicPozadinaGradovi.Name = "PicPozadinaGradovi";
            this.PicPozadinaGradovi.Size = new System.Drawing.Size(803, 450);
            this.PicPozadinaGradovi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPozadinaGradovi.TabIndex = 8;
            this.PicPozadinaGradovi.TabStop = false;
            // 
            // PbrGradovi
            // 
            this.PbrGradovi.Location = new System.Drawing.Point(688, 31);
            this.PbrGradovi.Maximum = 10;
            this.PbrGradovi.Name = "PbrGradovi";
            this.PbrGradovi.Size = new System.Drawing.Size(100, 23);
            this.PbrGradovi.TabIndex = 17;
            this.toolTip1.SetToolTip(this.PbrGradovi, "Progres");
            this.PbrGradovi.Value = 1;
            // 
            // LblProgressGradovi
            // 
            this.LblProgressGradovi.AutoSize = true;
            this.LblProgressGradovi.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProgressGradovi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblProgressGradovi.Location = new System.Drawing.Point(733, 9);
            this.LblProgressGradovi.Name = "LblProgressGradovi";
            this.LblProgressGradovi.Size = new System.Drawing.Size(47, 19);
            this.LblProgressGradovi.TabIndex = 18;
            this.LblProgressGradovi.Text = "0/10";
            this.LblProgressGradovi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.LblProgressGradovi, "Rezultat");
            // 
            // FrmGradovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblProgressGradovi);
            this.Controls.Add(this.PbrGradovi);
            this.Controls.Add(this.BtnNazadGradovi);
            this.Controls.Add(this.BtnGradoviTreci);
            this.Controls.Add(this.BtnGradoviCetvrti);
            this.Controls.Add(this.BtnGradoviDrugi);
            this.Controls.Add(this.BtnGradoviPrvi);
            this.Controls.Add(this.PicGradovi);
            this.Controls.Add(this.LblPitanjeGradovi);
            this.Controls.Add(this.PicPozadinaGradovi);
            this.Name = "FrmGradovi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicGradovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPozadinaGradovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnGradoviTreci;
        private System.Windows.Forms.Button BtnGradoviCetvrti;
        private System.Windows.Forms.Button BtnGradoviDrugi;
        private System.Windows.Forms.Button BtnGradoviPrvi;
        private System.Windows.Forms.PictureBox PicGradovi;
        private System.Windows.Forms.Label LblPitanjeGradovi;
        private System.Windows.Forms.PictureBox PicPozadinaGradovi;
        private System.Windows.Forms.Button BtnNazadGradovi;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ProgressBar PbrGradovi;
        private System.Windows.Forms.Label LblProgressGradovi;
    }
}