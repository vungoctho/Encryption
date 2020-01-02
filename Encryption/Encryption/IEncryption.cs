using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    public interface IEncryption
    {
        string Decrypt(string text, string additionalKey);
        string Encrypt(string text, string additionalKey);
    }
}
