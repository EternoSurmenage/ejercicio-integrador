using System;

namespace ArticlesAPI.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string msg)
            : base(msg) { }

        public BadRequestException(string msg, Exception ex)
            : base(msg, ex) { }
    }
}