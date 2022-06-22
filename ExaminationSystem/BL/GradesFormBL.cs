using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.DAL;

namespace ExaminationSystem.BL
{
    public static class GradesFormBL
    {
        public static DataTable GetStudGrades(int _St_ID)
        {
            SqlCommand cmd = new SqlCommand("GetCourseGradeForStudent " + _St_ID);
            return DALEXSYS.select(cmd);
        }
        public static DataTable GetStudGrades(int _St_ID, string _Crs_Name)
        {
            SqlCommand cmd = new SqlCommand("GetCourseGradeForStudent @St_ID, @Crs_Name");
            cmd.Parameters.AddWithValue("St_ID", _St_ID);
            cmd.Parameters.AddWithValue("Crs_Name", _Crs_Name);
            return DALEXSYS.select(cmd);
        }

        public static DataTable GetStudCourses(int _St_ID)
        {
            SqlCommand cmd = new SqlCommand("StudentExaminedCourses " + _St_ID);
            return DALEXSYS.select(cmd);
        }
    }
}
