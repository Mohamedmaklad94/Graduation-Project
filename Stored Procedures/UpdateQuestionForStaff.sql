create proc UpdateQuestionForStaff @Quest_ID int,@Quest_Type nvarchar(50),@Model_Ans_Num int,
@Quest_Cont nvarchar(200),@Crs_Name nvarchar(50),@Option1 nvarchar(50),
@Option2 nvarchar(50),@Option3 nvarchar(50),@Option4 nvarchar(50)
AS
begin
	-- Get Course ID
	declare @Crs_ID int =(select Crs_ID from Courses where Crs_Name = @Crs_Name)

	-- Update Question Table
	Update Questions
	set Quest_Type=@Quest_Type,Model_Ans_Num=@Model_Ans_Num,
		Quest_Cont=@Quest_Cont,Crs_ID=@Crs_ID
	where Quest_ID=@Quest_ID

	-- Update Choice Table
	if(@Quest_Type = 'MCQ')
	begin
		update Choices set Ans_Cont = @Option1
		where Quest_ID=@Quest_ID and Model_Ans_Num=1
		update Choices set Ans_Cont = @Option2
		where Quest_ID=@Quest_ID and Model_Ans_Num=2
		update Choices set Ans_Cont = @Option3
		where Quest_ID=@Quest_ID and Model_Ans_Num=3
		update Choices set Ans_Cont = @Option4
		where Quest_ID=@Quest_ID and Model_Ans_Num=4
	end
end