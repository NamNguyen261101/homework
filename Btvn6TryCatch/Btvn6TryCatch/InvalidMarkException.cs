using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btvn6TryCatch
{
    public class InvalidMarkException : Exception 
    {
        public InvalidMarkException() : base("Hãy nhập 1 số > 0 bạn ơi")
        {
            
        }
    }
}
