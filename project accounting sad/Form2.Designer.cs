namespace project_accounting_sad
{
    partial class Form2
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
            this.button_backmainmenu = new System.Windows.Forms.Button();
            this.button_inputorder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_backmainmenu
            // 
            this.button_backmainmenu.BackColor = System.Drawing.Color.Transparent;
            this.button_backmainmenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_backmainmenu.Location = new System.Drawing.Point(13, 15);
            this.button_backmainmenu.Name = "button_backmainmenu";
            this.button_backmainmenu.Size = new System.Drawing.Size(139, 74);
            this.button_backmainmenu.TabIndex = 0;
            this.button_backmainmenu.UseVisualStyleBackColor = false;
            // 
            // button_inputorder
            // 
            this.button_inputorder.BackColor = System.Drawing.Color.Transparent;
            this.button_inputorder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_inputorder.Location = new System.Drawing.Point(174, 134);
            this.button_inputorder.Name = "button_inputorder";
            this.button_inputorder.Size = new System.Drawing.Size(171, 112);
            this.button_inputorder.TabIndex = 1;
            this.button_inputorder.UseVisualStyleBackColor = false;
            this.button_inputorder.Click += new System.EventHandler(this.button_inputorder_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_accounting_sad.Properties.Resources.messageImage_1700139286218;
            this.ClientSize = new System.Drawing.Size(1051, 575);
            this.Controls.Add(this.button_inputorder);
            this.Controls.Add(this.button_backmainmenu);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_backmainmenu;
        private System.Windows.Forms.Button button_inputorder;
    }
}