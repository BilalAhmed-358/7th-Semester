using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml;
using System.Xml.Serialization;

namespace MySecondService
{
    public partial class SR2 : ServiceBase
    {
        Timer timeDelay;
        public SR2()
        {
            InitializeComponent();
            timeDelay = new Timer();
            timeDelay.Interval = 3000;
            timeDelay.Elapsed += new System.Timers.ElapsedEventHandler(WorkProcess);
        }

        private void WorkProcess(object sender, ElapsedEventArgs e)
        {
            // Folders should exsist
            string dirPath = @"C:\IPT-Folders\IPT_Week04\ServiceFiles";
            ProcessDirectory(dirPath);
           
        }

        public static void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);
        }

        // Insert logic for processing found files here.
        public static void ProcessFile(string path)
        {
            LogService("Reading File : " + path);
            StreamReader fs = new StreamReader(path);
            string tempLine = fs.ReadLine();
            fs.Close();
            SerializeData(tempLine);
            LogService("Deleting File : " + path);
            File.Delete(path);
            
        }

        protected override void OnStart(string[] args)
        {
            LogService("Service Starting");
            timeDelay.Enabled = true;
        }

        protected override void OnStop()
        {
            LogService("Service Stoping");
            timeDelay.Enabled = false;
        }

        private static void LogService(string content)
        {
            FileStream fs = new FileStream(@"C:\IPT-Folders\IPT_Week04\log.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine(content);
            sw.Flush();
            sw.Close();
        }

        public static Course ConvertToCourse(string text)
        {
            char[] delim = { ',' };
            string[] tempArray = text.Split(delim);
            return new Course(tempArray[0], tempArray[1]);
        }

        public static void SerializeData(string text)
        {
            Course courseObj = ConvertToCourse(text);

            XmlSerializer ser = new XmlSerializer(typeof(Course));
            TextWriter writer = new StreamWriter(@"C:\IPT-Folders\IPT_Week04\ServiceWrites\EmployeeInfo.xml", true);
            ser.Serialize(writer, courseObj);
            writer.Close();
        }
    }
}
