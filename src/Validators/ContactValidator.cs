﻿using FluentValidation;
using ShieldTech.ValueObjects.ValueObjects;

namespace ShieldTech.ValueObjects.Validators
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.ContactEmailObj).SetValidator(new EmailValidator());
            RuleFor(x => x.ContactCellphoneObj).SetValidator(new CellphoneValidator());
            RuleFor(x => x.ContactName).NotNull().NotEmpty().WithMessage("O nome do contato é de preenchimento obrigatório");
            RuleFor(x => x.ContactName).MaximumLength(200).WithMessage("O nome do contato deve ter no máximo 200 caracteres");
        }
    }
}