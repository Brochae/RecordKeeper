-- World Record

-- 1. All columns should block nulls
-- 2. Block blank values for all varchar columns
-- 3. Block negative numbers for all int columns
-- 4. Rerun the World Record data

-- Test your constraints! Try inserting bad data to ensure that your table is protected (save test script in test folder).


use RecordKeeperDB
go
drop table if exists WorldRecord
go
create table dbo.WorldRecord(
	WorldRecordId int not null identity primary key,
	Category varchar (100) not null constraint ck_WorldRecord_Category_cannot_be_blank check(Category <> ''),
	RecordName varchar (200) not null 
		constraint ck_WorldRecord_Record_Name_cannot_be_blank check (RecordName <> '')
		constraint ck_WorldRecord_Record_Name_must_be_unique unique,
	RecordDesc varchar (max) not null constraint ck_WorldRecord_Record_Desc_cannot_be_blank check (RecordDesc <> ''),
	FullName varchar (100) not null constraint ck_WorldRecord_Full_Name_cannot_be_blank check (FullName <> ''),
	Amount decimal not null constraint ck_WorldRecord_Amount_must_be_greater_than_zero check (Amount > 0),
	UnitOfMeasure varchar (100) not null constraint ck_WorldRecord_Unit_of_Measure_cannot_be_blank check (UnitOfMeasure <> ''),
	YearAchieved int not null constraint ck_WorldRecord_YearAchieved_must_be_greater_than_or_equal_to_1200 check(YearAchieved >= 1200),
	RecordBreakerAddress varchar (500) not null default '',
	DateInserted datetime not null default getdate(),
	Country varchar (50) not null constraint ck_WorldRecord_Country_cannot_be_blank check (Country <> ''),
	constraint ck_USA_WorldRecords_must_be_after_1776 check(not(Country = 'USA' and YearAchieved < 1776))
	)
go
alter table WorldRecord drop constraint if exists u_WorldRecord_Code
alter table WorldRecord drop column if exists Code

alter table WorldRecord 
	add Code as CONCAT(LEFT(REPLACE(RecordName, ' ', ''), 20), YearAchieved) persisted
	constraint u_WorldRecord_Code unique
