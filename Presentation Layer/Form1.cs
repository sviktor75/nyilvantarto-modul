using BusinessLayer;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Serilog.Sinks.File;
using LiteDB;
using Common;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        // switch between MySQL or LiteDB
        private readonly bool isMySQL = false;

        private FrameWork frameWork;

        public Form1()
        {
            FactorySupport factorySupport = new FactorySupport();
            Log.Logger = new LoggerConfiguration().WriteTo.File(@"C:\Log\Log.txt", rollingInterval: RollingInterval.Hour).CreateLogger();
            Directory.CreateDirectory(@"C:\db");
            LiteRepository repo = new LiteRepository(ApplicationConfig.DbConnectionString);

            frameWork = factorySupport.Create(isMySQL, repo);
            
            InitializeComponent();
        }
    }
}
