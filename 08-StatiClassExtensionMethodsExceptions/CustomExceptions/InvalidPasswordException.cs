using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions.CustomExceptions
{
    internal class InvalidPasswordException : Exception
    {
        public InvalidPasswordException() : base("ERROR: Sifre bos ola bilmez ve ya 6 simvoldan az olmamalidir.") { }
        public InvalidPasswordException(string message) : base(message) { }
    }
}
