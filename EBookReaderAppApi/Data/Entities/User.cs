﻿namespace EBookReaderAppApi.Data.Entities
{
	public class User
	{
		public Guid Id { get; set; }
		public string Email { get; set; } = null!;
		public ICollection<Library> Libraries { get; set; } = [];
	}
}
