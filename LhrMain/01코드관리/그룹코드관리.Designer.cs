
namespace LhrMain._01코드관리
{
    partial class 그룹코드관리
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
            this.data_panel = new System.Windows.Forms.Panel();
            this.ct_cdg_use = new System.Windows.Forms.CheckBox();
            this.ct_cdg_length = new System.Windows.Forms.TextBox();
            this.ct_cdg_digit = new System.Windows.Forms.TextBox();
            this.ct_cdg_grpnm = new System.Windows.Forms.TextBox();
            this.ct_cdg_grpcd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_panel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdg_grpcd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdg_grpnm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdg_digit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdg_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdg_use = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdg_kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.data_panel.SuspendLayout();
            this.grid_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // data_panel
            // 
            this.data_panel.Controls.Add(this.ct_cdg_use);
            this.data_panel.Controls.Add(this.ct_cdg_length);
            this.data_panel.Controls.Add(this.ct_cdg_digit);
            this.data_panel.Controls.Add(this.ct_cdg_grpnm);
            this.data_panel.Controls.Add(this.ct_cdg_grpcd);
            this.data_panel.Controls.Add(this.label5);
            this.data_panel.Controls.Add(this.label4);
            this.data_panel.Controls.Add(this.label3);
            this.data_panel.Controls.Add(this.label2);
            this.data_panel.Controls.Add(this.label1);
            this.data_panel.Location = new System.Drawing.Point(667, 47);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(275, 400);
            this.data_panel.TabIndex = 14;
            // 
            // ct_cdg_use
            // 
            this.ct_cdg_use.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ct_cdg_use.AutoSize = true;
            this.ct_cdg_use.Checked = true;
            this.ct_cdg_use.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ct_cdg_use.Location = new System.Drawing.Point(120, 187);
            this.ct_cdg_use.Name = "ct_cdg_use";
            this.ct_cdg_use.Size = new System.Drawing.Size(15, 14);
            this.ct_cdg_use.TabIndex = 9;
            this.ct_cdg_use.Tag = "";
            this.ct_cdg_use.UseVisualStyleBackColor = true;
            // 
            // ct_cdg_length
            // 
            this.ct_cdg_length.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.ct_cdg_length.Location = new System.Drawing.Point(120, 145);
            this.ct_cdg_length.Name = "ct_cdg_length";
            this.ct_cdg_length.Size = new System.Drawing.Size(140, 21);
            this.ct_cdg_length.TabIndex = 8;
            // 
            // ct_cdg_digit
            // 
            this.ct_cdg_digit.Location = new System.Drawing.Point(120, 105);
            this.ct_cdg_digit.Name = "ct_cdg_digit";
            this.ct_cdg_digit.Size = new System.Drawing.Size(140, 21);
            this.ct_cdg_digit.TabIndex = 7;
            // 
            // ct_cdg_grpnm
            // 
            this.ct_cdg_grpnm.Location = new System.Drawing.Point(120, 63);
            this.ct_cdg_grpnm.Name = "ct_cdg_grpnm";
            this.ct_cdg_grpnm.Size = new System.Drawing.Size(140, 21);
            this.ct_cdg_grpnm.TabIndex = 6;
            // 
            // ct_cdg_grpcd
            // 
            this.ct_cdg_grpcd.Location = new System.Drawing.Point(120, 16);
            this.ct_cdg_grpcd.Name = "ct_cdg_grpcd";
            this.ct_cdg_grpcd.Size = new System.Drawing.Size(140, 21);
            this.ct_cdg_grpcd.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "사용여부";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "단위코드명 길이";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "단위코드 길이";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "그룹코드명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "그룹코드";
            // 
            // grid_panel
            // 
            this.grid_panel.Controls.Add(this.dataGridView1);
            this.grid_panel.Location = new System.Drawing.Point(12, 46);
            this.grid_panel.Name = "grid_panel";
            this.grid_panel.Size = new System.Drawing.Size(649, 400);
            this.grid_panel.TabIndex = 13;
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
            this.cdg_grpcd,
            this.cdg_grpnm,
            this.cdg_digit,
            this.cdg_length,
            this.cdg_use,
            this.cdg_kind});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 386);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataList_SelectionChanged);
            // 
            // status
            // 
            this.status.HeaderText = "상태";
            this.status.Name = "status";
            this.status.Width = 70;
            // 
            // cdg_grpcd
            // 
            this.cdg_grpcd.HeaderText = "그룹코드";
            this.cdg_grpcd.Name = "cdg_grpcd";
            this.cdg_grpcd.Width = 80;
            // 
            // cdg_grpnm
            // 
            this.cdg_grpnm.HeaderText = "그룹코드명";
            this.cdg_grpnm.Name = "cdg_grpnm";
            // 
            // cdg_digit
            // 
            this.cdg_digit.HeaderText = "단위코드 길이";
            this.cdg_digit.Name = "cdg_digit";
            this.cdg_digit.Width = 130;
            // 
            // cdg_length
            // 
            this.cdg_length.HeaderText = "단위코드명 길이";
            this.cdg_length.Name = "cdg_length";
            this.cdg_length.Width = 130;
            // 
            // cdg_use
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "True";
            this.cdg_use.DefaultCellStyle = dataGridViewCellStyle2;
            this.cdg_use.HeaderText = "사용여부";
            this.cdg_use.Name = "cdg_use";
            this.cdg_use.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cdg_use.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cdg_kind
            // 
            this.cdg_kind.HeaderText = "종류";
            this.cdg_kind.Name = "cdg_kind";
            this.cdg_kind.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(64, 10);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(154, 21);
            this.txt_Search.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "코드명:";
            // 
            // 그룹코드관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 451);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.data_panel);
            this.Controls.Add(this.grid_panel);
            this.Name = "그룹코드관리";
            this.Text = "그룹코드관리";
            this.Load += new System.EventHandler(this.그룹코드관리_Load);
            this.data_panel.ResumeLayout(false);
            this.data_panel.PerformLayout();
            this.grid_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel data_panel;
        private System.Windows.Forms.TextBox ct_cdg_length;
        private System.Windows.Forms.TextBox ct_cdg_digit;
        private System.Windows.Forms.TextBox ct_cdg_grpnm;
        private System.Windows.Forms.TextBox ct_cdg_grpcd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel grid_panel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox ct_cdg_use;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdg_grpcd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdg_grpnm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdg_digit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdg_length;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdg_use;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdg_kind;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Search;
    }
}