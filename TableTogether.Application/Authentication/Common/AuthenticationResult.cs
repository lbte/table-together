using TableTogether.Domain.User;

namespace TableTogether.Application.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token
);