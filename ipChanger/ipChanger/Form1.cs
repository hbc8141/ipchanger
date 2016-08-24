using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
// 중복 실행 방지

using System.Net.NetworkInformation;
// 네트워크 인터페이스에 대한 구성, 통계정보 제공

using System.Runtime.InteropServices;
// ini 파일 읽기, 쓰기


namespace ip_Changer
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32", CharSet=CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        // ini파일 읽기
        [DllImport("kernel32", CharSet=CharSet.Unicode)]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        // ini파일 쓰기

        private string filePath = null;

        private string[] setList = new string[] { "ip", "submask", "gateway", "masterDns", "slaveDns" };

        private IpSetting ipsetting;
        private Cmd cmd;

        private Process pro;
        private ProcessStartInfo proInfo;

        private int processLength=0;
        
        public int ProcessLength
        {
            set { processLength = value; }
            get { return processLength;  }
        }

        public Form1()
        {
            InitializeComponent();

            StringBuilder sb = new StringBuilder();
            sb.Insert(0, Application.StartupPath);
            sb.Replace('\\', '/');
            sb.Append("/system.ini");
            filePath = sb.ToString();
            sb.Clear();
            MessageBox.Show(filePath);
            pro = new Process();
            proInfo = new ProcessStartInfo();
        } // form 생성        

        private void Form1_Load(object sender, EventArgs e)
        {
            Process[] process = Process.GetProcessesByName("ipChanger");

            ProcessLength = process.Length;

            if (process.Length > 1)
            {
                GC.Collect();
                MessageBox.Show("이미 프로그램이 실행 중입니다.", "에러");
                Application.Exit();
            } // 중복실행 방지

            showMessage();

            if (wifiRadio.Checked)
                connectList(NetworkInterfaceType.Wireless80211);

            else
                connectList(NetworkInterfaceType.Ethernet);
            
            StringBuilder sb = new StringBuilder(255);

            cmd = new Cmd();
            ipsetting = new IpSetting();

            readText(filePath, sb);

            GC.Collect();
        }// form 불러오기

        private void ipSetting_Click(object sender, EventArgs e)
        {
            ipsetting.ShowDialog();
        } // ip고급설정 버튼 클릭 시 창 띄우기


        public void setIP(string ip, string subnet, string gateway, string masterDns, string slaveDns)
        {            
            string selectedItem = connectListBox.SelectedItem.ToString();

            cmd.cmdStart(pro, proInfo);

            if (ipActiveRadio.Checked == true)
            {
                pro.StandardInput.Write("netsh interface ip set address \"" + selectedItem + "\" dhcp" + Environment.NewLine);
                pro.StandardInput.Write("netsh interface ip set dns \"" + selectedItem + "\" dhcp" + Environment.NewLine);
            } // 유동 ip

            else if(ipPassiveRadio.Checked == true)
            {
                string value = ip + " " + subnet + " " + gateway + " 1";

                pro.StandardInput.Write("netsh interface ip set address \"" + selectedItem +"\" static " + value + Environment.NewLine);
                pro.StandardInput.Write("netsh interface ip add dns \"" + selectedItem + "\" " + masterDns + " index=3" + Environment.NewLine);
                pro.StandardInput.Write("netsh interface ip add dns \"" + selectedItem + "\" " + slaveDns + " index=4" + Environment.NewLine);
                /* http://tempdb.tistory.com/72 */ 
            } // 고정 ip

            cmd.cmdClose(pro);

            MessageBox.Show("ip change successfully", "Success");

            GC.Collect(); // garbage collect
        } // ip 설정

        private void ipSetChange_Click(object sender, EventArgs e)
        {
            try
            {
                //if (wifiRadio.Checked)
                //{
                //    if (ipPassiveRadio.Checked)
                //    {
                //        string ip = ipsetting.IP;
                //        string gateway = ipsetting.Gateway;
                //        string subnetMask = ipsetting.SubnetMask;
                //        string masterDns = ipsetting.MasterDns;
                //        string slaveDns = ipsetting.SlaveDns;

                //        GC.Collect();

                //        setIP(ip, subnetMask, gateway, masterDns, slaveDns);
                //    }

                //    else
                //        setIP(null, null, null, null, null);
                //} // wifi radiobutton 클릭 시

                //else if (cableRadio.Checked)
                //{
                //    MessageBox.Show("현재 유선 연결은 지원하지 않습니다.", "Error");
                //    //cableRadio.Checked = false;
                //    //wifiRadio.Checked = true;
                //} // cable radiobutton 클릭 시 
                //// 현재는 무선만 지원

                // 유, 무선 문제없이 잘 돌아감!
                if (ipPassiveRadio.Checked)
                {
                    string ip = ipsetting.IP;
                    string gateway = ipsetting.Gateway;
                    string subnetMask = ipsetting.SubnetMask;
                    string masterDns = ipsetting.MasterDns;
                    string slaveDns = ipsetting.SlaveDns;

                    GC.Collect();

                    setIP(ip, subnetMask, gateway, masterDns, slaveDns);
                }

                else
                    setIP(null, null, null, null, null);
            }  
            catch (NullReferenceException)
            {
                MessageBox.Show("리스트 항목 중 하나를 선택해주세요", "에러");
            }                        
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } // 나가기 메뉴 클릭 시

        private void makerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showMessage();
        } // 만든이 메뉴 클릭 시

        private void licenseCertificationBtn_Click(object sender, EventArgs e)
        {
            cmd.cmdStart(pro, proInfo);

            pro.StandardInput.Write("slmgr -xpr" + Environment.NewLine);
            
            cmd.cmdClose(pro);

            GC.Collect(); // garbage collect
        } // 정품 라이센스 확인

        private void iP설정초기화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("확인을 누르시면 IP 설정 값이 초기화됩니다.\r계속하시겠습니까?", "설정", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ipsetting.IP = "";
                ipsetting.SubnetMask = "";
                ipsetting.Gateway = "";
                ipsetting.MasterDns = "";
                ipsetting.SlaveDns = "";

                MessageBox.Show("ip setting initialization successfully", "Success");
            }
            
        } // 설정 초기화 버튼 클릭 시 값 제거

        private void cableRadio_Click(object sender, EventArgs e)
        {
            connectList(NetworkInterfaceType.Ethernet);
        } // 유선 라디오버튼 클릭 시

        private void wifiRadio_Click(object sender, EventArgs e)
        {
            connectList(NetworkInterfaceType.Wireless80211);
        } // 무선 라디오버튼 클릭 시

        private void connectList(NetworkInterfaceType type)
        {
            connectListBox.Items.Clear();
            // 모든 list 제거
            
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface adapter in interfaces)
            {
                if (adapter.NetworkInterfaceType == type)
                {
                    if (operationalStatusCheckBox.Checked)
                    {
                        if (adapter.OperationalStatus == OperationalStatus.Up)
                            connectListBox.Items.Add(adapter.Name);
                    }
                    else
                        connectListBox.Items.Add(adapter.Name);
                }
            }

            GC.Collect(); // garbage collect
        } // 연결가능 목록 보여주기

        private void operationalStatusCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (wifiRadio.Checked)
                wifiRadio_Click(sender, e);

            else
                cableRadio_Click(sender, e);
        } // 데이터 통신 가능여부 체크 및 리스트 보여주기

        private void showMessage()
        {
            MessageBox.Show("하병철\n\nCopyright © 2016 SkyVersion. All rights reserved.\n\n위 프로그램은 개인, 기관, 관공서, 기업에서 무료로 사용가능한 프리웨어입니다.", "만든이");
        } // 제작자 및 만든이 메세지 보여주기

        private void readText(string filePath, StringBuilder sb)
        {
            for (int i = 0; i < setList.Length; i++)
            {
                int temp = GetPrivateProfileString(setList[i], setList[i], "", sb, 255, filePath);

                switch (i)
                {
                    case 0:
                        ipsetting.IP = sb.ToString();
                        break;
                    case 1:
                        ipsetting.SubnetMask = sb.ToString();
                        break;
                    case 2:
                        ipsetting.Gateway = sb.ToString();
                        break;
                    case 3:
                        ipsetting.MasterDns = sb.ToString();
                        break;
                    case 4:
                        ipsetting.SlaveDns = sb.ToString();
                        break;
                    default:
                        break;
                }
                sb.Clear();
            }
        } // 텍스트 읽기

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ProcessLength == 1 && ipsetting.IsEscapeKeyDown)
            {
                WritePrivateProfileString("ip", "ip", ipsetting.IP, filePath);
                WritePrivateProfileString("submask", "submask", ipsetting.SubnetMask, filePath);
                WritePrivateProfileString("gateway", "gateway", ipsetting.Gateway, filePath);
                WritePrivateProfileString("masterDns", "masterDns", ipsetting.MasterDns, filePath);
                WritePrivateProfileString("slaveDns", "slaveDns", ipsetting.SlaveDns, filePath);
            } // 프로세스가 하나이거나 ipsetting시 esc키를 누르지 않았을 때       
        } // 폼 종료 시 ini 파일에 기록

        private void 문의사항ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("사용중 문의사항이 있으시면 아래 메일로 문의바랍니다.\n문의주시면 매우 빠르게 수정하겠습니다.\n\n문의메일 : hbc8141@naver.com", "문의사항");
        }
    }
}
