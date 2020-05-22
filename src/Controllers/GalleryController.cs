using System.Collections.Generic;
using System.Threading.Tasks;
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
		///	Displays the image galleries available (One for each project).
		/// </summary>
		public IActionResult Index()
		{
			IEnumerable<Project> model = _appDbContext
				.Projects;

			return View(model);
		}

		/// <summary>
		///	Displays the image gallery for a particular project.		
		/// </summary>
		public async Task<ViewResult> ProjectAsync(string project)
		{
			Project currentProject;

			if(string.IsNullOrEmpty(project))
			{
				return View(NotFound());
			}
			else
			{
				currentProject = await _appDbContext
					.Projects
					.SingleOrDefaultAsync(p => p.Name == project);				
			}

			return View(currentProject);
		}
	}
}