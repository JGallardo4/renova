using Microsoft.EntityFrameworkCore;
using Renova.Models.Gallery;

namespace Renova.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{			
		}

        public DbSet<GallerySection> GallerySections { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            base.OnModelCreating(modelBuilder);

            // Seed GallerySection data
			modelBuilder.Entity<GallerySection>().HasData(
				new GallerySection
				{
                    GallerySectionId = 1,
                    Name = "Kitchen"
                },
                
                new GallerySection
				{
                    GallerySectionId = 2,
                    Name = "Living Room"
                },

                new GallerySection
				{
                    GallerySectionId = 3,
                    Name = "Bathroom"
                },
                
                new GallerySection
				{
                    GallerySectionId = 4,
                    Name = "Office"
                },
                
                new GallerySection
				{
                    GallerySectionId = 5,
                    Name = "Others"
                });

			// Seed Image data
			modelBuilder.Entity<Image>().HasData(
				new Image
				{
                    ImageId = 1,
                    GallerySectionId = 1,
                    Stage = StageEnum.Before,
                    ImageUrl = "/images/kitchen/kitchen1_before_1.jpg"
                },
                
                new Image
				{
                    ImageId = 2,
                    GallerySectionId = 1,
                    Stage = StageEnum.During,
                    ImageUrl = "/images/kitchen/kitchen1_during_1.jpg"
                },
                
                new Image
				{
                    ImageId = 3,
                    GallerySectionId = 1,
                    Stage = StageEnum.After,
                    ImageUrl = "/images/kitchen/kitchen1_after_1.jpg"
                });
        }
    }
}