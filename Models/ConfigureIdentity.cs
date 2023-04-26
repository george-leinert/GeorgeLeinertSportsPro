using Microsoft.AspNetCore.Identity;

namespace MVCHOT2.Models
{
	public class ConfigureIdentity
	{
		public static async Task CreateAdminUserAsync(IServiceProvider provider)
		{
			var roleManager = provider.GetRequiredService<RoleManager<IdentityRole>>();

			var userManager = provider.GetRequiredService<UserManager<User>>();

			string username = "admin";
			string password = "admin123";
			string roleName = "Admin";

			if (await roleManager.FindByNameAsync(roleName) == null)
			{
				User user = new User { UserName = username };
				var result = await userManager.CreateAsync(user, password);
				if (result.Succeeded)
				{
					await userManager.AddToRoleAsync(user, roleName);
				}
			}
		}
	}
}
