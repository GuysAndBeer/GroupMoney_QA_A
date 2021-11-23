using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMoney_QA_A.Attributes
{
    public class AliasAttribute : Attribute
    {
        public string Alias { get; set; }

        public AliasAttribute()
        { }

        public AliasAttribute(string alias)
        {
            Alias = alias;
        }
    }
}
