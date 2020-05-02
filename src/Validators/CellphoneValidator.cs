using FluentValidation;
using ShieldTech.MethodExtensions;
using ShieldTech.ValueObjects.ValueObjects;

namespace ShieldTech.ValueObjects.Validators
{
    public class CellphoneValidator : AbstractValidator<Cellphone>
    {
        public CellphoneValidator()
        {
            RuleFor(x => x.FullNumber)
                .Must(x => x.HasOnlyNumbers())
                .WithMessage("O telefone celular deve ser composto apenas de números");

            RuleFor(x => x.FullNumber)
                .NotEmpty()
                .MaximumLength(20)
                .WithMessage("O número do celular é de preenchimento obrigatório");

            RuleFor(x => x.DDD)
                .Length(2)
                .WithMessage("O DDD do celular deve possuir 2 dígitos");

            RuleFor(x => x.Number)
                .Length(8, 9)
                .WithMessage("O número de telefone do celular deve conter entre 8 e 9 dígitos");
        }
    }
}