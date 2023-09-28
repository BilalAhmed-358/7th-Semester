using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace XMLReader2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            XmlDocument xd = new XmlDocument();
            xd.Load(@"D:\IPT Material\IPT 2021-Shared\Lectures\Week04\Code\Week04-XML\InputFiles\IPT_Week04\example1.xml");

            XmlNodeList nodelist = xd.SelectNodes("/suite/testcase"); // get all <testcase> nodes

            foreach (XmlNode node in nodelist) // for each <testcase> node
            {
                TestCase tc = new TestCase();

                tc.id = node.Attributes.GetNamedItem("id").Value;
                tc.kind = node.Attributes.GetNamedItem("kind").Value;

                XmlNode n = node.SelectSingleNode("inputs"); // get the one <input> node
                tc.arg1 = n.ChildNodes.Item(0).InnerText;
                tc.arg2 = n.ChildNodes.Item(1).InnerText;

                tc.expected = node.ChildNodes.Item(1).InnerText;

                txtMessage.Text += tc.ToString() + Environment.NewLine;
            } // foreach <testcase> node
        }
    }
}
