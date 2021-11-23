using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMoney_QA_A.CustomException
{
    public class NoSuchPageFound : Exception
    {
        public NoSuchPageFound(string massage) : base(massage)
        {

        }
    }
}
