
namespace LhrMain._01코드관리
{
    partial class 대학코드관리
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
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.data_panel = new System.Windows.Forms.Panel();
            this.ct_univ_use = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ct_univ_seq = new System.Windows.Forms.TextBox();
            this.ct_univ_name = new System.Windows.Forms.TextBox();
            this.ct_univ_code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.univ_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.univ_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.univ_seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.univ_use = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 12);
            this.label8.TabIndex = 56;
            this.label8.Text = "대학명 검색:";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(90, 14);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(154, 21);
            this.txt_Search.TabIndex = 55;
            // 
            // data_panel
            // 
            this.data_panel.Controls.Add(this.ct_univ_use);
            this.data_panel.Controls.Add(this.label6);
            this.data_panel.Controls.Add(this.ct_univ_seq);
            this.data_panel.Controls.Add(this.ct_univ_name);
            this.data_panel.Controls.Add(this.ct_univ_code);
            this.data_panel.Controls.Add(this.label4);
            this.data_panel.Controls.Add(this.label3);
            this.data_panel.Controls.Add(this.label2);
            this.data_panel.Controls.Add(this.label1);
            this.data_panel.Location = new System.Drawing.Point(553, 57);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(251, 379);
            this.data_panel.TabIndex = 53;
            // 
            // ct_univ_use
            // 
            this.ct_univ_use.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ct_univ_use.AutoSize = true;
            this.ct_univ_use.Checked = true;
            this.ct_univ_use.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ct_univ_use.Location = new System.Drawing.Point(95, 149);
            this.ct_univ_use.Name = "ct_univ_use";
            this.ct_univ_use.Size = new System.Drawing.Size(15, 14);
            this.ct_univ_use.TabIndex = 14;
            this.ct_univ_use.Tag = "";
            this.ct_univ_use.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "사용여부";
            // 
            // ct_univ_seq
            // 
            this.ct_univ_seq.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.ct_univ_seq.Location = new System.Drawing.Point(94, 108);
            this.ct_univ_seq.Name = "ct_univ_seq";
            this.ct_univ_seq.Size = new System.Drawing.Size(140, 21);
            this.ct_univ_seq.TabIndex = 8;
            // 
            // ct_univ_name
            // 
            this.ct_univ_name.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.ct_univ_name.Location = new System.Drawing.Point(94, 63);
            this.ct_univ_name.Name = "ct_univ_name";
            this.ct_univ_name.Size = new System.Drawing.Size(140, 21);
            this.ct_univ_name.TabIndex = 6;
            // 
            // ct_univ_code
            // 
            this.ct_univ_code.Location = new System.Drawing.Point(94, 16);
            this.ct_univ_code.Name = "ct_univ_code";
            this.ct_univ_code.Size = new System.Drawing.Size(140, 21);
            this.ct_univ_code.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 111);
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
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "대학교명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "대학코드";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(9, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 379);
            this.panel1.TabIndex = 54;
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
            this.univ_code,
            this.univ_name,
            this.univ_seq,
            this.univ_use});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(532, 368);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataList_SelectionChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // status
            // 
            this.status.HeaderText = "상태";
            this.status.Name = "status";
            this.status.Width = 70;
            // 
            // univ_code
            // 
            this.univ_code.HeaderText = "대학코드";
            this.univ_code.Name = "univ_code";
            this.univ_code.Width = 80;
            // 
            // univ_name
            // 
            this.univ_name.HeaderText = "대학명(원형)";
            this.univ_name.Name = "univ_name";
            this.univ_name.Width = 180;
            // 
            // univ_seq
            // 
            this.univ_seq.HeaderText = "코드seq";
            this.univ_seq.Name = "univ_seq";
            this.univ_seq.Width = 80;
            // 
            // univ_use
            // 
            this.univ_use.HeaderText = "사용여부";
            this.univ_use.Name = "univ_use";
            // 
            // 대학코드관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.data_panel);
            this.Controls.Add(this.panel1);
            this.Name = "대학코드관리";
            this.Text = "대학코드관리";
            this.Load += new System.EventHandler(this.대학코드관리_Load);
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
        private System.Windows.Forms.TextBox ct_univ_seq;
        private System.Windows.Forms.TextBox ct_univ_name;
        private System.Windows.Forms.TextBox ct_univ_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox ct_univ_use;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn univ_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn univ_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn univ_seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn univ_use;
    }
}