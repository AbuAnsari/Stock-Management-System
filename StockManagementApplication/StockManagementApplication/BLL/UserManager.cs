using StockManagementApplication.DAL;
using StockManagementApplication.Models;

namespace StockManagementApplication.BLL
{
    public class UserManager
    {
        readonly UserRepository _userRepository = new UserRepository();

        public bool Save(UserInfo user)
        {
            var save = _userRepository.Save(user);
            return save;
        }

        public bool IsUserNameExist(UserInfo user)
        {
            var isExist = _userRepository.IsUserNameExist(user);
            return isExist;
        }

        public bool Login(string userName, string password)
        {
            var login = _userRepository.Login(userName, password);
            return login;
        }
    }
}
