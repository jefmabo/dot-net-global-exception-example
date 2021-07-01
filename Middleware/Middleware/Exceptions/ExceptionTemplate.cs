using System;

namespace Api.Middleware.Exceptions
{
    public class ExceptionTemplate : Exception
    {
        public int HttpResponse;
        public ExceptionTemplate(string message) : base(message) { }
    }
}
