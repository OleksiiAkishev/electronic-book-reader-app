
namespace EBookReaderAppApi.Data.Entities
{
	public class Book
	{
		public Guid Id { get; set; }
		public string Title { get; set; } = null!;
		public Guid LibraryId { get; set; }
		public Library Library { get; set; } = null!;
		public ICollection<Page> Pages { get; set; } = [];
	}
}
