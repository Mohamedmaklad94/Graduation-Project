create proc AddNewQuestionForStaff @Quest_Type nvarchar(50),@Model_Ans_Num int,
@Quest_Cont nvarchar(200),@Crs_Name nvarchar(50),@Option1 nvarchar(50),
@Option2 nvarchar(50),@Option3 nvarchar(50),@Option4 nvarchar(50)
As
begin
	-- Get Course ID
	declare @Crs_ID int =(select Crs_ID from Courses where Crs_Name = @Crs_Name)

	-- Get Question ID
	declare @Quest_ID int
	if((select Count(*) from Questions)=0)
		set @Quest_ID = 1
	else
		set @Quest_ID =(select top(1)Quest_ID from Questions order by Quest_ID desc)+1

	-- Insert Into Question Table
	Insert INTO Questions
	values (@Quest_ID ,@Quest_Type ,@Model_Ans_Num ,@Quest_Cont ,@Crs_ID)

	if(@Quest_Type = 'MCQ')
	begin
		Insert Into Choices
		values 
		(@Quest_ID,1,@Option1),
		(@Quest_ID,2,@Option2),
		(@Quest_ID,3,@Option3),
		(@Quest_ID,4,@Option4)
	end
end