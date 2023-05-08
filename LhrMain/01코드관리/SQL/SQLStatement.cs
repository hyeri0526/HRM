using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LhrMain.SQL
{
    class SQLStatement
    {
        // 사용자 아이디와 패스워드 조회
        public static string
            SelectSQL = "select user_name,user_pswd from lhr_user where user_id = :user_id";

        //--------------------------------------- 그룹코드 ------------------------------------------------------
        //그룹코드 조회sql
        public static string
            SelectGcode = "SELECT cdg_grpcd, cdg_grpnm, cdg_digit, cdg_length, cdg_use FROM lhr_cdg " +
                        "where cdg_grpnm like :cdg_grpnm order by cdg_grpcd";
        //그룹코드 삽입sql
        public static string
            InsertGcode = "insert into lhr_cdg " +
                        "(cdg_grpcd, cdg_grpnm, cdg_digit, cdg_length, cdg_use) " +
                        " values " +
                        "(:cdg_grpcd, :cdg_grpnm, :cdg_digit, :cdg_length, :cdg_use)";
        //그룹코드 수정sql
        public static string
            UpdateGcode = "update lhr_cdg set " +
                        "cdg_grpnm=:cdg_grpnm, cdg_digit=:cdg_digit, cdg_length=:cdg_length, cdg_use=:cdg_use " +
                        "where cdg_grpcd = :cdg_grpcd";
        //그룹코드 삭제sql
        public static string
            DeleteGcode = "DELETE FROM lhr_cdg WHERE cdg_grpcd = :cdg_grpcd";


        //--------------------------------------- 단위코드 ------------------------------------------------------
        //단위코드에 그룹코드 세팅
        public static string
            SelectGrpcd = "SELECT cdg_grpcd, cdg_grpnm, cdg_digit, cdg_length, cdg_use, cdg_kind FROM lhr_cdg";

        //단위코드 조회sql
        public static string
            SelectUcode = " SELECT unit_grpcd, unit_cd, unit_nm, unit_nm2, unit_seq, unit_use ,cdg_grpnm " +
                          " FROM lhr_unit, lhr_cdg " +
                          " where unit_grpcd = cdg_grpcd" +
                          " and unit_grpcd like :cdg_grpcd and unit_nm like :unit_nm";
        //단위코드 삭제sql
        public static string
            DeleteUcode = "DELETE FROM lhr_unit WHERE unit_cd = :unit_cd";
        //단위코드 삽입sql
        public static string
           InsertUcode = "insert into lhr_unit " +
                       "(unit_grpcd, unit_cd, unit_nm, unit_nm2, unit_seq, unit_use) " +
                       " values " +
                       "(:cdg_grpcd, :unit_cd, :unit_nm, :unit_nm2, :unit_seq, :unit_use)";
        //단위코드 수정sql
        public static string
            UpdateUcode = "update lhr_unit set " +
                        "unit_nm =: unit_nm, unit_nm2 =: unit_nm2, unit_seq = :unit_seq , unit_use = :unit_use " +
                        "where unit_cd= :unit_cd";

        //--------------------------------------- 부서코드 ------------------------------------------------------
        //부서코드 조회sql
        public static string
            SelectDeptCode = "SELECT dept_code, dept_name, dept_names, dept_seq, dept_upp, dept_use FROM lhr_dept " +
                        "where dept_name like :dept_name order by dept_code ";
        //부서코드 삭제sql
        public static string
            DeleteDeptCode = "DELETE FROM lhr_dept WHERE dept_code = :dept_code";
        //부서코드 삽입sql
        public static string
           InsertDeptCode = "insert into lhr_dept " +
                       "(dept_code, dept_name, dept_names, dept_seq, dept_upp, dept_use) " +
                       " values " +
                       "(:dept_code, :dept_name, :dept_names, :dept_seq, :dept_upp, :dept_use)";
        //부서코드 수정sql
        public static string
            UpdateDeptCode = "update lhr_dept set " +
                        "dept_name=:dept_name, dept_names=:dept_names, dept_seq=:dept_seq, dept_upp=:dept_upp, dept_use=:dept_use " +
                        "where dept_code=:dept_code";

        //--------------------------------------- 대학 코드 ------------------------------------------------------
        //부서코드 조회sql
        public static string
            SelectUnivCode = "SELECT univ_code, univ_name, univ_seq, univ_use FROM lhr_univ " +
                        "where univ_name like :univ_name order by univ_code ";
        //부서코드 삭제sql
        public static string
            DeleteUnivCode = "DELETE FROM lhr_univ WHERE univ_code = :univ_code";
        //부서코드 삽입sql
        public static string
           InsertUnivCode = "insert into lhr_univ " +
                       "(univ_code, univ_name, univ_seq, univ_use) " +
                       " values " +
                       "(:univ_code, :univ_name, :univ_seq, :univ_use)";
        //부서코드 수정sql
        public static string
            UpdateUnivCode = "update lhr_univ set " +
                        "univ_code=:univ_code, univ_name=:univ_name, univ_seq=:univ_seq, univ_use=:univ_use " +
                        "where univ_code=:univ_code";
    }
}
