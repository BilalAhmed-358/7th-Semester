using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace XMLReader4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            XslTransform myXslTransform;
            myXslTransform = new XslTransform();
            myXslTransform.Load(@"D:\IPT Material\IPT 2021-Shared\Lectures\Week04\Code\Week04-XML\InputFiles\IPT_Week04\example4.xsl");
            myXslTransform.Transform(@"D:\IPT Material\IPT 2021-Shared\Lectures\Week04\Code\Week04-XML\InputFiles\IPT_Week04\example4_output1.xml", @"D:\IPT Material\IPT 2021-Shared\Lectures\Week04\Code\Week04-XML\InputFiles\IPT_Week04\Example4_ouput2.html");
        }
    }
}
