using BookShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Data
{
	public class ApplicationDBContext:DbContext
	{
        public DbSet<Category> Categories { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
            
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData(
				new Category { Id=1,Name="Horror",Description="So scary",DisplayOrder=2},
				new Category { Id = 2, Name = "Action", Description = "Hello", DisplayOrder = 3},
				new Category { Id = 3, Name = "Roman", Description = "A lot of roman stories", DisplayOrder = 1 },
				new Category { Id = 4, Name = "Science", Description = "So difficult", DisplayOrder = 4 }
			);
		}
	}
}
