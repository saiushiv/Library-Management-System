using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Library
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            
			// Please enter your Gmail's Email address in the below ****** marked area. 
			
			mail.From = new MailAddress("shiva.upadhyay008@gmail.com", "Testing");
           
            string tomail = toadd.Text.Trim();
           
            mail.To.Add(tomail);
            mail.IsBodyHtml = true;

            string msg = tosub.Text.Trim();
            
            mail.Subject = msg;

            string tomsg = tobody.Text.Trim();

            mail.Body = tomsg;
            mail.Priority = MailPriority.High;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            //smtp.UseDefaultCredentials = true;
            // Please enter your Gmail's Email address and password in the below ****** marked area. 
		    // Add your email id and password in the credential area.
            smtp.Credentials = new System.Net.NetworkCredential("", "");
            smtp.EnableSsl = true;
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            smtp.Send(mail);

            MessageBox.Show("Mail Sent Successfully");
        }

        private void toadd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
