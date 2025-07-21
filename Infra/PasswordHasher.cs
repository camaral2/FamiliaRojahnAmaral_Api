namespace FamiliaRojahnAmaral_Api.Infra;

using BCrypt.Net;

public static class PasswordHasher
{
    // Hash a password
    public static string HashPassword(string password)
    {
        return BCrypt.HashPassword(password);
    }

    // Verify password
    public static bool Verify(string plainPassword, string hashedPassword)
    {
        return BCrypt.Verify(plainPassword, hashedPassword);
    }
}
