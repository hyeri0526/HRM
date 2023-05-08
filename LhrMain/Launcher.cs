using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace LhrMain
{
    /// <summary>
    ///**************************************************************************
    /// 1. Project        : 교육용 시스템
    /// 2. 업무분류       : 시스템
    /// 3. 업무명칭       : 단위업무 런쳐
    /// 4. 최초작성 정보  : 2023.03.07 / 이혜리
    /// 5. 최근수정 정보  : 2023.03.07 / 이혜리
    ///**************************************************************************
    /// </summary>
    public partial class Launcher : Form
    {
        //************************************************************
        // 메인메뉴로부터 초기 설정값 넘겨 받기
        //************************************************************
        public string LoadingFormName;  // Loading 프로그램 Form Name
        public string LoadingPgmId;     // Loading 프로그램 Id
        public string LoadingPgmName;   // Loading 프로그램 이름
        public string UserId;           // 사용자 ID

        //************************************************************
        // 로컬변수 선언
        //************************************************************
        Button[] button;

        public Launcher()
        {
            InitializeComponent();
        }
        #region (Event)Form Load 시
        //**************************************************************************
        // (Event)Form(론처) Load 시
        //**************************************************************************
        private void Launcher_Load(object sender, EventArgs e)
        {
            //---2023.03.07-----------------------------------------------------
            ButtonFrm bf = new ButtonFrm() { TopLevel = false, TopMost = true };

            btn_panel.Controls.Add(bf);
            bf.Show();

            bf.form_panel = pnl_form;
            button = bf.button;
            bf.form_launcher = this;
            bf.form_load_style = "2";
            //---2023.03.07-----------------------------------------------------

            Form form = Utility.TryGetFormByName(LoadingFormName);  //이름으로 Form Object 생성

            if (form == null)
            {
                MessageBox.Show("해당메뉴 수행 프로그램이 존재하지 않습니다.");
                return;
            }
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            pnl_form.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            this.Text = LoadingPgmName;

            //---Loading Form에 초기값 전달
            InitialValue_Reflection_to_Form();

            form.Show();

            info_pgmid.Text = LoadingPgmId;
            info_message.Text = "";
        }
        #endregion

        #region 초기설정값 Reflection to Loading Form
        //**************************************************************************
        //-- 초기설정값 Reflection to Loading Form
        //**************************************************************************
        private void InitialValue_Reflection_to_Form()
        {
            Form form = (Form)pnl_form.Controls[0];
            Type type = form.GetType();

            type.GetProperty("MainBtn")?.SetValue(form, button);
            type.GetProperty("UserId")?.SetValue(form, UserId);
            type.GetProperty("Info_Count")?.SetValue(form, info_count);
            type.GetProperty("Info_Message")?.SetValue(form, info_message);
            /*--------------------------------------------------------------
            Button[] button = new Button[7];
            button[0] = btn_search;
            button[1] = btn_insert;
            button[2] = btn_update;
            button[3] = btn_delete;
            button[4] = btn_save;
            button[5] = btn_cancel;
            button[6] = btn_print;

            PropertyInfo pi = type.GetProperty("MainBtn");
            if (pi != null) pi.SetValue(form, button);

            pi = type.GetProperty("UserId");
            if (pi != null) pi.SetValue(form, UserId);

            pi = type.GetProperty("Info_Count");
            if (pi != null) pi.SetValue(form, info_count);

            pi = type.GetProperty("Info_Message");
            if (pi != null) pi.SetValue(form, info_message);
            ------------------------------------------------------------------*/

        }
        #endregion
    }
}
