using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Input;
using System.Runtime.InteropServices;


namespace PathConvert
{
    
    internal class Program
    {
        
       
        static void Main(string[] args)
        {
            string winPath = Console.ReadLine();
            Process p = new Process();
            p.StartInfo.FileName = "C:\\Windows\\system32\\cmd.exe";
            p.StartInfo.WorkingDirectory = @"" + winPath;
            p.Start();
        }
    }
}
