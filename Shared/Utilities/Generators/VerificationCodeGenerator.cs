using System;
namespace Shared.Utilities.Generators
{
    public class VerificationCodeGenerator
    {
        public static string Generate()
        {
            var random = new Random();
            return random.Next(100000, 999999).ToString();
        }
    }
}

