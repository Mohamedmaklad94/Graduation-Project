create proc DeleteQuestionForStaff (@Quest_ID int)
AS
begin
	-- Delete from Choices Table
	Delete from Choices where Quest_ID = @Quest_ID

	-- Delete from Question Table
	Delete from Questions where Quest_ID = @Quest_ID
end

-- DeleteQuestionForStaff 182