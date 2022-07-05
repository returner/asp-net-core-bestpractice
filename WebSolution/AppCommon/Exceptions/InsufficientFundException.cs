using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCommon.Exceptions
{
    public class InsufficientFundException : Exception
    {
        public decimal PayableBalance { get; }
        public decimal NeedBalance { get; }
        public InsufficientFundException(decimal payableBalance, decimal needBalance)
        {
            PayableBalance = payableBalance;
            NeedBalance = needBalance;
        }
    }
}
