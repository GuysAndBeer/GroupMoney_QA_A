using GroupMoney_QA_A.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMoney_QA_A.Interfaces
{
    public interface IConfig
    {
        BrowserType GetWebDriver();
        string GetUsername();
        string GetPassword();
        string GetWebSite();
        double GetPageLoadTimeout();
        double GetImplicitlyWait();
    }
}
