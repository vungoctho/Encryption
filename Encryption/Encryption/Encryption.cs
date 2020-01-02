using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    public class Encryption : IEncryption
    {
        private const string key = "1B3588DD-F0FE-4172-9A30-BCA73EB8FCD6";

        public string Decrypt(string encryptedText, string additionalKey)
        {
            return Cipher.Decrypt(encryptedText, key + additionalKey);
        }

        public string Encrypt(string text, string additionalKey)
        {
            return Cipher.Encrypt(text, key + additionalKey);
        }
    }
}
