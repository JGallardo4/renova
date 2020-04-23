using Microsoft.AspNetCore.Mvc;

namespace Renova.Controllers
{
	/// <summary>
	///	Contains all actions for displaying, and updating the about-us blurb.
	/// </summary>
	public class AboutController : Controller
	{
		/// <summary>
		///	Displays a blurb about the guild. 		
		/// </summary>
		public IActionResult Index()
		{			
			return View();
		}
	}
}