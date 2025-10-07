using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MultiShop.WebUI.Models;

namespace MultiShop.WebUI.Controllers
{
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult SendMail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMail(MailRequest mailRequest)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("MultiShop Katalog", "sevcanarig01@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("user", mailRequest.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodybuilder = new BodyBuilder();

            bodybuilder.TextBody = mailRequest.MessageContent;
            mimeMessage.Body = bodybuilder.ToMessageBody();

            mimeMessage.Subject = mailRequest.Subject;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("mail", "password");

            var value = smtpClient.Send(mimeMessage);

            smtpClient.Disconnect(true);

            return View();
        }
    }
}

        