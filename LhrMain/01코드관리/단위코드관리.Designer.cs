
namespace LhrMain._01코드관리
{
    partial class 단위코드관리
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
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.combo3 = new System.Windows.Forms.ComboBox();
            this.cmb_gcode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comb_Gcode = new System.Windows.Forms.ComboBox();
            this.data_panel = new System.Windows.Forms.Panel();
            this.ct_unit_nm2 = new System.Windows.Forms.TextBox();
            this.ct_unit_use = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ct_unit_seq = new System.Windows.Forms.TextBox();
            this.ct_unit_nm = new System.Windows.Forms.TextBox();
            this.ct_unit_cd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_panel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_nm2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_use = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdg_grpcd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_digit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdg_grpnm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.data_panel.SuspendLayout();
            this.grid_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 12);
            this.label8.TabIndex = 44;
            this.label8.Text = "코드명 검색:";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(350, 9);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(154, 21);
            this.txt_Search.TabIndex = 43;
            // 
            // combo3
            // 
            this.combo3.FormattingEnabled = true;
            this.combo3.Location = new System.Drawing.Point(140, 33);
            this.combo3.Name = "combo3";
            this.combo3.Size = new System.Drawing.Size(119, 20);
            this.combo3.TabIndex = 42;
            this.combo3.Visible = false;
            // 
            // cmb_gcode
            // 
            this.cmb_gcode.FormattingEnabled = true;
            this.cmb_gcode.Location = new System.Drawing.Point(15, 33);
            this.cmb_gcode.Name = "cmb_gcode";
            this.cmb_gcode.Size = new System.Drawing.Size(119, 20);
            this.cmb_gcode.TabIndex = 41;
            this.cmb_gcode.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 40;
            this.label6.Text = "그룹코드:";
            // 
            // comb_Gcode
            // 
            this.comb_Gcode.FormattingEnabled = true;
            this.comb_Gcode.Location = new System.Drawing.Point(80, 10);
            this.comb_Gcode.Name = "comb_Gcode";
            this.comb_Gcode.Size = new System.Drawing.Size(153, 20);
            this.comb_Gcode.TabIndex = 39;
            this.comb_Gcode.SelectedIndexChanged += new System.EventHandler(this.comb_Gcode_SelectedIndexChanged);
            // 
            // data_panel
            // 
            this.data_panel.Controls.Add(this.ct_unit_nm2);
            this.data_panel.Controls.Add(this.ct_unit_use);
            this.data_panel.Controls.Add(this.label7);
            this.data_panel.Controls.Add(this.ct_unit_seq);
            this.data_panel.Controls.Add(this.ct_unit_nm);
            this.data_panel.Controls.Add(this.ct_unit_cd);
            this.data_panel.Controls.Add(this.label5);
            this.data_panel.Controls.Add(this.label4);
            this.data_panel.Controls.Add(this.label3);
            this.data_panel.Controls.Add(this.label2);
            this.data_panel.Controls.Add(this.label1);
            this.data_panel.Location = new System.Drawing.Point(629, 55);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(254, 379);
            this.data_panel.TabIndex = 37;
            // 
            // ct_unit_nm2
            // 
            this.ct_unit_nm2.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.ct_unit_nm2.Location = new System.Drawing.Point(94, 105);
            this.ct_unit_nm2.Name = "ct_unit_nm2";
            this.ct_unit_nm2.Size = new System.Drawing.Size(140, 21);
            this.ct_unit_nm2.TabIndex = 7;
            // 
            // ct_unit_use
            // 
            this.ct_unit_use.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ct_unit_use.AutoSize = true;
            this.ct_unit_use.Checked = true;
            this.ct_unit_use.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ct_unit_use.Location = new System.Drawing.Point(94, 189);
            this.ct_unit_use.Name = "ct_unit_use";
            this.ct_unit_use.Size = new System.Drawing.Size(15, 14);
            this.ct_unit_use.TabIndex = 9;
            this.ct_unit_use.Tag = "";
            this.ct_unit_use.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "코드명(축약)";
            // 
            // ct_unit_seq
            // 
            this.ct_unit_seq.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.ct_unit_seq.Location = new System.Drawing.Point(94, 145);
            this.ct_unit_seq.Name = "ct_unit_seq";
            this.ct_unit_seq.Size = new System.Drawing.Size(140, 21);
            this.ct_unit_seq.TabIndex = 8;
            // 
            // ct_unit_nm
            // 
            this.ct_unit_nm.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.ct_unit_nm.Location = new System.Drawing.Point(94, 63);
            this.ct_unit_nm.Name = "ct_unit_nm";
            this.ct_unit_nm.Size = new System.Drawing.Size(140, 21);
            this.ct_unit_nm.TabIndex = 6;
            // 
            // ct_unit_cd
            // 
            this.ct_unit_cd.Location = new System.Drawing.Point(94, 16);
            this.ct_unit_cd.Name = "ct_unit_cd";
            this.ct_unit_cd.Size = new System.Drawing.Size(140, 21);
            this.ct_unit_cd.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "사용여부";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "코드SEQ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "코드명(원형)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "단위코드";
            // 
            // grid_panel
            // 
            this.grid_panel.Controls.Add(this.dataGridView1);
            this.grid_panel.Location = new System.Drawing.Point(12, 55);
            this.grid_panel.Name = "grid_panel";
            this.grid_panel.Size = new System.Drawing.Size(611, 379);
            this.grid_panel.TabIndex = 38;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.status,
            this.unit_cd,
            this.unit_nm,
            this.unit_nm2,
            this.unit_seq,
            this.unit_use,
            this.cdg_grpcd,
            this.unit_digit,
            this.cdg_grpnm});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(605, 368);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataList_SelectionChanged);
            // 
            // status
            // 
            this.status.HeaderText = "상태";
            this.status.Name = "status";
            this.status.Width = 70;
            // 
            // unit_cd
            // 
            this.unit_cd.HeaderText = "단위코드";
            this.unit_cd.Name = "unit_cd";
            this.unit_cd.Width = 80;
            // 
            // unit_nm
            // 
            this.unit_nm.HeaderText = "코드명(원형)";
            this.unit_nm.Name = "unit_nm";
            this.unit_nm.Width = 150;
            // 
            // unit_nm2
            // 
            this.unit_nm2.HeaderText = "코드명(축약)";
            this.unit_nm2.Name = "unit_nm2";
            // 
            // unit_seq
            // 
            this.unit_seq.HeaderText = "코드seq";
            this.unit_seq.Name = "unit_seq";
            this.unit_seq.Width = 80;
            // 
            // unit_use
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "True";
            this.unit_use.DefaultCellStyle = dataGridViewCellStyle2;
            this.unit_use.HeaderText = "사용여부";
            this.unit_use.Name = "unit_use";
            this.unit_use.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unit_use.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.unit_use.Width = 80;
            // 
            // cdg_grpcd
            // 
            this.cdg_grpcd.HeaderText = "그룹코드";
            this.cdg_grpcd.Name = "cdg_grpcd";
            this.cdg_grpcd.Visible = false;
            // 
            // unit_digit
            // 
            this.unit_digit.HeaderText = "길이";
            this.unit_digit.Name = "unit_digit";
            this.unit_digit.Visible = false;
            this.unit_digit.Width = 80;
            // 
            // cdg_grpnm
            // 
            this.cdg_grpnm.HeaderText = "그룹코드명";
            this.cdg_grpnm.Name = "cdg_grpnm";
            this.cdg_grpnm.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // 단위코드관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 451);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.combo3);
            this.Controls.Add(this.cmb_gcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comb_Gcode);
            this.Controls.Add(this.data_panel);
            this.Controls.Add(this.grid_panel);
            this.Name = "단위코드관리";
            this.Text = "단위코드관리";
            this.Load += new System.EventHandler(this.단위코드관리_Load);
            this.data_panel.ResumeLayout(false);
            this.data_panel.PerformLayout();
            this.grid_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ComboBox combo3;
        private System.Windows.Forms.ComboBox cmb_gcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comb_Gcode;
        private System.Windows.Forms.Panel data_panel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ct_unit_seq;
        private System.Windows.Forms.TextBox ct_unit_nm;
        private System.Windows.Forms.TextBox ct_unit_cd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel grid_panel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox ct_unit_use;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox ct_unit_nm2;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_nm2;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_use;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdg_grpcd;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_digit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdg_grpnm;
    }
}