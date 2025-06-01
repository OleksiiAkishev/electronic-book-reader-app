namespace EBookReaderAppApi.Data.Entities
{
	public class Library
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = null!;
		public Guid UserId { get; set; }
		public User User { get; set; } = null!;
		public ICollection<Book> Books { get; set; } = [];
	}
}
