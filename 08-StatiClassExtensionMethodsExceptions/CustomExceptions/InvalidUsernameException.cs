using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions.CustomExceptions
{
    internal class InvalidUsernameException : Exception
    {
        public InvalidUsernameException() : base("ERROR: Username bos ola bilmez ve ya 3 simvoldan az olmamalidir.") { }
        public InvalidUsernameException(string message) : base(message) { }
    }
}
