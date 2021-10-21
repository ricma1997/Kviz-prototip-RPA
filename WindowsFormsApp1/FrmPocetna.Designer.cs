
namespace WindowsFormsApp1
{
    partial class FrmPocetna
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
            this.LblNaslovPocetna = new System.Windows.Forms.Label();
            this.BtnPokreniIgru = new System.Windows.Forms.Button();
            this.BtnIzlaz = new System.Windows.Forms.Button();
            this.PicPozadinaPocetna = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicPozadinaPocetna)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNaslovPocetna
            // 
            this.LblNaslovPocetna.AutoSize = true;
            this.LblNaslovPocetna.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNaslovPocetna.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNaslovPocetna.Location = new System.Drawing.Point(332, 51);
            this.LblNaslovPocetna.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNaslovPocetna.Name = "LblNaslovPocetna";
            this.LblNaslovPocetna.Size = new System.Drawing.Size(153, 36);
            this.LblNaslovPocetna.TabIndex = 1;
            this.LblNaslovPocetna.Text = "GEO QUIZ";
            // 
            // BtnPokreniIgru
            // 
            this.BtnPokreniIgru.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPokreniIgru.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPokreniIgru.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPokreniIgru.Location = new System.Drawing.Point(338, 255);
            this.BtnPokreniIgru.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPokreniIgru.Name = "BtnPokreniIgru";
            this.BtnPokreniIgru.Size = new System.Drawing.Size(155, 32);
            this.BtnPokreniIgru.TabIndex = 2;
            this.BtnPokreniIgru.Text = "Pokreni igru";
            this.BtnPokreniIgru.UseVisualStyleBackColor = false;
            this.BtnPokreniIgru.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnIzlaz
            // 
            this.BtnIzlaz.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnIzlaz.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIzlaz.Location = new System.Drawing.Point(596, 367);
            this.BtnIzlaz.Margin = new System.Windows.Forms.Padding(2);
            this.BtnIzlaz.Name = "BtnIzlaz";
            this.BtnIzlaz.Size = new System.Drawing.Size(155, 32);
            this.BtnIzlaz.TabIndex = 3;
            this.BtnIzlaz.Text = "Izlaz";
            this.BtnIzlaz.UseVisualStyleBackColor = false;
            this.BtnIzlaz.Click += new System.EventHandler(this.button2_Click);
            // 
            // PicPozadinaPocetna
            // 
            this.PicPozadinaPocetna.Image = global::WindowsFormsApp1.Properties.Resources._148539;
            this.PicPozadinaPocetna.Location = new System.Drawing.Point(0, -1);
            this.PicPozadinaPocetna.Margin = new System.Windows.Forms.Padding(2);
            this.PicPozadinaPocetna.Name = "PicPozadinaPocetna";
            this.PicPozadinaPocetna.Size = new System.Drawing.Size(800, 454);
            this.PicPozadinaPocetna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPozadinaPocetna.TabIndex = 0;
            this.PicPozadinaPocetna.TabStop = false;
            // 
            // FrmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnIzlaz);
            this.Controls.Add(this.BtnPokreniIgru);
            this.Controls.Add(this.LblNaslovPocetna);
            this.Controls.Add(this.PicPozadinaPocetna);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geo Quiz";
            this.Load += new System.EventHandler(this.FrmPocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicPozadinaPocetna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicPozadinaPocetna;
        private System.Windows.Forms.Label LblNaslovPocetna;
        private System.Windows.Forms.Button BtnPokreniIgru;
        private System.Windows.Forms.Button BtnIzlaz;
    }
}