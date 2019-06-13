namespace FrmIPchange
{
    partial class FrmMain
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
            this.btn자동발번 = new System.Windows.Forms.Button();
            this.btn수동발번 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.lueAdapter = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAdapter.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn자동발번
            // 
            this.btn자동발번.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn자동발번.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn자동발번.Location = new System.Drawing.Point(12, 37);
            this.btn자동발번.Name = "btn자동발번";
            this.btn자동발번.Size = new System.Drawing.Size(126, 45);
            this.btn자동발번.TabIndex = 0;
            this.btn자동발번.Text = "자동IP발번";
            this.btn자동발번.UseVisualStyleBackColor = false;
            this.btn자동발번.Click += new System.EventHandler(this.btn자동발번_Click);
            // 
            // btn수동발번
            // 
            this.btn수동발번.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn수동발번.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn수동발번.Location = new System.Drawing.Point(163, 37);
            this.btn수동발번.Name = "btn수동발번";
            this.btn수동발번.Size = new System.Drawing.Size(125, 45);
            this.btn수동발번.TabIndex = 1;
            this.btn수동발번.Text = "수동IP발번";
            this.btn수동발번.UseVisualStyleBackColor = false;
            this.btn수동발번.Click += new System.EventHandler(this.btn수동발번_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "Adapter";
            // 
            // lueAdapter
            // 
            this.lueAdapter.Location = new System.Drawing.Point(71, 9);
            this.lueAdapter.Name = "lueAdapter";
            this.lueAdapter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueAdapter.Properties.DisplayMember = "Adapter";
            this.lueAdapter.Properties.NullText = "";
            this.lueAdapter.Properties.ShowHeader = false;
            this.lueAdapter.Properties.ValueMember = "Adapter";
            this.lueAdapter.Size = new System.Drawing.Size(217, 20);
            this.lueAdapter.TabIndex = 19;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 96);
            this.Controls.Add(this.lueAdapter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn수동발번);
            this.Controls.Add(this.btn자동발번);
            this.Name = "FrmMain";
            this.Text = "IP 변경 프로그램";
            ((System.ComponentModel.ISupportInitialize)(this.lueAdapter.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn자동발번;
        private System.Windows.Forms.Button btn수동발번;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LookUpEdit lueAdapter;
    }
}

