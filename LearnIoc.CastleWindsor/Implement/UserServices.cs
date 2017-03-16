using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnIoc.CastleWindsor.Interfaces;

namespace LearnIoc.CastleWindsor.Implement
{
    public class UserTestServices : IUserServices
    {
        public string GetUserName(string id)
        {
            return id + "UserTestServices的UserName为张三";
        }
    }

    public class UserServices : IUserServices
    {
        public string GetUserName(string id)
        {
            return id + "UserServices的UserName为张三";
        }
    }

    
}
