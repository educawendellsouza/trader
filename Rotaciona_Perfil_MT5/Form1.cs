using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
            MessageBox.Show("MetaTrader4 sendo iniciado");

            

            Process.Start(@"H:\Trader\Atalhos\terminal - Atalho.lnk");
            var timer = new System.Threading.Timer((x) => {SendKeys.Send("{CTRL}"+"{F5}");}, null, 10000, Timeout.Infinite);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MetaTrader5 sendo iniciado");
        }
    }
}
