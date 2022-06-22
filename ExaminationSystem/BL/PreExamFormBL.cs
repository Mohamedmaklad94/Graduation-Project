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
    public static class PreExamFormBL
    {
        public static DataTable GetCourses()
        {
            SqlCommand cmd = new SqlCommand("select Crs_ID, Crs_Name from courses");
            return DALEXSYS.select(cmd);
        }
        public static DataTable GetExamNo()
        {
            SqlCommand cmd = new SqlCommand("select count(*) from Exams");
            return DALEXSYS.select(cmd);
        }

        public static int GenerateExam(int _St_ID, string _Crs_Name, int _Exam_No)
        {
            //SqlCommand cmd = new SqlCommand("GenerateExam_V2 @ST_ID, @Crs_Name");
            SqlCommand cmd = new SqlCommand("GenerateExam_V3 @ST_ID, @Crs_Name, @Exam_No");
            cmd.Parameters.AddWithValue("ST_ID",_St_ID);
            cmd.Parameters.AddWithValue("Crs_Name", _Crs_Name);
            cmd.Parameters.AddWithValue("Exam_No", _Exam_No);
            return DALEXSYS.DML(cmd);
        }
    }
}
