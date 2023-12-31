using Organizarty.Adapters;

namespace Organizarty.Tests.src.Mock;

public class CryptographysMock : ICryptographys
{
    public byte[] GenenateSalt()
    {
        throw new NotImplementedException();
    }

    public (string HashedPassword, string Salt) Hash(string password, byte[] salt)
    {
        throw new NotImplementedException();
    }

    public (string HashedPassword, string Salt) HashPassword(string password)
    => (password, "Some salt");

    public bool VerifyPassword(string password, string storedHashedPassword, string storedSalt){
      return password == storedHashedPassword;
    }
}
