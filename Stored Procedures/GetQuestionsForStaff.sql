alter proc GetQuestionsForStaff (@Crs_name nvarchar(50))
As
begin 
	declare @Crs_ID int =(select Crs_ID from Courses where Crs_Name = @Crs_name)
	select q.Quest_ID,q.Quest_Type,q.Model_Ans_Num,q.Quest_Cont,
	(select Ans_Cont from Choices where Quest_ID=q.Quest_ID and Model_Ans_Num = 1) as 'Option 1',
	(select Ans_Cont from Choices where Quest_ID=q.Quest_ID and Model_Ans_Num = 2) as 'Option 2',
	(select Ans_Cont from Choices where Quest_ID=q.Quest_ID and Model_Ans_Num = 3) as 'Option 3',
	(select Ans_Cont from Choices where Quest_ID=q.Quest_ID and Model_Ans_Num = 4) as 'Option 4'
	from Questions q
	where q.Quest_Type = 'MCQ'
	and Crs_ID = @Crs_ID

	UNION

	select q.Quest_ID,q.Quest_Type,q.Model_Ans_Num,q.Quest_Cont,'True','False',NULL,NULL
	from Questions q
	where q.Quest_Type = 'T F'
	and Crs_ID = @Crs_ID


end

-- GetQuestionsForStaff 'SQL'

