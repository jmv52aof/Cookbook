namespace Cookbook.Helpers;

using Microsoft.IdentityModel.Tokens;
using System.Text;

public static class AuthOptions
{
    public const string ISSUER = "CookbookServer"; // издатель
    public const string AUDIENCE = "CookbookClient"; // потребитель
    const string KEY = "ed4fM!H4ed4fM!H4"; // ключ шифрования
    public const int LIFETIME = 7 * 24 * 60; // время жизни, минуты
    public static SymmetricSecurityKey GetSymmetricSecurityKey()
    {
        return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
    }
}
