using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogIt.Models
{
    public class SQLUserRepository : IUserRepository
    {
        private readonly AppDbContext context;

        public SQLUserRepository(AppDbContext context)
        {
            this.context = context;
        }

        User IUserRepository.Add(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }

        User IUserRepository.Delete(int Id)
        {
            User user = context.Users.Find(Id);
            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
            return user;
        }

        IEnumerable<User> IUserRepository.GetAllUsers()
        {
            return context.Users;
        }

        User IUserRepository.GetUser(int Id)
        {
            return context.Users.FirstOrDefault(m => m.Id == Id);
        }

        User IUserRepository.Update(User userChanges)
        {
            var user = context.Users.Attach(userChanges);
            user.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return userChanges;
        }

        User IUserRepository.GetUserFromEmail(string Email)
        {
            var userList = context.Users.Where(user => user.Email == Email).ToList();
            return (userList.LongCount() == 0) ? null : userList.First();
        }
    }
}