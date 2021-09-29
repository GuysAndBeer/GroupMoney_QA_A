using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMoney_QA_A.CustomException
{
    public class NoSuitableDriverFound : Exception
    {
        public NoSuitableDriverFound(string massage) : base(massage)
        {

        }
    }
}
