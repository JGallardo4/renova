using System;
using System.Collections.Generic;
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
				new Project
				{
                    ProjectId = 1,
                    Name = "Millwoods Project",
                    Directory = "/images/gallery/Millwoods/after/",
                    Images = new string[]
                    {
                        "house1_after_backentrance.jpg",
                        "house1_after_bathroom.jpg",
                        "house1_after_bathroom2.jpg",
                        "house1_after_decoratedwide.jpg",
                        "house1_after_diningarea.jpg",
                        "house1_after_kitchen1.jpg",
                        "house1_after_kitchen2.jpg",
                        "house1_after_kitchen3.jpg",
                        "house1_after_kitchen4.jpg",
                        "house1_after_livingroom.jpg",
                        "house1_after_livingroom2.jpg",
                        "house1_after_livingroom3.jpg",
                        "house1_after_wideshot.jpg",
                        "kitchen1_after_1.jpg"
                    }
                });
        }
    }
}