create proc R5_Exam_Quests @Exam_No int
As
begin
	select seq.Exam_ID , seq.Quest_Num , q.Quest_Type , q.Quest_Cont 
	from ST_Exam_Quest seq , Questions q
	where seq.Quest_ID = q.Quest_ID
	and seq.Exam_ID = @Exam_No
end

-- R5_Exam_Quests 1