using System;

namespace Hospital.Common
{
    public class HospitalException : Exception
    {
        public HospitalException(string message) : base(message)
        {
        }
    }
}
