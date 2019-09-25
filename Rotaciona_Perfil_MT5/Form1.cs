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
using System.Windows;
using System.Security.Permissions;


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
            //Task<byte[] > Execute (byte[] imageSource, string arguments)
            //{
            //    var process = new Process
            //    {
            //        StartInfo = new ProcessStartInfo
            //        {
            //            FileName = @"C:\Program Files\MetaTrader 5\terminal64.exe",
            //            Arguments = arguments,
            //            RedirectStandardInput = true,
            //            RedirectStandardOutput = true,
            //            RedirectStandardError = true,
            //            UseShellExecute = false,
            //            CreateNoWindow = true
            //        }
            //    };

            //    try
            //    {
            //        process.Start();
            //    }


                //Process p = new Process();
                //p.StartInfo.WorkingDirectory = (Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), @"MetaTrader 5\MT5 - Monitor.lnk"));
                //p.StartInfo.FileName = @"C:\Program Files\MetaTrader 5\terminal64.exe";
                //p.StartInfo.CreateNoWindow = true;
                //p.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                //p.Start();

                //if (p.Responding)
                //{
                //    MessageBox.Show("Status do Processo MT5 = Em Execução");
                //}
                //else
                //{
                //    MessageBox.Show("Status do Processo MT5 = Não respondendo");
                //}

                //System.Threading.Thread.Sleep(30000);

                //// Link para leitura https://docs.microsoft.com/pt-br/dotnet/api/system.windows.forms.sendkeys.send?view=netframework-4.8
            }

        private void Button2_Click(object sender, EventArgs e)
        {            
            Process p = new Process();
            // string nomeDoPrograma;
            p.StartInfo.WorkingDirectory = (Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), @"MetaTrader 5\MT5 - Monitor.lnk"));
            p.StartInfo.FileName = @"C:\Program Files\MetaTrader 5\terminal64.exe";
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            p.Start();

            
            if (p.Responding)
            {
                MessageBox.Show("Status do Processo MT5 = Em Execução");
            }
            else
            {
                MessageBox.Show("Status do Processo MT5 = Não respondendo");
            }


            
            SendKeys.SendWait("%R");
            MessageBox.Show("Envio do ALT+R");

            //SendKeys.SendWait("%{R}") as p.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            //var timer = new System.Threading.Timer((x) => { SendKeys.Send("{CTRL}%{F5}"); }, null, 15000, Timeout.Infinite);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var timer = new System.Threading.Timer((x) => {SendKeys.Send("{CTRL}%{F5}");}, null, 10000, Timeout.Infinite);
        }
    }
}
