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
            string[] de = new string[9];
            string[] lines = text.Split('\n');
            foreach (string line in lines)
            {
                string[] parts = line.Split('=');
                if(parts.Length == 2)
                {
                    string value = parts[1].Trim();
                    de.Append(value);
                    Console.WriteLine(value);
                }

            }
            return de;
        }
    }
}
