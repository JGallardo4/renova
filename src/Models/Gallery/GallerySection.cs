using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Renova.Models.Gallery
{
    /// <summary>
	///	Contains information for displaying all the photos for a Section of the Gallery.
	/// </summary>
    public class GallerySection
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int GallerySectionId { get; set; }
        
        [Required]
		[StringLength(100)]		
		public string Name { get; set; }

        [Required]
        public List<Image> Images { get; set; }
    }
}