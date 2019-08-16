--if (select top 1 1 from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'Task') is null
--begin
--	create table Task (
--		Id uniqueidentifier primary key,
--		[Name] varchar(100)
--	);
--end

if (select top 1 1 from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'Movies') is null
begin
	create table Movies (
		Id uniqueidentifier primary key,
		MovieName nvarchar(100),
		RunTime int,
		DirectorName nvarchar(100)
	);
end
