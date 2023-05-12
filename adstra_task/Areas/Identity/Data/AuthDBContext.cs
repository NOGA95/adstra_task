using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public DbSet<UsersList> usersLists { get; set; }
    }
}
    