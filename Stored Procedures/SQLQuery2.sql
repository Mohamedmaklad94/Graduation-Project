USE [Examination_SystemDB]
GO
/****** Object:  StoredProcedure [dbo].[UpdateStudentForStaff]    Script Date: 2/17/2022 4:14:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[UpdateStudentForStaff] @St_ID int,@St_Fname nvarchar(50),@St_Lname nvarchar(50),
@St_Address nvarchar(50), @St_DOB date, @st_pass nvarchar(8),
@St_Phone nvarchar(50), @Dept_ID int,@St_Pic image
As
begin
	-- Update Student Information
	Update Students
	set ST_Fname=@St_Fname,ST_Lname=@St_Lname,ST_Address=@St_Address,
	ST_DOB=@St_DOB,ST_Pass=@st_pass,ST_Phone=@St_Phone,Dept_ID=@Dept_ID,ST_pic=@St_Pic
	where ST_ID = @St_ID
end



