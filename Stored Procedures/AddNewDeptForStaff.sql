alter proc AddNewDeptForStaff @Dept_Name nvarchar(50),@Dept_Desc nvarchar(50)
AS
begin
	-- Get Dept ID
	declare @Dept_ID int
	if((select Count(*) from Questions)=0)
		set @Dept_ID = 101
	else
		set @Dept_ID =(select top(1)Dept_ID from Departments order by Dept_ID desc)+1
	-- Insert Into Department Table 
	Insert INTO Departments
	values (@Dept_ID, @Dept_Name ,@Dept_Desc)
end