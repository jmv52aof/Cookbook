-- use master;
-- create database cookbook;

use cookbook;
create table Recipe(
	Id int identity(1,1) constraint PK_Recipe primary key,
	Name nvarchar(255),
	ShortDescription nvarchar(511),
	FullDescription nvarchar(4000)
);

