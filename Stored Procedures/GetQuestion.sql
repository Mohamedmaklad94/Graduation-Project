alter proc GetQuestion @St_ID int , @Exam_No int , @Quest_No int
as
begin
	select Quest_Cont , Quest_Type
	from Questions
	where Quest_ID =
	(select Quest_ID
	from ST_Exam_Quest
	where ST_ID = @St_ID
	and Exam_ID = @Exam_No
	and Quest_Num = @Quest_No)
end

-- GetQuestion 2,1,1