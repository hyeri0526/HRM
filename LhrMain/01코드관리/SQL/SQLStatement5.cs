using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LhrMain.SQL
{
    class SQLStatement5
    {
        //경력사항 CRUD
        public static string
            SelectSQL0 = "select bas_empno,bas_name,dept_name as bas_dept " +
                        "from lhr_bas,lhr_dept " +
                        "where bas_empno like :bas_empno and bas_name like :bas_name and bas_dept = dept_code(+) " +
                        "order by bas_empno";
        public static string
            SelectSQL = "select car_empno, car_com, car_region, car_start, car_end, car_pos, car_dept, car_reason " +
                        "from lhr_car " +
                        "where car_empno = :car_empno ";
        public static string
            DeleteSQL = "delete from lhr_car where car_empno = :key1 and car_com = :key2";
        public static string
            UpdateSQL = "update lhr_car set car_com=:car_com, car_region=:car_region, car_start=:car_start, car_end=:car_end, " +
                        "car_pos=:car_pos, car_dept=:car_dept, car_reason=:car_reason " +
                        "where car_empno=:key1 and car_com=:key2";
        public static string
            InsertSQL = "insert into lhr_car " +
                        " (car_empno, car_com, car_region, car_start, car_end, car_pos, car_dept, car_reason) " +
                        "values " +
                        " (:car_empno, :car_com, :car_region, :car_start, :car_end, :car_pos, :car_dept, :car_reason)";
    }
}
