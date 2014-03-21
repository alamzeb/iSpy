using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace iSpy
{
    public partial class iSpyDetector : ServiceBase
    {
        public iSpyDetector()
        {
            InitializeComponent();
        }
        public void onDebug()
        {
            OnStart(null);
        }
        protected override void OnStart(string[] args)
        {
            System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "Started.txt");
        }

        protected override void OnStop()
        {
            System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "Stoped.txt");
        }
    }
}
