using System;
using Microsoft.IdentityModel.Tokens;

namespace Shared.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSigninCredentialsHelper(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
        }
    }
}

