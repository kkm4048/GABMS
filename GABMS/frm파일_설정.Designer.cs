namespace GABMS
{
    partial class frm파일_설정
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
            this.btn저장 = new System.Windows.Forms.Button();
            this.cmb프린터 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn저장
            // 
            this.btn저장.Location = new System.Drawing.Point(79, 92);
            this.btn저장.Name = "btn저장";
            this.btn저장.Size = new System.Drawing.Size(75, 39);
            this.btn저장.TabIndex = 72;
            this.btn저장.Text = "저 장";
            this.btn저장.UseVisualStyleBackColor = true;
            this.btn저장.Click += new System.EventHandler(this.btn저장_Click);
            // 
            // cmb프린터
            // 
            this.cmb프린터.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb프린터.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb프린터.FormattingEnabled = true;
            this.cmb프린터.Location = new System.Drawing.Point(79, 31);
            this.cmb프린터.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb프린터.Name = "cmb프린터";
            this.cmb프린터.Size = new System.Drawing.Size(401, 20);
            this.cmb프린터.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 70;
            this.label11.Text = "프린터";
            // 
            // frm파일_설정
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 455);
            this.Controls.Add(this.btn저장);
            this.Controls.Add(this.cmb프린터);
            this.Controls.Add(this.label11);
            this.Name = "frm파일_설정";
            this.Text = "설 정";
            this.Load += new System.EventHandler(this.frm파일_설정_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn저장;
        private System.Windows.Forms.ComboBox cmb프린터;
        private System.Windows.Forms.Label label11;
    }
}