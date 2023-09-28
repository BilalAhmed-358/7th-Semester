using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.XPath;

namespace XMLParser3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            XPathDocument xpd = new XPathDocument(@"D:\IPT Material\IPT 2021-Shared\Lectures\Week04\Code\Week04-XML\InputFiles\IPT_Week04\example1.xml");
            XPathNavigator xpn = xpd.CreateNavigator();
            XPathNodeIterator xpi = xpn.Select("/suite/testcase");

            while (xpi.MoveNext()) // each testcase node
            {
                TestCase tc = new TestCase();
                tc.id = xpi.Current.GetAttribute("id", xpn.NamespaceURI);
                tc.kind = xpi.Current.GetAttribute("kind", xpn.NamespaceURI);

                XPathNodeIterator tcChild = xpi.Current.SelectChildren(XPathNodeType.Element);
                while (tcChild.MoveNext()) // each part (<inputs> and <expected>) of <testcase>
                {
                    if (tcChild.Current.Name == "inputs")
                    {
                        XPathNodeIterator tcSubChild = tcChild.Current.SelectChildren(XPathNodeType.Element);
                        while (tcSubChild.MoveNext()) // each part (<arg1>, <arg2>) of <inputs>
                        {
                            if (tcSubChild.Current.Name == "arg1")
                                tc.arg1 = tcSubChild.Current.Value;
                            else if (tcSubChild.Current.Name == "arg2")
                                tc.arg2 = tcSubChild.Current.Value;
                        }
                    }
                    else if (tcChild.Current.Name == "expected")
                        tc.expected = tcChild.Current.Value;
                }
                txtMessage.Text += tc.ToString() + Environment.NewLine;

            }
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
