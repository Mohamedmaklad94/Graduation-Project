alter proc R3_Ins_Crs @Ins_ID int
as
begin
	select ic.INS_ID , i.INS_Name , c.Crs_Name , count(sc.ST_ID) As NoOfStudents 
	from INS_Crs ic 
	left join Courses c on ic.Crs_ID = c.Crs_ID
	left join ST_Crs sc on c.Crs_ID = sc.Crs_ID
	join Instructors i on i.INS_ID = ic.INS_ID
	where ic.INS_ID = @Ins_ID
	group by ic.INS_ID , i.INS_Name , c.Crs_Name
	order by ic.INS_ID
end

-- R3_Ins_Crs 2