using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ip_Changer
{
    public partial class WinLicense : Form
    {
        private Cmd cmd;
        private System.Diagnostics.Process pro;
        private System.Diagnostics.ProcessStartInfo proInfo;

        public WinLicense()
        {

        }

        public WinLicense(Cmd cmd, System.Diagnostics.Process pro, System.Diagnostics.ProcessStartInfo proInfo)
        {
            this.cmd = cmd;
            this.pro = pro;
            this.proInfo = proInfo;
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyLImit(e);
        } // 키 입력 제한

        private void keyLImit(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        } // 키 입력 제한(숫자, 영문)

        private void licenseChangeBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("예를 누르시면 시리얼 넘버가 바뀝니다.\r계속 하시겠습니까?", "경고", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("예");
            }
            else
            {
                MessageBox.Show("아니오");
            }
            cmd.cmdStart(pro, proInfo);
            pro.StandardInput.Write(Environment.NewLine);
            cmd.cmdClose(pro);

            this.Close();
        }
    }
}
