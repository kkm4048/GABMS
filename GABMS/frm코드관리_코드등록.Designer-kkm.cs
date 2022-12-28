namespace GABMS
{
    partial class frm코드관리_코드등록
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm코드관리_코드등록));
            this.pan등록 = new System.Windows.Forms.Panel();
            this.btn엑셀_업로드 = new System.Windows.Forms.Button();
            this.btn엑셀_등록 = new System.Windows.Forms.Button();
            this.lbl타이틀 = new System.Windows.Forms.Label();
            this.btn초기화 = new System.Windows.Forms.Button();
            this.btn닫기 = new System.Windows.Forms.Button();
            this.btn조회 = new System.Windows.Forms.Button();
            this.sc = new System.Windows.Forms.SplitContainer();
            this.spr1 = new FarPoint.Win.Spread.FpSpread();
            this.spr1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn바코드출력 = new System.Windows.Forms.Button();
            this.txt조회 = new System.Windows.Forms.TextBox();
            this.cmb품종 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCnt1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneralInfo = new System.Windows.Forms.TabPage();
            this.spr2 = new FarPoint.Win.Spread.FpSpread();
            this.spr2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panGenTop = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btn수정 = new System.Windows.Forms.Button();
            this.btn저장 = new System.Windows.Forms.Button();
            this.tabPlantSelection = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sc1 = new System.Windows.Forms.SplitContainer();
            this.panPlantStationTop = new System.Windows.Forms.Panel();
            this.spr3 = new FarPoint.Win.Spread.FpSpread();
            this.spr3_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panPlantStationTopBottom = new System.Windows.Forms.Panel();
            this.btn사진 = new System.Windows.Forms.Button();
            this.btn등록2 = new System.Windows.Forms.Button();
            this.btn수정2 = new System.Windows.Forms.Button();
            this.btn수정3 = new System.Windows.Forms.Button();
            this.panPlantStationTop1 = new System.Windows.Forms.Panel();
            this.txt시간 = new System.Windows.Forms.TextBox();
            this.txt일자 = new System.Windows.Forms.TextBox();
            this.txtKnouid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.spr4 = new FarPoint.Win.Spread.FpSpread();
            this.spr4_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pan등록.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr1_Sheet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabGeneralInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).BeginInit();
            this.panGenTop.SuspendLayout();
            this.tabPlantSelection.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc1)).BeginInit();
            this.sc1.Panel1.SuspendLayout();
            this.sc1.Panel2.SuspendLayout();
            this.sc1.SuspendLayout();
            this.panPlantStationTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr3_Sheet1)).BeginInit();
            this.panPlantStationTopBottom.SuspendLayout();
            this.panPlantStationTop1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr4_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pan등록
            // 
            this.pan등록.BackColor = System.Drawing.Color.White;
            this.pan등록.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan등록.Controls.Add(this.btnDelete);
            this.pan등록.Controls.Add(this.btn엑셀_업로드);
            this.pan등록.Controls.Add(this.btn엑셀_등록);
            this.pan등록.Controls.Add(this.lbl타이틀);
            this.pan등록.Controls.Add(this.btn초기화);
            this.pan등록.Controls.Add(this.btn닫기);
            this.pan등록.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan등록.Location = new System.Drawing.Point(0, 0);
            this.pan등록.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan등록.Name = "pan등록";
            this.pan등록.Size = new System.Drawing.Size(1313, 50);
            this.pan등록.TabIndex = 100;
            // 
            // btn엑셀_업로드
            // 
            this.btn엑셀_업로드.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn엑셀_업로드.Image = ((System.Drawing.Image)(resources.GetObject("btn엑셀_업로드.Image")));
            this.btn엑셀_업로드.Location = new System.Drawing.Point(924, 10);
            this.btn엑셀_업로드.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btn엑셀_업로드.Name = "btn엑셀_업로드";
            this.btn엑셀_업로드.Size = new System.Drawing.Size(142, 31);
            this.btn엑셀_업로드.TabIndex = 150;
            this.btn엑셀_업로드.Text = " 엑셀 파일 생성";
            this.btn엑셀_업로드.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn엑셀_업로드.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn엑셀_업로드.UseVisualStyleBackColor = true;
            this.btn엑셀_업로드.Click += new System.EventHandler(this.btn엑셀_업로드_Click);
            // 
            // btn엑셀_등록
            // 
            this.btn엑셀_등록.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn엑셀_등록.Image = ((System.Drawing.Image)(resources.GetObject("btn엑셀_등록.Image")));
            this.btn엑셀_등록.Location = new System.Drawing.Point(761, 9);
            this.btn엑셀_등록.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btn엑셀_등록.Name = "btn엑셀_등록";
            this.btn엑셀_등록.Size = new System.Drawing.Size(145, 31);
            this.btn엑셀_등록.TabIndex = 149;
            this.btn엑셀_등록.Text = " 엑셀 파일 업로드";
            this.btn엑셀_등록.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn엑셀_등록.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn엑셀_등록.UseVisualStyleBackColor = true;
            this.btn엑셀_등록.Click += new System.EventHandler(this.btn엑셀_등록_Click);
            // 
            // lbl타이틀
            // 
            this.lbl타이틀.AutoSize = true;
            this.lbl타이틀.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl타이틀.Location = new System.Drawing.Point(11, 15);
            this.lbl타이틀.Name = "lbl타이틀";
            this.lbl타이틀.Size = new System.Drawing.Size(82, 16);
            this.lbl타이틀.TabIndex = 44;
            this.lbl타이틀.Text = "코드 등록";
            // 
            // btn초기화
            // 
            this.btn초기화.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn초기화.Image = ((System.Drawing.Image)(resources.GetObject("btn초기화.Image")));
            this.btn초기화.Location = new System.Drawing.Point(639, 4);
            this.btn초기화.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn초기화.Name = "btn초기화";
            this.btn초기화.Size = new System.Drawing.Size(90, 32);
            this.btn초기화.TabIndex = 40;
            this.btn초기화.Text = "   초기화";
            this.btn초기화.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn초기화.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn초기화.UseVisualStyleBackColor = true;
            this.btn초기화.Visible = false;
            this.btn초기화.Click += new System.EventHandler(this.btn초기화_Click);
            // 
            // btn닫기
            // 
            this.btn닫기.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn닫기.Image = ((System.Drawing.Image)(resources.GetObject("btn닫기.Image")));
            this.btn닫기.Location = new System.Drawing.Point(174, 7);
            this.btn닫기.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn닫기.Name = "btn닫기";
            this.btn닫기.Size = new System.Drawing.Size(90, 32);
            this.btn닫기.TabIndex = 27;
            this.btn닫기.Text = "    닫 기";
            this.btn닫기.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn닫기.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn닫기.UseVisualStyleBackColor = true;
            this.btn닫기.Click += new System.EventHandler(this.btn닫기_Click);
            // 
            // btn조회
            // 
            this.btn조회.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn조회.Image = ((System.Drawing.Image)(resources.GetObject("btn조회.Image")));
            this.btn조회.Location = new System.Drawing.Point(87, 6);
            this.btn조회.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(90, 32);
            this.btn조회.TabIndex = 39;
            this.btn조회.Text = "    조 회";
            this.btn조회.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn조회.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn조회.UseVisualStyleBackColor = true;
            this.btn조회.Click += new System.EventHandler(this.btn조회_Click);
            // 
            // sc
            // 
            this.sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.sc.Location = new System.Drawing.Point(0, 50);
            this.sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.Controls.Add(this.spr1);
            this.sc.Panel1.Controls.Add(this.panel1);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.Controls.Add(this.tabControl1);
            this.sc.Panel2.Controls.Add(this.panel2);
            this.sc.Size = new System.Drawing.Size(1313, 683);
            this.sc.SplitterDistance = 832;
            this.sc.TabIndex = 101;
            this.sc.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.sc_SplitterMoved);
            // 
            // spr1
            // 
            this.spr1.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr1.Location = new System.Drawing.Point(0, 50);
            this.spr1.Name = "spr1";
            this.spr1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr1_Sheet1});
            this.spr1.Size = new System.Drawing.Size(832, 633);
            this.spr1.TabIndex = 102;
            this.spr1.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr1_ColumnWidthChanged);
            this.spr1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr1_CellClick);
            this.spr1.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr1_CellDoubleClick);
            this.spr1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.spr1_MouseUp);
            // 
            // spr1_Sheet1
            // 
            this.spr1_Sheet1.Reset();
            spr1_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr1_Sheet1.ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin1", System.Drawing.SystemColors.Control, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.LightGray, FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.WhiteSmoke, false, false, false, true, true, "ColumnHeaderEnhanced", "RowHeaderEnhanced", "DataAreaDefault", "CornerEnhanced");
            this.spr1_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr1_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr1_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.spr1_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr1_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.spr1_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr1_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr1_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.spr1_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr1_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr1_Sheet1.SheetCornerStyle.Parent = "CornerEnhanced";
            this.spr1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn바코드출력);
            this.panel1.Controls.Add(this.txt조회);
            this.panel1.Controls.Add(this.cmb품종);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblCnt1);
            this.panel1.Controls.Add(this.btn조회);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 50);
            this.panel1.TabIndex = 101;
            // 
            // btn바코드출력
            // 
            this.btn바코드출력.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn바코드출력.Image = ((System.Drawing.Image)(resources.GetObject("btn바코드출력.Image")));
            this.btn바코드출력.Location = new System.Drawing.Point(708, 6);
            this.btn바코드출력.Name = "btn바코드출력";
            this.btn바코드출력.Size = new System.Drawing.Size(125, 39);
            this.btn바코드출력.TabIndex = 149;
            this.btn바코드출력.Text = "  바코드출력";
            this.btn바코드출력.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn바코드출력.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn바코드출력.UseVisualStyleBackColor = true;
            this.btn바코드출력.Click += new System.EventHandler(this.btn바코드출력_Click);
            // 
            // txt조회
            // 
            this.txt조회.Location = new System.Drawing.Point(494, 12);
            this.txt조회.Name = "txt조회";
            this.txt조회.Size = new System.Drawing.Size(194, 21);
            this.txt조회.TabIndex = 100;
            // 
            // cmb품종
            // 
            this.cmb품종.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb품종.FormattingEnabled = true;
            this.cmb품종.Location = new System.Drawing.Point(249, 13);
            this.cmb품종.Name = "cmb품종";
            this.cmb품종.Size = new System.Drawing.Size(210, 20);
            this.cmb품종.TabIndex = 62;
            this.cmb품종.SelectedIndexChanged += new System.EventHandler(this.cmd품종_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 61;
            this.label3.Text = "Species";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCnt1
            // 
            this.lblCnt1.AutoSize = true;
            this.lblCnt1.Location = new System.Drawing.Point(12, 22);
            this.lblCnt1.Name = "lblCnt1";
            this.lblCnt1.Size = new System.Drawing.Size(11, 12);
            this.lblCnt1.TabIndex = 99;
            this.lblCnt1.Text = "0";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGeneralInfo);
            this.tabControl1.Controls.Add(this.tabPlantSelection);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(477, 633);
            this.tabControl1.TabIndex = 104;
            // 
            // tabGeneralInfo
            // 
            this.tabGeneralInfo.Controls.Add(this.spr2);
            this.tabGeneralInfo.Controls.Add(this.panGenTop);
            this.tabGeneralInfo.Location = new System.Drawing.Point(4, 22);
            this.tabGeneralInfo.Name = "tabGeneralInfo";
            this.tabGeneralInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneralInfo.Size = new System.Drawing.Size(469, 607);
            this.tabGeneralInfo.TabIndex = 0;
            this.tabGeneralInfo.Text = "General Info";
            this.tabGeneralInfo.UseVisualStyleBackColor = true;
            // 
            // spr2
            // 
            this.spr2.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr2.Location = new System.Drawing.Point(3, 58);
            this.spr2.Name = "spr2";
            this.spr2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr2_Sheet1});
            this.spr2.Size = new System.Drawing.Size(463, 546);
            this.spr2.TabIndex = 103;
            this.spr2.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr2_ColumnWidthChanged);
            // 
            // spr2_Sheet1
            // 
            this.spr2_Sheet1.Reset();
            spr2_Sheet1.SheetName = "Sheet2";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr2_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr2_Sheet1.ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin1", System.Drawing.SystemColors.Control, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.LightGray, FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.WhiteSmoke, false, false, false, true, true, "ColumnHeaderEnhanced", "RowHeaderEnhanced", "DataAreaDefault", "CornerEnhanced");
            this.spr2_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr2_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.spr2_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.spr2_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr2_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.spr2_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr2_Sheet1.SheetCornerStyle.Parent = "CornerEnhanced";
            this.spr2_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // panGenTop
            // 
            this.panGenTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panGenTop.Controls.Add(this.btn수정);
            this.panGenTop.Controls.Add(this.btn저장);
            this.panGenTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panGenTop.Location = new System.Drawing.Point(3, 3);
            this.panGenTop.Name = "panGenTop";
            this.panGenTop.Size = new System.Drawing.Size(463, 55);
            this.panGenTop.TabIndex = 104;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(410, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 32);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "  선택 일괄 삭제";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btn수정
            // 
            this.btn수정.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn수정.Image = ((System.Drawing.Image)(resources.GetObject("btn수정.Image")));
            this.btn수정.Location = new System.Drawing.Point(37, 9);
            this.btn수정.Name = "btn수정";
            this.btn수정.Size = new System.Drawing.Size(90, 32);
            this.btn수정.TabIndex = 43;
            this.btn수정.Text = "    수 정";
            this.btn수정.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn수정.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn수정.UseVisualStyleBackColor = true;
            this.btn수정.Click += new System.EventHandler(this.btn수정_Click);
            // 
            // btn저장
            // 
            this.btn저장.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn저장.Image = ((System.Drawing.Image)(resources.GetObject("btn저장.Image")));
            this.btn저장.Location = new System.Drawing.Point(144, 9);
            this.btn저장.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn저장.Name = "btn저장";
            this.btn저장.Size = new System.Drawing.Size(90, 32);
            this.btn저장.TabIndex = 44;
            this.btn저장.Text = "    저 장";
            this.btn저장.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn저장.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn저장.UseVisualStyleBackColor = true;
            this.btn저장.Click += new System.EventHandler(this.btn저장_Click);
            // 
            // tabPlantSelection
            // 
            this.tabPlantSelection.Controls.Add(this.panel3);
            this.tabPlantSelection.Location = new System.Drawing.Point(4, 22);
            this.tabPlantSelection.Name = "tabPlantSelection";
            this.tabPlantSelection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlantSelection.Size = new System.Drawing.Size(469, 607);
            this.tabPlantSelection.TabIndex = 1;
            this.tabPlantSelection.Text = "Plant Selection";
            this.tabPlantSelection.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.sc1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(463, 601);
            this.panel3.TabIndex = 1;
            // 
            // sc1
            // 
            this.sc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sc1.Location = new System.Drawing.Point(0, 0);
            this.sc1.Name = "sc1";
            this.sc1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc1.Panel1
            // 
            this.sc1.Panel1.Controls.Add(this.panPlantStationTop);
            // 
            // sc1.Panel2
            // 
            this.sc1.Panel2.Controls.Add(this.spr4);
            this.sc1.Size = new System.Drawing.Size(461, 599);
            this.sc1.SplitterDistance = 379;
            this.sc1.TabIndex = 104;
            this.sc1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.sc1_SplitterMoved);
            // 
            // panPlantStationTop
            // 
            this.panPlantStationTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPlantStationTop.Controls.Add(this.spr3);
            this.panPlantStationTop.Controls.Add(this.panPlantStationTopBottom);
            this.panPlantStationTop.Controls.Add(this.panPlantStationTop1);
            this.panPlantStationTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPlantStationTop.Location = new System.Drawing.Point(0, 0);
            this.panPlantStationTop.Name = "panPlantStationTop";
            this.panPlantStationTop.Size = new System.Drawing.Size(461, 379);
            this.panPlantStationTop.TabIndex = 0;
            // 
            // spr3
            // 
            this.spr3.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr3.Location = new System.Drawing.Point(0, 44);
            this.spr3.Name = "spr3";
            this.spr3.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr3_Sheet1});
            this.spr3.Size = new System.Drawing.Size(459, 276);
            this.spr3.TabIndex = 106;
            this.spr3.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr3_ColumnWidthChanged);
            // 
            // spr3_Sheet1
            // 
            this.spr3_Sheet1.Reset();
            spr3_Sheet1.SheetName = "Sheet3";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr3_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr3_Sheet1.ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin1", System.Drawing.SystemColors.Control, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.LightGray, FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.WhiteSmoke, false, false, false, true, true, "ColumnHeaderEnhanced", "RowHeaderEnhanced", "DataAreaDefault", "CornerEnhanced");
            this.spr3_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr3_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr3_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.spr3_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr3_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.spr3_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr3_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr3_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.spr3_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr3_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr3_Sheet1.SheetCornerStyle.Parent = "CornerEnhanced";
            this.spr3_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // panPlantStationTopBottom
            // 
            this.panPlantStationTopBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPlantStationTopBottom.Controls.Add(this.btn사진);
            this.panPlantStationTopBottom.Controls.Add(this.btn등록2);
            this.panPlantStationTopBottom.Controls.Add(this.btn수정2);
            this.panPlantStationTopBottom.Controls.Add(this.btn수정3);
            this.panPlantStationTopBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panPlantStationTopBottom.Location = new System.Drawing.Point(0, 320);
            this.panPlantStationTopBottom.Name = "panPlantStationTopBottom";
            this.panPlantStationTopBottom.Size = new System.Drawing.Size(459, 57);
            this.panPlantStationTopBottom.TabIndex = 105;
            // 
            // btn사진
            // 
            this.btn사진.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn사진.Image = ((System.Drawing.Image)(resources.GetObject("btn사진.Image")));
            this.btn사진.Location = new System.Drawing.Point(353, 6);
            this.btn사진.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn사진.Name = "btn사진";
            this.btn사진.Size = new System.Drawing.Size(90, 32);
            this.btn사진.TabIndex = 47;
            this.btn사진.Text = "   사 진";
            this.btn사진.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn사진.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn사진.UseVisualStyleBackColor = true;
            this.btn사진.Click += new System.EventHandler(this.btn사진_Click);
            // 
            // btn등록2
            // 
            this.btn등록2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn등록2.Image = ((System.Drawing.Image)(resources.GetObject("btn등록2.Image")));
            this.btn등록2.Location = new System.Drawing.Point(73, 6);
            this.btn등록2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn등록2.Name = "btn등록2";
            this.btn등록2.Size = new System.Drawing.Size(90, 32);
            this.btn등록2.TabIndex = 45;
            this.btn등록2.Text = "    등 록";
            this.btn등록2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn등록2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn등록2.UseVisualStyleBackColor = true;
            this.btn등록2.Click += new System.EventHandler(this.btn등록2_Click);
            // 
            // btn수정2
            // 
            this.btn수정2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn수정2.Image = ((System.Drawing.Image)(resources.GetObject("btn수정2.Image")));
            this.btn수정2.Location = new System.Drawing.Point(162, 6);
            this.btn수정2.Name = "btn수정2";
            this.btn수정2.Size = new System.Drawing.Size(90, 32);
            this.btn수정2.TabIndex = 44;
            this.btn수정2.Text = "    수 정";
            this.btn수정2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn수정2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn수정2.UseVisualStyleBackColor = true;
            this.btn수정2.Click += new System.EventHandler(this.btn수정2_Click);
            // 
            // btn수정3
            // 
            this.btn수정3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn수정3.Image = ((System.Drawing.Image)(resources.GetObject("btn수정3.Image")));
            this.btn수정3.Location = new System.Drawing.Point(251, 6);
            this.btn수정3.Name = "btn수정3";
            this.btn수정3.Size = new System.Drawing.Size(90, 32);
            this.btn수정3.TabIndex = 46;
            this.btn수정3.Text = "    삭 제";
            this.btn수정3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn수정3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn수정3.UseVisualStyleBackColor = true;
            this.btn수정3.Click += new System.EventHandler(this.btn수정3_Click);
            // 
            // panPlantStationTop1
            // 
            this.panPlantStationTop1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPlantStationTop1.Controls.Add(this.txt시간);
            this.panPlantStationTop1.Controls.Add(this.txt일자);
            this.panPlantStationTop1.Controls.Add(this.txtKnouid);
            this.panPlantStationTop1.Controls.Add(this.label1);
            this.panPlantStationTop1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panPlantStationTop1.Location = new System.Drawing.Point(0, 0);
            this.panPlantStationTop1.Name = "panPlantStationTop1";
            this.panPlantStationTop1.Size = new System.Drawing.Size(459, 44);
            this.panPlantStationTop1.TabIndex = 47;
            // 
            // txt시간
            // 
            this.txt시간.Enabled = false;
            this.txt시간.Location = new System.Drawing.Point(353, 7);
            this.txt시간.Name = "txt시간";
            this.txt시간.Size = new System.Drawing.Size(89, 21);
            this.txt시간.TabIndex = 103;
            // 
            // txt일자
            // 
            this.txt일자.Enabled = false;
            this.txt일자.Location = new System.Drawing.Point(251, 7);
            this.txt일자.Name = "txt일자";
            this.txt일자.Size = new System.Drawing.Size(90, 21);
            this.txt일자.TabIndex = 102;
            // 
            // txtKnouid
            // 
            this.txtKnouid.Enabled = false;
            this.txtKnouid.Location = new System.Drawing.Point(73, 7);
            this.txtKnouid.Name = "txtKnouid";
            this.txtKnouid.Size = new System.Drawing.Size(146, 21);
            this.txtKnouid.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 62;
            this.label1.Text = "KNOU ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spr4
            // 
            this.spr4.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr4.Location = new System.Drawing.Point(0, 0);
            this.spr4.Name = "spr4";
            this.spr4.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr4_Sheet1});
            this.spr4.Size = new System.Drawing.Size(461, 216);
            this.spr4.TabIndex = 103;
            this.spr4.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr4_ColumnWidthChanged);
            this.spr4.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr4_CellClick);
            // 
            // spr4_Sheet1
            // 
            this.spr4_Sheet1.Reset();
            spr4_Sheet1.SheetName = "Sheet4";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr4_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr4_Sheet1.ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin1", System.Drawing.SystemColors.Control, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.LightGray, FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.WhiteSmoke, false, false, false, true, true, "ColumnHeaderEnhanced", "RowHeaderEnhanced", "DataAreaDefault", "CornerEnhanced");
            this.spr4_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr4_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr4_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.spr4_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr4_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.spr4_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr4_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr4_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.spr4_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr4_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr4_Sheet1.SheetCornerStyle.Parent = "CornerEnhanced";
            this.spr4_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 50);
            this.panel2.TabIndex = 102;
            // 
            // frm코드관리_코드등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 733);
            this.Controls.Add(this.sc);
            this.Controls.Add(this.pan등록);
            this.Name = "frm코드관리_코드등록";
            this.Text = "코드 등록";
            this.Load += new System.EventHandler(this.frm코드관리_코드등록_Load);
            this.pan등록.ResumeLayout(false);
            this.pan등록.PerformLayout();
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr1_Sheet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabGeneralInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).EndInit();
            this.panGenTop.ResumeLayout(false);
            this.tabPlantSelection.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.sc1.Panel1.ResumeLayout(false);
            this.sc1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc1)).EndInit();
            this.sc1.ResumeLayout(false);
            this.panPlantStationTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr3_Sheet1)).EndInit();
            this.panPlantStationTopBottom.ResumeLayout(false);
            this.panPlantStationTop1.ResumeLayout(false);
            this.panPlantStationTop1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr4_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan등록;
        private System.Windows.Forms.Label lbl타이틀;
        private System.Windows.Forms.Button btn초기화;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.Button btn닫기;
        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.Panel panel1;
        private FarPoint.Win.Spread.FpSpread spr1;
        private FarPoint.Win.Spread.SheetView spr1_Sheet1;
        private FarPoint.Win.Spread.FpSpread spr2;
        private FarPoint.Win.Spread.SheetView spr2_Sheet1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCnt1;
        private System.Windows.Forms.ComboBox cmb품종;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn엑셀_등록;
        private System.Windows.Forms.TextBox txt조회;
        private System.Windows.Forms.Button btn바코드출력;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGeneralInfo;
        private System.Windows.Forms.TabPage tabPlantSelection;
        private System.Windows.Forms.Panel panel3;
        private FarPoint.Win.Spread.FpSpread spr4;
        private FarPoint.Win.Spread.SheetView spr4_Sheet1;
        private System.Windows.Forms.Panel panPlantStationTop;
        private System.Windows.Forms.Panel panPlantStationTop1;
        private FarPoint.Win.Spread.FpSpread spr3;
        private FarPoint.Win.Spread.SheetView spr3_Sheet1;
        private System.Windows.Forms.Panel panPlantStationTopBottom;
        private System.Windows.Forms.Button btn등록2;
        private System.Windows.Forms.Button btn수정2;
        private System.Windows.Forms.Button btn수정3;
        private System.Windows.Forms.TextBox txtKnouid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer sc1;
        private System.Windows.Forms.TextBox txt시간;
        private System.Windows.Forms.TextBox txt일자;
        private System.Windows.Forms.Button btn엑셀_업로드;
        private System.Windows.Forms.Panel panGenTop;
        private System.Windows.Forms.Button btn수정;
        private System.Windows.Forms.Button btn저장;
        private System.Windows.Forms.Button btn사진;
        private System.Windows.Forms.Button btnDelete;
    }
}