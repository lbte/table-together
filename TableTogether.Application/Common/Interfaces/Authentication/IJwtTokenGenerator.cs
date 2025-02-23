using TableTogether.Domain.User;

namespace TableTogether.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}