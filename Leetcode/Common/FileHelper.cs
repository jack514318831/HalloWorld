using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class FileHelper
    {
        public static string ReadText(string path)
        {
            string result = string.Empty;
            using (StreamReader sr = new StreamReader(path,Encoding.Default,false))
            {
                result = sr.ReadToEnd();
            }
            return result;
        }
    }
}
