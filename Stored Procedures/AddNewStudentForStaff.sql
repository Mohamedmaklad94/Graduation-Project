alter proc AddNewStudentForStaff @St_Fname nvarchar(50),@St_Lname nvarchar(50),
@St_Address nvarchar(50), @St_DOB date, @st_pass nvarchar(8),
@St_Phone nvarchar(50), @Dept_ID int
As
begin
	-- Get New Id For New Student
	declare @St_ID int
	if((select Count(*) from students)=0)
		set @St_ID = 1
	else
		set @St_ID =(select top(1)ST_ID from Students order by ST_ID desc)+1

	-- Add Student To Table Students
	insert into Students
	values (@St_ID,@St_Fname,@St_Lname,@St_Address,@St_DOB,@st_pass,@St_Phone,@Dept_ID)
end

/* 
AddNewStudentForStaff 'Ahmed','Omara','Mehalla','2-9-1995',
'123456','01018817390',105 
Delete from students where ST_ID = 11
*/

