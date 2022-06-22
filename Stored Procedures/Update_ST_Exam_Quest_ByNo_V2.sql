Create Proc Update_ST_Exam_Quest_ByNo_V2(@st_id int, @exam_id int, @Quest_No int, @St_Answer int)
as
begin
update ST_Exam_Quest
set ST_Answer = @St_Answer
where ST_ID = @st_id
and Exam_ID = @exam_id
and Quest_Num = @Quest_No
end

/*
Update_ST_Exam_Quest_ByNo_V2 1,1,6,4
*/