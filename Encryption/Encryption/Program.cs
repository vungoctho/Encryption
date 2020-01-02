using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            IEncryption encrypt = new Encryption();
            var text = encrypt.Encrypt("Hello123*3", "Tho");

            Console.WriteLine(text);

            Console.WriteLine(encrypt.Decrypt(text, "Tho"));
            var a = Console.ReadLine();

             var b= encrypt.Encrypt(a, "Test");
            Console.WriteLine(b);
            Console.WriteLine(encrypt.Decrypt(b, "Test"));
            Console.ReadLine();
        }
    }
}
