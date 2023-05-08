using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LhrMain.SQL
{
    class SQLStatement4
    {
        //인사발령대장 조회sql
        public static string
            SelectPAPR = "SELECT papr_appno, papr_date, papr_content, papr_num FROM lhr_papr " +
                        "order by papr_appno";
        //인사발령대장 삽입sql
        public static string
            InsertPAPR = "insert into lhr_papr " +
                        "(papr_appno, papr_date, papr_content, papr_num) " +
                        " values " +
                        "(:papr_appno, :papr_date, :papr_content, :papr_num)";
        //인사발령대장 수정sql
        public static string
            UpdatePAPR = "update lhr_papr set " +
                        "papr_date=:papr_date, papr_content=:papr_content, papr_num=:papr_num " +
                        "where papr_appno=:papr_appno and papr_date=:papr_date";
        //인사발령대장 삭제sql
        public static string
            DeletePAPR = "DELETE FROM lhr_papr WHERE papr_appno = :papr_appno";

        //------------------------------------------------------------------------------------------------//
        //인사발령 조회sql
        public static string
            SelectPAPP = "SELECT papp_empno, papp_appno, papp_date, papp_pap, papp_content, papp_auth, papp_basis,  " +
                         "papp_rmk, papp_pos_cd, papp_jkp_cd, papp_dept_cd, papp_pos_nm, papp_jkp_nm, papp_dept_nm " +
                         " FROM lhr_papp order by papp_appno";
        //인사발령 삽입sql
        public static string
            InsertPAPP = "insert into lhr_papp " +
                        "(papp_empno, papp_appno, papp_date, papp_pap, papp_content, papp_auth, papp_basis,  " +
                        "papp_rmk, papp_pos_cd, papp_jkp_cd, papp_dept_cd, papp_pos_nm, papp_jkp_nm, papp_dept_nm) " +
                        " values " +
                        "(:papp_empno, :papp_appno, :papp_date, :papp_pap, :papp_content, :papp_auth, :papp_basis," +
                        ":papp_rmk, :papp_pos_cd, :papp_jkp_cd, :papp_dept_cd, :papp_pos_nm, :papp_jkp_nm, :papp_dept_nm) ";
        //인사발령 수정sql
        public static string
            UpdatePAPP = "update lhr_papp set " +
                        "papp_empno=:papp_empno, papp_appno=:papp_appno, papp_date=:papp_date, papp_pap=:papp_pap, papp_content=:" +
                        "papp_auth=:papp_auth, papp_basis=:papp_basis,papp_rmk=:papp_rmk, papp_pos_cd=:papp_pos_cd,  " +
                        "papp_jkp_cd=papp_jkp_cd:, papp_dept_cd=:papp_dept_cd, papp_pos_nm=:papp_pos_nm, " +
                        "papp_jkp_nm=:papp_jkp_nm, papp_dept_nm=:papp_dept_nm " +
                        "where papp_empno=:papp_empno and papp_appno=:papp_appno";
        //인사발령 삭제sql
        public static string
            DeletePAPP = "DELETE FROM lhr_papp WHERE papp_empno=:papp_empno and papp_appno=:papp_appno";

        //사원번호 검색창 조회sql
        public static string
            SelectEmpno = "select bas_empno as codekey ,bas_name as codenm from lhr_bas where bas_empno like :condition";

        //인사발령번호 검색창 조회sql
        public static string
            SelectAppno = "select papr_appno as codekey ,papr_date as codenm from lhr_papr where papr_appno like :condition";

        //사원번호에 따라 부서,직급,직책 조회sql
        public static string
            SelectDPJ = "select b.bas_dept, b.bas_pos, b.bas_jkp, " +
                        "d.dept_name as dept_name, ut1.unit_nm as pos_name, ut2.unit_nm as jkp_name " +
                        "from lhr_bas b " +
                        "left join lhr_dept d on b.bas_dept = d.dept_code " +
                        "left join lhr_unit ut1 on b.bas_pos = ut1.unit_cd " +
                        "left join lhr_unit ut2 on b.bas_jkp = ut2.unit_cd " +
                        "where bas_empno =:empno";

        //인사발령번호에 따라 인사발령내용 조회sql
        public static string
          SelectAppCnt = "select papr_content from lhr_papr where papr_appno = :appno ";
    }
}
