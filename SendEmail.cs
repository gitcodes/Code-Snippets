using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;


public class SendEmail
{
	
		public void SendMail()
    {
       
        MailMessage mm = new MailMessage("SenderEmailAddress", "RecieveEmailAddress"); // Enter Sender And Reciever Email. 
        mm.Subject = " Add Subject";  //Enter Email Subject
        string body = "Hello ";
        body += "<br/> <br /> <em>Warm Greetings</em>"; //Enter your Email Content here.
        body += "<br /><br />Thanks";
        mm.Body = body;
        mm.IsBodyHtml = true;
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com"; //Enter Your email Smtp. SMTP of gmail is shown here. SMTP for outlook :"smtp-mail.outlook.com"
        smtp.EnableSsl = true; 
        NetworkCredential NetworkCred = new NetworkCredential("Sender Email ", "Passowrd");//Enter Email credentials of account from which the Email is being send.
        smtp.UseDefaultCredentials = true;
        smtp.Credentials = NetworkCred;
        smtp.Port = 587; // you can use port 25 as an alternative
        smtp.Send(mm);


    
	}
}
