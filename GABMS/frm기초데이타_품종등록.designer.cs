namespace GABMS
{
    partial class frm기초데이타_품종등록
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm기초데이타_품종등록));
            this.t시작 = new System.Windows.Forms.Timer(this.components);
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pan창고_데이타 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCnt = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btninit = new System.Windows.Forms.Button();
            this.pan등록 = new System.Windows.Forms.Panel();
            this.lbl타이틀 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pan품종 = new System.Windows.Forms.Panel();
            this.panSelectionTop = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn초기화2 = new System.Windows.Forms.Button();
            this.btn삭제2 = new System.Windows.Forms.Button();
            this.btn저장2 = new System.Windows.Forms.Button();
            this.btn수정2 = new System.Windows.Forms.Button();
            this.lblCnt2 = new System.Windows.Forms.Label();
            this.txt21 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.spr2 = new FarPoint.Win.Spread.FpSpread();
            this.spr2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.spr3 = new FarPoint.Win.Spread.FpSpread();
            this.spr3_Sheet2 = new FarPoint.Win.Spread.SheetView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn초기화3 = new System.Windows.Forms.Button();
            this.btn삭제3 = new System.Windows.Forms.Button();
            this.btn저장3 = new System.Windows.Forms.Button();
            this.btn수정3 = new System.Windows.Forms.Button();
            this.lblCnt3 = new System.Windows.Forms.Label();
            this.txt31 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panSeedlingSelection = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.pan창고_데이타.SuspendLayout();
            this.pan등록.SuspendLayout();
            this.pan품종.SuspendLayout();
            this.panSelectionTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr3_Sheet2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panSeedlingSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // t시작
            // 
            this.t시작.Enabled = true;
            this.t시작.Tick += new System.EventHandler(this.t시작_Tick);
            // 
            // spr
            // 
            this.spr.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr.Location = new System.Drawing.Point(0, 116);
            this.spr.Name = "spr";
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(312, 594);
            this.spr.TabIndex = 101;
            this.spr.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr_ColumnWidthChanged);
            this.spr.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr_CellClick);
            // 
            // spr_Sheet1
            // 
            this.spr_Sheet1.Reset();
            spr_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr_Sheet1.ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin1", System.Drawing.SystemColors.Control, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.LightGray, FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.WhiteSmoke, false, false, false, true, true, "ColumnHeaderEnhanced", "RowHeaderEnhanced", "DataAreaDefault", "CornerEnhanced");
            this.spr_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.spr_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.spr_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.spr_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr_Sheet1.SheetCornerStyle.Parent = "CornerEnhanced";
            this.spr_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // pan창고_데이타
            // 
            this.pan창고_데이타.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pan창고_데이타.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan창고_데이타.Controls.Add(this.btnDelete);
            this.pan창고_데이타.Controls.Add(this.lblCnt);
            this.pan창고_데이타.Controls.Add(this.btnAdd);
            this.pan창고_데이타.Controls.Add(this.btnEdit);
            this.pan창고_데이타.Controls.Add(this.txt2);
            this.pan창고_데이타.Controls.Add(this.txt1);
            this.pan창고_데이타.Controls.Add(this.label1);
            this.pan창고_데이타.Controls.Add(this.label3);
            this.pan창고_데이타.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan창고_데이타.Location = new System.Drawing.Point(0, 0);
            this.pan창고_데이타.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan창고_데이타.Name = "pan창고_데이타";
            this.pan창고_데이타.Size = new System.Drawing.Size(312, 116);
            this.pan창고_데이타.TabIndex = 103;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(216, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "    삭 제";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(5, 98);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(11, 12);
            this.lblCnt.TabIndex = 98;
            this.lblCnt.Text = "0";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(216, 3);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 32);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "    등 록";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(216, 41);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 32);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.Text = "    수 정";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(58, 44);
            this.txt2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt2.MaxLength = 0;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(156, 21);
            this.txt2.TabIndex = 1;
            this.txt2.Enter += new System.EventHandler(this.txt_Enter);
            this.txt2.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(58, 15);
            this.txt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt1.MaxLength = 0;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(89, 21);
            this.txt1.TabIndex = 0;
            this.txt1.Enter += new System.EventHandler(this.txt_Enter);
            this.txt1.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 70;
            this.label1.Text = "코드";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 60;
            this.label3.Text = "Species";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btninit
            // 
            this.btninit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninit.Image = ((System.Drawing.Image)(resources.GetObject("btninit.Image")));
            this.btninit.Location = new System.Drawing.Point(372, 4);
            this.btninit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btninit.Name = "btninit";
            this.btninit.Size = new System.Drawing.Size(90, 32);
            this.btninit.TabIndex = 40;
            this.btninit.Text = "   초기화";
            this.btninit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btninit.UseVisualStyleBackColor = true;
            this.btninit.Click += new System.EventHandler(this.btninit_Click);
            // 
            // pan등록
            // 
            this.pan등록.BackColor = System.Drawing.Color.White;
            this.pan등록.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan등록.Controls.Add(this.btninit);
            this.pan등록.Controls.Add(this.lbl타이틀);
            this.pan등록.Controls.Add(this.btnSearch);
            this.pan등록.Controls.Add(this.btnClose);
            this.pan등록.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan등록.Location = new System.Drawing.Point(0, 0);
            this.pan등록.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan등록.Name = "pan등록";
            this.pan등록.Size = new System.Drawing.Size(1451, 50);
            this.pan등록.TabIndex = 102;
            // 
            // lbl타이틀
            // 
            this.lbl타이틀.AutoSize = true;
            this.lbl타이틀.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl타이틀.Location = new System.Drawing.Point(3, 15);
            this.lbl타이틀.Name = "lbl타이틀";
            this.lbl타이틀.Size = new System.Drawing.Size(59, 16);
            this.lbl타이틀.TabIndex = 45;
            this.lbl타이틀.Text = "타이틀";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(262, 7);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 32);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "    조 회";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(170, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 32);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "    닫 기";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pan품종
            // 
            this.pan품종.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan품종.Controls.Add(this.spr);
            this.pan품종.Controls.Add(this.pan창고_데이타);
            this.pan품종.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan품종.Location = new System.Drawing.Point(0, 50);
            this.pan품종.Name = "pan품종";
            this.pan품종.Size = new System.Drawing.Size(314, 712);
            this.pan품종.TabIndex = 104;
            // 
            // panSelectionTop
            // 
            this.panSelectionTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panSelectionTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSelectionTop.Controls.Add(this.label5);
            this.panSelectionTop.Controls.Add(this.label4);
            this.panSelectionTop.Controls.Add(this.btn초기화2);
            this.panSelectionTop.Controls.Add(this.btn삭제2);
            this.panSelectionTop.Controls.Add(this.btn저장2);
            this.panSelectionTop.Controls.Add(this.btn수정2);
            this.panSelectionTop.Controls.Add(this.lblCnt2);
            this.panSelectionTop.Controls.Add(this.txt21);
            this.panSelectionTop.Controls.Add(this.label6);
            this.panSelectionTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSelectionTop.Location = new System.Drawing.Point(0, 0);
            this.panSelectionTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panSelectionTop.Name = "panSelectionTop";
            this.panSelectionTop.Size = new System.Drawing.Size(549, 116);
            this.panSelectionTop.TabIndex = 105;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 12);
            this.label5.TabIndex = 108;
            this.label5.Text = "( 선택 :  ,(콤마) 로 구분 )";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(5, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 16);
            this.label4.TabIndex = 107;
            this.label4.Text = "Seedling Selection";
            // 
            // btn초기화2
            // 
            this.btn초기화2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn초기화2.Image = ((System.Drawing.Image)(resources.GetObject("btn초기화2.Image")));
            this.btn초기화2.Location = new System.Drawing.Point(213, 61);
            this.btn초기화2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn초기화2.Name = "btn초기화2";
            this.btn초기화2.Size = new System.Drawing.Size(90, 32);
            this.btn초기화2.TabIndex = 106;
            this.btn초기화2.Text = "   초기화";
            this.btn초기화2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn초기화2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn초기화2.UseVisualStyleBackColor = true;
            this.btn초기화2.Visible = false;
            this.btn초기화2.Click += new System.EventHandler(this.btn초기화2_Click);
            // 
            // btn삭제2
            // 
            this.btn삭제2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn삭제2.Image = ((System.Drawing.Image)(resources.GetObject("btn삭제2.Image")));
            this.btn삭제2.Location = new System.Drawing.Point(423, 80);
            this.btn삭제2.Name = "btn삭제2";
            this.btn삭제2.Size = new System.Drawing.Size(90, 32);
            this.btn삭제2.TabIndex = 105;
            this.btn삭제2.Text = "    삭 제";
            this.btn삭제2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn삭제2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn삭제2.UseVisualStyleBackColor = true;
            this.btn삭제2.Visible = false;
            this.btn삭제2.Click += new System.EventHandler(this.btn삭제2_Click);
            // 
            // btn저장2
            // 
            this.btn저장2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn저장2.Image = ((System.Drawing.Image)(resources.GetObject("btn저장2.Image")));
            this.btn저장2.Location = new System.Drawing.Point(293, 4);
            this.btn저장2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn저장2.Name = "btn저장2";
            this.btn저장2.Size = new System.Drawing.Size(90, 32);
            this.btn저장2.TabIndex = 104;
            this.btn저장2.Text = "    저 장";
            this.btn저장2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn저장2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn저장2.UseVisualStyleBackColor = true;
            this.btn저장2.Click += new System.EventHandler(this.btn저장2_Click);
            // 
            // btn수정2
            // 
            this.btn수정2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn수정2.Image = ((System.Drawing.Image)(resources.GetObject("btn수정2.Image")));
            this.btn수정2.Location = new System.Drawing.Point(344, 77);
            this.btn수정2.Name = "btn수정2";
            this.btn수정2.Size = new System.Drawing.Size(90, 32);
            this.btn수정2.TabIndex = 103;
            this.btn수정2.Text = "    수 정";
            this.btn수정2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn수정2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn수정2.UseVisualStyleBackColor = true;
            this.btn수정2.Visible = false;
            this.btn수정2.Click += new System.EventHandler(this.btn수정2_Click);
            // 
            // lblCnt2
            // 
            this.lblCnt2.AutoSize = true;
            this.lblCnt2.Location = new System.Drawing.Point(6, 97);
            this.lblCnt2.Name = "lblCnt2";
            this.lblCnt2.Size = new System.Drawing.Size(11, 12);
            this.lblCnt2.TabIndex = 98;
            this.lblCnt2.Text = "0";
            // 
            // txt21
            // 
            this.txt21.Enabled = false;
            this.txt21.Location = new System.Drawing.Point(82, 28);
            this.txt21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt21.MaxLength = 0;
            this.txt21.Name = "txt21";
            this.txt21.Size = new System.Drawing.Size(95, 21);
            this.txt21.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 12);
            this.label6.TabIndex = 70;
            this.label6.Text = "Species";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // spr2
            // 
            this.spr2.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr2.AllowEditOverflow = true;
            this.spr2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr2.Location = new System.Drawing.Point(0, 116);
            this.spr2.Name = "spr2";
            this.spr2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr2_Sheet1});
            this.spr2.Size = new System.Drawing.Size(549, 594);
            this.spr2.TabIndex = 106;
            this.spr2.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr2_ColumnWidthChanged);
            this.spr2.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr2_CellClick);
            this.spr2.ComboCloseUp += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spr2_ComboCloseUp);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.spr3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panSeedlingSelection);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(314, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1137, 712);
            this.panel2.TabIndex = 107;
            // 
            // spr3
            // 
            this.spr3.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr3.Location = new System.Drawing.Point(551, 116);
            this.spr3.Name = "spr3";
            this.spr3.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr3_Sheet2});
            this.spr3.Size = new System.Drawing.Size(586, 596);
            this.spr3.TabIndex = 109;
            this.spr3.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr3_ColumnWidthChanged);
            this.spr3.ComboCloseUp += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spr3_ComboCloseUp);
            // 
            // spr3_Sheet2
            // 
            this.spr3_Sheet2.Reset();
            spr3_Sheet2.SheetName = "Sheet2";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr3_Sheet2.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr3_Sheet2.ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin1", System.Drawing.SystemColors.Control, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.LightGray, FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.WhiteSmoke, false, false, false, true, true, "ColumnHeaderEnhanced", "RowHeaderEnhanced", "DataAreaDefault", "CornerEnhanced");
            this.spr3_Sheet2.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr3_Sheet2.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr3_Sheet2.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.spr3_Sheet2.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr3_Sheet2.RowHeader.Columns.Default.Resizable = false;
            this.spr3_Sheet2.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr3_Sheet2.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr3_Sheet2.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.spr3_Sheet2.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr3_Sheet2.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr3_Sheet2.SheetCornerStyle.Parent = "CornerEnhanced";
            this.spr3_Sheet2.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn초기화3);
            this.panel1.Controls.Add(this.btn삭제3);
            this.panel1.Controls.Add(this.btn저장3);
            this.panel1.Controls.Add(this.btn수정3);
            this.panel1.Controls.Add(this.lblCnt3);
            this.panel1.Controls.Add(this.txt31);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(551, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 116);
            this.panel1.TabIndex = 108;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 12);
            this.label9.TabIndex = 110;
            this.label9.Text = "( 선택 :  ,(콤마) 로 구분 )";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 12);
            this.label8.TabIndex = 109;
            this.label8.Text = "( 선택 :  ,(콤마) 로 구분 )";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(5, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 107;
            this.label2.Text = "Plant Selection";
            // 
            // btn초기화3
            // 
            this.btn초기화3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn초기화3.Image = ((System.Drawing.Image)(resources.GetObject("btn초기화3.Image")));
            this.btn초기화3.Location = new System.Drawing.Point(210, 4);
            this.btn초기화3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn초기화3.Name = "btn초기화3";
            this.btn초기화3.Size = new System.Drawing.Size(90, 32);
            this.btn초기화3.TabIndex = 106;
            this.btn초기화3.Text = "   초기화";
            this.btn초기화3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn초기화3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn초기화3.UseVisualStyleBackColor = true;
            this.btn초기화3.Visible = false;
            // 
            // btn삭제3
            // 
            this.btn삭제3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn삭제3.Image = ((System.Drawing.Image)(resources.GetObject("btn삭제3.Image")));
            this.btn삭제3.Location = new System.Drawing.Point(483, 10);
            this.btn삭제3.Name = "btn삭제3";
            this.btn삭제3.Size = new System.Drawing.Size(90, 32);
            this.btn삭제3.TabIndex = 105;
            this.btn삭제3.Text = "    삭 제";
            this.btn삭제3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn삭제3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn삭제3.UseVisualStyleBackColor = true;
            this.btn삭제3.Visible = false;
            // 
            // btn저장3
            // 
            this.btn저장3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn저장3.Image = ((System.Drawing.Image)(resources.GetObject("btn저장3.Image")));
            this.btn저장3.Location = new System.Drawing.Point(305, 4);
            this.btn저장3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn저장3.Name = "btn저장3";
            this.btn저장3.Size = new System.Drawing.Size(90, 32);
            this.btn저장3.TabIndex = 104;
            this.btn저장3.Text = "    저 장";
            this.btn저장3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn저장3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn저장3.UseVisualStyleBackColor = true;
            this.btn저장3.Click += new System.EventHandler(this.btn저장3_Click);
            // 
            // btn수정3
            // 
            this.btn수정3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn수정3.Image = ((System.Drawing.Image)(resources.GetObject("btn수정3.Image")));
            this.btn수정3.Location = new System.Drawing.Point(421, 5);
            this.btn수정3.Name = "btn수정3";
            this.btn수정3.Size = new System.Drawing.Size(90, 32);
            this.btn수정3.TabIndex = 103;
            this.btn수정3.Text = "    수 정";
            this.btn수정3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn수정3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn수정3.UseVisualStyleBackColor = true;
            this.btn수정3.Visible = false;
            // 
            // lblCnt3
            // 
            this.lblCnt3.AutoSize = true;
            this.lblCnt3.Location = new System.Drawing.Point(6, 98);
            this.lblCnt3.Name = "lblCnt3";
            this.lblCnt3.Size = new System.Drawing.Size(11, 12);
            this.lblCnt3.TabIndex = 98;
            this.lblCnt3.Text = "0";
            // 
            // txt31
            // 
            this.txt31.Enabled = false;
            this.txt31.Location = new System.Drawing.Point(82, 28);
            this.txt31.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt31.MaxLength = 0;
            this.txt31.Name = "txt31";
            this.txt31.Size = new System.Drawing.Size(95, 21);
            this.txt31.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 12);
            this.label7.TabIndex = 70;
            this.label7.Text = "Species";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panSeedlingSelection
            // 
            this.panSeedlingSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSeedlingSelection.Controls.Add(this.spr2);
            this.panSeedlingSelection.Controls.Add(this.panSelectionTop);
            this.panSeedlingSelection.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSeedlingSelection.Location = new System.Drawing.Point(0, 0);
            this.panSeedlingSelection.Name = "panSeedlingSelection";
            this.panSeedlingSelection.Size = new System.Drawing.Size(551, 712);
            this.panSeedlingSelection.TabIndex = 107;
            // 
            // frm기초데이타_품종등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 762);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pan품종);
            this.Controls.Add(this.pan등록);
            this.Name = "frm기초데이타_품종등록";
            this.Tag = "frm기초데이타_품종등록";
            this.Text = "Species";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm기초데이타_구분등록_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.pan창고_데이타.ResumeLayout(false);
            this.pan창고_데이타.PerformLayout();
            this.pan등록.ResumeLayout(false);
            this.pan등록.PerformLayout();
            this.pan품종.ResumeLayout(false);
            this.panSelectionTop.ResumeLayout(false);
            this.panSelectionTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr3_Sheet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panSeedlingSelection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer t시작;
        private FarPoint.Win.Spread.FpSpread spr;
        private FarPoint.Win.Spread.SheetView spr_Sheet1;
        private System.Windows.Forms.Panel pan창고_데이타;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pan등록;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btninit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbl타이틀;
        private System.Windows.Forms.Panel pan품종;
        private System.Windows.Forms.Panel panSelectionTop;
        private System.Windows.Forms.Label lblCnt2;
        private System.Windows.Forms.TextBox txt21;
        private System.Windows.Forms.Label label6;
        private FarPoint.Win.Spread.FpSpread spr2;
        private FarPoint.Win.Spread.SheetView spr2_Sheet1;
        private System.Windows.Forms.Button btn삭제2;
        private System.Windows.Forms.Button btn저장2;
        private System.Windows.Forms.Button btn수정2;
        private System.Windows.Forms.Button btn초기화2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panSeedlingSelection;
        private FarPoint.Win.Spread.FpSpread spr3;
        private FarPoint.Win.Spread.SheetView spr3_Sheet2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn초기화3;
        private System.Windows.Forms.Button btn삭제3;
        private System.Windows.Forms.Button btn저장3;
        private System.Windows.Forms.Button btn수정3;
        private System.Windows.Forms.Label lblCnt3;
        private System.Windows.Forms.TextBox txt31;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}