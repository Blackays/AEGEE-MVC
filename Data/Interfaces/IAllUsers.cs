using AEGEE_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AEGEE_MVC.Data.Interfaces
{
    interface IAllUsers
    {
        IEnumerable<User> AllUsers { get; }
        public void SetAge(User user, int age);
    }
}
