using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace XMLSerializer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Name = "Abeeha";
            emp.Location = "Karachi";
            emp.Division = "Faculty";

            XmlSerializer ser = new XmlSerializer(typeof(Employee));

            TextWriter writer = new StreamWriter(@"D:\IPT Material\IPT 2021-Shared\Lectures\Week04\Code\Week04-XML\InputFiles\IPT_Week04\example5.xml");
            ser.Serialize(writer, emp);
            writer.Close();
        }
    }
}
