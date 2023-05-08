using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LhrMain
{
    /// <summary>
    ///**************************************************************************
    /// 1. Project        : LHR인사관리시스템
    /// 2. 업무분류       : 시스템
    /// 3. 업무명칭       : 시스템 메인메뉴 (통합버튼)
    /// 4. 최초작성 정보  : 2023.02.15 / 이혜리
    /// 5. 최근수정 정보  : 2023.02.15 / 이혜리
    ///**************************************************************************
    /// </summary>
    public partial class ButtonFrm : Form
    {
        public Button[] button;
        public TabControl tabControl;
        public Panel form_panel;
        public String form_load_style;
        public Form form_launcher;

        public ButtonFrm()
        {
            InitializeComponent();
        }

        private void ButtonFrm_Load(object sender, EventArgs e)
        {
            button = new Button[7] { btn_search, btn_insert, btn_update, btn_delete, btn_save, btn_cancel, btn_print };
            Utility.SetFuncBtn2(button, "0000000");
            //--공통버튼 ToolTip 설정-----------------------
            new ToolTip().SetToolTip(this.btn_search, "조회");
            new ToolTip().SetToolTip(this.btn_insert, "입력");
            new ToolTip().SetToolTip(this.btn_update, "수정");
            new ToolTip().SetToolTip(this.btn_delete, "삭제");
            new ToolTip().SetToolTip(this.btn_save, "저장");
            new ToolTip().SetToolTip(this.btn_cancel, "취소");
            new ToolTip().SetToolTip(this.btn_print, "인쇄");
            new ToolTip().SetToolTip(this.btn_close, "종료");
        }

        #region (Event)기능 버튼 Click (통합 버튼 이벤트 처리)
        //**************************************************************************
        //-- (Event)기능 버튼 Click (통합 버튼 이벤트 처리)
        //**************************************************************************
        private void BtnFunc_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.TabIndex == 7)    //--종료 버튼 Click
            {
                if (form_load_style.Equals("1"))
                {
                    if (MessageBox.Show("시스템을 종료합니다.", "종료메세지",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;

                    Application.Exit();
                }
                else
                {
                    if (btn_save.Enabled)  //--저장 버튼이 enabled라면
                    {
                        DialogResult result = MessageBox.Show("저장되지 않은 자료가 있습니다.취소하고 종료하시겠습니까?.", "종료확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No) return;
                    }
                    form_launcher.Close();
                }
                return;
            }

            if (form_load_style.Equals("1"))
            {
                Call_Method(btn.Tag as String);
            }
            else
            {
                Call_Method2(btn.Tag as String);
            }
        }
        #endregion

        #region 단위업무 화면 기능버튼 Method 호출
        //**************************************************************************
        //-- 단위업무 화면 기능버튼 Method 호출
        //**************************************************************************
        //---메인화면을 통해 보여줄때
        private void Call_Method(String _mtd)  // 버튼 Tag로 호출
        {
            if (tabControl.SelectedTab == null) return;
            if (tabControl.SelectedIndex == 0) return;   //Home Tabpage

            Form form = (Form)tabControl.SelectedTab.Controls[0];
            Type type = form.GetType();

            System.Reflection.MethodInfo mtd = type.GetMethod(_mtd);  // 버튼의 메서드 정보 저장
            if (mtd == null) return;
            mtd.Invoke(form, null);   // 버튼의 메서드 정보로 생성자 호출
        }
        //---론처를 통해 보여줄때
        private void Call_Method2(String _mtd)
        {
            Form form = (Form)form_panel.Controls[0];
            Type type = form.GetType();

            System.Reflection.MethodInfo mtd = type.GetMethod(_mtd);
            if (mtd == null) return;
            mtd.Invoke(form, null);
        }
        #endregion
        
    }
}
