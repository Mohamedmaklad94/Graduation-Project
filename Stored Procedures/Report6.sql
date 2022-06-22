alter proc R6_Stud_Exam_Quests @Stud_ID int , @Exam_No int
As
begin
	select seq.Exam_ID , seq.ST_ID , concat(ST_Fname,' ',ST_Lname) As 'Student Full Name' ,
	seq.Quest_Num , q.Quest_Type , q.Quest_Cont ,
	(select Ans_Cont from Choices where Quest_ID=q.Quest_ID and Model_Ans_Num = 1) as 'Option 1',
	(select Ans_Cont from Choices where Quest_ID=q.Quest_ID and Model_Ans_Num = 2) as 'Option 2',
	(select Ans_Cont from Choices where Quest_ID=q.Quest_ID and Model_Ans_Num = 3) as 'Option 3',
	(select Ans_Cont from Choices where Quest_ID=q.Quest_ID and Model_Ans_Num = 4) as 'Option 4',
	seq.ST_Answer , c.Ans_Cont as 'ST_Answer_content'
	from ST_Exam_Quest seq , Questions q , Choices c , Students s
	where seq.Quest_ID = q.Quest_ID
	and q.Quest_ID = c.Quest_ID
	and c.Model_Ans_Num = seq.ST_Answer
	and seq.ST_ID = s.ST_ID
	and seq.Exam_ID = @Exam_No
	and seq.ST_ID = @Stud_ID
end

-- R6_Stud_Exam_Quests 1,38