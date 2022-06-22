alter proc StudentsForStaff @Dept_Name varchar(50)
As
begin
	-- Get Dept_ID
	declare @Dept_ID int =
	(select Dept_ID from Departments where Dept_Name = @Dept_Name)

	select s.ST_ID,s.ST_Fname,s.ST_Lname,s.ST_Address,s.ST_DOB,s.ST_Pass,s.ST_Phone,d.Dept_Name 
	from Students s , Departments d
	where s.Dept_ID = d.Dept_ID
	and s.Dept_ID = @Dept_ID
end

-- StudentsForStaff 'BI'
