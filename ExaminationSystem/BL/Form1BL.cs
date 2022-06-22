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
    public static class Form1BL
    {
        public static DataTable StudLogin(int _St_ID, string _St_Pass)
        {
            SqlCommand cmd = new SqlCommand("studLogin @St_ID, @St_Pass");
            cmd.Parameters.AddWithValue("St_ID", _St_ID);
            cmd.Parameters.AddWithValue("St_Pass", _St_Pass);
            return DALEXSYS.select(cmd);
        }
        public static DataTable InsLogin(int _Ins_ID, string _Ins_Pass)
        {
            SqlCommand cmd = new SqlCommand("InsLogin @Ins_ID, @Ins_Pass");
            cmd.Parameters.AddWithValue("Ins_ID", _Ins_ID);
            cmd.Parameters.AddWithValue("Ins_Pass", _Ins_Pass);
            return DALEXSYS.select(cmd);
        }

    }
}
