namespace GABMS
{
    partial class frm메인
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m파일 = new System.Windows.Forms.ToolStripMenuItem();
            this.m파일_설정 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.m파일_종료 = new System.Windows.Forms.ToolStripMenuItem();
            this.m기초데이타 = new System.Windows.Forms.ToolStripMenuItem();
            this.m기초데이타_사용자등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.m기초데이타_품종등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.m코드관리 = new System.Windows.Forms.ToolStripMenuItem();
            this.m코드관리_코드등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 838);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1372, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m파일,
            this.m기초데이타,
            this.m코드관리});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1372, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m파일
            // 
            this.m파일.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m파일_설정,
            this.toolStripMenuItem1,
            this.m파일_종료});
            this.m파일.Name = "m파일";
            this.m파일.Size = new System.Drawing.Size(47, 20);
            this.m파일.Text = "파 일";
            // 
            // m파일_설정
            // 
            this.m파일_설정.Name = "m파일_설정";
            this.m파일_설정.Size = new System.Drawing.Size(102, 22);
            this.m파일_설정.Text = "설 정";
            this.m파일_설정.Click += new System.EventHandler(this.m파일_설정_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(99, 6);
            // 
            // m파일_종료
            // 
            this.m파일_종료.Name = "m파일_종료";
            this.m파일_종료.Size = new System.Drawing.Size(102, 22);
            this.m파일_종료.Text = "종 료";
            // 
            // m기초데이타
            // 
            this.m기초데이타.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m기초데이타_사용자등록,
            this.m기초데이타_품종등록});
            this.m기초데이타.Name = "m기초데이타";
            this.m기초데이타.Size = new System.Drawing.Size(83, 20);
            this.m기초데이타.Text = "기초 데이타";
            // 
            // m기초데이타_사용자등록
            // 
            this.m기초데이타_사용자등록.Name = "m기초데이타_사용자등록";
            this.m기초데이타_사용자등록.Size = new System.Drawing.Size(138, 22);
            this.m기초데이타_사용자등록.Tag = "frm기초데이타_사용자등록";
            this.m기초데이타_사용자등록.Text = "사용자 등록";
            this.m기초데이타_사용자등록.Click += new System.EventHandler(this.m기초데이타_사용자등록_Click);
            // 
            // m기초데이타_품종등록
            // 
            this.m기초데이타_품종등록.Name = "m기초데이타_품종등록";
            this.m기초데이타_품종등록.Size = new System.Drawing.Size(138, 22);
            this.m기초데이타_품종등록.Text = "품종 등록";
            this.m기초데이타_품종등록.Click += new System.EventHandler(this.m기초데이타_품종등록_Click);
            // 
            // m코드관리
            // 
            this.m코드관리.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m코드관리_코드등록});
            this.m코드관리.Name = "m코드관리";
            this.m코드관리.Size = new System.Drawing.Size(71, 20);
            this.m코드관리.Text = "코드 관리";
            // 
            // m코드관리_코드등록
            // 
            this.m코드관리_코드등록.Name = "m코드관리_코드등록";
            this.m코드관리_코드등록.Size = new System.Drawing.Size(126, 22);
            this.m코드관리_코드등록.Text = "코드 등록";
            this.m코드관리_코드등록.Click += new System.EventHandler(this.m코드관리_코드등록_Click);
            // 
            // frm메인
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 860);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm메인";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[D] 유전체육종관리시스템   GABMS (Genome Assisted Breeding Management System)  v1.1 221122";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m파일;
        private System.Windows.Forms.ToolStripMenuItem m파일_설정;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem m파일_종료;
        private System.Windows.Forms.ToolStripMenuItem m기초데이타;
        private System.Windows.Forms.ToolStripMenuItem m기초데이타_사용자등록;
        private System.Windows.Forms.ToolStripMenuItem m기초데이타_품종등록;
        private System.Windows.Forms.ToolStripMenuItem m코드관리;
        private System.Windows.Forms.ToolStripMenuItem m코드관리_코드등록;
    }
}

