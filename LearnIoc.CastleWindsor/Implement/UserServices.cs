using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnLoc.CastleWindsor.Interfaces;

namespace LearnLoc.CastleWindsor.Implement
{
    class UserServices : IUserServices
    {
        public string GetUserName(string id)
        {
            return id + "的UserName为张三";
        }
    }
}
