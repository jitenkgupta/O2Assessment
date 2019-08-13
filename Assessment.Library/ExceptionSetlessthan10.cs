using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Library
{
    [Serializable]
    internal class ExceptionSetlessthan10 : Exception
    {
        public ExceptionSetlessthan10(string message) : base(message)
        {

        }

        public ExceptionSetlessthan10()
        {
        }

        public ExceptionSetlessthan10(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    [Serializable]
    internal class ExceptionPretestNotEqual4 : Exception
    {
        public ExceptionPretestNotEqual4(string message) : base(message)
        {

        }

        public ExceptionPretestNotEqual4()
        {
        }

        public ExceptionPretestNotEqual4(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    [Serializable]
    internal class ExceptionOperationalNotEqual6 : Exception
    {
        public ExceptionOperationalNotEqual6(string message) : base(message)
        {

        }

        public ExceptionOperationalNotEqual6()
        {
        }

        public ExceptionOperationalNotEqual6(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
