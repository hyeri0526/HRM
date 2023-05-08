using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;
using Oracle.ManagedDataAccess.Client;
using LhrMain._02인사기록관리;
using System.IO;

namespace LhrMain
{
    /// <summary>
    ///******************************************************************
    /// 1. Project        : LHR인사관리시스템
    /// 2. 업무분류       : 시스템
    /// 3. 업무명칭       : 인사기본정보(CRUD)
    /// 4. 최초작성 정보  : 2023.02.15 / 이혜리
    /// 5. 최근수정 정보  : 2023.04.20 / 이혜리
    ///******************************************************************
    /// </summary>
    /// 
    public partial class BasicFrm : Form
    {
        public bool image_ch = false; // 증명사진 이미지가 변경되었는지.

        #region 초기 설정
        OracleConnection con = null;
        private bool select_sw = false;
        private bool query_sw = false;
        //***************************************************************
        // 메인메뉴로부터 초기 설정값 넘겨 받기
        //***************************************************************
        public Button[] MainBtn { get; set; }           // 메인기능 버튼
        public string UserId { get; set; }              // 사용자 ID
        public Label Info_Count { get; set; }           // 검색건수
        public Label Info_Message { get; set; }         // 하단 메세지
        public string last_button_status { get; set; }  // 버튼 최종상태

        public BasicFrm()
        {
            InitializeComponent();
            //*---Value Changed Event Handler(Start)---------------------
            ct_bas_empno.TextChanged += InputData_TextChanged;
            ct_bas_name.TextChanged += InputData_TextChanged;
            ct_bas_ename.TextChanged += InputData_TextChanged;
            ct_bas_cname.TextChanged += InputData_TextChanged;
            ct_bas_sex.SelectedValueChanged += InputData_TextChanged;
            ct_bas_bth.TextChanged += InputData_TextChanged;
            ct_bas_mil.SelectedValueChanged += InputData_TextChanged;
            ct_bas_mar.CheckedChanged += InputData_TextChanged;
            ct_bas_hdpno.TextChanged += InputData_TextChanged;
            ct_bas_univ.TextChanged += InputData_TextChanged;
            ct_bas_zip.TextChanged += InputData_TextChanged;
            ct_bas_addr1.TextChanged += InputData_TextChanged;
            ct_bas_addrex.TextChanged += InputData_TextChanged;
            ct_bas_addr2.TextChanged += InputData_TextChanged;
            ct_bas_sta.SelectedValueChanged += InputData_TextChanged;
            ct_bas_dept.TextChanged += InputData_TextChanged;
            ct_bas_pos.SelectedValueChanged += InputData_TextChanged;
            ct_bas_jkp.SelectedValueChanged += InputData_TextChanged;
            ct_bas_entdate.TextChanged += InputData_TextChanged;
            ct_bas_resdate.TextChanged += InputData_TextChanged;
            ct_bas_dptdate.TextChanged += InputData_TextChanged;
            ct_bas_posdate.TextChanged += InputData_TextChanged;
            ct_bas_jkpdate.TextChanged += InputData_TextChanged;
            ct_bas_levdate.TextChanged += InputData_TextChanged;
            ct_bas_reidate.TextChanged += InputData_TextChanged;
            ct_bas_acc_bank.TextChanged += InputData_TextChanged;
            ct_bas_acc_name.TextChanged += InputData_TextChanged;
            ct_bas_acc_no.TextChanged += InputData_TextChanged;
            ct_bas_salary.TextChanged += InputData_TextChanged;
            ct_bas_rmk.TextChanged += InputData_TextChanged;
            ct_bas_img.TextChanged += InputData_TextChanged;
            //*---Value Changed Event Handler(End)-----------------------
            //*---Validated Event Handler(Start) 유효성 검사 ------------
            ct_bas_empno.Validated += Input_Validation_Check;
            ct_bas_name.Validated += Input_Validation_Check;
            ct_bas_sex.Validated += Input_Validation_Check;
            ct_bas_bth.Validated += Input_Validation_Check;
            ct_bas_entdate.Validated += Input_Validation_Check;
            ct_bas_resdate.Validated += Input_Validation_Check;
            ct_bas_dptdate.Validated += Input_Validation_Check;
            ct_bas_posdate.Validated += Input_Validation_Check;
            ct_bas_jkpdate.Validated += Input_Validation_Check;
            ct_bas_levdate.Validated += Input_Validation_Check;
            ct_bas_reidate.Validated += Input_Validation_Check;
            //*---Validated Event Handler(End)--------------------------
        }

        private void BasicFrm_Load(object sender, EventArgs e)
        {

            //*---Combox 채우기(From Code Table)-------------------------
            Utility.SetComboWithCdnm(ct_bas_pos, SQL.SQLStatement1.SelectSQL_lhr_pos);
            Utility.SetComboWithCdnm(ct_bas_jkp, SQL.SQLStatement1.SelectSQL_lhr_jkp);
            Utility.SetComboWithCdnm(ct_bas_acc_bank, SQL.SQLStatement1.SelectSQL_lhr_bank);

            //*---Combox => "" 을 추가--VS 2017만 해당?------------------
            ct_bas_sex.Items.Add("");
            ct_bas_sta.Items.Add("");
            ct_bas_mil.Items.Add("");
            ct_bas_pos.Items.Add("");
            ct_bas_jkp.Items.Add("");
            ct_bas_acc_bank.Items.Add("");

            last_button_status = Utility.SetFuncBtn(MainBtn, "1");
            Utility.DataGridView_Scrolling_SpeedUp(dataGridView1);
        }
        #endregion

        #region 기능버튼(조회) Click
        //**************************************************************
        //** 조회 버튼 Click
        //**************************************************************
        public void BtnSearch_Click()
        {
            Utility.BusyIndicator(true);

            dataGridView1.Rows.Clear();
            int rowIdx = 0;
            DataGridViewRow row;
            //--DB Handling(Start)--------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQL.SQLStatement1.SelectSQL;
                cmd.BindByName = true;                                        //바인드 변수를 사용할 때 이름으로 바인딩하도록 설정
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = q_bas_empno.Text + "%";
                cmd.Parameters.Add("bas_name", OracleDbType.Varchar2).Value = "%" + q_bas_name.Text + "%";
                cmd.Parameters.Add("bas_dept", OracleDbType.Varchar2).Value = "%" + q_bas_dept.Text + "%";
                cmd.Parameters.Add("bas_pos", OracleDbType.Varchar2).Value = "%" + q_bas_pos.Text + "%";
                OracleDataReader dr = cmd.ExecuteReader();
                query_sw = true;                                              // SelectionChanged Event 발생을 회피하기 위해 (On)
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
                    row.Cells["bas_salary"].Value = String.Format("{0:#,0}", dr["bas_salary"]);
                    //row.Cells["bas_salary"].Value = dr.IsDBNull(11) ? 0 : dr.GetDecimal(11);
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
                query_sw = false; //*---SelectionChanged Event 발생을 회피하기 위해 (Off)
                Utility.BusyIndicator(false);
                if (con != null) con.Close();
            }
            //--DB Handling(End)----------------------------------------
            var recCnt = dataGridView1.RowCount;
            Info_Count.Text = recCnt.ToString();
            if (recCnt == 0)
            {
                Info_Message.Text = "조건을 만족하는 자료가 없습니다.";
                last_button_status = Utility.SetFuncBtn(MainBtn, "1");
                return;
            }

            Utility.SetFocusingDataGridView(dataGridView1, 0); //Focus를 맨 첫줄로 보내기
            this.DataList_SelectionChanged(null, null);        //선택된 첫줄을 Control에 표시하기
            last_button_status = Utility.SetFuncBtn(MainBtn, "2");
            Info_Message.Text = "자료가 정상적으로 조회 되었습니다.";

            string empno = ct_bas_empno.Text;
            imgCall(empno);

        }
        #endregion
        
        #region 기능버튼(입력) Click
        //************************************************************
        //** 입력 버튼 Click 
        //************************************************************
        public void BtnInsert_Click()
        {
            var rowIdx = dataGridView1.CurrentRow == null ? 0 : dataGridView1.CurrentRow.Index;

            if (dataGridView1.Rows.Count == 0)
            {
                rowIdx = dataGridView1.Rows.Add();
            }
            else
            {
                rowIdx++;
                dataGridView1.Rows.Insert(rowIdx);  // 행추가
            }
            dataGridView1.Rows[rowIdx].Cells["status"].Value = "A"; // 입력상태로 초기화
            Utility.SetFocusingDataGridView(dataGridView1, rowIdx); //추가된 Row로 Focus이동
            ct_bas_empno.Focus();                                   //최초 입력 컨트롤(사원번호)로 이동

            last_button_status = Utility.SetFuncBtn(MainBtn, "3");  //버튼마지막 상태: 3번 추가,삭제,저장,취소

        }
        #endregion

        #region 기능버튼(수정) Click
        //************************************************************
        //** 수정 버튼 Click 
        //************************************************************
        public void BtnUpdate_Click()
        {
            MessageBox.Show(this.Name + " 수정버튼 사용하지 않음");
        }
        #endregion

        #region 기능버튼(삭제) Click
        //*************************************************************
        //*** 삭제 버튼 Click 
        //*************************************************************
        public void BtnDelete_Click()
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 자료를 먼저 선택하세요.", "삭제확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataGridViewRow row = dataGridView1.CurrentRow;
            //신규 입력중인 자료는 단순하게 Grid에서 제거만 한다.
            if ((String)row.Cells["status"].Value == "A")
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                return;
            }
            DialogResult result = MessageBox.Show(row.Cells["bas_empno"].Value +
                                                  " 자료를 삭제하시겠습니까.", "삭제확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            //--DB Handling(Start)--------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.BindByName = true;
                cmd.CommandText = SQL.SQLStatement1.DeleteSQL;
                cmd.Parameters.Add("key1", OracleDbType.Varchar2).Value = row.Cells["key1"].Value;
                if (cmd.ExecuteNonQuery() <= 0)
                {
                    Info_Message.Text = "자료 삭제에 문제가 있습니다. 시스템 담당자에게 문의하세요.";
                    return;
                }
                dataGridView1.Rows.RemoveAt(row.Index);
                Info_Count.Text = dataGridView1.RowCount.ToString();
                Info_Message.Text = "자료가 정상적으로 삭제 되었습니다.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                if (con != null) con.Close();
                //con?.Close();
            }
            //--DB Handling(End)-------------------------------------
            //* 삭제 후 리스트 자료가 없으면, 콘트롤의 값을 ""로 초기화
            if (dataGridView1.RowCount == 0)
            {
                select_sw = true;
                Utility.SetTextNull(data_panel);
                select_sw = false;
            }
        }
        #endregion

        #region 기능버튼(저장) Click -- 
        //************************************************************
        //** 저장 버튼 Click (여러 건의 DATA 추가입력/수정 후 저장)
        //************************************************************
        public void BtnSave_Click()
        {
            DialogResult result = MessageBox.Show("입력 및 수정중인 자료를 저장합니다.", "저장확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            // 입력값에 오류가 있는지 여부 확인
            if (!Utility.InputErrorCheck(dataGridView1)) return;


            OracleTransaction tran = null;
            try
            {
                con = Utility.SetOracleConnection();
                tran = con.BeginTransaction(IsolationLevel.ReadCommitted); //데이터를 읽을 때 해당 데이터가 다른 트랜잭션에서 변경되지 않음
                OracleCommand cmd = con.CreateCommand();
                cmd.BindByName = true;                                     //바인드 변수를 사용할 때 이름으로 바인딩하도록 설정
                cmd.Transaction = tran;                                    //실행될 때 해당 트랜잭션 내에서 실행 여러 명령을 하나의 트랜잭션으로 묶어서 실행하고자 할 때
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["status"].Value == null) continue;

                    if (row.Cells["status"].Value.Equals("A"))
                    {
                        cmd.CommandText = SQL.SQLStatement1.InsertSQL;
                        cmd.Parameters.Add("bas_img", OracleDbType.Blob).Value = Utility.ImageToByteArray(pictureBox1.Image);
                    }

                    if (row.Cells["status"].Value.Equals("U")) 
                    {
                        // 기존에 이미지 없고, 데이터 수정
                        if (row.Cells["bas_img"].Value == null || row.Cells["bas_img"].Value.ToString() == "")
                        {                            
                            cmd.CommandText = SQL.SQLStatement1.UpdateSQL;
                            cmd.Parameters.Add("bas_img", OracleDbType.Blob).Value = Utility.ImageToByteArray(pictureBox1.Image);
                        }
                        //기존에 이미지 있고, 다른 데이터 수정시에는 이미지는 빼고 update
                        else
                        {                            
                            cmd.CommandText = SQL.SQLStatement1.UpdateSQL2;                            
                        }                        
                    }

                    cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = row.Cells["bas_empno"].Value;
                    cmd.Parameters.Add("bas_name", OracleDbType.Varchar2).Value = row.Cells["bas_name"].Value;
                    cmd.Parameters.Add("bas_cname", OracleDbType.Varchar2).Value = row.Cells["bas_cname"].Value;
                    cmd.Parameters.Add("bas_ename", OracleDbType.Varchar2).Value = row.Cells["bas_ename"].Value;
                    cmd.Parameters.Add("bas_sex", OracleDbType.Varchar2).Value = row.Cells["bas_sex"].Value;
                    cmd.Parameters.Add("bas_bth", OracleDbType.Varchar2).Value = Utility.FormatDateR((string)row.Cells["bas_bth"].Value);
                    cmd.Parameters.Add("bas_mil", OracleDbType.Varchar2).Value = row.Cells["bas_mil"].Value;
                    cmd.Parameters.Add("bas_mar", OracleDbType.Varchar2).Value = Utility.ChangeBoolType(row.Cells["bas_mar"].Value, "YN");
                    cmd.Parameters.Add("bas_hdpno", OracleDbType.Varchar2).Value = row.Cells["bas_hdpno"].Value;
                    cmd.Parameters.Add("bas_zip", OracleDbType.Varchar2).Value = row.Cells["bas_zip"].Value;
                    cmd.Parameters.Add("bas_addr1", OracleDbType.Varchar2).Value = row.Cells["bas_addr1"].Value;
                    cmd.Parameters.Add("bas_addrex", OracleDbType.Varchar2).Value = row.Cells["bas_addrex"].Value;
                    cmd.Parameters.Add("bas_addr2", OracleDbType.Varchar2).Value = row.Cells["bas_addr2"].Value;
                    cmd.Parameters.Add("bas_sta", OracleDbType.Varchar2).Value = row.Cells["bas_sta"].Value;
                    cmd.Parameters.Add("bas_univ", OracleDbType.Varchar2).Value = Utility.GetCode((string)row.Cells["bas_univ"].Value);
                    cmd.Parameters.Add("bas_pos", OracleDbType.Varchar2).Value = Utility.GetCode((string)row.Cells["bas_pos"].Value);
                    cmd.Parameters.Add("bas_dept", OracleDbType.Varchar2).Value = Utility.GetCode((string)row.Cells["bas_dept"].Value);
                    cmd.Parameters.Add("bas_jkp", OracleDbType.Varchar2).Value = Utility.GetCode((string)row.Cells["bas_jkp"].Value);
                    cmd.Parameters.Add("bas_entdate", OracleDbType.Varchar2).Value = Utility.FormatDateR((string)row.Cells["bas_entdate"].Value);
                    cmd.Parameters.Add("bas_resdate", OracleDbType.Varchar2).Value = Utility.FormatDateR((string)row.Cells["bas_resdate"].Value);
                    cmd.Parameters.Add("bas_levdate", OracleDbType.Varchar2).Value = Utility.FormatDateR((string)row.Cells["bas_levdate"].Value);
                    cmd.Parameters.Add("bas_reidate", OracleDbType.Varchar2).Value = Utility.FormatDateR((string)row.Cells["bas_reidate"].Value);
                    cmd.Parameters.Add("bas_dptdate", OracleDbType.Varchar2).Value = Utility.FormatDateR((string)row.Cells["bas_dptdate"].Value);
                    cmd.Parameters.Add("bas_posdate", OracleDbType.Varchar2).Value = Utility.FormatDateR((string)row.Cells["bas_posdate"].Value);
                    cmd.Parameters.Add("bas_jkpdate", OracleDbType.Varchar2).Value = Utility.FormatDateR((string)row.Cells["bas_jkpdate"].Value);
                    cmd.Parameters.Add("bas_acc_bank", OracleDbType.Varchar2).Value = Utility.GetCode((string)row.Cells["bas_acc_bank"].Value);
                    cmd.Parameters.Add("bas_acc_name", OracleDbType.Varchar2).Value = row.Cells["bas_acc_name"].Value;
                    cmd.Parameters.Add("bas_acc_no", OracleDbType.Varchar2).Value = row.Cells["bas_acc_no"].Value;
                    cmd.Parameters.Add("bas_salary", OracleDbType.Varchar2).Value = row.Cells["bas_salary"].Value;
                    cmd.Parameters.Add("bas_rmk", OracleDbType.Varchar2).Value = row.Cells["bas_rmk"].Value;                    

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();  //*----반드시 포함
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                if (con != null) con.Close();
            }

            // 정상적으로 저장 후 초기화하기
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["status"].Value == null) continue;
                row.Cells["key1"].Value = row.Cells["bas_empno"].Value;
                row.Cells["status"].Value = "";
            }
            Info_Message.Text = "자료가 정상적으로 저장 되었습니다.";
            last_button_status = Utility.SetFuncBtn(MainBtn, "2");      //조회후 버튼 상태로 "1101001" 조회,입력, 삭제, 종료
        }
        #endregion

        #region 기능버튼(취소) Click
        //**************************************************************
        //** 취소 버튼 Click
        //**************************************************************
        public void BtnCancel_Click()
        {
            DialogResult result = MessageBox.Show("입력 및 수정중인 자료를 취소합니다.", "취소메세지", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            BtnSearch_Click();
        }
        #endregion

        #region Conrtrol Value Changed 공통 Event Handler
        //**************************************************************
        //*** Conrtrol Value Changed 공통 Event Handler
        //**************************************************************
        private void InputData_TextChanged(object sender, EventArgs e)
        {
            if (select_sw) return; //GridView 선택 시 최초값 설정에 따른 이벤트는 무시

            if (dataGridView1.SelectedRows.Count <= 0) return;

            Utility.SetValueToGridView(dataGridView1, sender as Control);

            //*--Data Status = "수정"  설정-----------------------------
            DataGridViewRow row = dataGridView1.CurrentRow;


            if ((String)row.Cells["status"].Value == "A" || (String)row.Cells["status"].Value == "U") return;
            else
            {
                row.Cells["status"].Value = "U";
            }
            //*--Data Status = "수정"  설정-----------------------------

            last_button_status = Utility.SetFuncBtn(MainBtn, "3");
        }
        #endregion

        #region DataGridView의 선택이 변경되었을 때 각 콘트롤에 Data Setting
        //**************************************************************
        //*** DataGridView의 선택이 변경되었을 때 각 콘트롤에 Data Setting
        //**************************************************************
        private void DataList_SelectionChanged(object sender, EventArgs e)
        {
            if (query_sw) return;  //* 조회 버튼을 누를때, 수행하지 않기 위해
            if (dataGridView1.Rows.Count == 0) return;

            select_sw = true;      //* Control의 TextChanged 이벤트와의 충돌을 피하기 위해 (On)

            Utility.SetValueToControlFromGridView(dataGridView1, data_panel);
            Input_Validation_Check(sender, e); //* Control 에 오류메세지 표시

            select_sw = false;    //* Control의 TextChanged 이벤트와의 충돌을 피하기 위해 (Off)
            pictureBox1.Image = null;

            string empno = ct_bas_empno.Text;
            imgCall(empno);
            
        }
        #endregion

        #region Input Data Validation Check (Validated Event)
        //************************************************************
        //** Input Data Validation Check (Validated Event)
        //************************************************************
        private void Input_Validation_Check(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0) return;

            dataGridView1.SelectedRows[0].ErrorText = "";
            //*---------------------------------------------------------------------------------------------------------
            if (ct_bas_empno.Text == "")
            {
                SetError(ct_bas_empno, "사원번호를 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_bas_empno, errorProvider1);
            }

            //*---------------------------------------------------------------------------------------------------------
            if (ct_bas_name.Text == "")
            {
                SetError(ct_bas_name, "성명을 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_bas_name, errorProvider1);
            }

            //*---------------------------------------------------------------------------------------------------------
            if (ct_bas_sex.Text == "")
            {
                SetError(ct_bas_sex, "성별을 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_bas_sex, errorProvider1);
            }
                        
            //*---------------------------------------------------------------------------------------------------------
            if (ct_bas_dept.Text == "")
            {
                SetError(ct_bas_dept, "부서를 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_bas_dept, errorProvider1);
            }

            //*---------------------------------------------------------------------------------------------------------
            if (ct_bas_pos.Text == "")
            {
                SetError(ct_bas_pos, "직급을 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_bas_pos, errorProvider1);
            }

            //*---------------------------------------------------------------------------------------------------------
            if (Utility.Check_Date_IsEmpty(ct_bas_bth.Text))
            {
                SetError(ct_bas_bth, "생년월일을 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else if (Utility.Check_Date_YYYYMMDD(ct_bas_bth.Text) == false)
            {
                SetError(ct_bas_bth, "생년월일 날짜형태가 올바르지 않습니다.", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_bas_bth, errorProvider1);
            }

            //*---------------------------------------------------------------------------------------------------------
            if (Utility.Check_Date_IsEmpty(ct_bas_entdate.Text))
            {
                SetError(ct_bas_entdate, "입사날짜를 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else if (Utility.Check_Date_YYYYMMDD(ct_bas_bth.Text) == false)
            {
                SetError(ct_bas_entdate, "입사 날짜형태가 올바르지 않습니다.", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_bas_entdate, errorProvider1);
            }

            //*---------------------------------------------------------------------------------------------------------
            if (Utility.Check_Date_YYYYMMDD(ct_bas_resdate.Text) == false)
            {
                SetError(ct_bas_resdate, "퇴사일자 날짜형태가 올바르지 않습니다.", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_bas_resdate, errorProvider1);
            }

            //*---------------------------------------------------------------------------------------------------------
            if (Utility.Check_Date_YYYYMMDD(ct_bas_levdate.Text) == false)
            {
                SetError(ct_bas_levdate, "휴직일자 날짜형태가 올바르지 않습니다.", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_bas_levdate, errorProvider1);
            }
            //*---------------------------------------------------------------------------------------------------------
            if (Utility.Check_Date_YYYYMMDD(ct_bas_reidate.Text) == false)
            {
                SetError(ct_bas_reidate, "복직일자 날짜형태가 올바르지 않습니다.", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_bas_reidate, errorProvider1);
            }

            //*---------------------------------------------------------------------------------------------------------
            if (Utility.Check_Date_YYYYMMDD(ct_bas_dptdate.Text) == false)
            {
                SetError(ct_bas_dptdate, "현부서일자 날짜형태가 올바르지 않습니다.", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_bas_dptdate, errorProvider1);
            }

            //*---------------------------------------------------------------------------------------------------------
            if (Utility.Check_Date_YYYYMMDD(ct_bas_posdate.Text) == false)
            {
                SetError(ct_bas_posdate, "현직급일자 날짜형태가 올바르지 않습니다.", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_bas_posdate, errorProvider1);
            }

            //*---------------------------------------------------------------------------------------------------------
            if (Utility.Check_Date_YYYYMMDD(ct_bas_jkpdate.Text) == false)
            {
                SetError(ct_bas_jkpdate, "현직책일자 날짜형태가 올바르지 않습니다.", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_bas_jkpdate, errorProvider1);
            }
            //*---------------------------------------------------------------------------------------------------------
        }
        private void SetError(Control ctl, String errMsg, DataGridViewRow row, ErrorProvider errProvider)
        {
            errProvider.SetError(ctl, errMsg);
            row.ErrorText = errMsg;
        }
        private void ResetError(Control ctl, ErrorProvider errProvider)
        {
            errProvider.SetError(ctl, "");
        }    
        #endregion

        #region TextBox에서 숫자만 입력받도록 (KeyPress Event)
        //************************************************************
        //** TextBox에서 숫자만 입력받도록 (KeyPress Event)
        //************************************************************
        private void Number_Only_Protect(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            //*--8 : BackSpace , 46 : dot  ----------------*/
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region 부서, 대학 코드 검색 윈도우 실행
        //*************************************************************
        //*** 코드 검색 윈도우 실행
        //*************************************************************
        private void btn_bas_univ_Click(object sender, EventArgs e)
        {
            if (Utility.ShowSearchCDWindow(SQL.SQLStatement1.SelectUniv, "프로그램코드", out string result) == true)
            {
                if (dataGridView1.SelectedRows.Count < 1) return;
                ct_bas_univ.Text = result;
            }
        }

        private void btn_bas_dept_Click(object sender, EventArgs e)
        {
            if (Utility.ShowSearchCDWindow(SQL.SQLStatement1.SelectDept, "프로그램코드", out string result) == true)
            {
                if (dataGridView1.SelectedRows.Count < 1) return;
                ct_bas_dept.Text = result;
            }
        }
        #endregion
        
        #region 우편번호 주소 검색 윈도우 실행
        //*************************************************************
        //*** 우편번호 주소 검색 윈도우 실행
        //*************************************************************
        private void btn_bas_zip_Click(object sender, EventArgs e)
        {
            ZipSearch frm = new ZipSearch();
            frm.ShowDialog();

            if (frm.Tag == null) { return; }
            DataRow dr = (DataRow)frm.Tag;

            ct_bas_zip.Text = dr["zonecode"].ToString();
            ct_bas_addr1.Text = dr["ADDR1"].ToString();
            ct_bas_addr2.Text = "";
            ct_bas_addrex.Text = dr["EX"].ToString();

            ct_bas_addr2.Focus();
        }
        #endregion
        
        #region 증명사진 등록/삭제 버튼 
        private void btnPic_Click(object sender, EventArgs e)
        {
            image_ch = false;

            if (ct_bas_empno.Text == "")
            {
                MessageBox.Show("사원이 선택되지 않았습니다.", "확인");
                return;
            }

            MessageBox.Show("증명사진은 한명 등록 후 저장 버튼을 눌러주세요.", "확인");
            string imame_file = string.Empty;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imame_file = dialog.FileName;
            }
            else if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            pictureBox1.Image = Bitmap.FromFile(imame_file);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            image_ch = true;
            dataGridView1.CurrentRow.Cells["status"].Value = "U";
            last_button_status = Utility.SetFuncBtn(MainBtn, "3");
        }

        private void btnPDel_Click(object sender, EventArgs e)
        {
            image_ch = false;
            if (pictureBox1.Image == null) return;

            pictureBox1.Image = null;
            ct_bas_img.Text = "";
            image_ch = true;
            dataGridView1.CurrentRow.Cells["status"].Value = "U";
            last_button_status = Utility.SetFuncBtn(MainBtn, "3");
        }
        #endregion

        #region 증명사진 DB에서 불러와서 picturebox에 로딩하기
        private void imgCall(string empno)
        {
            //-----------------증명사진 DB에서 불러와서 로딩하기---------------------------------------------------
            byte[] imageData = null;
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQL.SQLStatement1.SelectImage;
                cmd.BindByName = true;                                        //바인드 변수를 사용할 때 이름으로 바인딩하도록 설정
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = empno;
                OracleDataReader dr = cmd.ExecuteReader();
                query_sw = true;                                              // SelectionChanged Event 발생을 회피하기 위해 (On)
                if (dr.Read())
                {
                    if (dr["bas_img"] == null || dr["bas_img"].ToString() == "")
                    {
                        pictureBox1.Image = null;
                        return;
                    }

                    imageData = (byte[])dr["bas_img"];                         // BLOB 데이터를 바이트 배열로 변환

                    using (MemoryStream ms = new MemoryStream(imageData))     // 바이트 배열을 MemoryStream으로 변환
                    {
                        Image image = Image.FromStream(ms);                   // MemoryStream으로부터 이미지 로드                        
                        pictureBox1.Image = image;                            // PictureBox에 이미지 설정
                    }

                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                query_sw = false; //*---SelectionChanged Event 발생을 회피하기 위해 (Off)
                Utility.BusyIndicator(false);
                if (con != null) con.Close();
            }
        }
        #endregion        
        
    }
}
