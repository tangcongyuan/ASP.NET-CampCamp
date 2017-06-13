namespace CampCamp.Web.DataContexts.IdentityMigrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CampCamp.Web.DataContexts.IdentityDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DataContexts\IdentityMigrations";
        }

        protected override void Seed(CampCamp.Web.DataContexts.IdentityDb context)
        {
            List<ApplicationUser> users = new List<ApplicationUser>
            {
                new ApplicationUser
                {
                    UserName = "tangcongyuan",
                    Email = "tangcongyuan@gmail.com"
                },
                new ApplicationUser
                {
                    UserName = "erictang",
                    Email = "erictang@gmail.com"
                },
                new ApplicationUser
                {
                    UserName = "134TurnpikeKid",
                    Email = "134TurnpikeKid@gmail.com"
                }
            };
            
            foreach (var user in users)
            {
                if (!context.Users.Any(u => u.UserName == user.UserName))
                {
                    var store = new UserStore<ApplicationUser>(context);
                    var manager = new ApplicationUserManager(store);
                    manager.Create(user, "P@ssw0rd");
                }
            }
        }
    }
}
