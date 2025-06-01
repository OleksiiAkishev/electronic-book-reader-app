using Microsoft.EntityFrameworkCore;

namespace EBookReaderAppApi.Data
{
	public class EBookReaderDbContext(DbContextOptions<EBookReaderDbContext> options) : DbContext(options)
	{

	}
}
