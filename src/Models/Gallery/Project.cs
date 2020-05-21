using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;

namespace Renova.Models.Gallery
{
    /// <summary>
	///	Contains information for displaying all the photos for a Section of the Gallery.
	/// </summary>
    public class Project
    {
		public Project(string name)
		{
			Name = name;

            string relativePath = Path.Combine("images", "gallery", Name);
            string fullPath = Path.GetFullPath(Path.Combine("wwwroot", relativePath));

            Images = Directory
                .GetFiles(fullPath, "*.jpg")
                .Select(Path.GetFileName)
                .Select(f => "/" + relativePath + "/" + f)
                .ToArray();
		}

        public int ProjectId { get; set; }
        
        [Required]
		[StringLength(100)]		
		public string Name { get; set; }

        [Required]
		[StringLength(100)]		
		public string DisplayName { get; set; }

        [Required]
		[StringLength(100)]		
		public string ThumbnailImage { get; set; }

        public string[] Images { get; }
    }
}