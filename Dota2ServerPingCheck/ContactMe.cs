using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dota2ServerPingCheck
{
    public partial class ContactMe : Form
    {
        public ContactMe()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("your_email_address@gmail.com");
                mail.To.Add("umer.javaid.ceme@gmail.com");
                mail.Subject = "Dota2ServerPingCheck Feedback";
                mail.Body = tbFeedback.Text;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Sent Successfull.");
                btnSend.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Sending Mail: \r\n" + ex.ToString());
            }
        }
    }
}
