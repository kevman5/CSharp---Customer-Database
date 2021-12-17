
namespace customer_db
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tb_phone1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_email1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_script1 = new System.Windows.Forms.TextBox();
            this.tb_price1 = new System.Windows.Forms.TextBox();
            this.tb_end1 = new System.Windows.Forms.TextBox();
            this.tb_start1 = new System.Windows.Forms.TextBox();
            this.tb_jobname1 = new System.Windows.Forms.TextBox();
            this.tb_client1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveClientInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadClientInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(755, 406);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_clear);
            this.tabPage1.Controls.Add(this.tb_phone1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.tb_email1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tb_script1);
            this.tabPage1.Controls.Add(this.tb_price1);
            this.tabPage1.Controls.Add(this.tb_end1);
            this.tabPage1.Controls.Add(this.tb_start1);
            this.tabPage1.Controls.Add(this.tb_jobname1);
            this.tabPage1.Controls.Add(this.tb_client1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(747, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Client/Job";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tb_phone1
            // 
            this.tb_phone1.Location = new System.Drawing.Point(95, 232);
            this.tb_phone1.Name = "tb_phone1";
            this.tb_phone1.Size = new System.Drawing.Size(100, 20);
            this.tb_phone1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Job Description";
            // 
            // tb_email1
            // 
            this.tb_email1.Location = new System.Drawing.Point(320, 232);
            this.tb_email1.Name = "tb_email1";
            this.tb_email1.Size = new System.Drawing.Size(100, 20);
            this.tb_email1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Job Bid Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Est Finish Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Job Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Client Name";
            // 
            // tb_script1
            // 
            this.tb_script1.Location = new System.Drawing.Point(320, 171);
            this.tb_script1.Name = "tb_script1";
            this.tb_script1.Size = new System.Drawing.Size(100, 20);
            this.tb_script1.TabIndex = 5;
            // 
            // tb_price1
            // 
            this.tb_price1.Location = new System.Drawing.Point(95, 172);
            this.tb_price1.Name = "tb_price1";
            this.tb_price1.Size = new System.Drawing.Size(100, 20);
            this.tb_price1.TabIndex = 4;
            // 
            // tb_end1
            // 
            this.tb_end1.Location = new System.Drawing.Point(320, 101);
            this.tb_end1.Name = "tb_end1";
            this.tb_end1.Size = new System.Drawing.Size(100, 20);
            this.tb_end1.TabIndex = 3;
            // 
            // tb_start1
            // 
            this.tb_start1.Location = new System.Drawing.Point(95, 102);
            this.tb_start1.Name = "tb_start1";
            this.tb_start1.Size = new System.Drawing.Size(100, 20);
            this.tb_start1.TabIndex = 2;
            // 
            // tb_jobname1
            // 
            this.tb_jobname1.Location = new System.Drawing.Point(320, 34);
            this.tb_jobname1.Name = "tb_jobname1";
            this.tb_jobname1.Size = new System.Drawing.Size(100, 20);
            this.tb_jobname1.TabIndex = 1;
            // 
            // tb_client1
            // 
            this.tb_client1.Location = new System.Drawing.Point(95, 35);
            this.tb_client1.Name = "tb_client1";
            this.tb_client1.Size = new System.Drawing.Size(100, 20);
            this.tb_client1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(747, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Client/Job List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveClientInfoToolStripMenuItem,
            this.loadClientInfoToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveClientInfoToolStripMenuItem
            // 
            this.saveClientInfoToolStripMenuItem.Name = "saveClientInfoToolStripMenuItem";
            this.saveClientInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveClientInfoToolStripMenuItem.Text = "Save Client Info";
            this.saveClientInfoToolStripMenuItem.Click += new System.EventHandler(this.saveClientInfoToolStripMenuItem_Click);
            // 
            // loadClientInfoToolStripMenuItem
            // 
            this.loadClientInfoToolStripMenuItem.Name = "loadClientInfoToolStripMenuItem";
            this.loadClientInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadClientInfoToolStripMenuItem.Text = "Load Client Info";
            this.loadClientInfoToolStripMenuItem.Click += new System.EventHandler(this.loadClientInfoToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 8);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(421, 329);
            this.listBox1.TabIndex = 0;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(183, 292);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 16;
            this.btn_clear.Text = "Clear all";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_phone1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_email1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_script1;
        private System.Windows.Forms.TextBox tb_price1;
        private System.Windows.Forms.TextBox tb_end1;
        private System.Windows.Forms.TextBox tb_start1;
        private System.Windows.Forms.TextBox tb_jobname1;
        private System.Windows.Forms.TextBox tb_client1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveClientInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadClientInfoToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_clear;
    }
}

