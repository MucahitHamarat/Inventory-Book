namespace NTierVrsy.WFUI.MusteriFormlari
{
    partial class frmMusteriDuzeltSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriDuzeltSil));
            this.button2 = new System.Windows.Forms.Button();
            this.btnMusGuncelle = new System.Windows.Forms.Button();
            this.chBoxHesabiniAc = new System.Windows.Forms.CheckBox();
            this.richTextBoxMusAciklama = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMusAdres = new System.Windows.Forms.RichTextBox();
            this.cmbMusGrubu = new System.Windows.Forms.ComboBox();
            this.maskedBFax = new System.Windows.Forms.MaskedTextBox();
            this.maskedBGSM = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedBTel = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMusUnvan = new System.Windows.Forms.TextBox();
            this.txtMusSoyad = new System.Windows.Forms.TextBox();
            this.txtMusAd = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(503, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnMusGuncelle
            // 
            this.btnMusGuncelle.Location = new System.Drawing.Point(408, 372);
            this.btnMusGuncelle.Name = "btnMusGuncelle";
            this.btnMusGuncelle.Size = new System.Drawing.Size(87, 23);
            this.btnMusGuncelle.TabIndex = 13;
            this.btnMusGuncelle.Text = "Güncelle";
            this.btnMusGuncelle.UseVisualStyleBackColor = true;
            this.btnMusGuncelle.Click += new System.EventHandler(this.btnMusGuncelle_Click);
            // 
            // chBoxHesabiniAc
            // 
            this.chBoxHesabiniAc.AutoSize = true;
            this.chBoxHesabiniAc.Location = new System.Drawing.Point(408, 337);
            this.chBoxHesabiniAc.Name = "chBoxHesabiniAc";
            this.chBoxHesabiniAc.Size = new System.Drawing.Size(94, 17);
            this.chBoxHesabiniAc.TabIndex = 12;
            this.chBoxHesabiniAc.Text = "Hesabını Aç";
            this.chBoxHesabiniAc.UseVisualStyleBackColor = true;
            // 
            // richTextBoxMusAciklama
            // 
            this.richTextBoxMusAciklama.Location = new System.Drawing.Point(408, 214);
            this.richTextBoxMusAciklama.Name = "richTextBoxMusAciklama";
            this.richTextBoxMusAciklama.Size = new System.Drawing.Size(252, 103);
            this.richTextBoxMusAciklama.TabIndex = 11;
            this.richTextBoxMusAciklama.Text = "";
            // 
            // richTextBoxMusAdres
            // 
            this.richTextBoxMusAdres.Location = new System.Drawing.Point(408, 81);
            this.richTextBoxMusAdres.Name = "richTextBoxMusAdres";
            this.richTextBoxMusAdres.Size = new System.Drawing.Size(252, 103);
            this.richTextBoxMusAdres.TabIndex = 10;
            this.richTextBoxMusAdres.Text = "";
            // 
            // cmbMusGrubu
            // 
            this.cmbMusGrubu.DisplayMember = "Ad";
            this.cmbMusGrubu.FormattingEnabled = true;
            this.cmbMusGrubu.Items.AddRange(new object[] {
            "Bayiler",
            "Aile",
            "Arkadaş",
            "Yabancı Müşteri"});
            this.cmbMusGrubu.Location = new System.Drawing.Point(117, 290);
            this.cmbMusGrubu.Name = "cmbMusGrubu";
            this.cmbMusGrubu.Size = new System.Drawing.Size(199, 21);
            this.cmbMusGrubu.TabIndex = 9;
            this.cmbMusGrubu.ValueMember = "ID";
            // 
            // maskedBFax
            // 
            this.maskedBFax.Location = new System.Drawing.Point(117, 210);
            this.maskedBFax.Mask = "(999) 000-0000";
            this.maskedBFax.Name = "maskedBFax";
            this.maskedBFax.Size = new System.Drawing.Size(199, 20);
            this.maskedBFax.TabIndex = 6;
            // 
            // maskedBGSM
            // 
            this.maskedBGSM.Location = new System.Drawing.Point(117, 184);
            this.maskedBGSM.Mask = "(999) 000-0000";
            this.maskedBGSM.Name = "maskedBGSM";
            this.maskedBGSM.Size = new System.Drawing.Size(199, 20);
            this.maskedBGSM.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(22, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Fax:";
            // 
            // maskedBTel
            // 
            this.maskedBTel.Location = new System.Drawing.Point(117, 158);
            this.maskedBTel.Mask = "(999) 000-0000";
            this.maskedBTel.Name = "maskedBTel";
            this.maskedBTel.Size = new System.Drawing.Size(199, 20);
            this.maskedBTel.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(22, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Cep:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(22, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "Grubu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(22, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "T.C. No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Ünvanı/Lakabı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Telefon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(22, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(335, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "Açıklama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Soyadı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(353, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "Adres:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Adı:";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(117, 264);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(199, 20);
            this.txtTC.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(117, 238);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtMusUnvan
            // 
            this.txtMusUnvan.Location = new System.Drawing.Point(117, 130);
            this.txtMusUnvan.Name = "txtMusUnvan";
            this.txtMusUnvan.Size = new System.Drawing.Size(199, 20);
            this.txtMusUnvan.TabIndex = 3;
            // 
            // txtMusSoyad
            // 
            this.txtMusSoyad.Location = new System.Drawing.Point(117, 104);
            this.txtMusSoyad.Name = "txtMusSoyad";
            this.txtMusSoyad.Size = new System.Drawing.Size(199, 20);
            this.txtMusSoyad.TabIndex = 2;
            // 
            // txtMusAd
            // 
            this.txtMusAd.Location = new System.Drawing.Point(117, 78);
            this.txtMusAd.Name = "txtMusAd";
            this.txtMusAd.Size = new System.Drawing.Size(199, 20);
            this.txtMusAd.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(13, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 68);
            this.button3.TabIndex = 65;
            this.button3.Text = "Müşteri Bul";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(552, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 66;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // frmMusteriDuzeltSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 436);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtMusSoyad);
            this.Controls.Add(this.txtMusAd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMusGuncelle);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "frmMusteriDuzeltSil";
            this.Text = "Düzelt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMusGuncelle;
        private System.Windows.Forms.CheckBox chBoxHesabiniAc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.RichTextBox richTextBoxMusAciklama;
        public System.Windows.Forms.RichTextBox richTextBoxMusAdres;
        public System.Windows.Forms.ComboBox cmbMusGrubu;
        public System.Windows.Forms.MaskedTextBox maskedBFax;
        public System.Windows.Forms.MaskedTextBox maskedBGSM;
        public System.Windows.Forms.MaskedTextBox maskedBTel;
        public System.Windows.Forms.TextBox txtTC;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtMusUnvan;
        public System.Windows.Forms.TextBox txtMusSoyad;
        public System.Windows.Forms.TextBox txtMusAd;
    }
}