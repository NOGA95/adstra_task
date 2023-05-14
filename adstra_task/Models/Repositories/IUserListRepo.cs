using adstra_task.Areas.Identity.Data;
using adstra_task.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adstra_task.Models.Repositories
{
   public interface IUserListRepo
    {
        public ApplicationUser GetUserByID(string userid);
        void Update(EditUserVM ObjToUpdate);
        void Delete(string id);
        IEnumerable<ApplicationUser>  GetUserIDByName(string username);
    }
}
