using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MimeKit;
using Renova.ViewModels.Contact;

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
			var model =	new EmailViewModel();

			return View(model);
		}

		/// <summary>
		///	Validates input and sends email
		/// </summary>
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> IndexAsync(EmailViewModel model)
		{
			// Build message
			var message = new MimeMessage();

			message.From.Add(new MailboxAddress(model.SenderName, "hello@renovacontracting.ca"));
			message.To.Add(new MailboxAddress("Juan Gallardo", "info@renovacontracting.ca"));
			message.Subject = $"Inquiry from {model.SenderName} sent from renovacontracting.ca";

			message.Body = new TextPart("plain")
			{
				Text = $"Reply to {model.SenderName} at {model.SenderEmailAddress}\nMessage: \n" + model.Message
			};

			// Connect to client and send email
			using (var client = new SmtpClient())
			{
				client.ServerCertificateValidationCallback =
					(sender, certificate, certChainType, errors) => true;

				client.AuthenticationMechanisms.Remove("XOAUTH2");
				
				await client
					.ConnectAsync(Configuration["Email:Smtp:Host"], Configuration.GetValue<int>("Email:Smtp:Port"), SecureSocketOptions.Auto)
					.ConfigureAwait(false);

				await client.AuthenticateAsync(Configuration["Email:Smtp:Username"], Configuration["Email:Smtp:Password"])
					.ConfigureAwait(false);

				await client.SendAsync(message).ConfigureAwait(false);

				await client.DisconnectAsync(true).ConfigureAwait(false);
			}

			return RedirectToAction("Index", "Home");
		}
	}
}