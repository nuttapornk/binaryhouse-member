using Application.Common.Interfaces.Repositories;
using FluentValidation;

namespace Application.Process.Registers.Commands.Register.v1;

public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{

    public RegisterCommandValidator(IMemberRepository memberRepository)
    {
        RuleFor(r => r.InfoName)
        .NotNull()
        .NotEmpty()
        .MaximumLength(100);

        RuleFor(r => r.Email)
        .NotNull()
        .NotEmpty()
        .MaximumLength(100)
        .EmailAddress()
        .MustAsync(memberRepository.IsEmailEmpty).WithMessage("This email is already in use");
    }
}
