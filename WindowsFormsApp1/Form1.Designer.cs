
namespace WindowsFormsApp1
{
    partial class FrmKategorije
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
            this.LblKategorije = new System.Windows.Forms.Label();
            this.BtnZnamenitosti = new System.Windows.Forms.Button();
            this.BtnGradovi = new System.Windows.Forms.Button();
            this.BtnDrzave = new System.Windows.Forms.Button();
            this.PicPozadinaKategorije = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicPozadinaKategorije)).BeginInit();
            this.SuspendLayout();
            // 
            // LblKategorije
            // 
            this.LblKategorije.AutoSize = true;
            this.LblKategorije.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblKategorije.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKategorije.ForeColor = System.Drawing.Color.Transparent;
            this.LblKategorije.Location = new System.Drawing.Point(105, 43);
            this.LblKategorije.Name = "LblKategorije";
            this.LblKategorije.Size = new System.Drawing.Size(565, 27);
            this.LblKategorije.TabIndex = 9;
            this.LblKategorije.Text = "Odaberite jednu od ponuđenih tematskih cjelina!";
            this.LblKategorije.Click += new System.EventHandler(this.LblKategorije_Click);
            // 
            // BtnZnamenitosti
            // 
            this.BtnZnamenitosti.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnZnamenitosti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnZnamenitosti.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZnamenitosti.Location = new System.Drawing.Point(34, 287);
            this.BtnZnamenitosti.Name = "BtnZnamenitosti";
            this.BtnZnamenitosti.Size = new System.Drawing.Size(246, 35);
            this.BtnZnamenitosti.TabIndex = 8;
            this.BtnZnamenitosti.Text = "Kulturne znamenitosti";
            this.BtnZnamenitosti.UseVisualStyleBackColor = false;
            // 
            // BtnGradovi
            // 
            this.BtnGradovi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGradovi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGradovi.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGradovi.Location = new System.Drawing.Point(34, 235);
            this.BtnGradovi.Name = "BtnGradovi";
            this.BtnGradovi.Size = new System.Drawing.Size(246, 35);
            this.BtnGradovi.TabIndex = 7;
            this.BtnGradovi.Text = "Gradovi";
            this.BtnGradovi.UseVisualStyleBackColor = false;
            // 
            // BtnDrzave
            // 
            this.BtnDrzave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDrzave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDrzave.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDrzave.Location = new System.Drawing.Point(34, 180);
            this.BtnDrzave.Name = "BtnDrzave";
            this.BtnDrzave.Size = new System.Drawing.Size(246, 35);
            this.BtnDrzave.TabIndex = 6;
            this.BtnDrzave.Text = "Države";
            this.BtnDrzave.UseVisualStyleBackColor = false;
            this.BtnDrzave.Click += new System.EventHandler(this.BtnDrzave_Click);
            // 
            // PicPozadinaKategorije
            // 
            this.PicPozadinaKategorije.Image = global::WindowsFormsApp1.Properties.Resources._148539;
            this.PicPozadinaKategorije.Location = new System.Drawing.Point(0, 0);
            this.PicPozadinaKategorije.Name = "PicPozadinaKategorije";
            this.PicPozadinaKategorije.Size = new System.Drawing.Size(800, 451);
            this.PicPozadinaKategorije.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPozadinaKategorije.TabIndex = 5;
            this.PicPozadinaKategorije.TabStop = false;
            // 
            // FrmKategorije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblKategorije);
            this.Controls.Add(this.BtnZnamenitosti);
            this.Controls.Add(this.BtnGradovi);
            this.Controls.Add(this.BtnDrzave);
            this.Controls.Add(this.PicPozadinaKategorije);
            this.Name = "FrmKategorije";
            this.Text = "Kategorije";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicPozadinaKategorije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblKategorije;
        private System.Windows.Forms.Button BtnZnamenitosti;
        private System.Windows.Forms.Button BtnGradovi;
        private System.Windows.Forms.Button BtnDrzave;
        private System.Windows.Forms.PictureBox PicPozadinaKategorije;
    }
}