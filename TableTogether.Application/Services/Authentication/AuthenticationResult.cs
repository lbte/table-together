using TableTogether.Domain.Entities;

namespace TableTogether.Application.Services.Authentication;

public record AuthenticationResult(
    User User,
    string Token
);