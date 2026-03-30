using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions.CustomExceptions
{
    internal class IncorrectPasswordException : Exception
    {
        public int AttemptsLeft { get; set; }
        public IncorrectPasswordException(int attemptsLeft)
            : base($"WARNING: Sifre sehvdir! Qalan cehd sayiniz: {attemptsLeft}")
        {
            AttemptsLeft = attemptsLeft;
        }
    }
}
