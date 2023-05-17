using System;
using adstra_task.Areas.Identity.Data;
using adstra_task.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace adstra_task.Data
{
    public class AuthDBContext : IdentityDbContext<ApplicationUser>
    {
        public AuthDBContext(DbContextOptions<AuthDBContext> options)
            : base(options)
        {
        }

       

        internal static object Create(object v)
        {
            throw new NotImplementedException();
        }


        public DbSet<ApplicationUser> usersLists { get; set; }


    }
}
