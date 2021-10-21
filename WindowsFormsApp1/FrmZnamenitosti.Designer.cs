
namespace WindowsFormsApp1
{
    partial class FrmZnamenitosti
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
            this.LblPitanjeZnamenitosti = new System.Windows.Forms.Label();
            this.BtnZnamenitostiPrvi = new System.Windows.Forms.Button();
            this.BtnZnamenitostiDrugi = new System.Windows.Forms.Button();
            this.BtnZnamenitostiTreci = new System.Windows.Forms.Button();
            this.BtnZnamenitostiCetvrti = new System.Windows.Forms.Button();
            this.BtnNazadZnamenitosti = new System.Windows.Forms.Button();
            this.PicZnamenitosti = new System.Windows.Forms.PictureBox();
            this.PicPozadinaZnamenitosti = new System.Windows.Forms.PictureBox();
            this.PbrZnamenitosti = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LblProgressZnamenitosti = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicZnamenitosti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPozadinaZnamenitosti)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPitanjeZnamenitosti
            // 
            this.LblPitanjeZnamenitosti.AutoSize = true;
            this.LblPitanjeZnamenitosti.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblPitanjeZnamenitosti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblPitanjeZnamenitosti.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPitanjeZnamenitosti.ForeColor = System.Drawing.SystemColors.Control;
            this.LblPitanjeZnamenitosti.Location = new System.Drawing.Point(172, 34);
            this.LblPitanjeZnamenitosti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPitanjeZnamenitosti.Name = "LblPitanjeZnamenitosti";
            this.LblPitanjeZnamenitosti.Size = new System.Drawing.Size(372, 19);
            this.LblPitanjeZnamenitosti.TabIndex = 1;
            this.LblPitanjeZnamenitosti.Text = "Koji je naziv kulturne znamenitosti sa slike?";
            // 
            // BtnZnamenitostiPrvi
            // 
            this.BtnZnamenitostiPrvi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnZnamenitostiPrvi.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZnamenitostiPrvi.Location = new System.Drawing.Point(192, 329);
            this.BtnZnamenitostiPrvi.Margin = new System.Windows.Forms.Padding(2);
            this.BtnZnamenitostiPrvi.Name = "BtnZnamenitostiPrvi";
            this.BtnZnamenitostiPrvi.Size = new System.Drawing.Size(194, 25);
            this.BtnZnamenitostiPrvi.TabIndex = 2;
            this.BtnZnamenitostiPrvi.Tag = "0";
            this.BtnZnamenitostiPrvi.Text = "button1";
            this.BtnZnamenitostiPrvi.UseVisualStyleBackColor = true;
            this.BtnZnamenitostiPrvi.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // BtnZnamenitostiDrugi
            // 
            this.BtnZnamenitostiDrugi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnZnamenitostiDrugi.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZnamenitostiDrugi.Location = new System.Drawing.Point(410, 329);
            this.BtnZnamenitostiDrugi.Margin = new System.Windows.Forms.Padding(2);
            this.BtnZnamenitostiDrugi.Name = "BtnZnamenitostiDrugi";
            this.BtnZnamenitostiDrugi.Size = new System.Drawing.Size(194, 25);
            this.BtnZnamenitostiDrugi.TabIndex = 3;
            this.BtnZnamenitostiDrugi.Tag = "0";
            this.BtnZnamenitostiDrugi.Text = "button2";
            this.BtnZnamenitostiDrugi.UseVisualStyleBackColor = true;
            this.BtnZnamenitostiDrugi.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // BtnZnamenitostiTreci
            // 
            this.BtnZnamenitostiTreci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnZnamenitostiTreci.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZnamenitostiTreci.Location = new System.Drawing.Point(192, 386);
            this.BtnZnamenitostiTreci.Margin = new System.Windows.Forms.Padding(2);
            this.BtnZnamenitostiTreci.Name = "BtnZnamenitostiTreci";
            this.BtnZnamenitostiTreci.Size = new System.Drawing.Size(194, 25);
            this.BtnZnamenitostiTreci.TabIndex = 4;
            this.BtnZnamenitostiTreci.Tag = "0";
            this.BtnZnamenitostiTreci.Text = "button3";
            this.BtnZnamenitostiTreci.UseVisualStyleBackColor = true;
            this.BtnZnamenitostiTreci.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // BtnZnamenitostiCetvrti
            // 
            this.BtnZnamenitostiCetvrti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnZnamenitostiCetvrti.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZnamenitostiCetvrti.Location = new System.Drawing.Point(410, 386);
            this.BtnZnamenitostiCetvrti.Margin = new System.Windows.Forms.Padding(2);
            this.BtnZnamenitostiCetvrti.Name = "BtnZnamenitostiCetvrti";
            this.BtnZnamenitostiCetvrti.Size = new System.Drawing.Size(194, 25);
            this.BtnZnamenitostiCetvrti.TabIndex = 5;
            this.BtnZnamenitostiCetvrti.Tag = "0";
            this.BtnZnamenitostiCetvrti.Text = "button4";
            this.BtnZnamenitostiCetvrti.UseVisualStyleBackColor = true;
            this.BtnZnamenitostiCetvrti.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // BtnNazadZnamenitosti
            // 
            this.BtnNazadZnamenitosti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNazadZnamenitosti.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNazadZnamenitosti.Location = new System.Drawing.Point(667, 386);
            this.BtnNazadZnamenitosti.Name = "BtnNazadZnamenitosti";
            this.BtnNazadZnamenitosti.Size = new System.Drawing.Size(91, 29);
            this.BtnNazadZnamenitosti.TabIndex = 7;
            this.BtnNazadZnamenitosti.Text = "Nazad";
            this.BtnNazadZnamenitosti.UseVisualStyleBackColor = true;
            this.BtnNazadZnamenitosti.Click += new System.EventHandler(this.BtnNazadZnamenitosti_Click);
            // 
            // PicZnamenitosti
            // 
            this.PicZnamenitosti.Image = global::WindowsFormsApp1.Properties.Resources.Taj_Mahal;
            this.PicZnamenitosti.Location = new System.Drawing.Point(176, 66);
            this.PicZnamenitosti.Margin = new System.Windows.Forms.Padding(2);
            this.PicZnamenitosti.Name = "PicZnamenitosti";
            this.PicZnamenitosti.Size = new System.Drawing.Size(438, 239);
            this.PicZnamenitosti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicZnamenitosti.TabIndex = 6;
            this.PicZnamenitosti.TabStop = false;
            // 
            // PicPozadinaZnamenitosti
            // 
            this.PicPozadinaZnamenitosti.Image = global::WindowsFormsApp1.Properties.Resources._148539;
            this.PicPozadinaZnamenitosti.Location = new System.Drawing.Point(-1, 0);
            this.PicPozadinaZnamenitosti.Margin = new System.Windows.Forms.Padding(2);
            this.PicPozadinaZnamenitosti.Name = "PicPozadinaZnamenitosti";
            this.PicPozadinaZnamenitosti.Size = new System.Drawing.Size(802, 450);
            this.PicPozadinaZnamenitosti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPozadinaZnamenitosti.TabIndex = 0;
            this.PicPozadinaZnamenitosti.TabStop = false;
            // 
            // PbrZnamenitosti
            // 
            this.PbrZnamenitosti.Location = new System.Drawing.Point(688, 34);
            this.PbrZnamenitosti.Maximum = 10;
            this.PbrZnamenitosti.Name = "PbrZnamenitosti";
            this.PbrZnamenitosti.Size = new System.Drawing.Size(100, 23);
            this.PbrZnamenitosti.TabIndex = 8;
            this.toolTip1.SetToolTip(this.PbrZnamenitosti, "Progres");
            this.PbrZnamenitosti.Value = 1;
            // 
            // LblProgressZnamenitosti
            // 
            this.LblProgressZnamenitosti.AutoSize = true;
            this.LblProgressZnamenitosti.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProgressZnamenitosti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblProgressZnamenitosti.Location = new System.Drawing.Point(663, 12);
            this.LblProgressZnamenitosti.Name = "LblProgressZnamenitosti";
            this.LblProgressZnamenitosti.Size = new System.Drawing.Size(47, 19);
            this.LblProgressZnamenitosti.TabIndex = 9;
            this.LblProgressZnamenitosti.Text = "0/10";
            this.LblProgressZnamenitosti.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.LblProgressZnamenitosti, "Rezultat");
            // 
            // FrmZnamenitosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblProgressZnamenitosti);
            this.Controls.Add(this.PbrZnamenitosti);
            this.Controls.Add(this.BtnNazadZnamenitosti);
            this.Controls.Add(this.PicZnamenitosti);
            this.Controls.Add(this.BtnZnamenitostiCetvrti);
            this.Controls.Add(this.BtnZnamenitostiTreci);
            this.Controls.Add(this.BtnZnamenitostiDrugi);
            this.Controls.Add(this.BtnZnamenitostiPrvi);
            this.Controls.Add(this.LblPitanjeZnamenitosti);
            this.Controls.Add(this.PicPozadinaZnamenitosti);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmZnamenitosti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FrmZnamenitosti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicZnamenitosti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPozadinaZnamenitosti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicPozadinaZnamenitosti;
        private System.Windows.Forms.Label LblPitanjeZnamenitosti;
        private System.Windows.Forms.Button BtnZnamenitostiPrvi;
        private System.Windows.Forms.Button BtnZnamenitostiDrugi;
        private System.Windows.Forms.Button BtnZnamenitostiTreci;
        private System.Windows.Forms.Button BtnZnamenitostiCetvrti;
        private System.Windows.Forms.PictureBox PicZnamenitosti;
        private System.Windows.Forms.Button BtnNazadZnamenitosti;
        private System.Windows.Forms.ProgressBar PbrZnamenitosti;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label LblProgressZnamenitosti;
    }
}