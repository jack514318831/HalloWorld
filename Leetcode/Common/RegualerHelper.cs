using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common
{
    public class RegualerHelper
    {
        public static string GetAllMatches(string inputstr, string pattern)
        {
            StringBuilder sb = new StringBuilder();
            MatchCollection mtc = Regex.Matches(inputstr, pattern);
            foreach (Match item in mtc)
            {
                sb.Append(item.ToString());
                sb.AppendLine();
            }
            return sb.ToString();
        }

        //Get Content
        public static string GetContent(string inputstr)
        {
            string pattern = "(?<=<meta name=\"description\" content=)(.|\\n)*?(?=/>)";
            StringBuilder sb = new StringBuilder();
            MatchCollection mtc = Regex.Matches(inputstr, pattern);
            foreach (Match item in mtc)
            {
                sb.Append(item.ToString());
                sb.AppendLine();
            }
            return sb.ToString();
        }

        //Get Title
        public static string GetTitle(string inputstr)
        {
            string pattern = "(?<=<title>)(.|\\n)*?(?=</title>)";
            StringBuilder sb = new StringBuilder();
            MatchCollection mtc = Regex.Matches(inputstr, pattern);
            foreach (Match item in mtc)
            {
                sb.Append(item.ToString());
                sb.AppendLine();
            }
            return sb.ToString();
        }

        //Get Solution

        public static string GetSolution(string inputstr)
        {
            string pattern = "(?<=<div class=\"article-title\">)(.|\\n)*?(?=Rate this article)";
            StringBuilder sb = new StringBuilder();
            MatchCollection mtc = Regex.Matches(inputstr, pattern);
            foreach (Match item in mtc)
            {
                sb.Append(item.ToString());
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
