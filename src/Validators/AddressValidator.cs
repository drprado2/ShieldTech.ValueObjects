using FluentValidation;
using ShieldTech.MethodExtensions;
using ShieldTech.ValueObjects.ValueObjects;

namespace ShieldTech.ValueObjects.Validators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.City)
                .NotEmpty()
                .WithMessage("A cidade do endereço é de preenchimento obrigatório");

            RuleFor(x => x.District)
                .NotEmpty()
                .WithMessage("O bairro do endereço é de preenchimento obrigatório");

            RuleFor(x => x.District)
                .MaximumLength(120)
                .WithMessage("O bairro deve ter no máximo 120 caracteres");

            RuleFor(x => x.Number)
                .GreaterThan(0)
                .WithMessage("O número do endereço é de preenchimento obrigatório");

            RuleFor(x => x.Street)
                .NotEmpty()
                .WithMessage("O logradouro do endereço é de preenchimento obrigatório");

            RuleFor(x => x.Street)
                .MaximumLength(150)
                .WithMessage("O logradouro deve ter no máximo 150 caracteres");

            RuleFor(x => x.PostalCode)
                .NotEmpty()
                .WithMessage("O CEP do endereço é de preenchimento obrigatório");

            RuleFor(x => x.PostalCode)
                .Must(x => x.HasOnlyNumbers())
                .WithMessage("O CEP do endereço deve ser preenchido apenas com números");

            RuleFor(x => x.PostalCode)
                .Length(8)
                .WithMessage("O CEP do endereço deve possuir 8 dígitos");

            RuleFor(x => x.UF)
                .NotEmpty()
                .WithMessage("O estado é de preenchimento obrigatório");

            RuleFor(x => x.UF)
                .Length(2)
                .WithMessage("O estado deve possuir 2 dígitos");
        }
    }
}