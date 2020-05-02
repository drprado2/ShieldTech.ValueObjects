using System;
using ShieldTech.ValueObjects.Validators;

namespace ShieldTech.ValueObjects.ExtensionMethods
{
    public static class StringExtensions
    {
        public static bool IsValidCnpj(this String @string)
        {
            return CnpjValidator.IsValidCnpj(@string);
        }
        
        public static bool IsValidCpf(this String @string)
        {
            return CpfValidator.IsValidCpf(@string);
        }
    }
}