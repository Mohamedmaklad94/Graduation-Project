create proc GetCoursesForStaff (@INS_ID int)
As
begin 
	select c.Crs_ID,c.Crs_Name
	from INS_Crs ic , Courses c
	where ic.Crs_ID = c.Crs_ID
	and ic.INS_ID = @INS_ID
end

-- GetCoursesForStaff 1