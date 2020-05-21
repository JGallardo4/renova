using System;
using Microsoft.EntityFrameworkCore;
using Renova.Models.Gallery;

namespace Renova.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{			
		}

        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            base.OnModelCreating(modelBuilder);

            // Set up backing field for sting[]
            modelBuilder.Entity<Project>()
                .Property(p => p.Images)
                .HasConversion(
                    v => string.Join(';', v),
                    v => v.Split(';', StringSplitOptions.RemoveEmptyEntries) 
                );

            // Seed Project data
			modelBuilder.Entity<Project>().HasData(
				new Project("before-after")
                {
                    ProjectId = 1,
                    DisplayName = "Before and After Gallery",
                    ThumbnailImage = ""
                },

                new Project("duggan")
                {
                    ProjectId = 2,
                    DisplayName = "Duggan Project",
                    ThumbnailImage = ""
                },

                new Project("millwoods")
                {
                    ProjectId = 3,
                    DisplayName = "Millwoods Project",
                    ThumbnailImage = ""
                });
        }
    }
}