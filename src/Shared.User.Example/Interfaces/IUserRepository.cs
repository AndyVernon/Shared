namespace Shared.User.Example.Interfaces
{
    internal interface IUserRepository
    {
        bool IsValidUsername(string username);
    }
}
