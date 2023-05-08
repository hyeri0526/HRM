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
using System.Reflection;

namespace LhrMain._02인사기록관리
{
    /// <summary>
    ///**************************************************************************
    /// 1. Project        : 교육용 시스템
    /// 2. 업무분류       : 업무1
    /// 3. 업무명칭       : 인사정보조회
    /// 4. 최초작성 정보  : 2023.04.18 / 이혜리
    /// 5. 최근수정 정보  : 2023.04.18 / 이혜리
    ///**************************************************************************
    /// </summary>
    /// 
    public partial class 인사정보조회 : Form
    {
        #region 초기 설정
        OracleConnection con = null;
        //************************************************************
        // 메인메뉴로부터 초기 설정값 넘겨 받기
        //************************************************************
        public Button[] MainBtn { get; set; }           // 메인기능 버튼
        public string UserId { get; set; }              // 사용자 ID
        public Label Info_Count { get; set; }           // 검색건수
        public Label Info_Message { get; set; }         // 하단 메세지
        public string last_button_status { get; set; }  // 버튼 최종상태

        public 인사정보조회()
        {
            InitializeComponent();
        }

        private void 인사정보조회_Load(object sender, EventArgs e)
        {
            last_button_status = Utility.SetFuncBtn2(MainBtn, "1000000");

            Utility.DataGridView_Scrolling_SpeedUp(dataGridView1);
        }
        #endregion

        #region 기능버튼(조회) Click
        //************************************************************
        //** 조회 버튼 Click
        //************************************************************
        //************************************************************
        //**Type.1  DataSource = DataTable*(가장 빠름)****************
        //************************************************************
        public void BtnSearch_Click()
        {
            Utility.BusyIndicator(true);

            //--DB Handling(Start)-------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQL.SQLStatement3.SelectSQL1;
                cmd.BindByName = true;
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = q_bas_empno.Text + "%";
                cmd.Parameters.Add("bas_name", OracleDbType.Varchar2).Value = "%" + q_bas_name.Text + "%";
                cmd.Parameters.Add("bas_dept", OracleDbType.Varchar2).Value = "%" + q_bas_dept.Text + "%";
                cmd.Parameters.Add("bas_pos", OracleDbType.Varchar2).Value = "%" + q_bas_pos.Text + "%";
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "TAB");
                dataGridView1.DataSource = ds.Tables["TAB"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                Utility.BusyIndicator(false);
                if (con != null) con.Close();
            }
            //--DB Handling(End)-------------------------------------
            var recCnt = dataGridView1.RowCount;
            Info_Count.Text = recCnt.ToString();
            if (recCnt == 0)
            {
                Info_Message.Text = "조건을 만족하는 자료가 없습니다.";
                return;
            }
            Info_Message.Text = "자료가 정상적으로 조회 되었습니다.";
        }
        //************************************************************
        //**Type.2  직접 DataGridView 핸들링**************************
        //************************************************************
        public void BtnSearch1_Click()
        {
            Utility.BusyIndicator(true);

            dataGridView1.Rows.Clear();
            int rowIdx = 0;
            DataGridViewRow row;
            //--DB Handling(Start)-------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQL.SQLStatement3.SelectSQL;
                cmd.BindByName = true;
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = q_bas_empno.Text + "%";
                cmd.Parameters.Add("bas_name", OracleDbType.Varchar2).Value = "%" + q_bas_name.Text + "%";
                cmd.Parameters.Add("bas_dept", OracleDbType.Varchar2).Value = "%" + q_bas_dept.Text + "%";
                cmd.Parameters.Add("bas_pos", OracleDbType.Varchar2).Value = "%" + q_bas_pos.Text + "%";
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rowIdx = dataGridView1.Rows.Add();
                    row = dataGridView1.Rows[rowIdx];
                    row.Cells["bas_empno"].Value = dr["bas_empno"].ToString();
                    row.Cells["bas_name"].Value = dr["bas_name"].ToString();
                    row.Cells["bas_dept"].Value = Utility.SetCode(dr["bas_dept"].ToString());
                    row.Cells["bas_pos"].Value = Utility.SetCode(dr["bas_pos"].ToString());
                    row.Cells["bas_jkp"].Value = Utility.SetCode(dr["bas_jkp"].ToString());
                    row.Cells["bas_cname"].Value = dr["bas_cname"].ToString();
                    row.Cells["bas_ename"].Value = dr["bas_ename"].ToString();
                    row.Cells["bas_sex"].Value = dr["bas_sex"].ToString();
                    row.Cells["bas_bth"].Value = Utility.FormatDate(dr["bas_bth"].ToString());
                    row.Cells["bas_mil"].Value = dr["bas_mil"].ToString();
                    row.Cells["bas_mar"].Value = Utility.ChangeBoolType(dr["bas_mar"].ToString());
                    row.Cells["bas_hdpno"].Value = dr["bas_hdpno"].ToString();
                    row.Cells["bas_univ"].Value = Utility.SetCode(dr["bas_univ"].ToString());
                    row.Cells["bas_zip"].Value = dr["bas_zip"].ToString();
                    row.Cells["bas_addr1"].Value = dr["bas_addr1"].ToString();
                    row.Cells["bas_addrex"].Value = dr["bas_addrex"].ToString();
                    row.Cells["bas_addr2"].Value = dr["bas_addr2"].ToString();
                    row.Cells["bas_sta"].Value = dr["bas_sta"].ToString();
                    row.Cells["bas_entdate"].Value = Utility.FormatDate(dr["bas_entdate"].ToString());
                    row.Cells["bas_resdate"].Value = Utility.FormatDate(dr["bas_resdate"].ToString());
                    row.Cells["bas_dptdate"].Value = Utility.FormatDate(dr["bas_dptdate"].ToString());
                    row.Cells["bas_posdate"].Value = Utility.FormatDate(dr["bas_posdate"].ToString());
                    row.Cells["bas_jkpdate"].Value = Utility.FormatDate(dr["bas_jkpdate"].ToString());
                    row.Cells["bas_levdate"].Value = Utility.FormatDate(dr["bas_levdate"].ToString());
                    row.Cells["bas_reidate"].Value = Utility.FormatDate(dr["bas_reidate"].ToString());
                    row.Cells["bas_acc_bank"].Value = Utility.SetCode(dr["bas_acc_bank"].ToString());
                    row.Cells["bas_acc_name"].Value = dr["bas_acc_name"].ToString();
                    row.Cells["bas_acc_no"].Value = dr["bas_acc_no"].ToString();
                    row.Cells["bas_salary"].Value = dr.IsDBNull(11) ? 0 : dr.GetDecimal(11);
                    row.Cells["bas_rmk"].Value = dr["bas_rmk"].ToString();
                    row.Cells["bas_img"].Value = dr["bas_img"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                Utility.BusyIndicator(false);
                if (con != null) con.Close();
            }
            //--DB Handling(End)-------------------------------------
            var recCnt = dataGridView1.RowCount;
            Info_Count.Text = recCnt.ToString();
            if (recCnt == 0)
            {
                Info_Message.Text = "조건을 만족하는 자료가 없습니다.";
                return;
            }
            Info_Message.Text = "자료가 정상적으로 조회 되었습니다.";
        }
        #endregion
    }
}
