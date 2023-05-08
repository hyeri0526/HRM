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
using System.Configuration;

namespace LhrMain
{    
    /// <summary>
    ///**************************************************************************
    /// 1. Project        : LHR인사관리 시스템
    /// 2. 업무분류       : 시스템
    /// 3. 업무명칭       : 시스템 로그인
    /// 4. 최초작성 정보  : 2023.02.14 / 이혜리
    /// 5. 최근수정 정보  : 2020.02.14 / 이혜리
    ///**************************************************************************
    /// </summary>
    public partial class Login : Form
    {
        MainFrm mainFrm;  // 메인화면 폼 변수
        private bool chk_userid_save;  //아이디 저장여부 변수
        private string saved_userid;   //아이디 변수
        private OracleConnection con = null;
        private bool btn_state = false;  // 종료버튼 안누른 상태

        public Login(MainFrm _mainFrm)
        {
            InitializeComponent();
            this.mainFrm = _mainFrm;
        }

        public bool Get_Btn_State() { return btn_state; }
        public void Set_Btn_State(bool btn_state) { this.btn_state = btn_state; }

        #region (Event)로그인 화면이 보여질 때
        private void Login_Shown(object sender, EventArgs e)
        {
            /*------------------------------------------------------------------
             사용자ID 저장여부 Check 
             \LhrSystem\LhrMain\bin\Debug\LhrMain.exe.Config 파일: 
             <appSettings>
             <add key="userid_save" value="0" />
             <add key="userid" value="aaa" />
             </appSettings>  
             -------------------------------------------------------------------*/
            string userid_save = ConfigurationManager.AppSettings["userid_save"];
            //사용자 아이디 저장: 1
            if (userid_save.Equals("1"))
            {
                cbx_useridSave.Checked = true;                               //아이디 저장 체크박스에 체크
                tb_userid.Text = ConfigurationManager.AppSettings["userid"]; // 이전에 저장된 아이디를 가져와서 텍스트박스에 넣기
                saved_userid = tb_userid.Text;                               // 현재 아이디를 saved_userid 변수에 넣기
                chk_userid_save = true;                                      // 아이디 저장여부 chk_userid_save 변수에 true
                tb_pswd.Focus(); 
            }
            else if (userid_save == null)
            {
                cbx_useridSave.Checked = false;  // 저장 체크박스 해제
                chk_userid_save = false;
                tb_userid.Focus();
            }
            else  // 사용자 아이디 저장: 0
            {
                cbx_useridSave.Checked = false;  // 저장 체크박스 해제
                chk_userid_save = false;
                tb_userid.Focus();
            }
        }
        #endregion 
        
        #region (Event)로그인 버튼 Click
        //**************************************************************************
        //-- (Event)로그인 버튼 Click
        //**************************************************************************
        private void btn_login_Click(object sender, EventArgs e)
        {
            if ((tb_userid.Text == "") | (tb_pswd.Text == ""))
            {
                MessageBox.Show("사용자 ID와 비밀번호를 입력하세요.", "로그인확인", MessageBoxButtons.OK, MessageBoxIcon.Hand); // x표 아이콘
                return;
            }
            /*-----사용자ID 저장 여부와 ID 에 변경이 있을 때------------------------*/
            bool change_check = false;
            if (cbx_useridSave.Checked != chk_userid_save)
            {
                change_check = true;
            }
            else if ((cbx_useridSave.Checked == true) & (tb_userid.Text != saved_userid))
            {
                change_check = true;
            }
            if (change_check == true)
            {
                try
                {
                    var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var settings = configFile.AppSettings.Settings;
                    settings["userid"].Value = tb_userid.Text;
                    settings["userid_save"].Value = cbx_useridSave.Checked == true ? "1" : "0";
                    configFile.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            /*----로그인 인증 (추가적용 포인트)------------------------------*/
            /*    1. 비밀번호는 SHA-256 일방향암호화로 관리  
            /*    2. 계정잠김(사용중지) 관리                          
            /*    3. 계정잠김(비밀번호 5회 오류) 관리                          
            /*    4. 계정잠김(장기미접속 사용자) 관리                          
            /*    5. 동일한 아이디로 중복 로그인 불허용 관리                          
            /*    6. 비밀번호 주기적 변경 관리                          
            /*----로그인 인증 -----------------------------------------------*/
            OracleDataReader dr = null;
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQL.SQLStatement.SelectSQL;     //"select user_name,user_pswd from lhr_user where user_id = :user_id";

                cmd.Parameters.Add("user_id", OracleDbType.Varchar2).Value = tb_userid.Text;
                dr = cmd.ExecuteReader();
                if (!dr.Read())                                   //사용자 ID 존재 하지 않으면
                {
                    MessageBox.Show("아이디 또는 비밀번호가 올바르지 않습니다.", "로그인확인", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                //---비밀번호 Check-----------------------------------------------------------------------------------------------------/
                if (tb_pswd.Text != dr.GetString(1))
                {
                    MessageBox.Show("아이디 또는 비밀번호가 올바르지 않습니다.", "로그인확인", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                mainFrm.UserId = tb_userid.Text;
                mainFrm.UserNm = dr.GetString(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                if (dr != null) dr.Close();
                if (con != null) con.Close();
            }
            //--DB Handling(End)-------------------------------------

            this.Close();
        }
        #endregion
        

        #region (Event)프로그램 종료 버튼 Click
        //**************************************************************************
        //-- (Event)프로그램 종료 버튼 Click
        //**************************************************************************
        private void btn_exit_Click(object sender, EventArgs e)
        {
            btn_state = true;
            this.Close();
        }
        #endregion

        private void tb_pswd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_login_Click(sender, e);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tb_pswd.Text = "sys";        
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btn_state == true)
            {
                Application.Exit();
            }            
        }
    }
}