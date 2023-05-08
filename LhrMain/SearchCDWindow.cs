using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Windows.Input;

namespace LhrMain
{
    public partial class SearchCDWindow : Form
    {
        private string result;
        private string sql;
        public string Aa;

        public string GetResult
        {
            get { return result; }
        }

        public SearchCDWindow(string sql)
        {
            this.sql = sql;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = string.Empty;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SearchCDWindow_Load(object sender, EventArgs e)
        {
            this.ActiveControl = searchText;
            searchText.Focus();
            //전체 리스트 다 보여주기
            Query_Code();
        }

        private void searchText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                Query_Code();
            }
        }
                
        private void Query_Code()
        {
            OracleConnection con = null;
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();

                cmd.CommandText = sql;
                cmd.Parameters.Add("condition", OracleDbType.Varchar2).Value = "%" + searchText.Text + "%";

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "TAB");
                dataGridView1.DataSource = ds.Tables["TAB"].DefaultView;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                if (con != null) con.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            result = (string)dataGridView1.Rows[e.RowIndex].Cells[0].Value + ":" +
                     (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value;            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
