using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Middleware.Exceptions
{
    public class Exception1 : ExceptionTemplate
    {
        public Exception1() : base("Exception1")
        {
            HttpResponse = 401;
        }
    }
}
