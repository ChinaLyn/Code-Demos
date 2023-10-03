using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 框架搭建演示
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.Desktop);
            Application.Run(new Form1());

        }
    }
}
