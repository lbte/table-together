using TableTogether.Application.Common.Interfaces.Authentication;

namespace TableTogether.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{

    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        // check if user already exists

        // generate unique id by creating the user
        Guid userId = Guid.NewGuid();

        // generate token
        var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);

        return new AuthenticationResult(
            userId, 
            firstName, 
            lastName, 
            email, 
            token);
    }

    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(), 
            "firstName", 
            "lastName", 
            email, 
            "token");
    }
}