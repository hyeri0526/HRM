using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LhrMain.SQL
{
    class SQLStatement7
    {
        //자격면허 CRUD
        public static string
            SelectSQL0 = "select bas_empno,bas_name,dept_name as bas_dept " +
                        "from lhr_bas,lhr_dept " +
                        "where bas_empno like :bas_empno and bas_name like :bas_name and bas_dept = dept_code(+) " +
                        "order by bas_empno";
        public static string
            SelectSQL = "select lic_empno, lic_name, lic_grade, lic_acqdate, lic_organ from lhr_lic " +                        
                        "where lic_empno = :lic_empno ";
        public static string
            DeleteSQL = "delete from lhr_lic where lic_empno = :lic_empno and lic_name = :lic_name";
        public static string
            UpdateSQL = "update lhr_lic set lic_name =:lic_name, lic_grade=:lic_grade, lic_acqdate=:lic_acqdate, lic_organ=:lic_organ" +
                        "where lic_empno =:lic_empno and lic_name =:lic_name";
        public static string
            InsertSQL = "insert into lhr_lic " +
                        "(lic_empno, lic_name, lic_grade, lic_acqdate, lic_organ) " +
                        "values " +
                        "(:lic_empno, :lic_name, :lic_grade, :lic_acqdate, :lic_organ)";
    }
}
