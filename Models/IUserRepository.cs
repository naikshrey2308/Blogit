using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogIt.Models
{
    public interface IUserRepository
    {
        User GetUser(int Id);
        User GetUserFromEmail(string Email);
        IEnumerable<User> GetAllUsers();
        User Add(User User);
        User Update(User UserChanges);
        User Delete(int Id);
    }
}
