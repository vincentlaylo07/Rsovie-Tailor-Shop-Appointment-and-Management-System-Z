using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.Classes
{
    internal class PasswordManagerClass
    {
        public string HashPassword(string password)
        {
            // Generate a salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            // Hash the password with PBKDF2 and the salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20); // 20 is the size of the hash

            // Combine the salt and hash
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            // Convert to base64 string for storage
            string hashedPassword = Convert.ToBase64String(hashBytes);

            return hashedPassword;
        }

        public bool VerifyPassword(string userInput, string storedHashedPassword)
        {
            // Decode the stored hashed password
            byte[] decodedHashedPassword = Convert.FromBase64String(storedHashedPassword);

            // Extract the salt from the decoded stored hashed password
            byte[] salt = new byte[16];
            Array.Copy(decodedHashedPassword, 0, salt, 0, 16);

            // Compute the hash of the user input using the extracted salt
            var pbkdf2 = new Rfc2898DeriveBytes(userInput, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20); // 20 is the size of the hash

            // Compare the computed hash with the stored hash
            for (int i = 0; i < 20; i++)
            {
                if (decodedHashedPassword[i + 16] != hash[i])
                {
                    return false; // Passwords don't match
                }
            }
            return true; // Passwords match
        }
    }
}
