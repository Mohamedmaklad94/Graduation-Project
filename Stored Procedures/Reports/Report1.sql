create proc R1_Stu_Dep @DeptNo int
As
begin
	select * 
	from Students
	where Dept_ID = @DeptNo
end

-- R1_Stu_Dep 101
