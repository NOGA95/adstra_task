using System;
using adstra_task.Areas.Identity.Data;
using adstra_task.Models;
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

        internal static object GetConnectionString()
        {
            //var conn = ConfigurationManager.ConnectionStrings["AuthDBContextConnection"].ConnectionString;
            //var csb = new SqlConnectionStringBuilder(conn);
            //string dbName = csb.InitialCatalog;

            //string sqlServerInstance = "(localdb)\\mssqllocaldb";

            return "Data Source=" + "" + ";Initial Catalog=" + "";


        }



        public DbSet<UsersList> usersLists { get; set; }


    }
}
