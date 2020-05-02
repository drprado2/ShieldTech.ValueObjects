using FluentValidation.Results;
using ShieldTech.ValueObjects.Validators;

namespace ShieldTech.ValueObjects.ValueObjects
{
    public class Email : BaseValueObject
    {
        private bool _isValid;

        public Email(string value)
        {
            Value = value;
        }

        public string Value { get; set; }

        public override bool IsValid => _isValid;

        public override ValidationResult Validate()
        {
            var result = new EmailValidator().Validate(this);
            _isValid = result.IsValid;
            return result;
        }
    }
}