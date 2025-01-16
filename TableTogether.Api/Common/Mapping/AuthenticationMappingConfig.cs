using Mapster;
using TableTogether.Application.Authentication.Commands.Register;
using TableTogether.Application.Authentication.Common;
using TableTogether.Application.Authentication.Queries.Login;
using TableTogether.Contracts.Authentication;

namespace TableTogether.Api.Common.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, RegisterCommand>();
        
        config.NewConfig<LoginRequest, LoginQuery>();

        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            .Map(dest => dest, src => src.User);
    }
}