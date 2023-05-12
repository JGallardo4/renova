using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Renova.ViewModels.Contact;
using SendGrid;
using SendGrid.Helpers.Mail;
using MimeKit;

namespace Renova.Controllers
{
    /// <summary>
    ///	Contains all actions for displaying the email form, validating input, and sending mail
    /// </summary>
    public class ContactController : Controller
    {
        private IConfiguration Configuration { get; set; }

        public ContactController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        ///	Shows email contact form
        /// </summary>
        [HttpGet]
        public IActionResult Index()
        {
            var model = new EmailViewModel();

            return View(model);
        }

        /// <summary>
        ///	Validates input and sends email
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> IndexAsync(EmailViewModel model)
        {
            var apiKey = Configuration["SENDGRID_API"];
            var client = new SendGridClient(apiKey);

            var from = new EmailAddress(Configuration["FROM_ADDRESS"], "Contact form at RenovaContracting.CA");
            var to = new EmailAddress(Configuration["TO_ADDRESS"], "Juan Gallardo");
            var subject = $"Inquiry from {model.SenderName} sent via renovacontracting.ca";

            var body = @$"Reply to {model.SenderName} at {model.SenderEmailAddress}
						Message: \n" + model.Message;

            var msg = MailHelper.CreateSingleEmail(from, to, subject, null, body);
			Console.WriteLine(msg.Serialize());
            var response = await client.SendEmailAsync(msg).ConfigureAwait(false);
			System.Console.WriteLine(response);

            return RedirectToAction("Index", "Home");
        }
    }
}
