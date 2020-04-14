using AuthTest.Core.Constants;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthTest.Data.Initialize
{
    public static class IdentityDataInitializer
    {
        public static void SeedData(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync
  (Constants.UserRole).Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = Constants.UserRole;
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync
(Constants.AdminRole).Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = Constants.AdminRole;
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
        }
    }
}
