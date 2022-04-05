using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patten
{
    public class UserRegistractionException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            Invalid
        }
        public UserRegistractionException(ExceptionType type, string Message) : base(Message)
        {
            this.type = type;
        }
    }
}
