using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LhrMain.SQL
{
    class SQLStatement3
    {
        public static string SelectSQL = "select b.bas_empno,b.bas_name,b.bas_cname, b.bas_ename,b.bas_sex,b.bas_bth,b.bas_mil,b.bas_mar, " +
                                        "b.bas_hdpno, b.bas_zip, b.bas_addr1, b.bas_addrex, b.bas_addr2, b.bas_sta, " +
                                        "b.bas_dept||':'||d.dept_name as bas_dept, " +
                                        "b.bas_univ||':'||uv.univ_name as bas_univ, " +
                                        "b.bas_pos||':'||ut1.unit_nm as bas_pos, " +
                                        "b.bas_jkp||':'||ut2.unit_nm  as bas_jkp, " +
                                        "b.bas_acc_bank||':'||ut3.unit_nm as bas_acc_bank, " +
                                        "b.bas_entdate, b.bas_resdate, b.bas_dptdate, b.bas_posdate, b.bas_jkpdate, b.bas_levdate, b.bas_reidate, " +
                                        "b.bas_acc_name, b.bas_acc_no, b.bas_salary, b.bas_rmk, b.bas_img " +
                                        "from lhr_bas b " +
                                        "left join lhr_dept d on b.bas_dept = d.dept_code  " +
                                        "left join lhr_univ uv on b.bas_univ = uv.univ_code  " +
                                        "left join lhr_unit ut1 on b.bas_pos = ut1.unit_cd " +
                                        "left join lhr_unit ut2 on b.bas_jkp = ut2.unit_cd " +
                                        "left join lhr_unit ut3 on b.bas_acc_bank = ut3.unit_cd " +
                                        "where b.bas_empno like :bas_empno and b.bas_name like :bas_name and d.dept_name like :bas_dept and ut1.unit_nm like :bas_pos " +
                                        "order by b.bas_empno ";
        public static string SelectSQL1 = "select b.bas_empno,b.bas_name,b.bas_cname, b.bas_ename,b.bas_sex,to_date(b.bas_bth,'yyyymmdd') as bas_bth, "+
                                        "b.bas_mil,b.bas_mar, b.bas_hdpno, b.bas_zip, b.bas_addr1, b.bas_addrex, b.bas_addr2, b.bas_sta, " +
                                        "b.bas_dept||':'||d.dept_name as bas_dept, " +
                                        "b.bas_univ||':'||uv.univ_name as bas_univ, " +
                                        "b.bas_pos||':'||ut1.unit_nm as bas_pos, " +
                                        "b.bas_jkp||':'||ut2.unit_nm  as bas_jkp, " +
                                        "b.bas_acc_bank||':'||ut3.unit_nm as bas_acc_bank, " +
                                        "to_date(b.bas_entdate,'yyyymmdd') as bas_entdate, to_date(b.bas_resdate,'yyyymmdd') as bas_resdate, to_date(b.bas_dptdate,'yyyymmdd') as bas_dptdate, "+
                                        "to_date(b.bas_posdate,'yyyymmdd') as bas_posdate, to_date(b.bas_jkpdate,'yyyymmdd') as bas_jkpdate, to_date(b.bas_levdate,'yyyymmdd') as bas_levdate, "+
                                        "to_date(b.bas_reidate,'yyyymmdd') as bas_reidate, " +
                                        "b.bas_acc_name, b.bas_acc_no, b.bas_salary, b.bas_rmk, b.bas_img " +
                                        "from lhr_bas b "+
                                        "left join lhr_dept d on b.bas_dept = d.dept_code  " +
                                        "left join lhr_univ uv on b.bas_univ = uv.univ_code  " +
                                        "left join lhr_unit ut1 on b.bas_pos = ut1.unit_cd " +
                                        "left join lhr_unit ut2 on b.bas_jkp = ut2.unit_cd " +
                                        "left join lhr_unit ut3 on b.bas_acc_bank = ut3.unit_cd " +
                                        "where b.bas_empno like :bas_empno and b.bas_name like :bas_name and d.dept_name like :bas_dept and ut1.unit_nm like :bas_pos " +
                                        "order by b.bas_empno ";
    }
}
