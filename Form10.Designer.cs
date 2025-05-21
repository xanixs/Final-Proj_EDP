namespace EDP
{
    partial class Insert
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
            this.nametext = new System.Windows.Forms.TextBox();
            this.passtext = new System.Windows.Forms.TextBox();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.phonetext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(79, 50);
            this.nametext.Multiline = true;
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(379, 33);
            this.nametext.TabIndex = 0;
            this.nametext.TextChanged += new System.EventHandler(this.nametext_TextChanged);
            // 
            // passtext
            // 
            this.passtext.Location = new System.Drawing.Point(79, 291);
            this.passtext.Multiline = true;
            this.passtext.Name = "passtext";
            this.passtext.Size = new System.Drawing.Size(379, 33);
            this.passtext.TabIndex = 1;
            this.passtext.TextChanged += new System.EventHandler(this.passtext_TextChanged);
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(79, 126);
            this.emailtext.Multiline = true;
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(379, 33);
            this.emailtext.TabIndex = 2;
            this.emailtext.TextChanged += new System.EventHandler(this.emailtext_TextChanged);
            // 
            // phonetext
            // 
            this.phonetext.Location = new System.Drawing.Point(79, 209);
            this.phonetext.Multiline = true;
            this.phonetext.Name = "phonetext";
            this.phonetext.Size = new System.Drawing.Size(379, 33);
            this.phonetext.TabIndex = 3;
            this.phonetext.TextChanged += new System.EventHandler(this.phonetext_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(83, 364);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(104, 35);
            this.add.TabIndex = 8;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(340, 364);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(104, 35);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(542, 442);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phonetext);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.nametext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Insert";
            this.Text = "Insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.TextBox phonetext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button cancel;
    }
}