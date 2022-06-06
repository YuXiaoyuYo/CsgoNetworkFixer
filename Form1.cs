using System;
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
            MessageBox.Show("成功刷新DNS", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD.exe", "/c netsh advfirewall set allprofiles state off");
            MessageBox.Show("成功关闭防火墙", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD.exe", "/c ipconfig /renew");
            MessageBox.Show("成功重置网卡", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("这将会导致QQ系软件停止运行\n确认要这么做吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("Taskkill.exe", "/im qqprotect.exe /f");
                MessageBox.Show("成功关闭Q盾", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Taskkill.exe", "/im csgo.exe /f");
            MessageBox.Show("CSGO已关闭", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("这会导致QQ系软件停止运行\n确认这么做吗", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("ipconfig.exe", "/flushdns");
                System.Diagnostics.Process.Start("netsh.exe", "advfirewall set allprofiles state off");
                System.Diagnostics.Process.Start("ipconfig.exe", "/renew");
                System.Diagnostics.Process.Start("taskkill.exe", "/im qqprotect.exe /f");
                System.Diagnostics.Process.Start("taskkill.exe", "/im csgo.exe /f");
                MessageBox.Show("成功！\n享受宁的CSGO8吧");
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } //关闭窗口
    }
}
