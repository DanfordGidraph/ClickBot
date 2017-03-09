using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace ClickBot_Application
{
    class VisitWebsite
    {
        [DllImport("wininet.dll", SetLastError = true)]
        private static extern bool InternetSetOption(IntPtr hInternet, int dwOption,
            IntPtr lpBuffer, int lpdwBufferLength);
        private Guid IID_IAuthenticate = new Guid("79eac9d0-baf9-11ce-8c82-00aa004ba90b");
        private const int INET_E_DEFAULT_ACTION = unchecked((int)0x800C0011);
        private const int S_OK = unchecked((int)0x00000000);
        private const int INTERNET_OPTION_PROXY = 38;
        private const int INTERNET_OPEN_TYPE_DIRECT = 1;
        private const int INTERNET_OPEN_TYPE_PROXY = 3;
       

        public struct INTERNET_PROXY_INFO
        {
            public int dwAccessType;
            public IntPtr proxy;
            public IntPtr proxyBypass;
        }
        public VisitWebsite(WebBrowser browser, string proxyPath)
        {
            browser.Navigate("about:blank");
            object obj = browser.ActiveXInstance;
                       
            string[] proxies = File.ReadAllLines(proxyPath);
            foreach (string proxy in proxies)
            {
                SetProxyServer(proxy);

                try
                {
                   // browser.Navigate("about:blank");
                    //Application.DoEvents();

                    //browser.Navigate("http://google.com");
                    browser.Navigate("http://www.showmyip.co.uk/");
                    //Thread.Sleep(10000);
                    //Application.DoEvents();
                   if(browser.StatusText != "Done" || browser.Document.Body.InnerText == null)
                   {
                        MessageBox.Show("The Current IP is {0}",proxy);
                        Application.DoEvents();
                   }

                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }


                //MessageBox.Show(browser.Document.Body.InnerText.Trim());
            }
        }

        private void SetProxyServer(string proxy)
        {
            //Create structure
            INTERNET_PROXY_INFO proxyInfo = new INTERNET_PROXY_INFO();

            if (proxy == null)
            {
                proxyInfo.dwAccessType = INTERNET_OPEN_TYPE_DIRECT;
            }
            else
            {
                proxyInfo.dwAccessType = INTERNET_OPEN_TYPE_PROXY;
                proxyInfo.proxy = Marshal.StringToHGlobalAnsi(proxy);
                proxyInfo.proxyBypass = Marshal.StringToHGlobalAnsi("local");
            }

            // Allocate memory
            IntPtr proxyInfoPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(proxyInfo));

            // Convert structure to IntPtr
            Marshal.StructureToPtr(proxyInfo, proxyInfoPtr, true);
            bool returnValue = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_PROXY,
                proxyInfoPtr, Marshal.SizeOf(proxyInfo));
        }
    }
        
}
