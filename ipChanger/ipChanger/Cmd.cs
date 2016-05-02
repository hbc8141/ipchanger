using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ip_Changer
{
    public class Cmd
    {
        public void cmdStart(System.Diagnostics.Process pro, System.Diagnostics.ProcessStartInfo proInfo)
        {
            proInfo.FileName = "cmd.exe";
            proInfo.CreateNoWindow = true; // cmd 창 띄우지 않기
            proInfo.UseShellExecute = false;

            proInfo.RedirectStandardOutput = true;
            // cmd 데이터 받기

            proInfo.RedirectStandardInput = true;
            // cmd 데이터 보내기

            proInfo.RedirectStandardError = true;
            // cmd 오류내용 받기

            pro.EnableRaisingEvents = false;
            pro.StartInfo = proInfo;
            pro.Start();
        } // cmd 시작 시

        public void cmdClose(System.Diagnostics.Process pro)
        {
            pro.StandardInput.Close();
            // cmd 명령어 입력 후 닫기

            //string resultValue = pro.StandardOutput.ReadToEnd();
            //// 결과값 리턴

            pro.WaitForExit();
            pro.Close();
        } // cmd 종료 시
    }
}
