namespace Library
{
    partial class BookLoan
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CDNO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DOUT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DUDATE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chk_in = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(12, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check-out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book-ID*";
            // 
            // BID
            // 
            this.BID.Location = new System.Drawing.Point(117, 43);
            this.BID.Name = "BID";
            this.BID.Size = new System.Drawing.Size(100, 20);
            this.BID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Branch-ID*";
            // 
            // CDNO
            // 
            this.CDNO.Location = new System.Drawing.Point(117, 140);
            this.CDNO.Name = "CDNO";
            this.CDNO.Size = new System.Drawing.Size(100, 20);
            this.CDNO.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Card-No*";
            // 
            // DOUT
            // 
            this.DOUT.Enabled = false;
            this.DOUT.Location = new System.Drawing.Point(117, 187);
            this.DOUT.Name = "DOUT";
            this.DOUT.ReadOnly = true;
            this.DOUT.Size = new System.Drawing.Size(100, 20);
            this.DOUT.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date-Out";
            // 
            // DUDATE
            // 
            this.DUDATE.Enabled = false;
            this.DUDATE.Location = new System.Drawing.Point(117, 248);
            this.DUDATE.Name = "DUDATE";
            this.DUDATE.Size = new System.Drawing.Size(100, 20);
            this.DUDATE.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Due-Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(271, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 266);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chk_in
            // 
            this.chk_in.Cursor = System.Windows.Forms.Cursors.Default;
            this.chk_in.Location = new System.Drawing.Point(15, 395);
            this.chk_in.Name = "chk_in";
            this.chk_in.Size = new System.Drawing.Size(139, 39);
            this.chk_in.TabIndex = 12;
            this.chk_in.Text = "Check-in";
            this.chk_in.UseVisualStyleBackColor = true;
            this.chk_in.Click += new System.EventHandler(this.chk_in_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(721, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(624, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total-Book-Loans";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Location = new System.Drawing.Point(746, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Location = new System.Drawing.Point(15, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 38);
            this.button2.TabIndex = 17;
            this.button2.Text = "Send Notification Email";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(462, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 184);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search a specific Book";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(137, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 54);
            this.button4.TabIndex = 20;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Borrower";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(169, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(190, 20);
            this.textBox4.TabIndex = 24;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Book_ID";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(169, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 20);
            this.textBox3.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Membership_Card_Number*";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(169, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 20);
            this.textBox2.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Location = new System.Drawing.Point(189, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 184);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To Extend the Book_Loan period";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Default;
            this.button6.Location = new System.Drawing.Point(35, 67);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(187, 39);
            this.button6.TabIndex = 22;
            this.button6.Text = "Update Due_Date";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(271, 274);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 34);
            this.button5.TabIndex = 23;
            this.button5.Text = "Export to Excel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // BookLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(833, 524);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chk_in);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DUDATE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DOUT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CDNO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BookLoan";
            this.Text = "BookLoan";
            this.Load += new System.EventHandler(this.BookLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CDNO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DOUT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DUDATE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button chk_in;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}