using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace txtFiletoUI
{
    internal class UserFileReader
    {
        public string filePath;

        public UserFileReader(string p_filePath)
        {
            filePath = p_filePath;
        }


        //Methods
        public string readfile()
        {
            string data;
            StreamReader reader= null;
            reader  = new StreamReader(filePath);
            data = reader.ReadToEnd();
            Console.WriteLine(data);
            reader.Close();
            return data;
        }
    }
}
