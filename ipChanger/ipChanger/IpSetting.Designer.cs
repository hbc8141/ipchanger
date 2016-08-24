namespace ip_Changer
{
    partial class IpSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ipLebel = new System.Windows.Forms.Label();
            this.submaskLabel = new System.Windows.Forms.Label();
            this.gatewayLabel = new System.Windows.Forms.Label();
            this.mDnsLabel = new System.Windows.Forms.Label();
            this.sDnsLabel = new System.Windows.Forms.Label();
            this.ipInput = new System.Windows.Forms.TextBox();
            this.submaskInput = new System.Windows.Forms.TextBox();
            this.gatewayInput = new System.Windows.Forms.TextBox();
            this.masterDnsInput = new System.Windows.Forms.TextBox();
            this.slaveDnsInput = new System.Windows.Forms.TextBox();
            this.complete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipLebel
            // 
            this.ipLebel.AutoSize = true;
            this.ipLebel.Location = new System.Drawing.Point(25, 30);
            this.ipLebel.Name = "ipLebel";
            this.ipLebel.Size = new System.Drawing.Size(16, 12);
            this.ipLebel.TabIndex = 0;
            this.ipLebel.Text = "IP";
            // 
            // submaskLabel
            // 
            this.submaskLabel.AutoSize = true;
            this.submaskLabel.Location = new System.Drawing.Point(25, 65);
            this.submaskLabel.Name = "submaskLabel";
            this.submaskLabel.Size = new System.Drawing.Size(79, 12);
            this.submaskLabel.TabIndex = 1;
            this.submaskLabel.Text = "Subnet Mask";
            // 
            // gatewayLabel
            // 
            this.gatewayLabel.AutoSize = true;
            this.gatewayLabel.Location = new System.Drawing.Point(25, 105);
            this.gatewayLabel.Name = "gatewayLabel";
            this.gatewayLabel.Size = new System.Drawing.Size(55, 12);
            this.gatewayLabel.TabIndex = 2;
            this.gatewayLabel.Text = "Gateway";
            // 
            // mDnsLabel
            // 
            this.mDnsLabel.AutoSize = true;
            this.mDnsLabel.Location = new System.Drawing.Point(25, 143);
            this.mDnsLabel.Name = "mDnsLabel";
            this.mDnsLabel.Size = new System.Drawing.Size(73, 12);
            this.mDnsLabel.TabIndex = 3;
            this.mDnsLabel.Text = "Master DNS";
            // 
            // sDnsLabel
            // 
            this.sDnsLabel.AutoSize = true;
            this.sDnsLabel.Location = new System.Drawing.Point(25, 180);
            this.sDnsLabel.Name = "sDnsLabel";
            this.sDnsLabel.Size = new System.Drawing.Size(65, 12);
            this.sDnsLabel.TabIndex = 4;
            this.sDnsLabel.Text = "Slave DNS";
            // 
            // ipInput
            // 
            this.ipInput.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ipInput.Location = new System.Drawing.Point(125, 27);
            this.ipInput.MaxLength = 15;
            this.ipInput.Name = "ipInput";
            this.ipInput.Size = new System.Drawing.Size(100, 21);
            this.ipInput.TabIndex = 5;
            this.ipInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ipInput_KeyPress);
            // 
            // submaskInput
            // 
            this.submaskInput.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.submaskInput.Location = new System.Drawing.Point(125, 62);
            this.submaskInput.MaxLength = 15;
            this.submaskInput.Name = "submaskInput";
            this.submaskInput.Size = new System.Drawing.Size(100, 21);
            this.submaskInput.TabIndex = 6;
            this.submaskInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.submaskInput_KeyPress);
            // 
            // gatewayInput
            // 
            this.gatewayInput.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.gatewayInput.Location = new System.Drawing.Point(125, 102);
            this.gatewayInput.MaxLength = 15;
            this.gatewayInput.Name = "gatewayInput";
            this.gatewayInput.Size = new System.Drawing.Size(100, 21);
            this.gatewayInput.TabIndex = 7;
            this.gatewayInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gatewayInput_KeyPress);
            // 
            // masterDnsInput
            // 
            this.masterDnsInput.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.masterDnsInput.Location = new System.Drawing.Point(125, 140);
            this.masterDnsInput.MaxLength = 15;
            this.masterDnsInput.Name = "masterDnsInput";
            this.masterDnsInput.Size = new System.Drawing.Size(100, 21);
            this.masterDnsInput.TabIndex = 8;
            this.masterDnsInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.masterDnsInput_KeyPress);
            // 
            // slaveDnsInput
            // 
            this.slaveDnsInput.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.slaveDnsInput.Location = new System.Drawing.Point(125, 177);
            this.slaveDnsInput.MaxLength = 15;
            this.slaveDnsInput.Name = "slaveDnsInput";
            this.slaveDnsInput.Size = new System.Drawing.Size(100, 21);
            this.slaveDnsInput.TabIndex = 9;
            this.slaveDnsInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.slaveDnsInput_KeyPress);
            // 
            // complete
            // 
            this.complete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.complete.Location = new System.Drawing.Point(98, 227);
            this.complete.Name = "complete";
            this.complete.Size = new System.Drawing.Size(75, 23);
            this.complete.TabIndex = 10;
            this.complete.Text = "완료";
            this.complete.UseVisualStyleBackColor = true;
            this.complete.Click += new System.EventHandler(this.complete_Click);
            // 
            // IpSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.complete);
            this.Controls.Add(this.slaveDnsInput);
            this.Controls.Add(this.masterDnsInput);
            this.Controls.Add(this.gatewayInput);
            this.Controls.Add(this.submaskInput);
            this.Controls.Add(this.ipInput);
            this.Controls.Add(this.sDnsLabel);
            this.Controls.Add(this.mDnsLabel);
            this.Controls.Add(this.gatewayLabel);
            this.Controls.Add(this.submaskLabel);
            this.Controls.Add(this.ipLebel);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IpSetting";
            this.ShowIcon = false;
            this.Text = "IpSetting";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IpSetting_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipLebel;
        private System.Windows.Forms.Label submaskLabel;
        private System.Windows.Forms.Label gatewayLabel;
        private System.Windows.Forms.Label mDnsLabel;
        private System.Windows.Forms.Label sDnsLabel;
        private System.Windows.Forms.TextBox ipInput;
        private System.Windows.Forms.TextBox submaskInput;
        private System.Windows.Forms.TextBox gatewayInput;
        private System.Windows.Forms.TextBox masterDnsInput;
        private System.Windows.Forms.TextBox slaveDnsInput;
        private System.Windows.Forms.Button complete;
    }
}