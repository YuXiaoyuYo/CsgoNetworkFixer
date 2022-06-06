using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csgo_Fixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD.exe", "/c ipconfig /flushdns");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD.exe", "/c netsh advfirewall set allprofiles state off");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD.exe", "/c ipconfig /renew");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD.exe", "/c ipconfig /flushdns");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD.exe", "/c ipconfig /flushdns");
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        } //关闭窗口
    }
}
