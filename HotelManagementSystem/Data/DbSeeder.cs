using Microsoft.AspNetCore.Identity;
using HotelManagementSystem.Constants;

namespace HotelManagementSystem.Data
{
	public class DbSeeder
	{
		public static async Task Seed(IServiceProvider service)
		{
			var uerMgr = service.GetService<UserManager<IdentityUser>>();
			var roleMgr = service.GetService<RoleManager<IdentityRole>>();

			// adding some roles to db

			await roleMgr.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
			await roleMgr.CreateAsync(new IdentityRole(Roles.Staffs.ToString()));
			await roleMgr.CreateAsync(new IdentityRole(Roles.User.ToString()));

			// create admin uesr
			var admin = new IdentityUser
			{
				UserName = "administrator@gmail.com",
				Email = "administrator@gmail.com",
				EmailConfirmed = true
			};

			var isAdminExists = await uerMgr.FindByEmailAsync(admin.Email);
			if (isAdminExists is null)
			{
				await uerMgr.CreateAsync(admin, "Admin1234*");
				await uerMgr.AddToRoleAsync(admin, Roles.Admin.ToString());
			}

            var Staffs = new IdentityUser
            {
                UserName = "staffs@gmail.com",
                Email = "staffs@gmail.com",
                EmailConfirmed = true
            };

            var isStaffsExists = await uerMgr.FindByEmailAsync(Staffs.Email);
            if (isStaffsExists is null)
            {
                await uerMgr.CreateAsync(Staffs, "Staffs1234*");
                await uerMgr.AddToRoleAsync(Staffs, Roles.Staffs.ToString());
            }
        }
	}
}
