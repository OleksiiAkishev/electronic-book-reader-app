using EBookReaderAppApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EBookReaderAppApi.Data
{
	public class EBookReaderDbContext(DbContextOptions<EBookReaderDbContext> options) : DbContext(options)
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Library> Libraries { get; set; }
		public DbSet<Book> Books { get; set; }
		public DbSet<Page> Pages { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>()
				.HasMany(u => u.Libraries)
				.WithOne(l => l.User)
				.HasForeignKey(l => l.UserId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<Library>()
				.HasMany(l => l.Books)
				.WithOne(b => b.Library)
				.HasForeignKey(b => b.LibraryId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<Book>()
				.HasMany(b => b.Pages)
				.WithOne(p => p.Book)
				.HasForeignKey(b => b.BookId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
