namespace EDP
{
    partial class Form11
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
            this.cancel = new System.Windows.Forms.Button();
            this.upd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phonetext = new System.Windows.Forms.TextBox();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.passtext = new System.Windows.Forms.TextBox();
            this.nametext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(324, 378);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(104, 35);
            this.cancel.TabIndex = 19;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // upd
            // 
            this.upd.Location = new System.Drawing.Point(67, 378);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(104, 35);
            this.upd.TabIndex = 18;
            this.upd.Text = "Update";
            this.upd.UseVisualStyleBackColor = true;
            this.upd.Click += new System.EventHandler(this.upd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // phonetext
            // 
            this.phonetext.Location = new System.Drawing.Point(63, 223);
            this.phonetext.Multiline = true;
            this.phonetext.Name = "phonetext";
            this.phonetext.Size = new System.Drawing.Size(379, 33);
            this.phonetext.TabIndex = 13;
            this.phonetext.TextChanged += new System.EventHandler(this.phonetext_TextChanged);
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(63, 140);
            this.emailtext.Multiline = true;
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(379, 33);
            this.emailtext.TabIndex = 12;
            this.emailtext.TextChanged += new System.EventHandler(this.emailtext_TextChanged);
            // 
            // passtext
            // 
            this.passtext.Location = new System.Drawing.Point(63, 305);
            this.passtext.Multiline = true;
            this.passtext.Name = "passtext";
            this.passtext.Size = new System.Drawing.Size(379, 33);
            this.passtext.TabIndex = 11;
            this.passtext.TextChanged += new System.EventHandler(this.passtext_TextChanged);
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(63, 64);
            this.nametext.Multiline = true;
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(379, 33);
            this.nametext.TabIndex = 10;
            this.nametext.TextChanged += new System.EventHandler(this.nametext_TextChanged);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.upd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phonetext);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.nametext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form11";
            this.Text = "Form11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button upd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phonetext;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.TextBox nametext;
    }
}