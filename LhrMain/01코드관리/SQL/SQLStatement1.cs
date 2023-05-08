using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LhrMain.SQL
{
    class SQLStatement1
    {
        
        //--------------------------------------- 인사정보기본정보 ------------------------------------------------------
        //인사기본정보 조회sql
        public static string
            SelectSQL = "select b.bas_empno,b.bas_name,b.bas_cname, b.bas_ename,b.bas_sex,b.bas_bth,b.bas_mil,b.bas_mar, " +
                        "b.bas_hdpno, b.bas_zip, b.bas_addr1, b.bas_addrex, b.bas_addr2, b.bas_sta, " +
                        "b.bas_dept||':'||d.dept_name as bas_dept, " +
                        "b.bas_univ||':'||uv.univ_name as bas_univ, " +
                        "b.bas_pos||':'||ut1.unit_nm as bas_pos, " +
                        "b.bas_jkp||':'||ut2.unit_nm  as bas_jkp, " +
                        "b.bas_acc_bank||':'||ut3.unit_nm as bas_acc_bank, " +
                        "b.bas_entdate, b.bas_resdate, b.bas_dptdate, b.bas_posdate, b.bas_jkpdate, b.bas_levdate, b.bas_reidate, " +
                        "b.bas_acc_name, b.bas_acc_no, b.bas_salary, b.bas_rmk, b.bas_img " +
                        "from lhr_bas b "+
                        "left join lhr_dept d on b.bas_dept = d.dept_code  " +
                        "left join lhr_univ uv on b.bas_univ = uv.univ_code  " +
                        "left join lhr_unit ut1 on b.bas_pos = ut1.unit_cd " +
                        "left join lhr_unit ut2 on b.bas_jkp = ut2.unit_cd " +
                        "left join lhr_unit ut3 on b.bas_acc_bank = ut3.unit_cd " +
                        "where b.bas_empno like :bas_empno and b.bas_name like :bas_name and d.dept_name like :bas_dept and ut1.unit_nm like :bas_pos " +
                        "order by b.bas_empno ";

        //인사기본정보 삭제sql
        public static string
           DeleteSQL = "delete from lhr_bas where bas_empno = :bas_empno";
        //인사기본정보 입력sql
        public static string
            InsertSQL = "insert into lhr_bas" +
                        " (bas_empno,bas_name, bas_cname, bas_ename, bas_sex,bas_bth,bas_mil,bas_mar, bas_hdpno, bas_univ, bas_zip, bas_addr1, " +
                        " bas_addrex, bas_addr2, bas_sta, bas_pos,bas_dept, bas_jkp, bas_entdate,bas_resdate, " +
                        " bas_dptdate, bas_posdate, bas_jkpdate, bas_levdate, " +
                        " bas_reidate, bas_acc_bank, bas_acc_name, bas_acc_no, bas_salary, bas_rmk, bas_img) " +
                        " values " +
                        " (:bas_empno,:bas_name, :bas_cname, :bas_ename, :bas_sex,:bas_bth,:bas_mil,:bas_mar, :bas_hdpno, :bas_univ, :bas_zip, " +
                        " :bas_addr1, :bas_addrex, :bas_addr2, :bas_sta, :bas_pos,:bas_dept, :bas_jkp, :bas_entdate,:bas_resdate, :bas_dptdate, " +
                        " :bas_posdate, :bas_jkpdate, :bas_levdate, :bas_reidate, :bas_acc_bank, :bas_acc_name, " +
                        " :bas_acc_no, :bas_salary, :bas_rmk, :bas_img)";
        //인사기본정보 수정sql
        public static string
            UpdateSQL = "update lhr_bas set bas_empno=:bas_empno,bas_name=:bas_name,bas_cname=:bas_cname, bas_ename=:bas_ename, "+
                        "bas_sex=:bas_sex,bas_bth=:bas_bth,bas_mil=:bas_mil,bas_mar=:bas_mar, bas_hdpno=:bas_hdpno, bas_univ=:bas_univ, " +
                        "bas_zip=:bas_zip, bas_addr1=:bas_addr1, bas_addrex=:bas_addrex, bas_addr2=:bas_addr2, bas_sta=:bas_sta, " +
                        "bas_pos=:bas_pos, bas_dept=:bas_dept, bas_jkp=:bas_jkp, bas_entdate=:bas_entdate, bas_jkpdate=:bas_jkpdate, " +
                        "bas_resdate=:bas_resdate, bas_dptdate=:bas_dptdate, bas_posdate=:bas_posdate, " +
                        "bas_levdate=:bas_levdate, bas_reidate=:bas_reidate, bas_acc_bank=:bas_acc_bank,bas_acc_name=:bas_acc_name, " +
                        "bas_acc_no=:bas_acc_no, bas_salary=:bas_salary, bas_rmk=:bas_rmk, bas_img=:bas_img "+
                        "where bas_empno = :bas_empno";
        public static string
            UpdateSQL2 = "update lhr_bas set bas_empno=:bas_empno,bas_name=:bas_name,bas_cname=:bas_cname, bas_ename=:bas_ename, " +
                        "bas_sex=:bas_sex,bas_bth=:bas_bth,bas_mil=:bas_mil,bas_mar=:bas_mar, bas_hdpno=:bas_hdpno, bas_univ=:bas_univ, " +
                        "bas_zip=:bas_zip, bas_addr1=:bas_addr1, bas_addrex=:bas_addrex, bas_addr2=:bas_addr2, bas_sta=:bas_sta, " +
                        "bas_pos=:bas_pos, bas_dept=:bas_dept, bas_jkp=:bas_jkp, bas_entdate=:bas_entdate, bas_jkpdate=:bas_jkpdate, " +
                        "bas_resdate=:bas_resdate, bas_dptdate=:bas_dptdate, bas_posdate=:bas_posdate, " +
                        "bas_levdate=:bas_levdate, bas_reidate=:bas_reidate, bas_acc_bank=:bas_acc_bank,bas_acc_name=:bas_acc_name, " +
                        "bas_acc_no=:bas_acc_no, bas_salary=:bas_salary, bas_rmk=:bas_rmk " +
                        "where bas_empno = :bas_empno";

        //직급 콤보박스 세팅 sql
        public static string
             SelectSQL_lhr_pos = "select u.unit_cd||':'||u.unit_nm from lhr_unit u,lhr_cdg c " +
                                 "where u.unit_grpcd = c.cdg_grpcd and c.cdg_grpnm='직급'";
        //직책 콤보박스 세팅 sql
        public static string
             SelectSQL_lhr_jkp = "select u.unit_cd||':'||u.unit_nm from lhr_unit u,lhr_cdg c " +
                                 "where u.unit_grpcd = c.cdg_grpcd and c.cdg_grpnm='직책'";
        //은행 콤보박스 세팅 sql
        public static string
             SelectSQL_lhr_bank = "select u.unit_cd||':'||u.unit_nm from lhr_unit u,lhr_cdg c " +
                                 "where u.unit_grpcd = c.cdg_grpcd and c.cdg_grpnm='은행'";
        //부서 검색창 조회sql
        public static string
            SelectDept = "select dept_code as codekey,dept_name as codenm from lhr_dept where dept_name like :condition";
        //출신대학 검색창 조회sql
        public static string
            SelectUniv = "select univ_code as codekey,univ_name as codenm from lhr_univ where univ_name like :condition";

        //증명사진 조회sql
        public static string
            SelectImage = "select bas_img from lhr_bas where bas_empno =:bas_empno";
        
    }
}
