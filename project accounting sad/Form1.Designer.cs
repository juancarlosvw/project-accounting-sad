namespace project_accounting_sad
{
    partial class Form1
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
            this.txtbox_inputusername = new System.Windows.Forms.TextBox();
            this.txtbox_inputpassword = new System.Windows.Forms.MaskedTextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_inputusername
            // 
            this.txtbox_inputusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_inputusername.Location = new System.Drawing.Point(59, 313);
            this.txtbox_inputusername.Name = "txtbox_inputusername";
            this.txtbox_inputusername.Size = new System.Drawing.Size(164, 13);
            this.txtbox_inputusername.TabIndex = 0;
            // 
            // txtbox_inputpassword
            // 
            this.txtbox_inputpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_inputpassword.Location = new System.Drawing.Point(59, 384);
            this.txtbox_inputpassword.Name = "txtbox_inputpassword";
            this.txtbox_inputpassword.PasswordChar = '*';
            this.txtbox_inputpassword.Size = new System.Drawing.Size(164, 13);
            this.txtbox_inputpassword.TabIndex = 1;
            this.txtbox_inputpassword.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtbox_inputpassword_MaskInputRejected);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.Transparent;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_login.Location = new System.Drawing.Point(254, 420);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 31);
            this.button_login.TabIndex = 2;
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_accounting_sad.Properties.Resources.messageImage_1700139200807;
            this.ClientSize = new System.Drawing.Size(337, 457);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.txtbox_inputpassword);
            this.Controls.Add(this.txtbox_inputusername);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_inputusername;
        private System.Windows.Forms.MaskedTextBox txtbox_inputpassword;
        private System.Windows.Forms.Button button_login;
    }
}

