using FluentValidation.Results;
using ShieldTech.ValueObjects.Validators;

namespace ShieldTech.ValueObjects.ValueObjects
{
    public class Cpf : BaseValueObject
    {
        private bool _isValid;

        public Cpf(string value)
        {
            Value = value ?? string.Empty;
        }

        public string Value { get; }

        public override bool IsValid => _isValid;

        public override ValidationResult Validate()
        {
            var result = new CpfValidator().Validate(this);
            _isValid = result.IsValid;
            return result;
        }
    }
}