using ErrorOr;
using FluentValidation;
using MediatR;
using TableTogether.Application.Authentication.Commands.Register;
using TableTogether.Application.Authentication.Common;

namespace TableTogether.Application.Common.Behaviors;

public class ValidationBehavior(IValidator<RegisterCommand> validator) : 
IPipelineBehavior<RegisterCommand, ErrorOr<AuthenticationResult>>
{
    private readonly IValidator<RegisterCommand> _validator = validator;

    public async Task<ErrorOr<AuthenticationResult>> Handle(
        RegisterCommand request,
        RequestHandlerDelegate<ErrorOr<AuthenticationResult>> next,
        CancellationToken cancellationToken)
    {
        // before the handler
        var validationResult = await _validator.ValidateAsync(request, cancellationToken);

        if (validationResult.IsValid)
        {
            return await next(); // call the handler
        }

        var errors = validationResult.Errors
            .ConvertAll(validationFailure => Error.Validation(
                validationFailure.PropertyName,
                validationFailure.ErrorMessage));

        return errors;
    }
}