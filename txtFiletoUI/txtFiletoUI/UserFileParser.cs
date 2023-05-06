using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace txtFiletoUI
{
    internal class UserFileParser
    {
        public string[] stringParser(string text)
        {
            List<string> de_list = new List<string>(); 
            string[] lines = text.Split('\n');

            foreach (string line in lines)
            {
                string[] parts = line.Split('=');
                if(parts.Length == 2)
                {
                    string value = parts[1].Trim();
                    de_list.Add(value);
                    
                }

            }
            return de_list.ToArray();
        }
    }
}
