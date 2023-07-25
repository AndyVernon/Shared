using Shared.User.Example.Interfaces;

namespace Shared.User.Example.Repositories
{
    internal class UserRepository : IUserRepository
    {
        private List<string> _userNames;
        
        public UserRepository() 
        {
            _userNames = GetUsernames();
        }

        bool IUserRepository.IsValidUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return false;
            }

            var isValidUserName = _userNames.Contains(username, StringComparer.InvariantCultureIgnoreCase);
            return isValidUserName;
        }

        private List<string> GetUsernames()
        {
            List<string> users = new List<string>();
            for (int i = 1; i < 4; i++)
            {
                users.Add($"User {i}");
            }

            return users;
        }


    }
}
