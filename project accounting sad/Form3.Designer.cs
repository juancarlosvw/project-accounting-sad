namespace project_accounting_sad
{
    partial class Form3
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
            this.txtbox_plat = new System.Windows.Forms.TextBox();
            this.txtbox_jenismobil = new System.Windows.Forms.TextBox();
            this.txtbox_harga = new System.Windows.Forms.TextBox();
            this.txtbox_estimasi = new System.Windows.Forms.TextBox();
            this.cbox_jenisservice = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtbox_plat
            // 
            this.txtbox_plat.BackColor = System.Drawing.Color.DimGray;
            this.txtbox_plat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_plat.Location = new System.Drawing.Point(28, 115);
            this.txtbox_plat.Name = "txtbox_plat";
            this.txtbox_plat.Size = new System.Drawing.Size(100, 13);
            this.txtbox_plat.TabIndex = 0;
            // 
            // txtbox_jenismobil
            // 
            this.txtbox_jenismobil.BackColor = System.Drawing.Color.DimGray;
            this.txtbox_jenismobil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_jenismobil.Location = new System.Drawing.Point(143, 115);
            this.txtbox_jenismobil.Name = "txtbox_jenismobil";
            this.txtbox_jenismobil.Size = new System.Drawing.Size(100, 13);
            this.txtbox_jenismobil.TabIndex = 1;
            // 
            // txtbox_harga
            // 
            this.txtbox_harga.BackColor = System.Drawing.Color.DimGray;
            this.txtbox_harga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_harga.Location = new System.Drawing.Point(484, 115);
            this.txtbox_harga.Name = "txtbox_harga";
            this.txtbox_harga.Size = new System.Drawing.Size(100, 13);
            this.txtbox_harga.TabIndex = 2;
            // 
            // txtbox_estimasi
            // 
            this.txtbox_estimasi.BackColor = System.Drawing.Color.DimGray;
            this.txtbox_estimasi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_estimasi.Location = new System.Drawing.Point(604, 115);
            this.txtbox_estimasi.Name = "txtbox_estimasi";
            this.txtbox_estimasi.Size = new System.Drawing.Size(100, 13);
            this.txtbox_estimasi.TabIndex = 3;
            // 
            // cbox_jenisservice
            // 
            this.cbox_jenisservice.BackColor = System.Drawing.Color.DimGray;
            this.cbox_jenisservice.FormattingEnabled = true;
            this.cbox_jenisservice.Location = new System.Drawing.Point(255, 111);
            this.cbox_jenisservice.Name = "cbox_jenisservice";
            this.cbox_jenisservice.Size = new System.Drawing.Size(102, 21);
            this.cbox_jenisservice.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(373, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_accounting_sad.Properties.Resources.messageImage_1700139344321;
            this.ClientSize = new System.Drawing.Size(955, 489);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbox_jenisservice);
            this.Controls.Add(this.txtbox_estimasi);
            this.Controls.Add(this.txtbox_harga);
            this.Controls.Add(this.txtbox_jenismobil);
            this.Controls.Add(this.txtbox_plat);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_plat;
        private System.Windows.Forms.TextBox txtbox_jenismobil;
        private System.Windows.Forms.TextBox txtbox_harga;
        private System.Windows.Forms.TextBox txtbox_estimasi;
        private System.Windows.Forms.ComboBox cbox_jenisservice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}