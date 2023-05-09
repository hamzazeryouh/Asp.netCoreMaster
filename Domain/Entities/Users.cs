using Microsoft.AspNetCore.Identity;

namespace NetCoreMaster.Domain.Entities
{
	public class Users: IdentityUser
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}
