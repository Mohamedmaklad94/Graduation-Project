create proc UpdateDeptForStaff @Dept_ID int,@Dept_Name nvarchar(50),@Dept_Desc nvarchar(50)
AS
begin
	update Departments
	set Dept_Name = @Dept_Name, Dept_Desc = @Dept_Desc
	where Dept_ID = @Dept_ID
end