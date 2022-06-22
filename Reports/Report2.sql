alter proc R2_Stud_Grade @ST_ID int
as
begin
	Select seg.ST_ID , CONCAT(s.ST_Fname,' ',s.ST_Lname) As 'Student Full Name' , e.Crs_ID , c.Crs_Name , e.Exam_Date , seg.Grade
	from ST_Exam_Grade seg , Exams e , Students s , Courses c
	where e.Exam_ID = seg.Exam_ID
	and s.ST_ID = seg.ST_ID
	and c.Crs_ID = e.Crs_ID
	and seg.ST_ID = @ST_ID
end

--R2_Stud_Grade 1
