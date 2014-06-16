using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(2);
            label1.Text = progressBar1.Value.ToString() +"%";
        if (progressBar1.Value == 100)
        {
            timer1.Stop();
            var childform = new LibraryManager();
            this.Hide();
            childform.ShowDialog();
            this.Close();
        }
      
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
