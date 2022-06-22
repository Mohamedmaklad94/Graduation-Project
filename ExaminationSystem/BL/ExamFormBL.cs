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
    public static class ExamFormBL
    {
        public static DataTable GetQuestion(int _St_ID , int _Exam_No , int _Quest_No)
        {
            SqlCommand cmd= new SqlCommand("GetQuestion @St_ID , @Exam_No , @Quest_No");
            cmd.Parameters.AddWithValue("St_ID", _St_ID);
            cmd.Parameters.AddWithValue("Exam_No", _Exam_No);
            cmd.Parameters.AddWithValue("Quest_No", _Quest_No);
            return DALEXSYS.select(cmd);
        }

        public static DataTable GetChoices(int _St_ID, int _Exam_No, int _Quest_No)
        {
            SqlCommand cmd = new SqlCommand("GetChoices @St_ID , @Exam_No , @Quest_No");
            cmd.Parameters.AddWithValue("St_ID", _St_ID);
            cmd.Parameters.AddWithValue("Exam_No", _Exam_No);
            cmd.Parameters.AddWithValue("Quest_No", _Quest_No);
            return DALEXSYS.select(cmd);
        }

        public static int AnswerQuestion(int _St_ID, int _Exam_No, int _Quest_No , int _St_Answer)
        {
            SqlCommand cmd = new SqlCommand("Update_ST_Exam_Quest_ByNo_V2 @St_ID , @Exam_No , @Quest_No , @ST_Answer");
            cmd.Parameters.AddWithValue("St_ID", _St_ID);
            cmd.Parameters.AddWithValue("Exam_No", _Exam_No);
            cmd.Parameters.AddWithValue("Quest_No", _Quest_No);
            cmd.Parameters.AddWithValue("ST_Answer", _St_Answer);
            return DALEXSYS.DML(cmd);
        }

        public static int CorrectExam(int _St_ID, int _Exam_No)
        {
            SqlCommand cmd = new SqlCommand("CorrectExam @St_ID , @Exam_No");
            cmd.Parameters.AddWithValue("St_ID", _St_ID);
            cmd.Parameters.AddWithValue("Exam_No", _Exam_No);
            return DALEXSYS.DML(cmd);
        }

    }
}
