create proc InsLogin @INS_ID int , @INS_Pass nvarchar(50)
AS
begin
	select * 
	from instructors 
	where INS_ID = @Ins_ID 
	and Ins_Pass = @Ins_Pass
end