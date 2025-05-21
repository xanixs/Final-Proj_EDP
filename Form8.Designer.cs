namespace EDP
{
    partial class tenant
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.provbutton = new System.Windows.Forms.Button();
            this.tenbutton = new System.Windows.Forms.Button();
            this.paybutton = new System.Windows.Forms.Button();
            this.manbutton = new System.Windows.Forms.Button();
            this.reqbutton = new System.Windows.Forms.Button();
            this.leasebutton = new System.Windows.Forms.Button();
            this.apabutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tenantgrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tenantgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.provbutton);
            this.panel1.Controls.Add(this.tenbutton);
            this.panel1.Controls.Add(this.paybutton);
            this.panel1.Controls.Add(this.manbutton);
            this.panel1.Controls.Add(this.reqbutton);
            this.panel1.Controls.Add(this.leasebutton);
            this.panel1.Controls.Add(this.apabutton);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 793);
            this.panel1.TabIndex = 16;
            // 
            // provbutton
            // 
            this.provbutton.Location = new System.Drawing.Point(64, 638);
            this.provbutton.Name = "provbutton";
            this.provbutton.Size = new System.Drawing.Size(204, 54);
            this.provbutton.TabIndex = 6;
            this.provbutton.Text = "Provider";
            this.provbutton.UseVisualStyleBackColor = true;
            this.provbutton.Click += new System.EventHandler(this.provbutton_Click);
            // 
            // tenbutton
            // 
            this.tenbutton.Location = new System.Drawing.Point(64, 548);
            this.tenbutton.Name = "tenbutton";
            this.tenbutton.Size = new System.Drawing.Size(204, 54);
            this.tenbutton.TabIndex = 5;
            this.tenbutton.Text = "Tenant";
            this.tenbutton.UseVisualStyleBackColor = true;
            this.tenbutton.Click += new System.EventHandler(this.tenbutton_Click);
            // 
            // paybutton
            // 
            this.paybutton.Location = new System.Drawing.Point(64, 459);
            this.paybutton.Name = "paybutton";
            this.paybutton.Size = new System.Drawing.Size(204, 54);
            this.paybutton.TabIndex = 4;
            this.paybutton.Text = "Payment";
            this.paybutton.UseVisualStyleBackColor = true;
            this.paybutton.Click += new System.EventHandler(this.paybutton_Click);
            // 
            // manbutton
            // 
            this.manbutton.Location = new System.Drawing.Point(64, 370);
            this.manbutton.Name = "manbutton";
            this.manbutton.Size = new System.Drawing.Size(204, 54);
            this.manbutton.TabIndex = 3;
            this.manbutton.Text = "Manager";
            this.manbutton.UseVisualStyleBackColor = true;
            this.manbutton.Click += new System.EventHandler(this.manbutton_Click);
            // 
            // reqbutton
            // 
            this.reqbutton.Location = new System.Drawing.Point(64, 283);
            this.reqbutton.Name = "reqbutton";
            this.reqbutton.Size = new System.Drawing.Size(204, 54);
            this.reqbutton.TabIndex = 2;
            this.reqbutton.Text = "Request";
            this.reqbutton.UseVisualStyleBackColor = true;
            this.reqbutton.Click += new System.EventHandler(this.reqbutton_Click);
            // 
            // leasebutton
            // 
            this.leasebutton.Location = new System.Drawing.Point(64, 194);
            this.leasebutton.Name = "leasebutton";
            this.leasebutton.Size = new System.Drawing.Size(204, 54);
            this.leasebutton.TabIndex = 1;
            this.leasebutton.Text = "Lease";
            this.leasebutton.UseVisualStyleBackColor = true;
            this.leasebutton.Click += new System.EventHandler(this.leasebutton_Click);
            // 
            // apabutton
            // 
            this.apabutton.Location = new System.Drawing.Point(64, 100);
            this.apabutton.Name = "apabutton";
            this.apabutton.Size = new System.Drawing.Size(204, 54);
            this.apabutton.TabIndex = 0;
            this.apabutton.Text = "Apartment";
            this.apabutton.UseVisualStyleBackColor = true;
            this.apabutton.Click += new System.EventHandler(this.apabutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 59);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tenant";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tenantgrid
            // 
            this.tenantgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tenantgrid.Location = new System.Drawing.Point(378, 101);
            this.tenantgrid.Name = "tenantgrid";
            this.tenantgrid.RowHeadersWidth = 62;
            this.tenantgrid.RowTemplate.Height = 28;
            this.tenantgrid.Size = new System.Drawing.Size(965, 573);
            this.tenantgrid.TabIndex = 18;
            // 
            // tenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 788);
            this.Controls.Add(this.tenantgrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "tenant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tenant";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.tenant_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tenantgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button provbutton;
        private System.Windows.Forms.Button tenbutton;
        private System.Windows.Forms.Button paybutton;
        private System.Windows.Forms.Button manbutton;
        private System.Windows.Forms.Button reqbutton;
        private System.Windows.Forms.Button leasebutton;
        private System.Windows.Forms.Button apabutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tenantgrid;
    }
}