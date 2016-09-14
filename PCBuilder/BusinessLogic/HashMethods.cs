using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BusinessLogic
{
    /// <summary>
    /// Hash method class containing the Sha256 hashing method.
    /// </summary>
    public static class HashMethods
    {
        /// <summary>
        /// Hashes the passed value.
        /// </summary>
        /// <param name="source">The value to be hashed.</param>
        /// <returns>String of the hashed value.</returns>
        public static string HashSha256(this string source)
        {
            byte[] data;

            using (SHA256 sha256hash = SHA256.Create())
            {
                data = sha256hash.ComputeHash(Encoding.UTF8.GetBytes(source));
            }

            var s = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                s.Append(data[i].ToString("x2"));
            }

            return s.ToString();
        }

        /// <summary>
        /// Verifies the sha256 hash.
        /// </summary>
        /// <param name="compareString">The compare string.</param>
        /// <param name="hashString">The hash string.</param>
        /// <returns>Boolean value of the result of the comparison.</returns>
        public static bool VerifySha256Hash(this string compareString, string hashString)
        {
            var c = StringComparer.OrdinalIgnoreCase;

            return (0 == c.Compare(compareString.HashSha256(), hashString));
        }
    }
}
