using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LhrMain.SQL
{
    class SQLStatement2
    {
        // 가족관계사항 CRUD
        public static string
            SelectSQL0 = "select bas_empno,bas_name,dept_name as bas_dept " +
                        "from lhr_bas,lhr_dept " +
                        "where bas_empno like :bas_empno and bas_name like :bas_name and bas_dept = dept_code(+) " +
                        "order by bas_empno";
        public static string
            SelectSQL = "select fam_empno,fam_name,fam_rel||':'||rel_name as fam_rel,fam_bth,fam_ltg " +
                        "from lhr_fam,lhr_rel " +
                        "where fam_empno = :fam_empno and fam_rel = rel_code(+)";
        public static string
            DeleteSQL = "delete from lhr_fam where fam_empno = :key1 and fam_name = :key2";
        public static string
            UpdateSQL = "update lhr_fam set fam_name=:fam_name,fam_rel=:fam_rel,fam_bth=:fam_bth,fam_ltg=:fam_ltg " +
                        "where fam_empno = :key1 and fam_name = :key2";
        public static string
            InsertSQL = "insert into lhr_fam" +
                        " (fam_empno,fam_name,fam_rel,fam_bth,fam_ltg) " +
                        "values " +
                        " (:fam_empno,:fam_name,:fam_rel,:fam_bth,:fam_ltg)";

        public static string
            SelectSQL_lhr_rel = "select rel_code||':'||rel_name from lhr_rel";
    }
}
