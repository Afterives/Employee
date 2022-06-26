using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employee.Authentication
{
    public class UserAccountService
    {
        private List<UserAccount> _users;

        public UserAccountService()
        {
            _users = new List<UserAccount>
            {
                new UserAccount{ UserName = "admin", Password = "admin", Role = "Administrator"},
                new UserAccount{ UserName = "user", Password = "user", Role = "User"},
                new UserAccount{ UserName = "Przemysław", Password = "przemek123", Role = "Administrator"}
            };
        }

        public UserAccount? GetByUserName(string userName)
        {
            return _users.FirstOrDefault(x => x.UserName == userName);
        }
    }
}
