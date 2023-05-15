using adstra_task.Areas.Identity.Data;
using adstra_task.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using adstra_task.ViewModel;

namespace adstra_task.Models.Repositories
{
    public class UserListRepo : IUserListRepo
    {

        private readonly AuthDBContext _context;

        public UserListRepo(AuthDBContext context)
        {
            _context = context;
        }

       

        
        public IEnumerable<ApplicationUser> GetUserIDByName(string username)
        {
            try
            {
                var name = username;
                return _context.usersLists.FromSqlRaw("Select * From AspNetUsers Where UserName = {0}", name).ToList();
               

            }
           catch (Exception ex)
            {
                string s = ex.Message;
                return null;
            }
        }

        public void Delete(ApplicationUser ObjDelete)
        {
            var ObjToDelete = _context.usersLists.SingleOrDefault(m => m.Id == ObjDelete.Id);
            if (ObjToDelete != null)
            {
                _context.usersLists.Remove(ObjToDelete);
                _context.SaveChanges();

            }
        }

        public ApplicationUser GetUserByID(string userid)
        {
            return _context.usersLists.FirstOrDefault(m => m.Id == userid);
        }
        public void Update(ApplicationUser ObjUpdate)
        {
            var ObjToUpdate = _context.usersLists.FirstOrDefault(m => m.Id == ObjUpdate.Id);
            if (ObjToUpdate != null)
            {
                ObjToUpdate.FirstName = ObjUpdate.FirstName;
                ObjToUpdate.LastName = ObjUpdate.LastName;
                ObjToUpdate.PhoneNumber = ObjUpdate.PhoneNumber.ToString();
                ObjToUpdate.Email = ObjUpdate.Email;
            }
            _context.SaveChanges();
        }
    }
}
