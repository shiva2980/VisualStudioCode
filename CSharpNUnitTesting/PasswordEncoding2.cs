using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests1
{
     class PasswordEncoding2
    {
        [Test]
        public void EncodingPasswordforemail()
        {
            string password = "Cooper@2021";

            var passwordInBytes = Encoding.UTF8.GetBytes(password);
            string encodepassword = Convert.ToBase64String(passwordInBytes);
            Console.WriteLine("Encoded pwd is: " + encodepassword);

            var encodepasswordinbytes = Convert.FromBase64String("Q29vcGVyQDIwMjE=");
            string decodepassword = Encoding.UTF8.GetString(encodepasswordinbytes);
            Console.WriteLine("Encoded pwd is: " + decodepassword);
        }
    }
}
