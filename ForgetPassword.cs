using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroLibrary
{
    public partial class ForgetPassword : MetroFramework.Forms.MetroForm
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            string fromMail = "librarymanagementrecovery@gmail.com";
            string fromPassword = "ynahcnornvaakqlx";


            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Greetings !";
            message.To.Add(new MailAddress("buddikaalwis@hotmail.com"));
            message.Body = "<html><body> <h1>Hello </h1>" +
                "<p>Congratulations! You are now an Employee of Pizza Master!</p>" +
                "<p>Please use these credentials you have been given below when you have to login for your future tasks</p>" +
                "<p><b>Username:</b>  </p>" +
                "<p><b>Password:</b> </p></body></html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);
        }

        private void ForgetPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1().Show();
        }
    }
}
