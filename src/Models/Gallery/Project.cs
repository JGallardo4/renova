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

            string relativePathFull = Path.Combine("images", "gallery", Name, "full-resolution");
            string relativePathThumbnail = Path.Combine("images", "gallery", Name, "thumbnails");

            string fullPathFull = Path.GetFullPath(Path.Combine("wwwroot", relativePathFull));
            string fullPathThumbnail = Path.GetFullPath(Path.Combine("wwwroot", relativePathThumbnail));

            FullImages = Directory
                .GetFiles(fullPathFull, "*.jpg")
                .Select(Path.GetFileName)
                .Select(f => "/" + relativePathFull + "/" + f)
                .OrderBy(f => f)                
                .ToArray();

            ThumbnailImages = Directory
                .GetFiles(fullPathThumbnail, "*.jpg")
                .Select(Path.GetFileName)
                .Select(f => "/" + relativePathThumbnail + "/" + f)
                .OrderBy(f => f)                
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

        public string[] FullImages { get; }

        public string[] ThumbnailImages { get; }
    }
}