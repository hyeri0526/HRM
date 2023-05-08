
namespace LhrMain._02인사기록관리
{
    partial class 가족관계정보
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
            this.label6 = new System.Windows.Forms.Label();
            this.ct_fam_ltg = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ct_fam_bth = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ct_fam_name = new System.Windows.Forms.TextBox();
            this.ct_fam_rel = new System.Windows.Forms.ComboBox();
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
            this.fam_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fam_rel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fam_bth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fam_ltg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fam_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tableLayoutPanel1.TabIndex = 3;
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
            this.data_panel.Controls.Add(this.label6);
            this.data_panel.Controls.Add(this.ct_fam_ltg);
            this.data_panel.Controls.Add(this.label5);
            this.data_panel.Controls.Add(this.ct_fam_bth);
            this.data_panel.Controls.Add(this.label4);
            this.data_panel.Controls.Add(this.label3);
            this.data_panel.Controls.Add(this.ct_fam_name);
            this.data_panel.Controls.Add(this.ct_fam_rel);
            this.data_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_panel.Location = new System.Drawing.Point(4, 35);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(540, 152);
            this.data_panel.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "동거여부";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_fam_ltg
            // 
            this.ct_fam_ltg.AutoSize = true;
            this.ct_fam_ltg.Location = new System.Drawing.Point(91, 98);
            this.ct_fam_ltg.Name = "ct_fam_ltg";
            this.ct_fam_ltg.Size = new System.Drawing.Size(15, 14);
            this.ct_fam_ltg.TabIndex = 4;
            this.ct_fam_ltg.Tag = "";
            this.ct_fam_ltg.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "생년월일";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_fam_bth
            // 
            this.ct_fam_bth.Location = new System.Drawing.Point(91, 70);
            this.ct_fam_bth.Mask = "0000-00-00";
            this.ct_fam_bth.Name = "ct_fam_bth";
            this.ct_fam_bth.Size = new System.Drawing.Size(156, 21);
            this.ct_fam_bth.TabIndex = 3;
            this.ct_fam_bth.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "관계";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "가족성명";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_fam_name
            // 
            this.ct_fam_name.Location = new System.Drawing.Point(91, 17);
            this.ct_fam_name.Name = "ct_fam_name";
            this.ct_fam_name.Size = new System.Drawing.Size(156, 21);
            this.ct_fam_name.TabIndex = 1;
            this.ct_fam_name.Tag = "";
            // 
            // ct_fam_rel
            // 
            this.ct_fam_rel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ct_fam_rel.FormattingEnabled = true;
            this.ct_fam_rel.Location = new System.Drawing.Point(91, 44);
            this.ct_fam_rel.Name = "ct_fam_rel";
            this.ct_fam_rel.Size = new System.Drawing.Size(156, 20);
            this.ct_fam_rel.TabIndex = 2;
            this.ct_fam_rel.SelectedValueChanged += new System.EventHandler(this.InputData_TextChanged);
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
            this.ct_bas_name.Location = new System.Drawing.Point(167, 2);
            this.ct_bas_name.MaxLength = 5;
            this.ct_bas_name.Name = "ct_bas_name";
            this.ct_bas_name.ReadOnly = true;
            this.ct_bas_name.Size = new System.Drawing.Size(80, 21);
            this.ct_bas_name.TabIndex = 22;
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
            this.ct_bas_empno.Location = new System.Drawing.Point(91, 2);
            this.ct_bas_empno.MaxLength = 5;
            this.ct_bas_empno.Name = "ct_bas_empno";
            this.ct_bas_empno.ReadOnly = true;
            this.ct_bas_empno.Size = new System.Drawing.Size(74, 21);
            this.ct_bas_empno.TabIndex = 20;
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
            this.q_bas_name.TabIndex = 19;
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
            this.q_bas_empno.TabIndex = 17;
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
            this.fam_name,
            this.fam_rel,
            this.fam_bth,
            this.fam_ltg,
            this.fam_empno,
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
            // fam_name
            // 
            this.fam_name.HeaderText = "가족성명";
            this.fam_name.Name = "fam_name";
            // 
            // fam_rel
            // 
            this.fam_rel.HeaderText = "관계";
            this.fam_rel.Name = "fam_rel";
            // 
            // fam_bth
            // 
            this.fam_bth.HeaderText = "생년월일";
            this.fam_bth.Name = "fam_bth";
            // 
            // fam_ltg
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fam_ltg.DefaultCellStyle = dataGridViewCellStyle3;
            this.fam_ltg.HeaderText = "동거여부";
            this.fam_ltg.Name = "fam_ltg";
            // 
            // fam_empno
            // 
            this.fam_empno.HeaderText = "사원번호";
            this.fam_empno.Name = "fam_empno";
            this.fam_empno.ReadOnly = true;
            this.fam_empno.Visible = false;
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
            // 가족관계정보
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 531);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "가족관계정보";
            this.Text = "가족관계정보";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.가족관계정보_FormClosing);
            this.Load += new System.EventHandler(this.가족관계정보_Load);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ct_fam_ltg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox ct_fam_bth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ct_fam_name;
        private System.Windows.Forms.ComboBox ct_fam_rel;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn fam_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn fam_rel;
        private System.Windows.Forms.DataGridViewTextBoxColumn fam_bth;
        private System.Windows.Forms.DataGridViewTextBoxColumn fam_ltg;
        private System.Windows.Forms.DataGridViewTextBoxColumn fam_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn key1;
        private System.Windows.Forms.DataGridViewTextBoxColumn key2;
    }
}