using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.DAL;
using System.IO;

namespace ExaminationSystem.BL
{
    public static class AddStudentsFormBL
    {
        public static DataTable GetStudentsForStaff(string _Dept_Name)
        {
            SqlCommand cmd = new SqlCommand("StudentsForStaff @Dept_Name");
            cmd.Parameters.AddWithValue("Dept_Name", _Dept_Name);
            return DALEXSYS.select(cmd);
        }
        public static int AddNewStudent(string _St_Fname, string _St_Lname, string _St_Address, DateTime _St_DOB, string _st_pass, string _St_Phone, string _Dept_Name, MemoryStream _memory)
        {
            SqlCommand cmd = new SqlCommand("AddNewStudentForStaff @St_Fname,@St_Lname,@St_Address,@St_DOB,@st_pass,@St_Phone,@Dept_Name,@memory");
            cmd.Parameters.AddWithValue("@St_Fname", _St_Fname);
            cmd.Parameters.AddWithValue("@St_Lname", _St_Lname);
            cmd.Parameters.AddWithValue("@St_Address", _St_Address);
            cmd.Parameters.AddWithValue("@St_DOB", _St_DOB);
            cmd.Parameters.AddWithValue("@st_pass", _st_pass);
            cmd.Parameters.AddWithValue("@St_Phone", _St_Phone);
            cmd.Parameters.AddWithValue("@Dept_Name", _Dept_Name);
            cmd.Parameters.AddWithValue("@memory", _memory.ToArray());
            return DALEXSYS.DML(cmd);
        }
        public static int UpdateStudent(int _St_ID,string _St_Fname, string _St_Lname, string _St_Address, DateTime _St_DOB, string _st_pass, string _St_Phone, string _Dept_Name,MemoryStream _memory)
        {
            SqlCommand cmd = new SqlCommand("UpdateStudentForStaff @St_ID,@St_Fname,@St_Lname,@St_Address,@St_DOB,@st_pass,@St_Phone,@Dept_Name,@memory");
            cmd.Parameters.AddWithValue("@St_ID", _St_ID);
            cmd.Parameters.AddWithValue("@St_Fname", _St_Fname);
            cmd.Parameters.AddWithValue("@St_Lname", _St_Lname);
            cmd.Parameters.AddWithValue("@St_Address", _St_Address);
            cmd.Parameters.AddWithValue("@St_DOB", _St_DOB);
            cmd.Parameters.AddWithValue("@st_pass", _st_pass);
            cmd.Parameters.AddWithValue("@St_Phone", _St_Phone);
            cmd.Parameters.AddWithValue("@Dept_Name", _Dept_Name);
            cmd.Parameters.AddWithValue("@memory", _memory.ToArray());
            return DALEXSYS.DML(cmd);
        }
        public static DataSet GetStudPic(int _St_ID)
        {
            SqlCommand cmd = new SqlCommand("select ST_pic from Students where ST_ID= @ST_ID");
            cmd.Parameters.AddWithValue("ST_ID", _St_ID);
            return DALEXSYS.selectds(cmd);
        }
    }
}
