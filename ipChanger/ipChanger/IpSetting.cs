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
            IsEscapeKeyDown = false;
            this.Close();
        } // 완료버튼 클릭 시 창 닫기

        public string IP{
            get { return ipInput.Text.ToString(); }
            set{ ipInput.Text = value; }
        }

        public string SubnetMask{
            get { return submaskInput.Text.ToString(); }
            set{ submaskInput.Text = value; }
        }

        public string Gateway{
            get { return gatewayInput.Text.ToString(); }
            set{ gatewayInput.Text = value; }
        }

        public string MasterDns{
            get { return masterDnsInput.Text.ToString(); }
            set { masterDnsInput.Text = value; }
        }

        public string SlaveDns{
            get { return slaveDnsInput.Text.ToString(); }
            set { slaveDnsInput.Text = value; }
        }

        private bool isEscapeKeyDown = false;
        public bool IsEscapeKeyDown{
            get { return isEscapeKeyDown; }
            set { isEscapeKeyDown = value; }
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

        private void IpSetting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape){
                IsEscapeKeyDown = true;
                this.Close();
            } // setting창에서 esc키를 눌렀을 시 form 종료
        } // control에서 keypreview를 등록해야만 이벤트가 정상적으로 작동한다.
    }
}
