using FluentValidation;
using ShieldTech.ValueObjects.ValueObjects;

namespace ShieldTech.ValueObjects.Validators
{
    public class EmailValidator : AbstractValidator<Email>
    {
        public EmailValidator()
        {
            RuleFor(x => x.Value)
                .NotEmpty()
                .EmailAddress()
                .WithMessage("O e-mail não é válido");
        }
    }
}