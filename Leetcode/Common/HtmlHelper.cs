using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class HtmlHelper
    {
        public static string GetResponseString(string urlstr)
        {
            string htmlstr=string.Empty;
            try
            {
                HttpWebRequest hrq = (HttpWebRequest) WebRequest.Create(urlstr);
                hrq.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.181 Safari/537.36";
                WebRequest wr = (WebRequest)hrq;
                wr.Proxy = null;
                WebResponse response = hrq.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                htmlstr = sr.ReadToEnd();
            }
            catch (Exception)
            {
                
            }
            finally
            {
            }

            return htmlstr;
        }
    }
}
