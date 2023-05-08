using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LhrMain.SQL
{
    class SQLStatement6
    {
        //학력사항 CRUD
        public static string
            SelectSQL0 = "select bas_empno,bas_name,dept_name as bas_dept " +
                        "from lhr_bas,lhr_dept " +
                        "where bas_empno like :bas_empno and bas_name like :bas_name and bas_dept = dept_code(+) " +
                        "order by bas_empno";
        public static string
            SelectSQL = "select edu_empno, edu_loe, edu_entdate, edu_gradate, edu_schnm, edu_dept, edu_degree, edu_grade, edu_gra, edu_last " +
                        "from lhr_edu " +
                        "where edu_empno = :edu_empno ";
        public static string
            DeleteSQL = "delete from lhr_edu where edu_empno = :edu_empno and edu_loe = :edu_loe";
        public static string
            UpdateSQL = "update lhr_edu set edu_loe =:edu_loe, edu_entdate =:edu_entdate, edu_gradate =:edu_gradate, edu_schnm =:edu_schnm, " +
                        "edu_dept =:edu_dept, edu_degree =:edu_degree, edu_grade =:edu_grade, edu_gra =:edu_gra, edu_last =:edu_last " +
                        "where edu_empno =:edu_empno and edu_loe =:edu_loe";
        public static string
            InsertSQL = "insert into lhr_edu " +
                        " (edu_empno, edu_loe, edu_entdate, edu_gradate, edu_schnm, edu_dept, edu_degree, edu_grade, edu_gra, edu_last) " +
                        "values " +
                        " (:edu_empno,:edu_loe, :edu_entdate, :edu_gradate, :edu_schnm, :edu_dept, :edu_degree, :edu_grade, :edu_gra, :edu_last)";
    }
}
