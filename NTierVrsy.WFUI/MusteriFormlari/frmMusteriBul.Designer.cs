namespace NTierVrsy.WFUI.MusteriFormlari
{
    partial class frmMusteriBul
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtAdaGore = new System.Windows.Forms.TextBox();
            this.txtSoyadaGore = new System.Windows.Forms.TextBox();
            this.txtUnvanaGore = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gridMusBul = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMusSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusBul)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdaGore
            // 
            this.txtAdaGore.Location = new System.Drawing.Point(12, 42);
            this.txtAdaGore.Multiline = true;
            this.txtAdaGore.Name = "txtAdaGore";
            this.txtAdaGore.Size = new System.Drawing.Size(151, 23);
            this.txtAdaGore.TabIndex = 1;
            this.txtAdaGore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSoyadaGore
            // 
            this.txtSoyadaGore.Location = new System.Drawing.Point(169, 42);
            this.txtSoyadaGore.Multiline = true;
            this.txtSoyadaGore.Name = "txtSoyadaGore";
            this.txtSoyadaGore.Size = new System.Drawing.Size(240, 23);
            this.txtSoyadaGore.TabIndex = 2;
            this.txtSoyadaGore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUnvanaGore
            // 
            this.txtUnvanaGore.Location = new System.Drawing.Point(415, 42);
            this.txtUnvanaGore.Multiline = true;
            this.txtUnvanaGore.Name = "txtUnvanaGore";
            this.txtUnvanaGore.Size = new System.Drawing.Size(196, 23);
            this.txtUnvanaGore.TabIndex = 3;
            this.txtUnvanaGore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(629, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridMusBul
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridMusBul.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridMusBul.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridMusBul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMusBul.Location = new System.Drawing.Point(12, 82);
            this.gridMusBul.Name = "gridMusBul";
            this.gridMusBul.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMusBul.Size = new System.Drawing.Size(541, 337);
            this.gridMusBul.TabIndex = 2;
            this.gridMusBul.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridMusBul_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ADINA GÖRE ARA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(242, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SOYADINA GÖRE ARA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(467, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "UNVAN/LAKABINA GÖRE ARA";
            // 
            // btnMusSil
            // 
            this.btnMusSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusSil.Location = new System.Drawing.Point(629, 100);
            this.btnMusSil.Name = "btnMusSil";
            this.btnMusSil.Size = new System.Drawing.Size(75, 23);
            this.btnMusSil.TabIndex = 5;
            this.btnMusSil.Text = "Sil";
            this.btnMusSil.UseVisualStyleBackColor = true;
            this.btnMusSil.Click += new System.EventHandler(this.btnMusSil_Click);
            // 
            // frmMusteriBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.btnMusSil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridMusBul);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUnvanaGore);
            this.Controls.Add(this.txtSoyadaGore);
            this.Controls.Add(this.txtAdaGore);
            this.Name = "frmMusteriBul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Bul";
            this.Load += new System.EventHandler(this.frmMusteriBul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMusBul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdaGore;
        private System.Windows.Forms.TextBox txtSoyadaGore;
        private System.Windows.Forms.TextBox txtUnvanaGore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView gridMusBul;
        private System.Windows.Forms.Button btnMusSil;
    }
}