namespace Library
{
    partial class Mail
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
            this.toadd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tosub = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tobody = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toadd
            // 
            this.toadd.Location = new System.Drawing.Point(147, 18);
            this.toadd.Name = "toadd";
            this.toadd.Size = new System.Drawing.Size(157, 20);
            this.toadd.TabIndex = 0;
            this.toadd.TextChanged += new System.EventHandler(this.toadd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject";
            // 
            // tosub
            // 
            this.tosub.Location = new System.Drawing.Point(147, 69);
            this.tosub.Name = "tosub";
            this.tosub.Size = new System.Drawing.Size(157, 20);
            this.tosub.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Message";
            // 
            // tobody
            // 
            this.tobody.Location = new System.Drawing.Point(38, 141);
            this.tobody.Multiline = true;
            this.tobody.Name = "tobody";
            this.tobody.Size = new System.Drawing.Size(384, 90);
            this.tobody.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(452, 284);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tobody);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tosub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Mail";
            this.Text = "Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox toadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tosub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tobody;
        private System.Windows.Forms.Button button1;
    }
}