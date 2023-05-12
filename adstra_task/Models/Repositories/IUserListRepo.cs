using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adstra_task.Models.Repositories
{
    interface IUserListRepo
    {
        void Add(UsersList ObjSave);
        IEnumerable<UsersList> AllUsers();
        void Update(UsersList ObjUpdate);
        void Delete(UsersList ObjDelete);


    }
}
