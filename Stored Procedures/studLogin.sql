create proc studLogin @St_ID int , @ST_Pass nvarchar(8)
AS
begin
	select * 
	from students 
	where ST_ID = @St_ID 
	and ST_Pass = @St_Pass
end