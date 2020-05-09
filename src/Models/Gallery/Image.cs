using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Renova.Models.Gallery
{
    public enum StageEnum
	{
		Before, During, After
	}

    public class Image
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int ImageId { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int GallerySectionId { get; set; }

		[Required]
		public GallerySection GallerySection { get; set; }	

        [Required]
		public StageEnum Stage { get; set; }

        [Required]
		[StringLength(100)]		
		public string ImageUrl { get; set; }
    }
}