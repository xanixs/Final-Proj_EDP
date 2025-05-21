namespace EDP
{
    partial class Provider
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
            this.providergrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.providergrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // providergrid
            // 
            this.providergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.providergrid.Location = new System.Drawing.Point(377, 99);
            this.providergrid.Name = "providergrid";
            this.providergrid.RowHeadersWidth = 62;
            this.providergrid.RowTemplate.Height = 28;
            this.providergrid.Size = new System.Drawing.Size(973, 573);
            this.providergrid.TabIndex = 15;
            this.providergrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.leasegrid_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 793);
            this.panel1.TabIndex = 16;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(64, 638);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(204, 54);
            this.button7.TabIndex = 6;
            this.button7.Text = "Provider";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(64, 548);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(204, 54);
            this.button6.TabIndex = 5;
            this.button6.Text = "Tenant";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(64, 459);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(204, 54);
            this.button5.TabIndex = 4;
            this.button5.Text = "Payment";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(64, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 54);
            this.button4.TabIndex = 3;
            this.button4.Text = "Manager";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(64, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "Request";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lease";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Apartment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 59);
            this.label1.TabIndex = 17;
            this.label1.Text = "Provider";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Provider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 788);
            this.Controls.Add(this.providergrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Provider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provider";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Provider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.providergrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView providergrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}