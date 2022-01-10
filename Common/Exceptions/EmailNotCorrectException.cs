using System;

namespace ITDesigners.Infrastructure
{
    public class EmailNotCorrectException : Exception
    {
        public EmailNotCorrectException(string message) : base(message)
        {

        }
    }
}
