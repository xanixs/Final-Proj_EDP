namespace EDP
{
    partial class Managers
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
            this.managersgrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.provbutton = new System.Windows.Forms.Button();
            this.tenbutton = new System.Windows.Forms.Button();
            this.paybutton = new System.Windows.Forms.Button();
            this.manbutton = new System.Windows.Forms.Button();
            this.reqbutton = new System.Windows.Forms.Button();
            this.leasebutton = new System.Windows.Forms.Button();
            this.apabutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.genrep = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.managersgrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // managersgrid
            // 
            this.managersgrid.ColumnHeadersHeight = 34;
            this.managersgrid.Location = new System.Drawing.Point(377, 169);
            this.managersgrid.Name = "managersgrid";
            this.managersgrid.RowHeadersWidth = 62;
            this.managersgrid.RowTemplate.Height = 28;
            this.managersgrid.Size = new System.Drawing.Size(1004, 503);
            this.managersgrid.TabIndex = 9;
            this.managersgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.leasegrid_CellContentClick);
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
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 793);
            this.panel1.TabIndex = 10;
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
            this.label1.Location = new System.Drawing.Point(381, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 59);
            this.label1.TabIndex = 11;
            this.label1.Text = "Managers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(1186, 695);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(195, 65);
            this.delete.TabIndex = 12;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.HotTrack;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(794, 695);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(195, 65);
            this.update.TabIndex = 13;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(377, 695);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(195, 65);
            this.add.TabIndex = 14;
            this.add.Text = "Insert";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // genrep
            // 
            this.genrep.BackColor = System.Drawing.Color.LemonChiffon;
            this.genrep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genrep.Location = new System.Drawing.Point(1206, 86);
            this.genrep.Name = "genrep";
            this.genrep.Size = new System.Drawing.Size(175, 52);
            this.genrep.TabIndex = 15;
            this.genrep.Text = "Generate Report";
            this.genrep.UseVisualStyleBackColor = false;
            this.genrep.Click += new System.EventHandler(this.genrep_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(377, 108);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(327, 35);
            this.search.TabIndex = 16;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(731, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Managers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 788);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.genrep);
            this.Controls.Add(this.add);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.managersgrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Managers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Managers";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.managersgrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView managersgrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button provbutton;
        private System.Windows.Forms.Button tenbutton;
        private System.Windows.Forms.Button paybutton;
        private System.Windows.Forms.Button manbutton;
        private System.Windows.Forms.Button reqbutton;
        private System.Windows.Forms.Button leasebutton;
        private System.Windows.Forms.Button apabutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button genrep;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button button1;
    }
}