using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Renova.Models.Gallery
{
    /// <summary>
	///	Contains information for displaying all the photos for a Section of the Gallery.
	/// </summary>
    public class Project
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int ProjectId { get; set; }
        
        [Required]
		[StringLength(100)]		
		public string Name { get; set; }

        [Required]
        public string Directory { get; set; } 

        [Required]
        public string[] Images { get; set; }        
    }
}