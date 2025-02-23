using TableTogether.Domain.User;

namespace TableTogether.Application.Common.Interfaces.Persistence;

public interface IUserRespository
{
    User? GetByEmail(string email);
    void Add(User user);
}