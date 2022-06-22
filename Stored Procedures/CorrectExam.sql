alter proc CorrectExam (@st_id int, @exam_id int)
as
begin
	declare @grade int = 0 , @I int = 1 , @Quest_Id int
	while @I <= 10
	begin
		set @Quest_Id = (select Quest_ID 
		from ST_Exam_Quest 
		where ST_ID = @st_id 
		and Exam_ID = @exam_id
		and Quest_Num = @I)
		if (select ST_Answer from ST_Exam_Quest where ST_ID = @st_id and Exam_ID = @exam_id and Quest_ID = @Quest_Id)
		 = (select Model_Ans_Num from Questions where Quest_ID = @Quest_Id)
		 set @grade = @grade + 1
		set @I = @I + 1
	end
	insert into ST_Exam_Grade
	values (@st_id, @exam_id, @grade * 10)
end