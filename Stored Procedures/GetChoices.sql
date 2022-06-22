alter proc GetChoices @St_ID int , @Exam_No int , @Quest_No int
As
begin
	select Ans_Cont
	from Choices
	where Quest_ID = 
	(select Quest_ID
	from ST_Exam_Quest
	where ST_ID = @St_ID
	and Exam_ID = @Exam_No
	and Quest_Num = @Quest_No)
end

-- GetChoices 2,1,2