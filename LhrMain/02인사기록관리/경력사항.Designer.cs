
namespace LhrMain._02인사기록관리
{
    partial class 경력사항
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.data_panel = new System.Windows.Forms.Panel();
            this.ct_car_reason = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ct_car_dept = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ct_car_pos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ct_car_end = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ct_car_region = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ct_car_start = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ct_car_com = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ct_bas_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ct_bas_empno = new System.Windows.Forms.TextBox();
            this.search_panel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.q_bas_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.q_bas_empno = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bas_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.car_com = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.data_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.search_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.search_panel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(904, 531);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.data_panel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(353, 337);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(548, 191);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // data_panel
            // 
            this.data_panel.Controls.Add(this.ct_car_reason);
            this.data_panel.Controls.Add(this.label8);
            this.data_panel.Controls.Add(this.ct_car_dept);
            this.data_panel.Controls.Add(this.label7);
            this.data_panel.Controls.Add(this.ct_car_pos);
            this.data_panel.Controls.Add(this.label6);
            this.data_panel.Controls.Add(this.ct_car_end);
            this.data_panel.Controls.Add(this.label1);
            this.data_panel.Controls.Add(this.ct_car_region);
            this.data_panel.Controls.Add(this.label5);
            this.data_panel.Controls.Add(this.ct_car_start);
            this.data_panel.Controls.Add(this.label4);
            this.data_panel.Controls.Add(this.label3);
            this.data_panel.Controls.Add(this.ct_car_com);
            this.data_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_panel.Location = new System.Drawing.Point(4, 35);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(540, 152);
            this.data_panel.TabIndex = 7;
            // 
            // ct_car_reason
            // 
            this.ct_car_reason.Location = new System.Drawing.Point(102, 119);
            this.ct_car_reason.Name = "ct_car_reason";
            this.ct_car_reason.Size = new System.Drawing.Size(414, 21);
            this.ct_car_reason.TabIndex = 11;
            this.ct_car_reason.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 31;
            this.label8.Text = "퇴직/이직사유";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_car_dept
            // 
            this.ct_car_dept.Location = new System.Drawing.Point(360, 87);
            this.ct_car_dept.Name = "ct_car_dept";
            this.ct_car_dept.Size = new System.Drawing.Size(156, 21);
            this.ct_car_dept.TabIndex = 10;
            this.ct_car_dept.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 29;
            this.label7.Text = "담당부서";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_car_pos
            // 
            this.ct_car_pos.Location = new System.Drawing.Point(102, 84);
            this.ct_car_pos.Name = "ct_car_pos";
            this.ct_car_pos.Size = new System.Drawing.Size(156, 21);
            this.ct_car_pos.TabIndex = 9;
            this.ct_car_pos.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "최종직급";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_car_end
            // 
            this.ct_car_end.Location = new System.Drawing.Point(360, 51);
            this.ct_car_end.Mask = "0000-00-00";
            this.ct_car_end.Name = "ct_car_end";
            this.ct_car_end.Size = new System.Drawing.Size(156, 21);
            this.ct_car_end.TabIndex = 8;
            this.ct_car_end.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "근무종료월";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_car_region
            // 
            this.ct_car_region.Location = new System.Drawing.Point(360, 17);
            this.ct_car_region.Name = "ct_car_region";
            this.ct_car_region.Size = new System.Drawing.Size(156, 21);
            this.ct_car_region.TabIndex = 6;
            this.ct_car_region.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "근무시작월";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_car_start
            // 
            this.ct_car_start.Location = new System.Drawing.Point(102, 48);
            this.ct_car_start.Mask = "0000-00-00";
            this.ct_car_start.Name = "ct_car_start";
            this.ct_car_start.Size = new System.Drawing.Size(156, 21);
            this.ct_car_start.TabIndex = 7;
            this.ct_car_start.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "소재지";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "근무처명";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_car_com
            // 
            this.ct_car_com.Location = new System.Drawing.Point(102, 14);
            this.ct_car_com.Name = "ct_car_com";
            this.ct_car_com.Size = new System.Drawing.Size(156, 21);
            this.ct_car_com.TabIndex = 5;
            this.ct_car_com.Tag = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ct_bas_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ct_bas_empno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 24);
            this.panel1.TabIndex = 8;
            // 
            // ct_bas_name
            // 
            this.ct_bas_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ct_bas_name.Location = new System.Drawing.Point(178, 2);
            this.ct_bas_name.MaxLength = 5;
            this.ct_bas_name.Name = "ct_bas_name";
            this.ct_bas_name.ReadOnly = true;
            this.ct_bas_name.Size = new System.Drawing.Size(80, 21);
            this.ct_bas_name.TabIndex = 4;
            this.ct_bas_name.TabStop = false;
            this.ct_bas_name.Tag = "";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "사원정보";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_bas_empno
            // 
            this.ct_bas_empno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ct_bas_empno.Location = new System.Drawing.Point(102, 2);
            this.ct_bas_empno.MaxLength = 5;
            this.ct_bas_empno.Name = "ct_bas_empno";
            this.ct_bas_empno.ReadOnly = true;
            this.ct_bas_empno.Size = new System.Drawing.Size(74, 21);
            this.ct_bas_empno.TabIndex = 3;
            this.ct_bas_empno.TabStop = false;
            this.ct_bas_empno.Tag = "";
            // 
            // search_panel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.search_panel, 2);
            this.search_panel.Controls.Add(this.label13);
            this.search_panel.Controls.Add(this.q_bas_name);
            this.search_panel.Controls.Add(this.label12);
            this.search_panel.Controls.Add(this.q_bas_empno);
            this.search_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_panel.Location = new System.Drawing.Point(3, 3);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(898, 34);
            this.search_panel.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(172, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 20;
            this.label13.Text = "성명";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_bas_name
            // 
            this.q_bas_name.Location = new System.Drawing.Point(207, 12);
            this.q_bas_name.Name = "q_bas_name";
            this.q_bas_name.Size = new System.Drawing.Size(89, 21);
            this.q_bas_name.TabIndex = 2;
            this.q_bas_name.Tag = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 18;
            this.label12.Text = "사원번호";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_bas_empno
            // 
            this.q_bas_empno.Location = new System.Drawing.Point(68, 12);
            this.q_bas_empno.Name = "q_bas_empno";
            this.q_bas_empno.Size = new System.Drawing.Size(89, 21);
            this.q_bas_empno.TabIndex = 1;
            this.q_bas_empno.Tag = "";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bas_empno,
            this.bas_name,
            this.bas_dept});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(10, 50);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView, 2);
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(337, 478);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // bas_empno
            // 
            this.bas_empno.DataPropertyName = "bas_empno";
            this.bas_empno.HeaderText = "사원번호";
            this.bas_empno.Name = "bas_empno";
            this.bas_empno.ReadOnly = true;
            // 
            // bas_name
            // 
            this.bas_name.DataPropertyName = "bas_name";
            this.bas_name.HeaderText = "성명";
            this.bas_name.Name = "bas_name";
            this.bas_name.ReadOnly = true;
            // 
            // bas_dept
            // 
            this.bas_dept.DataPropertyName = "bas_dept";
            this.bas_dept.HeaderText = "부서";
            this.bas_dept.Name = "bas_dept";
            this.bas_dept.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.car_com,
            this.car_region,
            this.car_start,
            this.car_end,
            this.car_empno,
            this.car_pos,
            this.car_dept,
            this.car_reason,
            this.status,
            this.key1,
            this.key2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(353, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(548, 288);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataList_SelectionChanged);
            // 
            // car_com
            // 
            this.car_com.HeaderText = "근무처";
            this.car_com.Name = "car_com";
            // 
            // car_region
            // 
            this.car_region.HeaderText = "소재지";
            this.car_region.Name = "car_region";
            // 
            // car_start
            // 
            this.car_start.HeaderText = "근무시작";
            this.car_start.Name = "car_start";
            // 
            // car_end
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.car_end.DefaultCellStyle = dataGridViewCellStyle3;
            this.car_end.HeaderText = "근무종료";
            this.car_end.Name = "car_end";
            // 
            // car_empno
            // 
            this.car_empno.HeaderText = "사원번호";
            this.car_empno.Name = "car_empno";
            this.car_empno.ReadOnly = true;
            this.car_empno.Visible = false;
            // 
            // car_pos
            // 
            this.car_pos.HeaderText = "최종직급";
            this.car_pos.Name = "car_pos";
            // 
            // car_dept
            // 
            this.car_dept.HeaderText = "담당부서";
            this.car_dept.Name = "car_dept";
            // 
            // car_reason
            // 
            this.car_reason.HeaderText = "퇴직/이직사유";
            this.car_reason.Name = "car_reason";
            this.car_reason.Width = 200;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.Visible = false;
            // 
            // key1
            // 
            this.key1.HeaderText = "Key1";
            this.key1.Name = "key1";
            this.key1.Visible = false;
            // 
            // key2
            // 
            this.key2.HeaderText = "Key2";
            this.key2.Name = "key2";
            this.key2.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // 경력사항
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 531);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "경력사항";
            this.Text = "경력사항";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.경력사항_FormClosing);
            this.Load += new System.EventHandler(this.경력사항_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.data_panel.ResumeLayout(false);
            this.data_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel data_panel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox ct_car_start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ct_car_com;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ct_bas_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ct_bas_empno;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox q_bas_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox q_bas_empno;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_dept;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox ct_car_end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ct_car_region;
        private System.Windows.Forms.TextBox ct_car_reason;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ct_car_dept;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ct_car_pos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_com;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_region;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_end;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn key1;
        private System.Windows.Forms.DataGridViewTextBoxColumn key2;
    }
}