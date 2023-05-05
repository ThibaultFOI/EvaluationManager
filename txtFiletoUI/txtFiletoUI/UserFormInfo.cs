using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace txtFiletoUI
{
    public partial class UserFormInfo : Form
    {


        public UserFormInfo()
        {
            InitializeComponent();
        }


        private void btnLoadUserInfo_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)| *.txt";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                UserFileReader filereader = new UserFileReader(ofd.FileName);
                UserFileParser parser = new UserFileParser();
                parser.stringParser(filereader.readfile());
            }
        }
    }
}
