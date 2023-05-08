
namespace LhrMain._03인사발령
{
    partial class 인사발령대장
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.data_panel = new System.Windows.Forms.Panel();
            this.ct_papr_date = new System.Windows.Forms.MaskedTextBox();
            this.ct_papr_num = new System.Windows.Forms.TextBox();
            this.ct_papr_content = new System.Windows.Forms.TextBox();
            this.ct_papr_appno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.papr_appno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papr_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papr_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papr_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.data_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel1.Controls.Add(this.data_panel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 451);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // data_panel
            // 
            this.data_panel.Controls.Add(this.ct_papr_date);
            this.data_panel.Controls.Add(this.ct_papr_num);
            this.data_panel.Controls.Add(this.ct_papr_content);
            this.data_panel.Controls.Add(this.ct_papr_appno);
            this.data_panel.Controls.Add(this.label4);
            this.data_panel.Controls.Add(this.label3);
            this.data_panel.Controls.Add(this.label2);
            this.data_panel.Controls.Add(this.label1);
            this.data_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_panel.Location = new System.Drawing.Point(607, 3);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(274, 445);
            this.data_panel.TabIndex = 15;
            // 
            // ct_papr_date
            // 
            this.ct_papr_date.Location = new System.Drawing.Point(109, 63);
            this.ct_papr_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.ct_papr_date.Mask = "0000-00-00";
            this.ct_papr_date.Name = "ct_papr_date";
            this.ct_papr_date.Size = new System.Drawing.Size(140, 21);
            this.ct_papr_date.TabIndex = 2;
            this.ct_papr_date.ValidatingType = typeof(System.DateTime);
            // 
            // ct_papr_num
            // 
            this.ct_papr_num.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.ct_papr_num.Location = new System.Drawing.Point(109, 145);
            this.ct_papr_num.Name = "ct_papr_num";
            this.ct_papr_num.Size = new System.Drawing.Size(140, 21);
            this.ct_papr_num.TabIndex = 4;
            // 
            // ct_papr_content
            // 
            this.ct_papr_content.Location = new System.Drawing.Point(109, 105);
            this.ct_papr_content.Name = "ct_papr_content";
            this.ct_papr_content.Size = new System.Drawing.Size(140, 21);
            this.ct_papr_content.TabIndex = 3;
            // 
            // ct_papr_appno
            // 
            this.ct_papr_appno.Location = new System.Drawing.Point(109, 16);
            this.ct_papr_appno.Name = "ct_papr_appno";
            this.ct_papr_appno.Size = new System.Drawing.Size(140, 21);
            this.ct_papr_appno.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "발령인원";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "발령내용";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "시행일자";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "인사발령번호";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.papr_appno,
            this.papr_date,
            this.papr_content,
            this.papr_num,
            this.status});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(598, 445);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataList_SelectionChanged);
            // 
            // papr_appno
            // 
            this.papr_appno.HeaderText = "인사발령번호";
            this.papr_appno.Name = "papr_appno";
            // 
            // papr_date
            // 
            this.papr_date.HeaderText = "시행일자";
            this.papr_date.Name = "papr_date";
            // 
            // papr_content
            // 
            this.papr_content.HeaderText = "발령내용";
            this.papr_content.Name = "papr_content";
            this.papr_content.Width = 250;
            // 
            // papr_num
            // 
            this.papr_num.HeaderText = "발령인원수";
            this.papr_num.Name = "papr_num";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // 인사발령대장
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 451);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "인사발령대장";
            this.Text = "인사발령대장";
            this.Load += new System.EventHandler(this.인사발령대장_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.data_panel.ResumeLayout(false);
            this.data_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel data_panel;
        private System.Windows.Forms.TextBox ct_papr_num;
        private System.Windows.Forms.TextBox ct_papr_content;
        private System.Windows.Forms.TextBox ct_papr_appno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn papr_appno;
        private System.Windows.Forms.DataGridViewTextBoxColumn papr_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn papr_content;
        private System.Windows.Forms.DataGridViewTextBoxColumn papr_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox ct_papr_date;
    }
}