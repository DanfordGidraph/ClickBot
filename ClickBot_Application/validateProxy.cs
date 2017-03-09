using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClickBot_Application
{
    class validateProxy
    {

        List<string> new_proxies = new List<string> { };
        foreach(string proxy in proxies)
        {
            char[] myChar = { '~','@','#','$','%','^','&','(',')','!', 'A', 'B', 'C', 'D', 'E', 'F', 'G',
                              'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
                              'W', 'X', 'Y', 'Z', '-', '+', ' ',';','>','<','/','?',',',']','[','{','}',
                               '|'};

        string newString = proxy.Trim(myChar);
        new_proxies.Add(newString);
            //MessageBox.Show(newString);
        }
    File.WriteAllLines(@"proxies/new_proxies.txt", new_proxies);
    }
}
