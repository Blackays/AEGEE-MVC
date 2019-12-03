using AEGEE_MVC.Data.Interfaces;
using AEGEE_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AEGEE_MVC.Data.Repository
{
    public class DescriptionsRepository : IAllDesc
    {
        private readonly AppDBContent appDBContent;
        public DescriptionsRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public List<Descriptions> GetAllDescOfUser(int userCharacterId) => appDBContent.Descriptions.Where(i => i.UserCharacterId.UserId == userCharacterId).ToList();
    }
}
