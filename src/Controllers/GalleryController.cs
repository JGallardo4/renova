using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Renova.Data;
using Renova.Models.Gallery;

namespace Renova.Controllers
{
	/// <summary>
	///	Contains all actions for displaying, and updating the image gallery.
	/// </summary>
	public class GalleryController : Controller
	{
		private readonly AppDbContext _appDbContext;

		public GalleryController(AppDbContext dbContext)
		{
			_appDbContext = dbContext;
		}

		/// <summary>
		///	Displays the image gallery separated in different sections		
		/// </summary>
		public IActionResult Index()
		{
			IEnumerable<Project> model = _appDbContext
				.Projects;

			return View(model);
		}
	}
}