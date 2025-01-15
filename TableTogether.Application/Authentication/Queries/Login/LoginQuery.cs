using ErrorOr;
using MediatR;
using TableTogether.Application.Authentication.Common;

namespace TableTogether.Application.Authentication.Queries.Login;

// Encapsulates the data needed to execute the command
public record LoginQuery(
    string Email,
    string Password
) : IRequest<ErrorOr<AuthenticationResult>>;