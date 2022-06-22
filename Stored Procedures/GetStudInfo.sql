create proc GetStudInfo @St_ID int
As
begin
	select s.ST_ID,s.ST_Fname,s.ST_Lname,s.ST_Address,s.ST_DOB,s.ST_Pass,s.ST_Phone,d.Dept_Name 
	from Students s , Departments d
	where s.Dept_ID = d.Dept_ID
	and s.ST_ID = @St_ID
end

-- GetStudInfo 2