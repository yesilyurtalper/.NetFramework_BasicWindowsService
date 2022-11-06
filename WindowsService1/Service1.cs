﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Console.WriteLine("onstart");
        }

        protected override void OnStop()
        {
            Console.WriteLine("Onstop");
        }

        internal void TestStartupAndStop()
        {
            string[] args = null;
            this.OnStart(args);
            Console.ReadLine();
            this.OnStop();
        }
    }
}
