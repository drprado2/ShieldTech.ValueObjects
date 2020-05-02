using FluentValidation.Results;

namespace ShieldTech.ValueObjects.ValueObjects
{
    public abstract class BaseValueObject
    {
        public abstract bool IsValid { get; }
        public abstract ValidationResult Validate();
    }
}