alter proc GetCourseGradeForStudent @St_ID int ,@Crs_Name nvarchar(50) = NULL
As
begin
	declare @Crs_ID int =(select Crs_ID from Courses where Crs_Name = @Crs_Name);
	if(@Crs_ID is Null)
	begin
		select c.Crs_Name, e.Exam_Date, i.INS_Name, seg.Grade
		from ST_Exam_Grade seg, Exams e, INS_Crs ic , Instructors i , Courses c
		where seg.Exam_ID = e.Exam_ID
		and e.Crs_ID = ic.Crs_ID
		and ic.INS_ID = i.INS_ID
		and ic.Crs_ID = c.Crs_ID
		and seg.ST_ID = @St_ID
	end
	else
	begin
		select c.Crs_Name, e.Exam_Date,i.INS_Name,seg.Grade
		from ST_Exam_Grade seg, Exams e, INS_Crs ic , Instructors i , Courses c
		where seg.Exam_ID = e.Exam_ID
		and e.Crs_ID = ic.Crs_ID
		and ic.INS_ID = i.INS_ID
		and ic.Crs_ID = c.Crs_ID
		and seg.ST_ID = @St_ID
		and e.Crs_ID = @Crs_ID
	end
end

-- GetCourseGradeForStudent 2,'SQL'