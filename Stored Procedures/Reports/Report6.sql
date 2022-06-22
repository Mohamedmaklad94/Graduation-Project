alter proc R6_Stud_Exam_Quests @Exam_No int , @Stud_ID int
As
begin
	select seq.Exam_ID , seq.ST_ID , concat(ST_Fname,' ',ST_Lname) As 'Student Full Name' , seq.Quest_Num , q.Quest_Type , q.Quest_Cont , seq.ST_Answer , c.Ans_Cont as 'ST_Answer_content'
	from ST_Exam_Quest seq , Questions q , Choices c , Students s
	where seq.Quest_ID = q.Quest_ID
	and q.Quest_ID = c.Quest_ID
	and c.Model_Ans_Num = seq.ST_Answer
	and seq.ST_ID = s.ST_ID
	and seq.Exam_ID = @Exam_No
	and seq.ST_ID = @Stud_ID
end

-- R6_Stud_Exam_Quests 1,1