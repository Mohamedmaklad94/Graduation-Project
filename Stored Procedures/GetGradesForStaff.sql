alter proc GetGradesForStaff @Crs_Name nvarchar(50)
As
begin
	-- Get Course ID
	declare @Crs_ID int =(select Crs_ID from Courses where Crs_Name = @Crs_Name);

	select s.ST_ID,CONCAT(s.ST_Fname,' ',s.ST_Lname) As 'Student Name',
	e.Exam_Date, seg.Grade
	from Students s, ST_Exam_Grade seg, Exams e, INS_Crs ic , Instructors i , Courses c
	where seg.Exam_ID = e.Exam_ID
	and s.ST_ID = seg.ST_ID
	and e.Crs_ID = ic.Crs_ID
	and ic.INS_ID = i.INS_ID
	and ic.Crs_ID = c.Crs_ID
	and e.Crs_ID = @Crs_ID
end

-- GetGradesForStaff 'CSHARP'