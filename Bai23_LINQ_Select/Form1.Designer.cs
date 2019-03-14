namespace Bai23_LINQ_Select
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
            this.lsv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSelectMethod = new System.Windows.Forms.Button();
            this.btnSelectQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsv
            // 
            this.lsv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsv.Dock = System.Windows.Forms.DockStyle.Top;
            this.lsv.FullRowSelect = true;
            this.lsv.GridLines = true;
            this.lsv.Location = new System.Drawing.Point(0, 0);
            this.lsv.Name = "lsv";
            this.lsv.Size = new System.Drawing.Size(800, 239);
            this.lsv.TabIndex = 0;
            this.lsv.UseCompatibleStateImageBehavior = false;
            this.lsv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 48;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MaSv";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ten SV";
            this.columnHeader3.Width = 231;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SDT";
            this.columnHeader4.Width = 181;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            this.columnHeader5.Width = 174;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Diem TB";
            this.columnHeader6.Width = 275;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 367);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(353, 186);
            this.listBox1.TabIndex = 1;
            // 
            // btnSelectMethod
            // 
            this.btnSelectMethod.Location = new System.Drawing.Point(12, 257);
            this.btnSelectMethod.Name = "btnSelectMethod";
            this.btnSelectMethod.Size = new System.Drawing.Size(136, 23);
            this.btnSelectMethod.TabIndex = 2;
            this.btnSelectMethod.Text = "Select Method";
            this.btnSelectMethod.UseVisualStyleBackColor = true;
            this.btnSelectMethod.Click += new System.EventHandler(this.btnSelectMethod_Click);
            // 
            // btnSelectQuery
            // 
            this.btnSelectQuery.Location = new System.Drawing.Point(171, 257);
            this.btnSelectQuery.Name = "btnSelectQuery";
            this.btnSelectQuery.Size = new System.Drawing.Size(182, 23);
            this.btnSelectQuery.TabIndex = 3;
            this.btnSelectQuery.Text = "Select By Query\\";
            this.btnSelectQuery.UseVisualStyleBackColor = true;
            this.btnSelectQuery.Click += new System.EventHandler(this.btnSelectQuery_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.btnSelectQuery);
            this.Controls.Add(this.btnSelectMethod);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lsv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSelectMethod;
        private System.Windows.Forms.Button btnSelectQuery;
    }
}

