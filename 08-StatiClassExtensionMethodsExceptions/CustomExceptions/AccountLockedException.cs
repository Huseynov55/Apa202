using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions.CustomExceptions
{
    internal class AccountLockedException : Exception
    {
        public AccountLockedException() : base("CRITICAL: Hesabiniz çoxsayli uğursuz cehdlere gore bloklanib!") { }
    }
}
