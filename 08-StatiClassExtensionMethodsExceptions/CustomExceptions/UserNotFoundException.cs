using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions.CustomExceptions
{
    internal class UserNotFoundException : Exception
    {
        public UserNotFoundException() : base("ERROR: Bele bir istifadeci tapilmadi.") { }
        public UserNotFoundException(string username) : base($"ERROR: '{username}' adli istifadeci sistemde yoxdur.") { }
    }
}

