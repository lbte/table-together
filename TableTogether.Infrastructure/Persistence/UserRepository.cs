using TableTogether.Application.Common.Interfaces.Persistence;
using TableTogether.Domain.Entities;

namespace TableTogether.Infrastructure.Persistence;

public class UserRepository : IUserRespository
{

    //temporary inmemory implementation
    private static readonly List<User> _users = new();
    public void Add(User user)
    {
        _users.Add(user);
    }

    public User? GetByEmail(string email)
    {
        return  _users.SingleOrDefault(u => u.Email == email);
    }
}