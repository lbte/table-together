using ErrorOr;
using MediatR;
using TableTogether.Application.Authentication.Common;

namespace TableTogether.Application.Authentication.Commands.Register;

// Encapsulates the data needed to execute the command
public record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password
) : IRequest<ErrorOr<AuthenticationResult>>;