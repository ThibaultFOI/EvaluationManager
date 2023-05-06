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
    public partial class Form1 : Form
    {


        public Form1()
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
                UserFormInfo forminfo = new UserFormInfo(parser.stringParser(filereader.readfile()));
                UserDisplayer displayer = new UserDisplayer();
                displayer.DisplayInfo(this,forminfo);

            }
        }
    }
}
