using FluentValidation.Results;
using ShieldTech.ValueObjects.Validators;

namespace ShieldTech.ValueObjects.ValueObjects
{
    public class Contact : BaseValueObject
    {
        private bool _isValid;
        public string ContactName { get; set; }
        public string ContactCellphone { get; set; }
        public string ContactEmail { get; set; }
        public Email ContactEmailObj => new Email(ContactEmail);
        public Cellphone ContactCellphoneObj => new Cellphone(ContactCellphone);

        public override bool IsValid => _isValid;

        public override ValidationResult Validate()
        {
            var result = new ContactValidator().Validate(this);
            _isValid = result.IsValid;
            return result;
        }
    }
}