using Keyyum.DAL;
using Keyyum.IBLL;
using Keyyum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyyum.BLL
{
    public class UserService:BaseService<User>,InterfaceUserService
    {
        public UserService() : base(RepositoryFactory.UserRepository) { }
        public bool Exist(string username)
        {
            throw new NotImplementedException();
        }

        public User Find(int userID)
        {
            throw new NotImplementedException();
        }

        public User Find(string userName)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> FindPageList(int pageIndex, int pageSize, out int totalRecord, int order)
        {
            throw new NotImplementedException();
        }
    }
}
