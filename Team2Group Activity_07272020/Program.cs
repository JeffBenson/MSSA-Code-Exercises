using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;


namespace Team2Group_Activity_07272020
{
    class Program
    {
        static void Main(string[] args)
        {
            



    namespace SwitchStatement
    {
        
        public sealed partial class MainPage : Page
        {
            public MainPage()
            {
                this.InitializeComponent();
            }

            private void copyClick(object sender, RoutedEventArgs e)
            {
                target.Text = "";
                string from = source.Text;
                for (int i = 0; i != from.Length; i++)
                {
                    char current = from[i];
                    copyOne(current);
                }
            }

            private void copyOne(char current)
            {
                switch (current)
                {
                    case '<':
                        target.Text += "&lt;";
                        break;
                    case '>':
                        target.Text += "&gt;";
                        break;
                    case '&':
                        target.Text += "&amp;";
                        break;
                    case '\"':
                        target.Text += "&#34;";
                        break;
                    case '\'':
                        target.Text += "&#39;";
                        break;
                    default:
                        target.Text += current;
                        break;
                }
            }
        }
    }

}
    }
}
