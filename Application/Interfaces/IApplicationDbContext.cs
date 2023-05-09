using Microsoft.EntityFrameworkCore;
using NetCoreMaster.Domain.Entities;

namespace NetCoreMaster.Application.Interfaces
{
	public interface IApplicationDbContext
	{
		DbSet<Users> Users { get; set; }
		Task<int> SaveChangesAsync();
	}
}
