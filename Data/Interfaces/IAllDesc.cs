using AEGEE_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AEGEE_MVC.Data.Interfaces
{
    public interface IAllDesc
    {
        public List<Descriptions> GetAllDescOfUser(int userCharacterId);


    }
}
