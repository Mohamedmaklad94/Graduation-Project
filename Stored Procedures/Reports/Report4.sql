create proc R4_Crs_Top @Crs_ID int
As
begin
	select c.Crs_ID , c.Crs_Name , t.Topic_Name
	from Courses c join Topics t
	on c.Topic_ID = t.Topic_ID
	where c.Crs_ID = @Crs_ID
end

-- R4_Crs_Top 1