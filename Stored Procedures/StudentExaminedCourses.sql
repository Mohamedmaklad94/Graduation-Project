alter proc StudentExaminedCourses @St_ID int
As
begin
	select c.Crs_ID,c.Crs_Name
	from ST_Crs sc , Courses c
	where sc.Crs_ID = c.Crs_ID
	and sc.ST_ID = @St_ID
end

-- StudentExaminedCourses 2