alter proc GetDeptsForStaff
AS
begin
	select Dept_ID,Dept_Name from Departments
end
