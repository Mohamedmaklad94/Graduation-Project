create proc UpdateStudentForStaff @St_ID int,@St_Fname nvarchar(50),@St_Lname nvarchar(50),
@St_Address nvarchar(50), @St_DOB date, @st_pass nvarchar(8),
@St_Phone nvarchar(50), @Dept_ID int
As
begin
	-- Update Student Information
	Update Students
	set ST_Fname=@St_Fname,ST_Lname=@St_Lname,ST_Address=@St_Address,
	ST_DOB=@St_DOB,ST_Pass=@st_pass,ST_Phone=@St_Phone,Dept_ID=@Dept_ID
	where ST_ID = @St_ID
end



