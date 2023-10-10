using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.ServiceProcess;
using System.Text;
using System.Timers;

namespace MyFirstWindowsService
{
    public partial class TestService : ServiceBase
    {
        System.Timers.Timer timeDelay;
        int count;
        public TestService()
        {
            InitializeComponent();
            timeDelay = new System.Timers.Timer();
            timeDelay.Elapsed += new System.Timers.ElapsedEventHandler(WorkProcess);
            timeDelay.Interval = 1000;
        }

        private void WorkProcess(object sender, ElapsedEventArgs e)
        {
            string process = "Timer Tick " + count;
            LogService(process);
            count++;
        }

        protected override void OnStart(string[] args)
        {
            LogService("Service is Started");
            timeDelay.Enabled = true;
        }

        protected override void OnStop()
        {
            LogService("Service Stoped");
            timeDelay.Enabled = false;
        }

        private void LogService(string content)
        {
            //Folder Must Exists
            FileStream fs = new FileStream(@"C: \Users\Bilal\Desktop\IPT Lab 04\WindowsService\WindowsService\Code1 - WindowService\MyFirstWindowsService\MyFirstWindowsService\bin\Debug\log.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine(content);
            sw.Flush();
            sw.Close();
        }

    }
}
