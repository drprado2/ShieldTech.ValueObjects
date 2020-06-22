using System.Linq;
using FluentValidation.Results;
using ShieldTech.ValueObjects.Validators;

namespace ShieldTech.ValueObjects.ValueObjects
{
    public class BankInformation : BaseValueObject
    {
        private bool _isValid;
        public string BankName { get; set; }
        public string BankAgency { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankAccountDigit { get; set; }
        public string BankAccountCnpj { get; set; }

        public override bool IsValid => _isValid;

        public override ValidationResult Validate()
        {
            var result = new BankInformationValidator().Validate(this);
            _isValid = result.IsValid;
            return new ValidationResult(result.Errors);
        }
    }
}