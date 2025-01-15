using TableTogether.Domain.Entities;

namespace TableTogether.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}