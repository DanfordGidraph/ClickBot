using System;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ClickBot_Application
{
    public partial class mainForm : Form
    {
        
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            string firstProxyList = (@"proxies/testProxies.txt");

            VisitWebsite siteVisitor1 = new VisitWebsite(def_WebBrowser, firstProxyList);
            
            VisitWebsite siteVisitor2 = new VisitWebsite(sec_WebBrowser, firstProxyList);
        }

        
    }
    
}
