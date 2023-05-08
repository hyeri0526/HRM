
namespace LhrMain._02인사기록관리
{
    partial class 인사정보조회
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.search_panel = new System.Windows.Forms.Panel();
            this.q_bas_pos = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.q_bas_dept = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.q_bas_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.q_bas_empno = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bas_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_jkp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_bth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_ename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_mil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_mar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_hdpno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_univ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_addr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_addrex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_addr2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_sta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_entdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_resdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_dptdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_posdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_jkpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_levdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_reidate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_acc_bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_acc_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_acc_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_rmk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.search_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 287F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.search_panel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(959, 608);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // search_panel
            // 
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
            this.search_panel.Size = new System.Drawing.Size(953, 34);
            this.search_panel.TabIndex = 0;
            // 
            // q_bas_pos
            // 
            this.q_bas_pos.Location = new System.Drawing.Point(488, 12);
            this.q_bas_pos.Name = "q_bas_pos";
            this.q_bas_pos.Size = new System.Drawing.Size(89, 21);
            this.q_bas_pos.TabIndex = 24;
            this.q_bas_pos.Tag = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(453, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 23;
            this.label17.Text = "직급";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_bas_dept
            // 
            this.q_bas_dept.Location = new System.Drawing.Point(343, 12);
            this.q_bas_dept.Name = "q_bas_dept";
            this.q_bas_dept.Size = new System.Drawing.Size(89, 21);
            this.q_bas_dept.TabIndex = 22;
            this.q_bas_dept.Tag = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(308, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 21;
            this.label16.Text = "부서";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bas_empno,
            this.bas_name,
            this.bas_dept,
            this.bas_pos,
            this.bas_jkp,
            this.bas_bth,
            this.bas_sex,
            this.bas_cname,
            this.bas_ename,
            this.bas_mil,
            this.bas_mar,
            this.bas_hdpno,
            this.bas_univ,
            this.bas_zip,
            this.bas_addr1,
            this.bas_addrex,
            this.bas_addr2,
            this.bas_sta,
            this.bas_entdate,
            this.bas_resdate,
            this.bas_dptdate,
            this.bas_posdate,
            this.bas_jkpdate,
            this.bas_levdate,
            this.bas_reidate,
            this.bas_acc_bank,
            this.bas_acc_name,
            this.bas_acc_no,
            this.bas_salary,
            this.bas_rmk,
            this.bas_img});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(946, 555);
            this.dataGridView1.TabIndex = 0;
            // 
            // bas_empno
            // 
            this.bas_empno.DataPropertyName = "bas_empno";
            this.bas_empno.HeaderText = "사원번호";
            this.bas_empno.Name = "bas_empno";
            this.bas_empno.ReadOnly = true;
            this.bas_empno.Width = 80;
            // 
            // bas_name
            // 
            this.bas_name.DataPropertyName = "bas_name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.bas_name.DefaultCellStyle = dataGridViewCellStyle2;
            this.bas_name.HeaderText = "성명";
            this.bas_name.Name = "bas_name";
            this.bas_name.ReadOnly = true;
            this.bas_name.Width = 60;
            // 
            // bas_dept
            // 
            this.bas_dept.DataPropertyName = "bas_dept";
            this.bas_dept.FillWeight = 80F;
            this.bas_dept.HeaderText = "부서";
            this.bas_dept.Name = "bas_dept";
            this.bas_dept.ReadOnly = true;
            // 
            // bas_pos
            // 
            this.bas_pos.DataPropertyName = "bas_pos";
            this.bas_pos.HeaderText = "직급";
            this.bas_pos.Name = "bas_pos";
            this.bas_pos.ReadOnly = true;
            // 
            // bas_jkp
            // 
            this.bas_jkp.DataPropertyName = "bas_jkp";
            this.bas_jkp.HeaderText = "직책";
            this.bas_jkp.Name = "bas_jkp";
            this.bas_jkp.ReadOnly = true;
            // 
            // bas_bth
            // 
            this.bas_bth.DataPropertyName = "bas_bth";
            this.bas_bth.HeaderText = "생년월일";
            this.bas_bth.Name = "bas_bth";
            this.bas_bth.ReadOnly = true;
            // 
            // bas_sex
            // 
            this.bas_sex.DataPropertyName = "bas_sex";
            this.bas_sex.HeaderText = "성별";
            this.bas_sex.Name = "bas_sex";
            this.bas_sex.ReadOnly = true;
            this.bas_sex.Width = 60;
            // 
            // bas_cname
            // 
            this.bas_cname.DataPropertyName = "bas_cname";
            this.bas_cname.HeaderText = "성명(한자)";
            this.bas_cname.Name = "bas_cname";
            this.bas_cname.ReadOnly = true;
            // 
            // bas_ename
            // 
            this.bas_ename.DataPropertyName = "bas_ename";
            this.bas_ename.HeaderText = "성명(영문)";
            this.bas_ename.Name = "bas_ename";
            this.bas_ename.ReadOnly = true;
            // 
            // bas_mil
            // 
            this.bas_mil.DataPropertyName = "bas_mil";
            this.bas_mil.HeaderText = "병역구분";
            this.bas_mil.Name = "bas_mil";
            this.bas_mil.ReadOnly = true;
            // 
            // bas_mar
            // 
            this.bas_mar.DataPropertyName = "bas_mar";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.NullValue = "False";
            this.bas_mar.DefaultCellStyle = dataGridViewCellStyle3;
            this.bas_mar.HeaderText = "결혼여부";
            this.bas_mar.Name = "bas_mar";
            this.bas_mar.ReadOnly = true;
            this.bas_mar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bas_hdpno
            // 
            this.bas_hdpno.DataPropertyName = "bas_hdpno";
            this.bas_hdpno.HeaderText = "휴대폰";
            this.bas_hdpno.Name = "bas_hdpno";
            this.bas_hdpno.ReadOnly = true;
            // 
            // bas_univ
            // 
            this.bas_univ.DataPropertyName = "bas_univ";
            this.bas_univ.HeaderText = "출신대학";
            this.bas_univ.Name = "bas_univ";
            this.bas_univ.ReadOnly = true;
            // 
            // bas_zip
            // 
            this.bas_zip.DataPropertyName = "bas_zip";
            this.bas_zip.HeaderText = "우편번호";
            this.bas_zip.Name = "bas_zip";
            this.bas_zip.ReadOnly = true;
            // 
            // bas_addr1
            // 
            this.bas_addr1.DataPropertyName = "bas_addr1";
            this.bas_addr1.HeaderText = "주소";
            this.bas_addr1.Name = "bas_addr1";
            this.bas_addr1.ReadOnly = true;
            // 
            // bas_addrex
            // 
            this.bas_addrex.DataPropertyName = "bas_addrex";
            this.bas_addrex.HeaderText = "주소참고";
            this.bas_addrex.Name = "bas_addrex";
            this.bas_addrex.ReadOnly = true;
            // 
            // bas_addr2
            // 
            this.bas_addr2.DataPropertyName = "bas_addr2";
            this.bas_addr2.HeaderText = "상세주소";
            this.bas_addr2.Name = "bas_addr2";
            this.bas_addr2.ReadOnly = true;
            // 
            // bas_sta
            // 
            this.bas_sta.DataPropertyName = "bas_sta";
            this.bas_sta.HeaderText = "재직상태";
            this.bas_sta.Name = "bas_sta";
            this.bas_sta.ReadOnly = true;
            // 
            // bas_entdate
            // 
            this.bas_entdate.DataPropertyName = "bas_entdate";
            this.bas_entdate.HeaderText = "입사일자";
            this.bas_entdate.Name = "bas_entdate";
            this.bas_entdate.ReadOnly = true;
            // 
            // bas_resdate
            // 
            this.bas_resdate.DataPropertyName = "bas_resdate";
            this.bas_resdate.HeaderText = "퇴사일자";
            this.bas_resdate.Name = "bas_resdate";
            this.bas_resdate.ReadOnly = true;
            // 
            // bas_dptdate
            // 
            this.bas_dptdate.DataPropertyName = "bas_dptdate";
            this.bas_dptdate.HeaderText = "현부서일자";
            this.bas_dptdate.Name = "bas_dptdate";
            this.bas_dptdate.ReadOnly = true;
            // 
            // bas_posdate
            // 
            this.bas_posdate.DataPropertyName = "bas_posdate";
            this.bas_posdate.HeaderText = "현직급일자";
            this.bas_posdate.Name = "bas_posdate";
            this.bas_posdate.ReadOnly = true;
            // 
            // bas_jkpdate
            // 
            this.bas_jkpdate.DataPropertyName = "bas_jkpdate";
            this.bas_jkpdate.HeaderText = "현직책일자";
            this.bas_jkpdate.Name = "bas_jkpdate";
            this.bas_jkpdate.ReadOnly = true;
            // 
            // bas_levdate
            // 
            this.bas_levdate.DataPropertyName = "bas_levdate";
            this.bas_levdate.HeaderText = "휴직일자";
            this.bas_levdate.Name = "bas_levdate";
            this.bas_levdate.ReadOnly = true;
            // 
            // bas_reidate
            // 
            this.bas_reidate.DataPropertyName = "bas_reidate";
            this.bas_reidate.HeaderText = "복직일자";
            this.bas_reidate.Name = "bas_reidate";
            this.bas_reidate.ReadOnly = true;
            // 
            // bas_acc_bank
            // 
            this.bas_acc_bank.DataPropertyName = "bas_acc_bank";
            this.bas_acc_bank.HeaderText = "은행명";
            this.bas_acc_bank.Name = "bas_acc_bank";
            this.bas_acc_bank.ReadOnly = true;
            // 
            // bas_acc_name
            // 
            this.bas_acc_name.DataPropertyName = "bas_acc_name";
            this.bas_acc_name.HeaderText = "예금주";
            this.bas_acc_name.Name = "bas_acc_name";
            this.bas_acc_name.ReadOnly = true;
            // 
            // bas_acc_no
            // 
            this.bas_acc_no.DataPropertyName = "bas_acc_no";
            this.bas_acc_no.HeaderText = "계좌번호";
            this.bas_acc_no.Name = "bas_acc_no";
            this.bas_acc_no.ReadOnly = true;
            // 
            // bas_salary
            // 
            this.bas_salary.DataPropertyName = "bas_salary";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.bas_salary.DefaultCellStyle = dataGridViewCellStyle4;
            this.bas_salary.HeaderText = "연봉";
            this.bas_salary.Name = "bas_salary";
            this.bas_salary.ReadOnly = true;
            // 
            // bas_rmk
            // 
            this.bas_rmk.DataPropertyName = "bas_rmk";
            this.bas_rmk.HeaderText = "참고사항";
            this.bas_rmk.Name = "bas_rmk";
            this.bas_rmk.ReadOnly = true;
            // 
            // bas_img
            // 
            this.bas_img.DataPropertyName = "bas_img";
            this.bas_img.HeaderText = "증명사진";
            this.bas_img.Name = "bas_img";
            this.bas_img.ReadOnly = true;
            this.bas_img.Visible = false;
            // 
            // 인사정보조회
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 608);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "인사정보조회";
            this.Text = "인사정보조회";
            this.Load += new System.EventHandler(this.인사정보조회_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.TextBox q_bas_pos;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox q_bas_dept;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox q_bas_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox q_bas_empno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_jkp;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_bth;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_ename;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_mil;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_mar;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_hdpno;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_univ;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_zip;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_addr1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_addrex;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_addr2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_sta;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_entdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_resdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_dptdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_posdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_jkpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_levdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_reidate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_acc_bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_acc_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_acc_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_rmk;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_img;
    }
}