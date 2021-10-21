
namespace WindowsFormsApp1
{
    partial class FrmDrzave
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
            this.BtnDrzaveCetvrti = new System.Windows.Forms.Button();
            this.BtnDrzaveTreci = new System.Windows.Forms.Button();
            this.BtnDrzaveDrugi = new System.Windows.Forms.Button();
            this.BtnDrzavePrvi = new System.Windows.Forms.Button();
            this.LblPitanjeDrzave = new System.Windows.Forms.Label();
            this.BtnNazadDrzave = new System.Windows.Forms.Button();
            this.PbxDrzave = new System.Windows.Forms.PictureBox();
            this.PicPozadinaDrzave = new System.Windows.Forms.PictureBox();
            this.PbrDrzave = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LblProgressDrzave = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbxDrzave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPozadinaDrzave)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDrzaveCetvrti
            // 
            this.BtnDrzaveCetvrti.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDrzaveCetvrti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDrzaveCetvrti.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDrzaveCetvrti.Location = new System.Drawing.Point(432, 362);
            this.BtnDrzaveCetvrti.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDrzaveCetvrti.Name = "BtnDrzaveCetvrti";
            this.BtnDrzaveCetvrti.Size = new System.Drawing.Size(179, 33);
            this.BtnDrzaveCetvrti.TabIndex = 11;
            this.BtnDrzaveCetvrti.Tag = "0";
            this.BtnDrzaveCetvrti.Text = "button4";
            this.BtnDrzaveCetvrti.UseVisualStyleBackColor = false;
            this.BtnDrzaveCetvrti.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // BtnDrzaveTreci
            // 
            this.BtnDrzaveTreci.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDrzaveTreci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDrzaveTreci.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDrzaveTreci.Location = new System.Drawing.Point(211, 362);
            this.BtnDrzaveTreci.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDrzaveTreci.Name = "BtnDrzaveTreci";
            this.BtnDrzaveTreci.Size = new System.Drawing.Size(179, 33);
            this.BtnDrzaveTreci.TabIndex = 10;
            this.BtnDrzaveTreci.Tag = "0";
            this.BtnDrzaveTreci.Text = "button3";
            this.BtnDrzaveTreci.UseVisualStyleBackColor = false;
            this.BtnDrzaveTreci.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // BtnDrzaveDrugi
            // 
            this.BtnDrzaveDrugi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDrzaveDrugi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDrzaveDrugi.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDrzaveDrugi.Location = new System.Drawing.Point(432, 321);
            this.BtnDrzaveDrugi.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDrzaveDrugi.Name = "BtnDrzaveDrugi";
            this.BtnDrzaveDrugi.Size = new System.Drawing.Size(179, 33);
            this.BtnDrzaveDrugi.TabIndex = 9;
            this.BtnDrzaveDrugi.Tag = "0";
            this.BtnDrzaveDrugi.Text = "button2";
            this.BtnDrzaveDrugi.UseVisualStyleBackColor = false;
            this.BtnDrzaveDrugi.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // BtnDrzavePrvi
            // 
            this.BtnDrzavePrvi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDrzavePrvi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDrzavePrvi.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDrzavePrvi.Location = new System.Drawing.Point(211, 321);
            this.BtnDrzavePrvi.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDrzavePrvi.Name = "BtnDrzavePrvi";
            this.BtnDrzavePrvi.Size = new System.Drawing.Size(179, 33);
            this.BtnDrzavePrvi.TabIndex = 8;
            this.BtnDrzavePrvi.Tag = "0";
            this.BtnDrzavePrvi.Text = "button1";
            this.BtnDrzavePrvi.UseVisualStyleBackColor = false;
            this.BtnDrzavePrvi.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // LblPitanjeDrzave
            // 
            this.LblPitanjeDrzave.AutoSize = true;
            this.LblPitanjeDrzave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblPitanjeDrzave.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPitanjeDrzave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPitanjeDrzave.Location = new System.Drawing.Point(228, 35);
            this.LblPitanjeDrzave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPitanjeDrzave.Name = "LblPitanjeDrzave";
            this.LblPitanjeDrzave.Size = new System.Drawing.Size(280, 19);
            this.LblPitanjeDrzave.TabIndex = 7;
            this.LblPitanjeDrzave.Text = "Koja država je prikazana na slici?";
            // 
            // BtnNazadDrzave
            // 
            this.BtnNazadDrzave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNazadDrzave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNazadDrzave.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNazadDrzave.Location = new System.Drawing.Point(682, 393);
            this.BtnNazadDrzave.Name = "BtnNazadDrzave";
            this.BtnNazadDrzave.Size = new System.Drawing.Size(89, 30);
            this.BtnNazadDrzave.TabIndex = 13;
            this.BtnNazadDrzave.Text = "Nazad";
            this.BtnNazadDrzave.UseVisualStyleBackColor = false;
            this.BtnNazadDrzave.Click += new System.EventHandler(this.BtnNazadDrzave_Click);
            // 
            // PbxDrzave
            // 
            this.PbxDrzave.Image = global::WindowsFormsApp1.Properties.Resources.mne;
            this.PbxDrzave.Location = new System.Drawing.Point(211, 69);
            this.PbxDrzave.Margin = new System.Windows.Forms.Padding(2);
            this.PbxDrzave.Name = "PbxDrzave";
            this.PbxDrzave.Size = new System.Drawing.Size(400, 236);
            this.PbxDrzave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxDrzave.TabIndex = 12;
            this.PbxDrzave.TabStop = false;
            // 
            // PicPozadinaDrzave
            // 
            this.PicPozadinaDrzave.Image = global::WindowsFormsApp1.Properties.Resources._148539;
            this.PicPozadinaDrzave.Location = new System.Drawing.Point(-1, -1);
            this.PicPozadinaDrzave.Margin = new System.Windows.Forms.Padding(2);
            this.PicPozadinaDrzave.Name = "PicPozadinaDrzave";
            this.PicPozadinaDrzave.Size = new System.Drawing.Size(804, 454);
            this.PicPozadinaDrzave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPozadinaDrzave.TabIndex = 0;
            this.PicPozadinaDrzave.TabStop = false;
            // 
            // PbrDrzave
            // 
            this.PbrDrzave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PbrDrzave.Location = new System.Drawing.Point(688, 35);
            this.PbrDrzave.MarqueeAnimationSpeed = 0;
            this.PbrDrzave.Maximum = 10;
            this.PbrDrzave.Name = "PbrDrzave";
            this.PbrDrzave.Size = new System.Drawing.Size(100, 23);
            this.PbrDrzave.Step = 1;
            this.PbrDrzave.TabIndex = 14;
            this.toolTip1.SetToolTip(this.PbrDrzave, "Progres");
            this.PbrDrzave.Value = 1;
            // 
            // LblProgressDrzave
            // 
            this.LblProgressDrzave.AutoSize = true;
            this.LblProgressDrzave.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProgressDrzave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblProgressDrzave.Location = new System.Drawing.Point(724, 13);
            this.LblProgressDrzave.Name = "LblProgressDrzave";
            this.LblProgressDrzave.Size = new System.Drawing.Size(47, 19);
            this.LblProgressDrzave.TabIndex = 15;
            this.LblProgressDrzave.Text = "0/10";
            this.LblProgressDrzave.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.LblProgressDrzave, "Rezultat");
            // 
            // FrmDrzave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblProgressDrzave);
            this.Controls.Add(this.PbrDrzave);
            this.Controls.Add(this.BtnNazadDrzave);
            this.Controls.Add(this.PbxDrzave);
            this.Controls.Add(this.BtnDrzaveCetvrti);
            this.Controls.Add(this.BtnDrzaveTreci);
            this.Controls.Add(this.BtnDrzaveDrugi);
            this.Controls.Add(this.BtnDrzavePrvi);
            this.Controls.Add(this.LblPitanjeDrzave);
            this.Controls.Add(this.PicPozadinaDrzave);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDrzave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Države";
            this.Load += new System.EventHandler(this.FrmDrzave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxDrzave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPozadinaDrzave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicPozadinaDrzave;
        private System.Windows.Forms.Button BtnDrzaveCetvrti;
        private System.Windows.Forms.Button BtnDrzaveTreci;
        private System.Windows.Forms.Button BtnDrzaveDrugi;
        private System.Windows.Forms.Button BtnDrzavePrvi;
        private System.Windows.Forms.Label LblPitanjeDrzave;
        private System.Windows.Forms.PictureBox PbxDrzave;
        private System.Windows.Forms.Button BtnNazadDrzave;
        private System.Windows.Forms.ProgressBar PbrDrzave;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label LblProgressDrzave;
    }
}