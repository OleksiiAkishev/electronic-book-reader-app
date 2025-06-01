namespace EBookReaderAppApi.Data.Entities
{
	public class Page
	{
		public Guid Id { get; set; }
		public int Number { get; set; }
		public string Content { get; set; } = null!;
		public Guid BookId { get; set; }
		public Book Book { get; set; } = null!;
	}
}
