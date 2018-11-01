using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class BaseDati : BaseDatiMariaDB
    {
    }



    public class BaseDatiException : Exception
    {
        public int ErrorCode = 0;

        public BaseDatiException() : base()
        {
        }

        public BaseDatiException(string message, int error_code) : base(message)
        {
            ErrorCode = error_code;
        }

        public BaseDatiException(string message, Exception inner, int error_code) : base(message, inner)
        {
            ErrorCode = error_code;
        }
    }
}
