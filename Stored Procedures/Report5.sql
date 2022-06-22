alter proc R5_Exam_Quests @Exam_No int
As
begin
	select seq.Exam_ID , seq.Quest_Num , q.Quest_Type , q.Quest_Cont ,
	(select Ans_Cont from Choices where Quest_ID=q.Quest_ID and Model_Ans_Num = 1) as 'Option 1',
	(select Ans_Cont from Choices where Quest_ID=q.Quest_ID and Model_Ans_Num = 2) as 'Option 2',
	(select Ans_Cont from Choices where Quest_ID=q.Quest_ID and Model_Ans_Num = 3) as 'Option 3',
	(select Ans_Cont from Choices where Quest_ID=q.Quest_ID and Model_Ans_Num = 4) as 'Option 4'
	from ST_Exam_Quest seq , Questions q
	where seq.Quest_ID = q.Quest_ID
	and seq.Exam_ID = @Exam_No
end

-- R5_Exam_Quests 1