namespace ip_Changer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iP설정초기화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ipActiveRadio = new System.Windows.Forms.RadioButton();
            this.ipPassiveRadio = new System.Windows.Forms.RadioButton();
            this.ipSetting = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ipSetChange = new System.Windows.Forms.Button();
            this.copyright = new System.Windows.Forms.Label();
            this.wifiRadio = new System.Windows.Forms.RadioButton();
            this.cableRadio = new System.Windows.Forms.RadioButton();
            this.connectWayGroup = new System.Windows.Forms.GroupBox();
            this.ipConnectGroup = new System.Windows.Forms.GroupBox();
            this.licenseCertificationBtn = new System.Windows.Forms.Button();
            this.connectListBox = new System.Windows.Forms.ListBox();
            this.operationalStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.문의사항ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.connectWayGroup.SuspendLayout();
            this.ipConnectGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.settingSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(359, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileFToolStripMenuItem
            // 
            this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makerToolStripMenuItem,
            this.문의사항ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            this.fileFToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.fileFToolStripMenuItem.Text = "메뉴 (F)";
            // 
            // makerToolStripMenuItem
            // 
            this.makerToolStripMenuItem.Name = "makerToolStripMenuItem";
            this.makerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.makerToolStripMenuItem.Text = "만든 이";
            this.makerToolStripMenuItem.Click += new System.EventHandler(this.makerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "종료";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingSToolStripMenuItem
            // 
            this.settingSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iP설정초기화ToolStripMenuItem});
            this.settingSToolStripMenuItem.Name = "settingSToolStripMenuItem";
            this.settingSToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.settingSToolStripMenuItem.Text = "설정 (S)";
            // 
            // iP설정초기화ToolStripMenuItem
            // 
            this.iP설정초기화ToolStripMenuItem.Name = "iP설정초기화ToolStripMenuItem";
            this.iP설정초기화ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iP설정초기화ToolStripMenuItem.Text = "IP 설정 초기화";
            this.iP설정초기화ToolStripMenuItem.Click += new System.EventHandler(this.iP설정초기화ToolStripMenuItem_Click);
            // 
            // ipActiveRadio
            // 
            this.ipActiveRadio.AutoSize = true;
            this.ipActiveRadio.Location = new System.Drawing.Point(9, 28);
            this.ipActiveRadio.Name = "ipActiveRadio";
            this.ipActiveRadio.Size = new System.Drawing.Size(47, 16);
            this.ipActiveRadio.TabIndex = 2;
            this.ipActiveRadio.Text = "자동";
            this.ipActiveRadio.UseVisualStyleBackColor = true;
            // 
            // ipPassiveRadio
            // 
            this.ipPassiveRadio.AutoSize = true;
            this.ipPassiveRadio.Checked = true;
            this.ipPassiveRadio.Location = new System.Drawing.Point(69, 28);
            this.ipPassiveRadio.Name = "ipPassiveRadio";
            this.ipPassiveRadio.Size = new System.Drawing.Size(47, 16);
            this.ipPassiveRadio.TabIndex = 3;
            this.ipPassiveRadio.TabStop = true;
            this.ipPassiveRadio.Text = "수동";
            this.ipPassiveRadio.UseVisualStyleBackColor = true;
            // 
            // ipSetting
            // 
            this.ipSetting.Location = new System.Drawing.Point(235, 200);
            this.ipSetting.Name = "ipSetting";
            this.ipSetting.Size = new System.Drawing.Size(113, 25);
            this.ipSetting.TabIndex = 4;
            this.ipSetting.Text = "IP 고급 설정 (T)";
            this.ipSetting.UseVisualStyleBackColor = true;
            this.ipSetting.Click += new System.EventHandler(this.ipSetting_Click);
            // 
            // ipSetChange
            // 
            this.ipSetChange.Location = new System.Drawing.Point(25, 170);
            this.ipSetChange.Name = "ipSetChange";
            this.ipSetChange.Size = new System.Drawing.Size(90, 25);
            this.ipSetChange.TabIndex = 5;
            this.ipSetChange.Text = "변경";
            this.ipSetChange.UseVisualStyleBackColor = true;
            this.ipSetChange.Click += new System.EventHandler(this.ipSetChange_Click);
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Location = new System.Drawing.Point(39, 241);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(283, 12);
            this.copyright.TabIndex = 6;
            this.copyright.Text = "Copyright © 2016 SkyVersion. All rights reserved.";
            // 
            // wifiRadio
            // 
            this.wifiRadio.AutoSize = true;
            this.wifiRadio.Checked = true;
            this.wifiRadio.Location = new System.Drawing.Point(10, 27);
            this.wifiRadio.Name = "wifiRadio";
            this.wifiRadio.Size = new System.Drawing.Size(47, 16);
            this.wifiRadio.TabIndex = 7;
            this.wifiRadio.TabStop = true;
            this.wifiRadio.Text = "무선";
            this.wifiRadio.UseVisualStyleBackColor = true;
            this.wifiRadio.Click += new System.EventHandler(this.wifiRadio_Click);
            // 
            // cableRadio
            // 
            this.cableRadio.AutoSize = true;
            this.cableRadio.Location = new System.Drawing.Point(69, 27);
            this.cableRadio.Name = "cableRadio";
            this.cableRadio.Size = new System.Drawing.Size(47, 16);
            this.cableRadio.TabIndex = 8;
            this.cableRadio.Text = "유선";
            this.cableRadio.UseVisualStyleBackColor = true;
            this.cableRadio.Click += new System.EventHandler(this.cableRadio_Click);
            // 
            // connectWayGroup
            // 
            this.connectWayGroup.Controls.Add(this.wifiRadio);
            this.connectWayGroup.Controls.Add(this.cableRadio);
            this.connectWayGroup.Location = new System.Drawing.Point(9, 27);
            this.connectWayGroup.Name = "connectWayGroup";
            this.connectWayGroup.Size = new System.Drawing.Size(119, 50);
            this.connectWayGroup.TabIndex = 9;
            this.connectWayGroup.TabStop = false;
            this.connectWayGroup.Text = "연결 방식";
            // 
            // ipConnectGroup
            // 
            this.ipConnectGroup.Controls.Add(this.ipActiveRadio);
            this.ipConnectGroup.Controls.Add(this.ipPassiveRadio);
            this.ipConnectGroup.Location = new System.Drawing.Point(9, 97);
            this.ipConnectGroup.Name = "ipConnectGroup";
            this.ipConnectGroup.Size = new System.Drawing.Size(119, 50);
            this.ipConnectGroup.TabIndex = 10;
            this.ipConnectGroup.TabStop = false;
            this.ipConnectGroup.Text = "ip 연결 방법";
            // 
            // licenseCertificationBtn
            // 
            this.licenseCertificationBtn.Location = new System.Drawing.Point(25, 200);
            this.licenseCertificationBtn.Name = "licenseCertificationBtn";
            this.licenseCertificationBtn.Size = new System.Drawing.Size(90, 25);
            this.licenseCertificationBtn.TabIndex = 11;
            this.licenseCertificationBtn.Text = "윈도 정품확인";
            this.licenseCertificationBtn.UseVisualStyleBackColor = true;
            this.licenseCertificationBtn.Click += new System.EventHandler(this.licenseCertificationBtn_Click);
            // 
            // connectListBox
            // 
            this.connectListBox.FormattingEnabled = true;
            this.connectListBox.ItemHeight = 12;
            this.connectListBox.Location = new System.Drawing.Point(134, 35);
            this.connectListBox.Name = "connectListBox";
            this.connectListBox.Size = new System.Drawing.Size(216, 112);
            this.connectListBox.TabIndex = 13;
            // 
            // operationalStatusCheckBox
            // 
            this.operationalStatusCheckBox.AutoSize = true;
            this.operationalStatusCheckBox.Location = new System.Drawing.Point(134, 154);
            this.operationalStatusCheckBox.Name = "operationalStatusCheckBox";
            this.operationalStatusCheckBox.Size = new System.Drawing.Size(100, 16);
            this.operationalStatusCheckBox.TabIndex = 14;
            this.operationalStatusCheckBox.Text = "연결 가능여부";
            this.operationalStatusCheckBox.UseVisualStyleBackColor = true;
            this.operationalStatusCheckBox.CheckedChanged += new System.EventHandler(this.operationalStatusCheckBox_CheckedChanged);
            // 
            // 문의사항ToolStripMenuItem
            // 
            this.문의사항ToolStripMenuItem.Name = "문의사항ToolStripMenuItem";
            this.문의사항ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.문의사항ToolStripMenuItem.Text = "문의사항";
            this.문의사항ToolStripMenuItem.Click += new System.EventHandler(this.문의사항ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(359, 262);
            this.Controls.Add(this.operationalStatusCheckBox);
            this.Controls.Add(this.connectListBox);
            this.Controls.Add(this.licenseCertificationBtn);
            this.Controls.Add(this.ipConnectGroup);
            this.Controls.Add(this.connectWayGroup);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.ipSetChange);
            this.Controls.Add(this.ipSetting);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "IP Changer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.connectWayGroup.ResumeLayout(false);
            this.connectWayGroup.PerformLayout();
            this.ipConnectGroup.ResumeLayout(false);
            this.ipConnectGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
        private System.Windows.Forms.RadioButton ipActiveRadio;
        private System.Windows.Forms.RadioButton ipPassiveRadio;
        private System.Windows.Forms.Button ipSetting;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button ipSetChange;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.ToolStripMenuItem makerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RadioButton wifiRadio;
        private System.Windows.Forms.RadioButton cableRadio;
        private System.Windows.Forms.GroupBox connectWayGroup;
        private System.Windows.Forms.GroupBox ipConnectGroup;
        private System.Windows.Forms.Button licenseCertificationBtn;
        private System.Windows.Forms.ToolStripMenuItem settingSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iP설정초기화ToolStripMenuItem;
        private System.Windows.Forms.ListBox connectListBox;
        private System.Windows.Forms.CheckBox operationalStatusCheckBox;
        private System.Windows.Forms.ToolStripMenuItem 문의사항ToolStripMenuItem;
    }
}

