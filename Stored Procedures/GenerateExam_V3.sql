USE [Examination_SystemDB]
GO
/* 
This version differs of version 1 in that :
-----------------------------------------------
1- Take Crs_Name Parameter insteed of Crs_ID.
*/
create proc [dbo].[GenerateExam_V3] (@st_id int, @crs_Name nvarchar(50), @exam_id int)
as
begin
	-- Get Course_ID From Course_Name
	declare @crs_id int = 
	(select Crs_ID from Courses where Crs_Name = @crs_Name )

	-- NoOfMCQ and NoOfTF
	declare @NoOfMCQ int , @NoOfTF int
	set @NoOfMCQ = CEILING(rand()*10)
	set @NoOfTF = 10 - @NoOfMCQ
	
	-- Insert In 'Exams' table
	insert into Exams
	values (@exam_id ,GETDATE(),@crs_id)

	-- Insert In 'ST_Crs' table
	insert into ST_Crs
	values (@st_id ,@crs_id)
	
	-- Insert In 'ST_Exam_Quest' table
	insert into ST_Exam_Quest(ST_ID,Exam_ID,Quest_ID,Quest_Num)
	select @st_id,@exam_id,Quest_ID,ROW_NUMBER() over (order by Quest_ID)
	from(

	-- Generate Exam
	select Quest_ID,Quest_Type,ROW_NUMBER() over (Partition by Quest_Type order by newid()) r1
	from Questions
	where Crs_ID = @crs_id ) t1
	where (Quest_Type = 'MCQ' and r1 between 1 and @NoOfMCQ)
	OR (Quest_Type = 'T F' and r1 between 1 and @NoOfTF)
	
end