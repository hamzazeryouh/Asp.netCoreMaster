
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NetCoreMaster.Application.Interfaces;
using NetCoreMaster.Domain.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace NetCoreMaster.Persistence.Context
{
	public class ApplicationDbContext : IdentityDbContext<Users>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			base.OnModelCreating(modelBuilder);
		}
		public async Task<int> SaveChangesAsync()
		{
			return await base.SaveChangesAsync();
		}
	}
}
