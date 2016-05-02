using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;
// ini 파일 읽기, 쓰기


namespace ip_Changer
{
    public partial class IpSetting : Form
    {
        public IpSetting()
        {
            InitializeComponent();
        }

        private void complete_Click(object sender, EventArgs e)
        {
            this.Close();
        } // 창 닫기

        public string IP{
            set{ ipInput.Text = value; }
            get{ return ipInput.Text.ToString(); }
        }

        public string SubnetMask{
            set{ submaskInput.Text = value; }
            get{ return submaskInput.Text.ToString(); }
        }

        public string Gateway{ 
            set{ gatewayInput.Text = value; }
            get{ return gatewayInput.Text.ToString(); }
        }

        public string MasterDns{
            set { masterDnsInput.Text = value; }
            get { return masterDnsInput.Text.ToString(); }
        }

        public string SlaveDns
        {
            set { slaveDnsInput.Text = value; }
            get { return slaveDnsInput.Text.ToString(); }
        }

        private void ipInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyLImit(e);
        }
        private void submaskInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyLImit(e);
        }
        private void gatewayInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyLImit(e);
        }
        private void masterDnsInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyLImit(e);
        }
        private void slaveDnsInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyLImit(e);
        }
        private void keyLImit(KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        } // 키 입력 제한
    }
}
