using FluentValidation;
using ShieldTech.ValueObjects.ValueObjects;

namespace ShieldTech.ValueObjects.Validators
{
    public class BankInformationValidator : AbstractValidator<BankInformation>
    {
        public BankInformationValidator()
        {
            RuleFor(x => new Cnpj(x.BankAccountCnpj))
                .SetValidator(new CnpjValidator());
            
            RuleFor(x => x.BankAgency)
                .NotEmpty()
                .WithMessage("A agência bancária é de preenchimento obrigatório");

            RuleFor(x => x.BankAccountDigit)
                .NotEmpty()
                .WithMessage("O dígito da conta corrente é de preenchimento obrigatório");

            RuleFor(x => x.BankAccountNumber)
                .NotEmpty()
                .WithMessage("O número da conta corrente é de preenchimento obrigatório");

            RuleFor(x => x.BankName)
                .NotEmpty()
                .WithMessage("O nome do banco é de preenchimento obrigatório");
        }
    }
}