
namespace LhrMain._01코드관리
{
    partial class 부서코드관리
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
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.data_panel = new System.Windows.Forms.Panel();
            this.ct_dept_use = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ct_dept_upp = new System.Windows.Forms.TextBox();
            this.ct_dept_seq = new System.Windows.Forms.TextBox();
            this.ct_dept_names = new System.Windows.Forms.TextBox();
            this.ct_dept_name = new System.Windows.Forms.TextBox();
            this.ct_dept_code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_upp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_use = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.data_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 12);
            this.label8.TabIndex = 52;
            this.label8.Text = "부서명 검색:";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(91, 23);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(154, 21);
            this.txt_Search.TabIndex = 51;
            // 
            // data_panel
            // 
            this.data_panel.Controls.Add(this.ct_dept_use);
            this.data_panel.Controls.Add(this.label6);
            this.data_panel.Controls.Add(this.label7);
            this.data_panel.Controls.Add(this.ct_dept_upp);
            this.data_panel.Controls.Add(this.ct_dept_seq);
            this.data_panel.Controls.Add(this.ct_dept_names);
            this.data_panel.Controls.Add(this.ct_dept_name);
            this.data_panel.Controls.Add(this.ct_dept_code);
            this.data_panel.Controls.Add(this.label5);
            this.data_panel.Controls.Add(this.label4);
            this.data_panel.Controls.Add(this.label3);
            this.data_panel.Controls.Add(this.label2);
            this.data_panel.Controls.Add(this.label1);
            this.data_panel.Location = new System.Drawing.Point(672, 66);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(252, 379);
            this.data_panel.TabIndex = 45;
            // 
            // ct_dept_use
            // 
            this.ct_dept_use.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ct_dept_use.AutoSize = true;
            this.ct_dept_use.Checked = true;
            this.ct_dept_use.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ct_dept_use.Location = new System.Drawing.Point(93, 225);
            this.ct_dept_use.Name = "ct_dept_use";
            this.ct_dept_use.Size = new System.Drawing.Size(15, 14);
            this.ct_dept_use.TabIndex = 12;
            this.ct_dept_use.Tag = "";
            this.ct_dept_use.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "사용여부";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "부서명(축약)";
            // 
            // ct_dept_upp
            // 
            this.ct_dept_upp.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.ct_dept_upp.Location = new System.Drawing.Point(92, 186);
            this.ct_dept_upp.Name = "ct_dept_upp";
            this.ct_dept_upp.Size = new System.Drawing.Size(140, 21);
            this.ct_dept_upp.TabIndex = 9;
            // 
            // ct_dept_seq
            // 
            this.ct_dept_seq.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.ct_dept_seq.Location = new System.Drawing.Point(92, 145);
            this.ct_dept_seq.Name = "ct_dept_seq";
            this.ct_dept_seq.Size = new System.Drawing.Size(140, 21);
            this.ct_dept_seq.TabIndex = 8;
            // 
            // ct_dept_names
            // 
            this.ct_dept_names.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.ct_dept_names.Location = new System.Drawing.Point(92, 105);
            this.ct_dept_names.Name = "ct_dept_names";
            this.ct_dept_names.Size = new System.Drawing.Size(140, 21);
            this.ct_dept_names.TabIndex = 7;
            // 
            // ct_dept_name
            // 
            this.ct_dept_name.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.ct_dept_name.Location = new System.Drawing.Point(92, 63);
            this.ct_dept_name.Name = "ct_dept_name";
            this.ct_dept_name.Size = new System.Drawing.Size(140, 21);
            this.ct_dept_name.TabIndex = 6;
            // 
            // ct_dept_code
            // 
            this.ct_dept_code.Location = new System.Drawing.Point(92, 16);
            this.ct_dept_code.Name = "ct_dept_code";
            this.ct_dept_code.Size = new System.Drawing.Size(140, 21);
            this.ct_dept_code.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "상위부서코드";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "부서SEQ";
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
            this.label2.Text = "부서명(원형)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "부서코드";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(10, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 379);
            this.panel1.TabIndex = 46;
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
            this.dept_code,
            this.dept_name,
            this.dept_names,
            this.dept_seq,
            this.dept_upp,
            this.dept_use});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(646, 368);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataList_SelectionChanged);
            // 
            // status
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.status.DefaultCellStyle = dataGridViewCellStyle2;
            this.status.HeaderText = "상태";
            this.status.Name = "status";
            this.status.Width = 70;
            // 
            // dept_code
            // 
            this.dept_code.HeaderText = "부서코드";
            this.dept_code.Name = "dept_code";
            this.dept_code.Width = 80;
            // 
            // dept_name
            // 
            this.dept_name.HeaderText = "부서명(원형)";
            this.dept_name.Name = "dept_name";
            this.dept_name.Width = 150;
            // 
            // dept_names
            // 
            this.dept_names.HeaderText = "부서명칭(축약)";
            this.dept_names.Name = "dept_names";
            this.dept_names.Width = 120;
            // 
            // dept_seq
            // 
            this.dept_seq.HeaderText = "코드seq";
            this.dept_seq.Name = "dept_seq";
            this.dept_seq.Width = 80;
            // 
            // dept_upp
            // 
            this.dept_upp.HeaderText = "상위부서코드";
            this.dept_upp.Name = "dept_upp";
            this.dept_upp.Visible = false;
            this.dept_upp.Width = 120;
            // 
            // dept_use
            // 
            dataGridViewCellStyle3.NullValue = "True";
            this.dept_use.DefaultCellStyle = dataGridViewCellStyle3;
            this.dept_use.HeaderText = "사용여부";
            this.dept_use.Name = "dept_use";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // 부서코드관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 451);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.data_panel);
            this.Controls.Add(this.panel1);
            this.Name = "부서코드관리";
            this.Text = "부서코드관리";
            this.Load += new System.EventHandler(this.부서코드관리_Load);
            this.data_panel.ResumeLayout(false);
            this.data_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Panel data_panel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ct_dept_upp;
        private System.Windows.Forms.TextBox ct_dept_seq;
        private System.Windows.Forms.TextBox ct_dept_names;
        private System.Windows.Forms.TextBox ct_dept_name;
        private System.Windows.Forms.TextBox ct_dept_code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox ct_dept_use;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_names;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_upp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_use;
    }
}