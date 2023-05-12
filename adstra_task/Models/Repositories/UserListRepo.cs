using adstra_task.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adstra_task.Models.Repositories
{
    public class UserListRepo : IUserListRepo
    {

        private readonly AuthDBContext _context;

        public UserListRepo(AuthDBContext context)
        {
            _context = context;
        }

        public void Add(UsersList ObjSave)
        {
            _context.usersLists.Add(ObjSave);
        }

        public IEnumerable<UsersList> AllUsers()
        {
            return _context.usersLists.ToList();

        }



        public void Delete(UsersList ObjDelete)
        {
            var ObjToDelete = _context.usersLists.SingleOrDefault(m => m.Id == ObjDelete.Id);
            if (ObjToDelete != null)
            {
                _context.usersLists.Remove(ObjToDelete);
            }
        }

        public void Update(UsersList ObjUpdate)
        {
            var ObjToUpdate = _context.usersLists.FirstOrDefault(m => m.Id == ObjUpdate.Id);
            if (ObjToUpdate != null)
            {
                ObjToUpdate.FirstName = ObjUpdate.FirstName;
                ObjToUpdate.LastName = ObjUpdate.LastName;
                ObjToUpdate.PhoneNumber = ObjUpdate.PhoneNumber;
                ObjToUpdate.Email = ObjUpdate.Email;
            }
        }
    }
}
