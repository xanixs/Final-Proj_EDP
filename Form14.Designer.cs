namespace EDP
{
    partial class Form14
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Newpass = new System.Windows.Forms.Label();
            this.old = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 210);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 31);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 119);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 31);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(201, 261);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(88, 32);
            this.enter.TabIndex = 14;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.Change_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(57, 261);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(87, 32);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Newpass
            // 
            this.Newpass.AutoSize = true;
            this.Newpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Newpass.Location = new System.Drawing.Point(26, 247);
            this.Newpass.Name = "Newpass";
            this.Newpass.Size = new System.Drawing.Size(0, 22);
            this.Newpass.TabIndex = 12;
            // 
            // old
            // 
            this.old.AutoSize = true;
            this.old.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.old.Location = new System.Drawing.Point(53, 172);
            this.old.Name = "old";
            this.old.Size = new System.Drawing.Size(226, 22);
            this.old.TabIndex = 11;
            this.old.Text = "What is your Managers ID?";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(57, 87);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(54, 22);
            this.user.TabIndex = 10;
            this.user.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Recovery Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 326);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Newpass);
            this.Controls.Add(this.old);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label1);
            this.Name = "Form14";
            this.Text = "Form14";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label Newpass;
        private System.Windows.Forms.Label old;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label1;
    }
}