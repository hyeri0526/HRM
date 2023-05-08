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


namespace LhrMain
{
    /// <summary>
    ///**************************************************************************
    /// 1. Project        : LHR 인사관리시스템
    /// 2. 업무분류       : 시스템
    /// 3. 업무명칭       : 시스템 메인메뉴
    /// 4. 최초작성 정보  : 2023.02.15 / 이혜리
    /// 5. 최근수정 정보  : 2023.04.07 / 이혜리 (통합버튼 Form 별도 구성)
    ///**************************************************************************
    /// </summary>
    /// 
    public partial class MainFrm : Form
    {
        public String UserId;  //로그인폼에서 넘어옴
        public String UserNm;  //로그인폼에서 넘어옴

        Point _imageLocation = new Point(20, 8);    //탭컨트롤 종료아이콘 위치변수
        Point _imgHitArea = new Point(20, 8);
        Button[] button;   // 버튼 객체배열
        

        public MainFrm()
        {
            InitializeComponent();
        }
        #region (Event)메인 프로그램 시작 시
        //**************************************************************************
        //-- (Event)메인 프로그램 시작 시 
        //**************************************************************************

        private void MainFrm_Load(object sender, EventArgs e)
        {
            //--로그인 화면 표시하기----------------------------------------------
            Login loginFrm = new Login(this);
            new Login(this).ShowDialog();
            
            tabControl.Padding = new Point(20, 4);
            // 하단 상태표시 글자
            info_user.Text = String.Format("사용자: {0}({1})", UserNm, UserId);
            info_message.Text = "";
            info_count.Text = "0";
            info_pgmid.Text = "";

            //---2023.02.15-----------------------------------------------------

            ButtonFrm bf = new ButtonFrm() { TopLevel = false, TopMost = true };    // 주요버튼 폼 동적 생성           

            btn_panel.Controls.Add(bf);             //생성된 버튼폼을 버튼패널에 추가

            bf.Show();                              

            button = bf.button;                    // 무슨 기능??
            bf.tabControl = this.tabControl;       //무슨 기능??

            //버튼form에 form_load_style을 1로 지정하면 메인화면을 통해 보여줄때를 달리 설정
            bf.form_load_style = "1";

            //---2023.02.17-----------------------------------------------------
            //탭컨트롤여백주기
            tabControl.Padding = new Point(20, 4);           
            
        }
        #endregion

        #region (Event)메뉴 선택 시(Double Click)
        //**************************************************************************
        //-- (Event)메뉴 선택 시(Double Click)
        //**************************************************************************
        private void tv_MainMenu_DoubleClick_1(object sender, EventArgs e)
        {
            /*----- Tag 정보--------------------------------------------------------
             * 0: Program Id
             * 1: Form Name
             * 2: Form Width
             * 3: Form Height
             * 4: Form Maximize
             * 5: Program Name
            ----------------------------------------------------------------------*/
            String tag = (String)(sender as TreeView).SelectedNode.Tag;
            if (String.IsNullOrEmpty(tag)) return;

            String[] tag_arr = tag.Split(':');
            if (tag_arr.Length != 6)
            {
                MessageBox.Show("선택된 메뉴에 대한 화면정보가 제대로 입력되지 않았습니다.");
                return;
            }

            //*---기능화면을 윈도우로 실행할지 또는 메인폼으로 삽입할 지 선택
            if (cb_new_window.Checked)
            {
                Load_Form2(tag_arr);
            }
            else
            {
                Load_Form(tag_arr);
            }
        }
    
        #endregion

        #region 메뉴 선택에 따른 해당 Form Load
        //**************************************************************************
        //-- 메뉴 선택에 따른 해당 Form Load 
        //**************************************************************************
        //** 1. 메인 메뉴에 삽입하는 형태로 Form Load----------------------------------
        private void Load_Form(String[] tag_arr)
        {
            Form form = Utility.TryGetFormByName(tag_arr[1]);  //이름으로 Form Object 생성
            if (form == null)
            {
                MessageBox.Show("해당메뉴 수행 프로그램이 존재하지 않습니다.");
                return;
            }
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            if (tag_arr[4].Equals("Y"))
            {
                form.Dock = DockStyle.Fill;
            }
            //---이미 존재하면, TabPage Activate
            TabPage tabPage = tabControl.TabPages[tag_arr[5]];
            if (tabPage != null)
            {
                tabControl.SelectTab(tabPage);
                return;
            }

            tabControl.TabPages.Add(tag_arr[5], tag_arr[5]);
            tabControl.TabPages[tabControl.TabPages.Count - 1].Controls.Add(form);
            tabControl.SelectTab(tabControl.TabPages.Count - 1);

            //---Loading Form에 초기값 전달
            InitialValue_Reflection_to_Form();

            form.Tag = tag_arr[0];
            form.Show();

            info_pgmid.Text = tag_arr[0];
            info_message.Text = "";

        }
        //** 2. 별도의 창을 띄우는 형태로 Form Load----------------------------------
        private void Load_Form2(String[] tag_arr)
        {
            var launcher = new Launcher();
            launcher.UserId = this.UserId;
            launcher.LoadingPgmId = tag_arr[0];
            launcher.LoadingPgmName = tag_arr[5];
            launcher.LoadingFormName = tag_arr[1];
            if (tag_arr[4].Equals("Y"))
            {
                launcher.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
            launcher.Width = Convert.ToInt32(tag_arr[2]) + 10;
            launcher.Height = Convert.ToInt32(tag_arr[3]) + 95 + 50;
            launcher.Show();
        }
        #endregion

        #region 초기설정값 Reflection to Loading Form
        //**************************************************************************
        //-- 초기설정값 Reflection to Loading Form
        //**************************************************************************
        private void InitialValue_Reflection_to_Form()
        {
            Form form = (Form)tabControl.SelectedTab.Controls[0];
            Type type = form.GetType();

            type.GetProperty("MainBtn")?.SetValue(form, button);
            type.GetProperty("UserId")?.SetValue(form, UserId);
            type.GetProperty("Info_Count")?.SetValue(form, info_count);
            type.GetProperty("Info_Message")?.SetValue(form, info_message);
        }
        #endregion       

        #region TapControl-> TabPage Header에 이미지 그리기
        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            //이 이벤트가 발생하려면 tabControl의 drwamode속성이  OwnerDrawFixed로 정의되어야만 함
            //반드시 프로젝트에서 오른쪽 클릭후 속성- 리소스 - 기존파일 추가 - 아이콘 모두 선택

            Rectangle r = e.Bounds;
            r = this.tabControl.GetTabRect(e.Index);
            r.Offset(5, 5);
            Brush TitleBrush = new SolidBrush(Color.Black);
            Font f = this.Font;
            string title = this.tabControl.TabPages[e.Index].Text;
            e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));

            if (e.Index == 0) return;
            if (e.Index != this.tabControl.SelectedIndex) return;  //선택된 Page에서만 Close Image 표시
            //Resource.Desinger.cs 에서 
            // internal static System.Drawing.Bitmap close

            Image img = new Bitmap(Properties.Resources.close);
            e.Graphics.DrawImage(img, new Point(r.X + (this.tabControl.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y));
        }
        #endregion

        #region (Event)TapPage Close 버튼 Click
        private void tabControl_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            if (tabControl.SelectedIndex == 0) return; // 제일 앞 탭이 선택되면 리턴

            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.tabControl.GetTabRect(tabControl.SelectedIndex).Width - (_imgHitArea.X);
            Rectangle r = this.tabControl.GetTabRect(tabControl.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 16;
            r.Height = 16;

            if (r.Contains(p))
            {
                TabPage tabPage = (TabPage)tabControl.TabPages[tabControl.SelectedIndex];

                //*--Page 삭제 前에 Form Close-----------
                Form form = (Form)tabPage.Controls[0];
                form.Close();
                //*--------------------------------------

                tabControl.TabPages.Remove(tabPage);
            }
        }
        #endregion

        #region TapPage가 선택될 때, 각 페이지에 따라 버튼 제어를 달리한다
        //**************************************************************************
        //-- TapPage가 선택될 때, 각 페이지에 따라 버튼 제어를 달리한다 
        //**************************************************************************
        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl.SelectedIndex == 0) //--Home TabPage 면 
            {
                Utility.SetFuncBtn2(button, "0000000");
                return;
            }

            Form form = (Form)tabControl.SelectedTab.Controls[0];
            Type type = form.GetType();

            PropertyInfo pi = type.GetProperty("last_button_status");
            if (pi != null)
            {
                Utility.SetFuncBtn2(button, pi.GetValue(form) as String);
            }
            info_pgmid.Text = form.Tag as String;
        }
        #endregion

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void MainFrm_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
