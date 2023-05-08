
namespace LhrMain
{
    partial class MainFrm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("그룹코드관리");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("단위코드관리");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("부서코드관리");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("대학코드관리");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("코드관리", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("인사기본정보등록");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("인사정보조회");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("가족관계정보");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("경력사항");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("학력사항");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("자격면허");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("인사 기록 관리", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("인사발령대장");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("인사발령등록");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("인사 발령", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("재직증명서");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("경력증명서");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("제증명 발급", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("근무 평가");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("분석 및 통계");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("인사 관리", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode12,
            treeNode15,
            treeNode18,
            treeNode19,
            treeNode20});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tv_MainMenu = new System.Windows.Forms.TreeView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.info_user = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.info_count = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.info_message = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.info_pgmid = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_new_window = new System.Windows.Forms.CheckBox();
            this.btn_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tv_MainMenu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1234, 741);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tv_MainMenu
            // 
            this.tv_MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_MainMenu.Location = new System.Drawing.Point(4, 65);
            this.tv_MainMenu.Name = "tv_MainMenu";
            treeNode1.Name = "노드1";
            treeNode1.Tag = "Pgm010:그룹코드관리:981:599:Y:그룹코드관리";
            treeNode1.Text = "그룹코드관리";
            treeNode2.Name = "노드2";
            treeNode2.Tag = "Pgm011:단위코드관리:981:599:Y:단위코드관리";
            treeNode2.Text = "단위코드관리";
            treeNode3.Name = "노드3";
            treeNode3.Tag = "Pgm012:부서코드관리:981:599:Y:부서코드관리";
            treeNode3.Text = "부서코드관리";
            treeNode4.Name = "노드0";
            treeNode4.Tag = "Pgm013:대학코드관리:981:599:Y:대학코드관리";
            treeNode4.Text = "대학코드관리";
            treeNode5.Name = "노드0";
            treeNode5.Text = "코드관리";
            treeNode6.Name = "노드6";
            treeNode6.Tag = "Pgm001:BasicFrm:981:599:Y:인사기본정보등록";
            treeNode6.Text = "인사기본정보등록";
            treeNode7.Name = "노드8";
            treeNode7.Tag = "Pgm002:인사정보조회:981:599:Y:인사정보조회";
            treeNode7.Text = "인사정보조회";
            treeNode8.Name = "노드7";
            treeNode8.Tag = "Pgm003:가족관계정보:881:524:N:가족관계정보";
            treeNode8.Text = "가족관계정보";
            treeNode9.Name = "노드0";
            treeNode9.Tag = "Pgm004:경력사항:981:599:Y:경력사항";
            treeNode9.Text = "경력사항";
            treeNode10.Name = "노드1";
            treeNode10.Tag = "Pgm005:학력사항:981:599:Y:학력사항";
            treeNode10.Text = "학력사항";
            treeNode11.Name = "노드0";
            treeNode11.Tag = "Pgm006:자격면허:981:599:Y:자격면허";
            treeNode11.Text = "자격면허";
            treeNode12.Name = "노드1";
            treeNode12.Text = "인사 기록 관리";
            treeNode13.Name = "노드0";
            treeNode13.Tag = "Pgm020:인사발령대장:981:599:Y:인사발령대장";
            treeNode13.Text = "인사발령대장";
            treeNode14.Name = "노드1";
            treeNode14.Tag = "Pgm021:인사발령등록:981:599:Y:인사발령등록";
            treeNode14.Text = "인사발령등록";
            treeNode15.Name = "노드2";
            treeNode15.Text = "인사 발령";
            treeNode16.Name = "노드0";
            treeNode16.Tag = "Pgm031:재직증명서:981:599:Y:재직증명서";
            treeNode16.Text = "재직증명서";
            treeNode17.Name = "노드1";
            treeNode17.Tag = "Pgm032:경력증명서:981:599:Y:경력증명서";
            treeNode17.Text = "경력증명서";
            treeNode18.Name = "노드3";
            treeNode18.Text = "제증명 발급";
            treeNode19.Name = "노드4";
            treeNode19.Text = "근무 평가";
            treeNode20.Name = "노드5";
            treeNode20.Text = "분석 및 통계";
            treeNode21.Name = "노드0";
            treeNode21.Text = "인사 관리";
            this.tv_MainMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21});
            this.tv_MainMenu.Size = new System.Drawing.Size(244, 641);
            this.tv_MainMenu.TabIndex = 0;
            this.tv_MainMenu.DoubleClick += new System.EventHandler(this.tv_MainMenu_DoubleClick_1);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Location = new System.Drawing.Point(255, 65);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(975, 641);
            this.tabControl.TabIndex = 1;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            this.tabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(967, 615);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.pictureBox1, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(961, 609);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = global::LhrMain.Properties.Resources.logo__2_;
            this.pictureBox1.Location = new System.Drawing.Point(328, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.CadetBlue;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.info_user, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 713);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(244, 24);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // info_user
            // 
            this.info_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.info_user.AutoSize = true;
            this.info_user.ForeColor = System.Drawing.Color.White;
            this.info_user.Location = new System.Drawing.Point(59, 6);
            this.info_user.Name = "info_user";
            this.info_user.Size = new System.Drawing.Size(125, 12);
            this.info_user.TabIndex = 2;
            this.info_user.Text = "사용자: 이혜리(00001)";
            this.info_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.CadetBlue;
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.info_count, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.info_message, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.info_pgmid, 5, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(255, 713);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(975, 24);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(147, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Message";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info_count
            // 
            this.info_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.info_count.AutoSize = true;
            this.info_count.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.info_count.ForeColor = System.Drawing.Color.White;
            this.info_count.Location = new System.Drawing.Point(70, 6);
            this.info_count.Name = "info_count";
            this.info_count.Size = new System.Drawing.Size(71, 12);
            this.info_count.TabIndex = 2;
            this.info_count.Text = "0";
            this.info_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "Count";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info_message
            // 
            this.info_message.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.info_message.AutoSize = true;
            this.info_message.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.info_message.ForeColor = System.Drawing.Color.White;
            this.info_message.Location = new System.Drawing.Point(238, 6);
            this.info_message.Name = "info_message";
            this.info_message.Size = new System.Drawing.Size(41, 12);
            this.info_message.TabIndex = 6;
            this.info_message.Text = "메세지";
            this.info_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(794, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "프로그램ID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info_pgmid
            // 
            this.info_pgmid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.info_pgmid.AutoSize = true;
            this.info_pgmid.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.info_pgmid.ForeColor = System.Drawing.Color.White;
            this.info_pgmid.Location = new System.Drawing.Point(892, 6);
            this.info_pgmid.Name = "info_pgmid";
            this.info_pgmid.Size = new System.Drawing.Size(80, 12);
            this.info_pgmid.TabIndex = 7;
            this.info_pgmid.Text = "PGM0001";
            this.info_pgmid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_panel, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(255, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(975, 54);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_new_window);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 48);
            this.panel1.TabIndex = 0;
            // 
            // cb_new_window
            // 
            this.cb_new_window.AutoSize = true;
            this.cb_new_window.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_new_window.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_new_window.Location = new System.Drawing.Point(15, 28);
            this.cb_new_window.Name = "cb_new_window";
            this.cb_new_window.Size = new System.Drawing.Size(104, 17);
            this.cb_new_window.TabIndex = 6;
            this.cb_new_window.Text = "New Window";
            this.cb_new_window.UseVisualStyleBackColor = true;
            // 
            // btn_panel
            // 
            this.btn_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_panel.Location = new System.Drawing.Point(641, 3);
            this.btn_panel.Name = "btn_panel";
            this.btn_panel.Size = new System.Drawing.Size(331, 48);
            this.btn_panel.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel6.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(244, 54);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(77, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Human Resources Management";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 741);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainFrm";
            this.Text = "LHR인사관리시스템";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView tv_MainMenu;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label info_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label info_count;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label info_message;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label info_pgmid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel btn_panel;
        private System.Windows.Forms.CheckBox cb_new_window;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}