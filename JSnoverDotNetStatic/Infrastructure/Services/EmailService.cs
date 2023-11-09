using JSnoverDotNetStatic.DataTransferObjects.BlogModels;
using JSnoverDotNetStatic.DataTransferObjects.Common;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace JSnoverDotNetStatic.Infrastructure.Services
{
    public class EmailService
    {        
        /// <summary>
        /// Notify Snover about new comment on blog
        /// </summary>
        /// <param name="comment"></param>
        /// <param name="blog"></param>
        internal static async Task NotifySnover(BlogCommentModel comment, BlogDisplayModel blog)
        {

            // call Azure Function to get blog data

            //var msg = new SendGridMessage()
            //{
            //    From = new EmailAddress("jsnover@jsnover.net", "jsnover.net"),
            //    Subject = "New Contact Request jsnover.net",
            //    PlainTextContent =
            //   $"New Comment on Blog: {blog.Title}, Name: {comment.Name}, Email: {comment.Email}, " +
            //   $"Subscribe: {comment.Subscribe}, Liked: {comment.Liked}, Comment: {comment.Body}",
            //    HtmlContent =
            //   $"<strong>New Comment on Blog</strong>: {blog.Title}<br/>" +
            //    $"<strong>Name</strong>: {comment.Name}<br/>" +
            //    $"<strong>Email</strong>: {comment.Email}<br/>" +
            //    $"<strong>Subscribe</strong>: {comment.Subscribe}<br/>" +
            //    $"<strong>Liked</strong>: {comment.Liked}<br/>" +
            //    $"<strong>Comment</strong>: {comment.Body}"
            //};
            //msg.AddTo(new EmailAddress("snoverjacob@yahoo.com", "Randy"));
            //await SendEmail(msg);
        }

        internal static async Task NotifySnover(string subscriberEmail)
        {

            // call Azure Function to get blog data

            //var msg = new SendGridMessage()
            //{
            //    From = new EmailAddress("jsnover@jsnover.net", "jsnover.net"),
            //    Subject = "New Subscriber jsnover.net",
            //    PlainTextContent =
            //    $"New Subscriber: {subscriberEmail}",
            //    HtmlContent =
            //    $"<strong>New Subscriber</strong>: {subscriberEmail}<br/>"
            //};
            //msg.AddTo(new EmailAddress("snoverjacob@yahoo.com", "Randy"));
            //await SendEmail(msg);
        }

        internal static async Task NotifySnover(ContactModel contactRequest)
        {

            // call Azure Function to get blog data

            //var msg = new SendGridMessage()
            //{
            //    From = new EmailAddress("jsnover@jsnover.net", "jsnover.net"),
            //    Subject = "jsnover.net New Contact Request",
            //    PlainTextContent =
            //    $"NEW CONTACT REQUEST - Name: {contactRequest.Name}, Email: {contactRequest.Email}, Request Body: {contactRequest.Body}, ISSUE WITH SITE: {contactRequest.Issue}",
            //    HtmlContent =
            //    $"<strong>NEW CONTACT REQUEST</strong><br/>" +
            //    $"<strong>Name</strong>: {contactRequest.Name}<br/>" +
            //    $"<strong>Email</strong>: {contactRequest.Email}<br/>" +
            //    $"<strong>Request Body</strong>: {contactRequest.Body}<br/>" +
            //    $"<strong>ISSUE WITH SITE</strong>: {contactRequest.Issue}<br/>"
            //};
            //msg.AddTo(new EmailAddress("snoverjacob@yahoo.com", "Randy"));
            //await SendEmail(msg);
        }

        private static async Task SendEmail()
        {
            //var builder = new ConfigurationBuilder()
            //    .AddJsonFile("appsettings.json", optional: false)
            //    .Build();

            //var apiKey = Environment.GetEnvironmentVariable("SendGrid:ApiKey");

            //if (apiKey is null)
            //{
            //    apiKey = builder.GetValue<string>("SendGrid:ApiKey");
            //}

            //var client = new SendGridClient(apiKey);
            
            //await client.SendEmailAsync(msg);
        }
    }
}