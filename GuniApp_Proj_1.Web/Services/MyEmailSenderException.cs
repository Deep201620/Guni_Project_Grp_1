using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuniApp_Proj_1.Web.Services
{

    public class MyEmailSenderException : ApplicationException
    {

        private const String StandardErrorMessage
            = "Something went wrong While sending the email";

        public MyEmailSenderException(): base(StandardErrorMessage)
        {   }

        public MyEmailSenderException(string message) : base(message)
        {

        }

        public MyEmailSenderException(string message, Exception Innenrexception): 
            base(message, Innenrexception)
        {

        }
    }
}
