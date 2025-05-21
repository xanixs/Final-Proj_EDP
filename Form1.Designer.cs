namespace EDP
{
    partial class LOGINPAGE
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
            this.username = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.fpass = new System.Windows.Forms.LinkLabel();
            this.login = new System.Windows.Forms.Button();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(23, 54);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(65, 25);
            this.username.TabIndex = 1;
            this.username.Text = "Email";
            this.username.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(28, 136);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(106, 25);
            this.pass.TabIndex = 2;
            this.pass.Text = "Password";
            this.pass.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // fpass
            // 
            this.fpass.AutoSize = true;
            this.fpass.Location = new System.Drawing.Point(218, 253);
            this.fpass.Name = "fpass";
            this.fpass.Size = new System.Drawing.Size(129, 20);
            this.fpass.TabIndex = 3;
            this.fpass.TabStop = true;
            this.fpass.Text = "Forget Password";
            this.fpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fpass_LinkClicked);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(222, 198);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(121, 38);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(155, 47);
            this.email_textbox.Multiline = true;
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(334, 32);
            this.email_textbox.TabIndex = 5;
            this.email_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(155, 129);
            this.password_textbox.Multiline = true;
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(334, 32);
            this.password_textbox.TabIndex = 6;
            this.password_textbox.UseSystemPasswordChar = true;
            this.password_textbox.TextChanged += new System.EventHandler(this.password_textbox_TextChanged);
            // 
            // LOGINPAGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(524, 332);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.login);
            this.Controls.Add(this.fpass);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGINPAGE";
            this.Text = "Login page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.LinkLabel fpass;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox password_textbox;
    }
}

