using FluentValidation.Results;
using ShieldTech.ValueObjects.Validators;

namespace ShieldTech.ValueObjects.ValueObjects
{
    public class Cellphone : BaseValueObject
    {
        private bool _isValid;

        public Cellphone(string value)
        {
            DDD = value.Substring(0, 2);
            Number = value.Substring(2);
            FullNumber = value;
        }

        public string DDD { get; }
        public string Number { get; }
        public string FullNumber { get; }

        public override bool IsValid => _isValid;

        public override ValidationResult Validate()
        {
            var result = new CellphoneValidator().Validate(this);
            _isValid = result.IsValid;
            return result;
        }
    }
}