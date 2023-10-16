using FluentValidation;

namespace Application.Process.Info.Commands.CreateInfo.v1;

public class CreateInfoCommandValidator : AbstractValidator<CreateInfoCommand>
{
    public CreateInfoCommandValidator()
    {
        RuleFor(r => r.Name)
        .NotEmpty()
        .NotNull();
    }
}
