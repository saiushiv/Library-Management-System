namespace Library
{
    partial class ListofBorrowers
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Cardno_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fnm_txt = new System.Windows.Forms.TextBox();
            this.lnm_txt = new System.Windows.Forms.TextBox();
            this.Addr_txt = new System.Windows.Forms.TextBox();
            this.phn_txt = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.baseTableCacheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseTableCacheBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(339, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(364, 297);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(624, 303);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(77, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Number of Borrowers";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(27, 229);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(214, 40);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add_New_Borrower";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Update
            // 
            this.Update.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Update.Location = new System.Drawing.Point(27, 284);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(214, 39);
            this.Update.TabIndex = 5;
            this.Update.Text = "Update Phone_no";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.button3_Click);
            // 
            // Cardno_txt
            // 
            this.Cardno_txt.BackColor = System.Drawing.Color.White;
            this.Cardno_txt.Enabled = false;
            this.Cardno_txt.Location = new System.Drawing.Point(161, 21);
            this.Cardno_txt.Name = "Cardno_txt";
            this.Cardno_txt.Size = new System.Drawing.Size(154, 20);
            this.Cardno_txt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Membership_Card_Number*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "*Means the marked field is mandatory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "First_Name*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Last_Name*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Address*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Contact_Number";
            // 
            // fnm_txt
            // 
            this.fnm_txt.Location = new System.Drawing.Point(161, 57);
            this.fnm_txt.Name = "fnm_txt";
            this.fnm_txt.Size = new System.Drawing.Size(154, 20);
            this.fnm_txt.TabIndex = 14;
            // 
            // lnm_txt
            // 
            this.lnm_txt.Location = new System.Drawing.Point(161, 96);
            this.lnm_txt.Name = "lnm_txt";
            this.lnm_txt.Size = new System.Drawing.Size(154, 20);
            this.lnm_txt.TabIndex = 15;
            // 
            // Addr_txt
            // 
            this.Addr_txt.Location = new System.Drawing.Point(161, 125);
            this.Addr_txt.Name = "Addr_txt";
            this.Addr_txt.Size = new System.Drawing.Size(154, 20);
            this.Addr_txt.TabIndex = 16;
            // 
            // phn_txt
            // 
            this.phn_txt.Location = new System.Drawing.Point(161, 155);
            this.phn_txt.Name = "phn_txt";
            this.phn_txt.Size = new System.Drawing.Size(154, 20);
            this.phn_txt.TabIndex = 17;
            // 
            // Delete
            // 
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Delete.Location = new System.Drawing.Point(27, 342);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(214, 36);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "Delete_the_Borrower";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // baseTableCacheBindingSource
            // 
            this.baseTableCacheBindingSource.DataSource = typeof(MySql.Data.MySqlClient.BaseTableCache);
            // 
            // ListofBorrowers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(705, 390);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.phn_txt);
            this.Controls.Add(this.Addr_txt);
            this.Controls.Add(this.lnm_txt);
            this.Controls.Add(this.fnm_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cardno_txt);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListofBorrowers";
            this.Text = "ListofBorrowers";
            this.Load += new System.EventHandler(this.ListofBorrowers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseTableCacheBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource baseTableCacheBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox Cardno_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fnm_txt;
        private System.Windows.Forms.TextBox lnm_txt;
        private System.Windows.Forms.TextBox Addr_txt;
        private System.Windows.Forms.TextBox phn_txt;
        private System.Windows.Forms.Button Delete;


    }
}