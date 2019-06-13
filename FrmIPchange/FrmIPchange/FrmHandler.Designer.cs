namespace FrmIPchange
{
    partial class FrmHandler
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDNS2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDNS1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubnetMask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGateWay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn수동발번 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDNS2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDNS1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSubnetMask);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGateWay);
            this.groupBox1.Location = new System.Drawing.Point(6, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 150);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "수동IP 설정";
            // 
            // txtDNS2
            // 
            this.txtDNS2.Enabled = false;
            this.txtDNS2.Location = new System.Drawing.Point(93, 123);
            this.txtDNS2.Name = "txtDNS2";
            this.txtDNS2.ReadOnly = true;
            this.txtDNS2.Size = new System.Drawing.Size(139, 21);
            this.txtDNS2.TabIndex = 13;
            this.txtDNS2.Text = "168.126.63.2";
            this.txtDNS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "DNS";
            // 
            // txtDNS1
            // 
            this.txtDNS1.Enabled = false;
            this.txtDNS1.Location = new System.Drawing.Point(93, 97);
            this.txtDNS1.Name = "txtDNS1";
            this.txtDNS1.ReadOnly = true;
            this.txtDNS1.Size = new System.Drawing.Size(139, 21);
            this.txtDNS1.TabIndex = 11;
            this.txtDNS1.Text = "168.126.63.1";
            this.txtDNS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "SubNetMask";
            // 
            // txtSubnetMask
            // 
            this.txtSubnetMask.Location = new System.Drawing.Point(93, 72);
            this.txtSubnetMask.Name = "txtSubnetMask";
            this.txtSubnetMask.ReadOnly = true;
            this.txtSubnetMask.Size = new System.Drawing.Size(139, 21);
            this.txtSubnetMask.TabIndex = 9;
            this.txtSubnetMask.Text = "255.255.255.0";
            this.txtSubnetMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(93, 19);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(139, 21);
            this.txtIP.TabIndex = 7;
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "GateWay";
            // 
            // txtGateWay
            // 
            this.txtGateWay.Location = new System.Drawing.Point(93, 45);
            this.txtGateWay.Name = "txtGateWay";
            this.txtGateWay.Size = new System.Drawing.Size(139, 21);
            this.txtGateWay.TabIndex = 5;
            this.txtGateWay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "* 수동IP발번 시 하단정보 입력해주세요";
            // 
            // btn수동발번
            // 
            this.btn수동발번.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn수동발번.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn수동발번.Location = new System.Drawing.Point(6, 179);
            this.btn수동발번.Name = "btn수동발번";
            this.btn수동발번.Size = new System.Drawing.Size(240, 28);
            this.btn수동발번.TabIndex = 6;
            this.btn수동발번.Text = "수동IP발번";
            this.btn수동발번.UseVisualStyleBackColor = false;
            this.btn수동발번.Click += new System.EventHandler(this.btn수동발번_Click);
            // 
            // FrmHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 212);
            this.Controls.Add(this.btn수동발번);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmHandler";
            this.Text = "수동IP발번";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDNS2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDNS1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubnetMask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGateWay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn수동발번;
    }
}