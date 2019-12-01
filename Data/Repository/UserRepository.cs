using AEGEE_MVC.Data.Interfaces;
using AEGEE_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AEGEE_MVC.Data.Repository
{
    public class UserRepository : IAllUsers
    {
        private readonly AppDBContent appDBContent;
        public UserRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent; 
        }

        
        public IEnumerable<User> AllUsers => appDBContent.Users.Include(c => c.UserId);
        
        public static User UserAuthorized(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string name = session.GetString("Username") ?? Guid.NewGuid().ToString();
            
            session.SetString("name", name);

            return new User();        
        }

        public void SetAge(User user, int age)
        {            
            appDBContent.Update(user.Age);
        }


    }
}
