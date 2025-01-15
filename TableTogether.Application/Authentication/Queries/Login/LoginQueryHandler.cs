using ErrorOr;
using MediatR;
using TableTogether.Application.Authentication.Common;
using TableTogether.Application.Common.Interfaces.Authentication;
using TableTogether.Application.Common.Interfaces.Persistence;
using TableTogether.Domain.Common.Errors;
using TableTogether.Domain.Entities;

namespace TableTogether.Application.Authentication.Queries.Login;

public class LoginQueryHandler(
    IUserRespository userRepository,
    IJwtTokenGenerator jwtTokenGenerator) :
    IRequestHandler<LoginQuery, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator = jwtTokenGenerator;
    private readonly IUserRespository _userRepository = userRepository;

    public async Task<ErrorOr<AuthenticationResult>> Handle(LoginQuery query, CancellationToken cancellationToken)
    {
        if (_userRepository.GetByEmail(query.Email) is not User user)
        {
            return Errors.Authentication.InvalidCredentials;
        }

        if (user.Password != query.Password)
        {
            return Errors.Authentication.InvalidCredentials;
        }

        var token = _jwtTokenGenerator.GenerateToken(user);
        return new AuthenticationResult(
            user, 
            token);
    }
}