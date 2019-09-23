using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rotaciona_Perfil_MT5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Iniciando MT4");
            Process.Start(@"H:\\Trader\\-\\terminal - Atalho.lnk");
            System.Threading.Thread.Sleep(30000);
            var timer = new System.Threading.Timer((x) => {SendKeys.Send("{CTRL}%{F5}");}, null, 10000, Timeout.Infinite);

            // Link para leitura https://docs.microsoft.com/pt-br/dotnet/api/system.windows.forms.sendkeys.send?view=netframework-4.8
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Iniciando MT5");
            Process.Start(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), @"MetaTrader 5\MT5 - Monitor.lnk"));           
            System.Threading.Thread.Sleep(30000);
            //var timer = new System.Threading.Timer((x) => { SendKeys.Send("{CTRL}%{F5}"); }, null, 15000, Timeout.Infinite);
        }
    }
}
