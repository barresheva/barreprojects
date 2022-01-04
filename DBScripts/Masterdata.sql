
IF NOT EXISTS (SELECT 1 FROM [UserRole] WHERE RoleName ='ADMIN')
BEGIN
	INSERT INTO [dbo].[UserRole](RoleName) VALUES('Admin')
END

IF NOT EXISTS (SELECT 1 FROM [UserRole] WHERE RoleName ='User')
BEGIN
	INSERT INTO [dbo].[UserRole](RoleName) VALUES('User')
END

IF NOT EXISTS (SELECT 1 FROM [RequestStatus] WHERE Status ='Pending')
BEGIN
	INSERT INTO [dbo].[RequestStatus](Status) VALUES('Pending')
END
IF NOT EXISTS (SELECT 1 FROM [RequestStatus] WHERE Status ='Accepted')
BEGIN
	INSERT INTO [dbo].[RequestStatus](Status) VALUES('Accepted')
END

IF NOT EXISTS (SELECT 1 FROM [RequestStatus] WHERE Status ='Rejected')
BEGIN
	INSERT INTO [dbo].[RequestStatus](Status) VALUES('Rejected')
END