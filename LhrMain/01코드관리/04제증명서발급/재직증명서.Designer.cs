
namespace LhrMain._04제증명서발급
{
    partial class 재직증명서
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.search_panel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.q_bas_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.q_bas_empno = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.data_panel = new System.Windows.Forms.Panel();
            this.ct_ctf_cont = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ct_ctf_lang = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ct_bas_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ct_bas_empno = new System.Windows.Forms.TextBox();
            this.q_bas_pos = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.q_bas_dept = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.bas_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_bth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_addr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_addr2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_sta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_entdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_resdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_levdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_reidate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_dptdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_posdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_jkpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_jkp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ct_ctf_date = new System.Windows.Forms.DateTimePicker();
            this.ct_ctf_cnt = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.search_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.data_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_ctf_cnt)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.search_panel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 450);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // search_panel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.search_panel, 2);
            this.search_panel.Controls.Add(this.q_bas_pos);
            this.search_panel.Controls.Add(this.label17);
            this.search_panel.Controls.Add(this.q_bas_dept);
            this.search_panel.Controls.Add(this.label16);
            this.search_panel.Controls.Add(this.label13);
            this.search_panel.Controls.Add(this.q_bas_name);
            this.search_panel.Controls.Add(this.label12);
            this.search_panel.Controls.Add(this.q_bas_empno);
            this.search_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_panel.Location = new System.Drawing.Point(3, 3);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(978, 34);
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
            this.bas_bth,
            this.bas_addr1,
            this.bas_addr2,
            this.bas_sta,
            this.bas_entdate,
            this.bas_resdate,
            this.bas_levdate,
            this.bas_reidate,
            this.bas_dptdate,
            this.bas_posdate,
            this.bas_jkpdate,
            this.bas_dept,
            this.bas_pos,
            this.bas_jkp});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(10, 50);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(721, 397);
            this.dataGridView.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.data_panel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(737, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(244, 404);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // data_panel
            // 
            this.data_panel.Controls.Add(this.ct_ctf_cnt);
            this.data_panel.Controls.Add(this.ct_ctf_date);
            this.data_panel.Controls.Add(this.ct_ctf_cont);
            this.data_panel.Controls.Add(this.label8);
            this.data_panel.Controls.Add(this.label6);
            this.data_panel.Controls.Add(this.label5);
            this.data_panel.Controls.Add(this.label3);
            this.data_panel.Controls.Add(this.ct_ctf_lang);
            this.data_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_panel.Location = new System.Drawing.Point(4, 35);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(236, 365);
            this.data_panel.TabIndex = 7;
            // 
            // ct_ctf_cont
            // 
            this.ct_ctf_cont.Location = new System.Drawing.Point(73, 116);
            this.ct_ctf_cont.Name = "ct_ctf_cont";
            this.ct_ctf_cont.Size = new System.Drawing.Size(138, 21);
            this.ct_ctf_cont.TabIndex = 11;
            this.ct_ctf_cont.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 31;
            this.label8.Text = "발급용도";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "발급부수";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "발급언어";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "발급일자";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_ctf_lang
            // 
            this.ct_ctf_lang.Location = new System.Drawing.Point(73, 50);
            this.ct_ctf_lang.Name = "ct_ctf_lang";
            this.ct_ctf_lang.Size = new System.Drawing.Size(138, 21);
            this.ct_ctf_lang.TabIndex = 5;
            this.ct_ctf_lang.Tag = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ct_bas_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ct_bas_empno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 24);
            this.panel1.TabIndex = 8;
            // 
            // ct_bas_name
            // 
            this.ct_bas_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ct_bas_name.Location = new System.Drawing.Point(149, 2);
            this.ct_bas_name.MaxLength = 5;
            this.ct_bas_name.Name = "ct_bas_name";
            this.ct_bas_name.ReadOnly = true;
            this.ct_bas_name.Size = new System.Drawing.Size(62, 21);
            this.ct_bas_name.TabIndex = 4;
            this.ct_bas_name.TabStop = false;
            this.ct_bas_name.Tag = "";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "사원정보";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_bas_empno
            // 
            this.ct_bas_empno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ct_bas_empno.Location = new System.Drawing.Point(73, 2);
            this.ct_bas_empno.MaxLength = 5;
            this.ct_bas_empno.Name = "ct_bas_empno";
            this.ct_bas_empno.ReadOnly = true;
            this.ct_bas_empno.Size = new System.Drawing.Size(74, 21);
            this.ct_bas_empno.TabIndex = 3;
            this.ct_bas_empno.TabStop = false;
            this.ct_bas_empno.Tag = "";
            // 
            // q_bas_pos
            // 
            this.q_bas_pos.Location = new System.Drawing.Point(500, 12);
            this.q_bas_pos.Name = "q_bas_pos";
            this.q_bas_pos.Size = new System.Drawing.Size(89, 21);
            this.q_bas_pos.TabIndex = 28;
            this.q_bas_pos.Tag = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(465, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 27;
            this.label17.Text = "직급";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_bas_dept
            // 
            this.q_bas_dept.Location = new System.Drawing.Point(355, 12);
            this.q_bas_dept.Name = "q_bas_dept";
            this.q_bas_dept.Size = new System.Drawing.Size(89, 21);
            this.q_bas_dept.TabIndex = 26;
            this.q_bas_dept.Tag = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(320, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 25;
            this.label16.Text = "부서";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // bas_bth
            // 
            this.bas_bth.HeaderText = "생년월일";
            this.bas_bth.Name = "bas_bth";
            this.bas_bth.ReadOnly = true;
            // 
            // bas_addr1
            // 
            this.bas_addr1.HeaderText = "주소";
            this.bas_addr1.Name = "bas_addr1";
            this.bas_addr1.ReadOnly = true;
            this.bas_addr1.Visible = false;
            // 
            // bas_addr2
            // 
            this.bas_addr2.HeaderText = "상세주소";
            this.bas_addr2.Name = "bas_addr2";
            this.bas_addr2.ReadOnly = true;
            this.bas_addr2.Visible = false;
            // 
            // bas_sta
            // 
            this.bas_sta.HeaderText = "재직상태";
            this.bas_sta.Name = "bas_sta";
            this.bas_sta.ReadOnly = true;
            // 
            // bas_entdate
            // 
            this.bas_entdate.HeaderText = "입사일자";
            this.bas_entdate.Name = "bas_entdate";
            this.bas_entdate.ReadOnly = true;
            // 
            // bas_resdate
            // 
            this.bas_resdate.HeaderText = "퇴사일자";
            this.bas_resdate.Name = "bas_resdate";
            this.bas_resdate.ReadOnly = true;
            this.bas_resdate.Visible = false;
            // 
            // bas_levdate
            // 
            this.bas_levdate.HeaderText = "휴직일자";
            this.bas_levdate.Name = "bas_levdate";
            this.bas_levdate.ReadOnly = true;
            this.bas_levdate.Visible = false;
            // 
            // bas_reidate
            // 
            this.bas_reidate.HeaderText = "복직일자";
            this.bas_reidate.Name = "bas_reidate";
            this.bas_reidate.ReadOnly = true;
            this.bas_reidate.Visible = false;
            // 
            // bas_dptdate
            // 
            this.bas_dptdate.HeaderText = "현)부서일자";
            this.bas_dptdate.Name = "bas_dptdate";
            this.bas_dptdate.ReadOnly = true;
            this.bas_dptdate.Visible = false;
            // 
            // bas_posdate
            // 
            this.bas_posdate.HeaderText = "현)직급일자";
            this.bas_posdate.Name = "bas_posdate";
            this.bas_posdate.ReadOnly = true;
            this.bas_posdate.Visible = false;
            // 
            // bas_jkpdate
            // 
            this.bas_jkpdate.HeaderText = "현)직책일자";
            this.bas_jkpdate.Name = "bas_jkpdate";
            this.bas_jkpdate.ReadOnly = true;
            this.bas_jkpdate.Visible = false;
            // 
            // bas_dept
            // 
            this.bas_dept.DataPropertyName = "bas_dept";
            this.bas_dept.HeaderText = "현)부서";
            this.bas_dept.Name = "bas_dept";
            this.bas_dept.ReadOnly = true;
            // 
            // bas_pos
            // 
            this.bas_pos.HeaderText = "현)직급";
            this.bas_pos.Name = "bas_pos";
            this.bas_pos.ReadOnly = true;
            // 
            // bas_jkp
            // 
            this.bas_jkp.HeaderText = "현)직책";
            this.bas_jkp.Name = "bas_jkp";
            this.bas_jkp.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ct_ctf_date
            // 
            this.ct_ctf_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ct_ctf_date.Location = new System.Drawing.Point(73, 14);
            this.ct_ctf_date.Name = "ct_ctf_date";
            this.ct_ctf_date.Size = new System.Drawing.Size(138, 21);
            this.ct_ctf_date.TabIndex = 32;
            // 
            // ct_ctf_cnt
            // 
            this.ct_ctf_cnt.Location = new System.Drawing.Point(73, 84);
            this.ct_ctf_cnt.Name = "ct_ctf_cnt";
            this.ct_ctf_cnt.Size = new System.Drawing.Size(138, 21);
            this.ct_ctf_cnt.TabIndex = 33;
            this.ct_ctf_cnt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // 재직증명서
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "재직증명서";
            this.Text = "재직증명서";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.data_panel.ResumeLayout(false);
            this.data_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_ctf_cnt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox q_bas_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox q_bas_empno;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel data_panel;
        private System.Windows.Forms.TextBox ct_ctf_cont;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ct_ctf_lang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ct_bas_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ct_bas_empno;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox q_bas_pos;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox q_bas_dept;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_bth;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_addr1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_addr2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_sta;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_entdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_resdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_levdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_reidate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_dptdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_posdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_jkpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_jkp;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker ct_ctf_date;
        private System.Windows.Forms.NumericUpDown ct_ctf_cnt;
    }
}