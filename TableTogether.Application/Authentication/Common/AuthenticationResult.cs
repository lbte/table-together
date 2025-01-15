using TableTogether.Domain.Entities;

namespace TableTogether.Application.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token
);