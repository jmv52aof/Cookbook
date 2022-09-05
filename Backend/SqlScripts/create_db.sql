-- use master;
-- create database cookbook;

use cookbook;

create table Recipe(
	Id int identity(1,1) constraint PK_Recipe primary key,
	Name nvarchar(255),
	ShortDescription nvarchar(511),
	CookTimeMinutes int,
  Portions int
);

create table Ingridient(
  Id int identity(1,1) constraint PK_Ingridient primary key,
  Title nvarchar(255),
  Text nvarchar(4000),
  recipeId int constraint FK_Ingridient_Recipe references Recipe(Id)
);

create table Step(
  Id int identity(1,1) constraint PK_Step primary key,
  Text nvarchar(4000),
  recipeId int constraint FK_Step_Recipe references Recipe(Id)
);

create table Account(
	Id int identity(1,1) constraint PK_Account primary key,
	Name nvarchar(255),
	Login nvarchar(255),
	Password nvarchar(255)
);
