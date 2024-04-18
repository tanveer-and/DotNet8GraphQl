
using DotNet8GraphQl.Entities;
using Microsoft.EntityFrameworkCore;
namespace DotNet8GraphQl.Data
{
	public class UserDBContext : DbContext
	{
		public UserDBContext(DbContextOptions<UserDBContext> options) : base(options) { }
		public DbSet<User> User { get; set;}
	}
}

