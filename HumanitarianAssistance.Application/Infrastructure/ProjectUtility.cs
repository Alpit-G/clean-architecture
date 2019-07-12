using System;
using System.Collections.Generic;
using System.Text;

namespace HumanitarianAssistance.Application.Infrastructure
{
    public static class ProjectUtility
    {
        public static string getClientCode(this string ClientId)
        {
            string code = string.Empty;
            if (ClientId.Length == 1)
                return code = "0000" + ClientId;
            else if (ClientId.Length == 2)
                return code = "000" + ClientId;
            else if (ClientId.Length == 3)
                return code = "00" + ClientId;
            else if (ClientId.Length == 4)
                return code = "0" + ClientId;
            else
                return code = "" + ClientId;
        }
    }
}
