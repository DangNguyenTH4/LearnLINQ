namespace Bai16FindLINQ
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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimSp = new System.Windows.Forms.Button();
            this.txtTimSp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGiaLapData = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFindAll = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnFindLast = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnRemoAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Tim";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(62, 282);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tim";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(34, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 186);
            this.listBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Tao Danh Sach";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "N";
            // 
            // btnTimSp
            // 
            this.btnTimSp.Location = new System.Drawing.Point(250, 305);
            this.btnTimSp.Name = "btnTimSp";
            this.btnTimSp.Size = new System.Drawing.Size(100, 23);
            this.btnTimSp.TabIndex = 24;
            this.btnTimSp.Text = "Tim";
            this.btnTimSp.UseVisualStyleBackColor = true;
            this.btnTimSp.Click += new System.EventHandler(this.btnTimSp_Click);
            // 
            // txtTimSp
            // 
            this.txtTimSp.Location = new System.Drawing.Point(329, 279);
            this.txtTimSp.Name = "txtTimSp";
            this.txtTimSp.Size = new System.Drawing.Size(100, 20);
            this.txtTimSp.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tim";
            // 
            // btnGiaLapData
            // 
            this.btnGiaLapData.Location = new System.Drawing.Point(283, 14);
            this.btnGiaLapData.Name = "btnGiaLapData";
            this.btnGiaLapData.Size = new System.Drawing.Size(177, 23);
            this.btnGiaLapData.TabIndex = 21;
            this.btnGiaLapData.Text = "Gia Lap Data";
            this.btnGiaLapData.UseVisualStyleBackColor = true;
            this.btnGiaLapData.Click += new System.EventHandler(this.btnGiaLapData_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(250, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(259, 179);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "STT";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ma";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gia";
            // 
            // btnFindAll
            // 
            this.btnFindAll.Location = new System.Drawing.Point(250, 332);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(100, 23);
            this.btnFindAll.TabIndex = 25;
            this.btnFindAll.Text = "Tim tat ca";
            this.btnFindAll.UseVisualStyleBackColor = true;
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Find Index";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnFindLast
            // 
            this.btnFindLast.Location = new System.Drawing.Point(250, 390);
            this.btnFindLast.Name = "btnFindLast";
            this.btnFindLast.Size = new System.Drawing.Size(100, 23);
            this.btnFindLast.TabIndex = 27;
            this.btnFindLast.Text = "Find Last";
            this.btnFindLast.UseVisualStyleBackColor = true;
            this.btnFindLast.Click += new System.EventHandler(this.btnFindLast_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(250, 419);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "Find Last Index";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnRemoAll
            // 
            this.btnRemoAll.Location = new System.Drawing.Point(380, 305);
            this.btnRemoAll.Name = "btnRemoAll";
            this.btnRemoAll.Size = new System.Drawing.Size(100, 23);
            this.btnRemoAll.TabIndex = 29;
            this.btnRemoAll.Text = "Remove All";
            this.btnRemoAll.UseVisualStyleBackColor = true;
            this.btnRemoAll.Click += new System.EventHandler(this.btnRemoAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.btnRemoAll);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnFindLast);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnFindAll);
            this.Controls.Add(this.btnTimSp);
            this.Controls.Add(this.txtTimSp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGiaLapData);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimSp;
        private System.Windows.Forms.TextBox txtTimSp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGiaLapData;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnFindAll;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnFindLast;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnRemoAll;
    }
}

