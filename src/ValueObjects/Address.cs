using FluentValidation.Results;
using ShieldTech.ValueObjects.Validators;

namespace ShieldTech.ValueObjects.ValueObjects
{
    public class Address : BaseValueObject
    {
        private bool _isValid;
        public string Country { get; set; }
        public string UF { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string Complement { get; set; }
        public int Number { get; set; }
        public string PostalCode { get; set; }

        public override bool IsValid => _isValid;

        public override ValidationResult Validate()
        {
            var result = new AddressValidator().Validate(this);
            _isValid = result.IsValid;
            return result;
        }
    }
}