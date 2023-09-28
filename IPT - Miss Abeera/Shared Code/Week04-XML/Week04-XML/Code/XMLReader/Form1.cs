using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace XMLReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            bool flag = false;
            XmlReader Reader = new XmlTextReader(@"D:\IPT Material\IPT 2021-Shared\Lectures\Week04\Code\Week04-XML\InputFiles\IPT_Week04\example1.xml");

            while (!Reader.EOF) //load loop
            {
                if (Reader.Name == "suite" && !Reader.IsStartElement()) break;

                while (Reader.Name != "testcase" || !Reader.IsStartElement())
                {
                    if (Reader.EOF == true)
                    {
                        flag = true;
                        break;
                    }
                    Reader.Read(); // advance to <testcase> tag
                }
                if (flag) break ;
                TestCase tc = new TestCase();
                tc.id = Reader.GetAttribute("id");
                tc.kind = Reader.GetAttribute("kind");
                Reader.Read();
                Reader.Read(); // advance to <inputs> tag
                Reader.Read(); // advance to <arg1> tag
                
                tc.arg1 = Reader.ReadElementString("arg1"); // consumes the </arg1> tag
                tc.arg2 = Reader.ReadElementString("arg2"); // consumes the </arg2> tag
                
                Reader.Read();
                Reader.Read(); // advance to <expected> tag
                tc.expected = Reader.ReadElementString("expected"); // consumes the </expected> tag
               
                //                                                 // we are now at an </testcase> tag
                // s.items.Add(tc);
                txtMessage.Text+= tc.ToString() + Environment.NewLine;
                Reader.Read(); // and now either at <testcase> tag or </suite> tag
            } 

        }
    }
}
