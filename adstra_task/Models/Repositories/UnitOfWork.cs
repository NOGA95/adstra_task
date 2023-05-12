using adstra_task.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using adstra_task.Models.Repositories;


namespace adstra_task.Models.Repositories
{
    //public class UnitOfWork : IUnitOfWork
    //{
    //    private readonly AuthDBContext _context;
    //    public IUserListRepo UserList { get; set; }


    //    public UnitOfWork(AuthDBContext context)
    //    {
    //        var appDbContext = AuthDBContext.Create(AuthDBContext.GetConnectionString());

    //        context = (AuthDBContext)appDbContext;



    //        _context = context;
    //        UserList = new UserListRepo(_context);

    //    }
    //    public void Complete()
    //    {
    //        _context.SaveChanges();
    //    }
    //}
}
