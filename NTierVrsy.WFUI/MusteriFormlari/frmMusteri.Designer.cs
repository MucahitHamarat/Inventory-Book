namespace NTierVrsy.WFUI
{
    partial class frmMusteri
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
            this.txtMusAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMusSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMusUnvan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedBTel = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedBGSM = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedBFax = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMusGrubu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBoxMusAdres = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBoxMusAciklama = new System.Windows.Forms.RichTextBox();
            this.chBoxHesabiniAc = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gridMusteriEkle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteriEkle)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMusAd
            // 
            this.txtMusAd.Location = new System.Drawing.Point(105, 12);
            this.txtMusAd.Name = "txtMusAd";
            this.txtMusAd.Size = new System.Drawing.Size(199, 20);
            this.txtMusAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Adı:";
            // 
            // txtMusSoyad
            // 
            this.txtMusSoyad.Location = new System.Drawing.Point(105, 38);
            this.txtMusSoyad.Name = "txtMusSoyad";
            this.txtMusSoyad.Size = new System.Drawing.Size(199, 20);
            this.txtMusSoyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Soyadı:";
            // 
            // txtMusUnvan
            // 
            this.txtMusUnvan.Location = new System.Drawing.Point(105, 64);
            this.txtMusUnvan.Name = "txtMusUnvan";
            this.txtMusUnvan.Size = new System.Drawing.Size(199, 20);
            this.txtMusUnvan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Telefon:";
            // 
            // maskedBTel
            // 
            this.maskedBTel.Location = new System.Drawing.Point(105, 92);
            this.maskedBTel.Mask = "(999) 000-0000";
            this.maskedBTel.Name = "maskedBTel";
            this.maskedBTel.Size = new System.Drawing.Size(199, 20);
            this.maskedBTel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ünvanı/Lakabı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Cep:";
            // 
            // maskedBGSM
            // 
            this.maskedBGSM.Location = new System.Drawing.Point(105, 118);
            this.maskedBGSM.Mask = "(999) 000-0000";
            this.maskedBGSM.Name = "maskedBGSM";
            this.maskedBGSM.Size = new System.Drawing.Size(199, 20);
            this.maskedBGSM.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(10, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Fax:";
            // 
            // maskedBFax
            // 
            this.maskedBFax.Location = new System.Drawing.Point(105, 144);
            this.maskedBFax.Mask = "(999) 000-0000";
            this.maskedBFax.Name = "maskedBFax";
            this.maskedBFax.Size = new System.Drawing.Size(199, 20);
            this.maskedBFax.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(105, 172);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(105, 198);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(199, 20);
            this.txtTC.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(10, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(10, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "T.C. No:";
            // 
            // cmbMusGrubu
            // 
            this.cmbMusGrubu.FormattingEnabled = true;
            this.cmbMusGrubu.Items.AddRange(new object[] {
            "Bayiler",
            "Aile",
            "Arkadaş",
            "Yabancı Müşteri"});
            this.cmbMusGrubu.Location = new System.Drawing.Point(105, 224);
            this.cmbMusGrubu.Name = "cmbMusGrubu";
            this.cmbMusGrubu.Size = new System.Drawing.Size(199, 21);
            this.cmbMusGrubu.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(10, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Grubu:";
            // 
            // richTextBoxMusAdres
            // 
            this.richTextBoxMusAdres.Location = new System.Drawing.Point(403, 12);
            this.richTextBoxMusAdres.Name = "richTextBoxMusAdres";
            this.richTextBoxMusAdres.Size = new System.Drawing.Size(252, 103);
            this.richTextBoxMusAdres.TabIndex = 10;
            this.richTextBoxMusAdres.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(348, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Adres:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(330, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Açıklama:";
            // 
            // richTextBoxMusAciklama
            // 
            this.richTextBoxMusAciklama.Location = new System.Drawing.Point(403, 145);
            this.richTextBoxMusAciklama.Name = "richTextBoxMusAciklama";
            this.richTextBoxMusAciklama.Size = new System.Drawing.Size(252, 103);
            this.richTextBoxMusAciklama.TabIndex = 11;
            this.richTextBoxMusAciklama.Text = "";
            // 
            // chBoxHesabiniAc
            // 
            this.chBoxHesabiniAc.AutoSize = true;
            this.chBoxHesabiniAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chBoxHesabiniAc.Location = new System.Drawing.Point(403, 268);
            this.chBoxHesabiniAc.Name = "chBoxHesabiniAc";
            this.chBoxHesabiniAc.Size = new System.Drawing.Size(94, 17);
            this.chBoxHesabiniAc.TabIndex = 12;
            this.chBoxHesabiniAc.Text = "Hesabını Aç";
            this.chBoxHesabiniAc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(394, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(483, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gridMusteriEkle
            // 
            this.gridMusteriEkle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMusteriEkle.Location = new System.Drawing.Point(14, 334);
            this.gridMusteriEkle.Name = "gridMusteriEkle";
            this.gridMusteriEkle.Size = new System.Drawing.Size(905, 82);
            this.gridMusteriEkle.TabIndex = 38;
            this.gridMusteriEkle.Visible = false;
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(696, 332);
            this.Controls.Add(this.gridMusteriEkle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chBoxHesabiniAc);
            this.Controls.Add(this.richTextBoxMusAciklama);
            this.Controls.Add(this.richTextBoxMusAdres);
            this.Controls.Add(this.cmbMusGrubu);
            this.Controls.Add(this.maskedBFax);
            this.Controls.Add(this.maskedBGSM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedBTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMusUnvan);
            this.Controls.Add(this.txtMusSoyad);
            this.Controls.Add(this.txtMusAd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "frmMusteri";
            this.Text = "Müşteri Ekle";
            this.Load += new System.EventHandler(this.frmMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteriEkle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMusAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusUnvan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedBTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedBGSM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedBFax;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMusGrubu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBoxMusAdres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBoxMusAciklama;
        private System.Windows.Forms.CheckBox chBoxHesabiniAc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView gridMusteriEkle;
    }
}