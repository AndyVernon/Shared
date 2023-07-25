using Shared.User.Example.Interfaces;

namespace Shared.User.Example.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        internal UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool IsValidUsername(string username)
        {
            return _userRepository.IsValidUsername(username);
        }
    }
}
