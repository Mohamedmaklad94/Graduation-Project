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
    public static class AddQuestionsFormBL
    {
        public static DataTable GetCoursesForStaff(int _Staff_ID)
        {
            SqlCommand cmd = new SqlCommand("GetCoursesForStaff @Staff_ID");
            cmd.Parameters.AddWithValue("Staff_ID", _Staff_ID);
            return DALEXSYS.select(cmd);
        }

        public static DataTable GetQuestionsForStaff(string _Crs_Name)
        {
            SqlCommand cmd = new SqlCommand("GetQuestionsForStaff @Crs_Name");
            cmd.Parameters.AddWithValue("Crs_Name", _Crs_Name);
            return DALEXSYS.select(cmd);
        }
        public static int AddNewQuestion(string _Quest_type, int _Model_Answer, string _Quest_cont, string _Crs_Name, string _Option1, string _Option2, string _Option3, string _Option4)
        {
            SqlCommand cmd = new SqlCommand("AddNewQuestionForStaff @Quest_Type,@Model_Ans_Num,@Quest_Cont,@Crs_Name,@Option1,@Option2, @Option3, @Option4");
            cmd.Parameters.AddWithValue("@Quest_Type", _Quest_type);
            cmd.Parameters.AddWithValue("@Model_Ans_Num", _Model_Answer);
            cmd.Parameters.AddWithValue("@Quest_Cont", _Quest_cont);
            cmd.Parameters.AddWithValue("@Crs_Name", _Crs_Name);
            cmd.Parameters.AddWithValue("@Option1", _Option1);
            cmd.Parameters.AddWithValue("@Option2", _Option2);
            cmd.Parameters.AddWithValue("@Option3", _Option3);
            cmd.Parameters.AddWithValue("@Option4", _Option4);
            return DALEXSYS.DML(cmd);
        }
        public static int UpdateQuestion(int _Quest_ID, string _Quest_type, int _Model_Answer, string _Quest_cont, string _Crs_Name, string _Option1, string _Option2, string _Option3, string _Option4)
        {
            SqlCommand cmd = new SqlCommand("UpdateQuestionForStaff @Quest_ID,@Quest_Type,@Model_Ans_Num,@Quest_Cont,@Crs_Name,@Option1,@Option2, @Option3, @Option4");
            cmd.Parameters.AddWithValue("@Quest_ID", _Quest_ID);
            cmd.Parameters.AddWithValue("@Quest_Type", _Quest_type);
            cmd.Parameters.AddWithValue("@Model_Ans_Num", _Model_Answer);
            cmd.Parameters.AddWithValue("@Quest_Cont", _Quest_cont);
            cmd.Parameters.AddWithValue("@Crs_Name", _Crs_Name);
            cmd.Parameters.AddWithValue("@Option1", _Option1);
            cmd.Parameters.AddWithValue("@Option2", _Option2);
            cmd.Parameters.AddWithValue("@Option3", _Option3);
            cmd.Parameters.AddWithValue("@Option4", _Option4);
            return DALEXSYS.DML(cmd);
        }
        public static int DeleteQuestion(int _Quest_ID)
        {
            SqlCommand cmd = new SqlCommand("DeleteQuestionForStaff " + _Quest_ID);
            return DALEXSYS.DML(cmd);
        }
    }
}
