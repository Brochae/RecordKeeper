--LB: Excellent! 100%

/* 1
Medalist 
   Recently somebody entered bad data into the medalist table (mixed up the year born and the olympic year),
   and that data was used to create an advertisement targeting an international audience.
   The advertisement was viewed by millions of people around the world. It was very embarassing.
   Strengthen the table in order to ensure that no bad data is ever inserted again.
   The following rules must be enforced:
      The year born must be before olympic year.
      The first olympic games happened in 1896. No data is allowed to be inserted before that.
      No null data is allowed.
      Columns should not allow blank data, zeros or negative numbers to be inserted. 
      Gymnasts must be at least 16 years old in order to compete.
      Boxers must be between 18 and 40 years old in order to compete.
      Each olympic year can only have one of each medal for each sport and its sport subcategory.
    After adding in the constraints, rerun the medalist data and include test scripts for the constraints to prove that you have succeeded in strengthening the table.
*/
use RecordKeeperDB
go
drop table if exists Medalist
go
create table dbo.Medalist(
	MedalistId int not null identity primary key,
	OlympicYear int not null constraint ck_Olympic_year_cannot_be_before_1896 check(OlympicYear >= 1896), 
	Season varchar (50) not null constraint ck_Season_cannot_be_blank check(Season <> ''),
	OlympicLocation varchar (100) not null constraint ck_Olympic_location_cannot_be_blank check(OlympicLocation <> ''),
	Sport varchar (100) not null constraint ck_Sport_cannot_be_blank check(Sport <> ''),
	SportSubcategory varchar (100) not null constraint ck_Sport_subcategory_cannot_be_blank check(SportSubcategory <> ''),
	Medal varchar (6) not null constraint ck_Medal_cannot_be_blank check(Medal <> ''),
	FirstName varchar (50) not null constraint ck_First_name_cannot_be_blank check(FirstName <> ''),
	LastName varchar (50) not null constraint ck_Last_name_cannot_be_blank check(LastName <> ''),
	Country varchar (50) not null constraint ck_Country_cannot_be_blank check(Country <> ''),
	YearBorn int not null,
	constraint ck_The_year_born_must_be_before_olympic_year check(YearBorn < OlympicYear),
	constraint ck_Gymnasts_must_be_at_least_16_years_old
		check(not(sport = 'Gymnastics' and OlympicYear - YearBorn < 16)),
	constraint ck_boxers_must_be_between_18_and_40_years_old
--Very nice nested parentheses
		check(not((sport = 'Boxing' and OlympicYear - YearBorn < 18) or (sport = 'Boxing' and OlympicYear - YearBorn > 40))),
	constraint u_There_can_only_be_one_winner_per_medal_level_per_a_sport_sub_catgory_per_a_sport_per_a_year
		unique(OlympicYear, Medal, Sport, SportSubcategory)
)
go

alter table Medalist drop column if exists AgeWhenWonMedal

alter table Medalist add AgeWhenWonMedal as OlympicYear - YearBorn persisted 

alter table Medalist drop column if exists Summary

alter table Medalist add Summary as CONCAT(Medal, ' - ', SUBSTRING(FirstName, 1,1), '.', SUBSTRING(LastName,1,1), '.: ', OlympicYear ) persisted 

alter table Medalist drop column if exists GoldMedalists

alter table Medalist add GoldMedalists as case Medal when 'Gold' then 1 else 0 end persisted

alter table Medalist drop constraint if exists d_Medalist_MedalistAddress
alter table Medalist drop column if exists MedalistsAddress

alter table Medalist 
      add MedalistsAddress varchar(500) not null 
      constraint d_Medalist_MedalistAddress default ''
