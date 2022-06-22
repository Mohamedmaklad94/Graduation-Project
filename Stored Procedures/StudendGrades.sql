create proc Stud_Grades @St_ID int
as
begin
	select c.Crs_Name , seg.Grade
	from ST_Exam_Grade seg , Exams e , Courses c
	where seg.Exam_ID = e.Exam_ID
	and e.Crs_ID = c.Crs_ID
	and seg.ST_ID = @St_ID
end

-- Stud_Grades 2

