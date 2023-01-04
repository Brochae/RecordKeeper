--LB: Great job on corrections! 100%
use RecordKeeperDB
go
drop table if exists ExecutiveOrder
drop table if exists President
drop table if exists Party
go
create table dbo.Party(
	PartyId int not null identity primary key,
	PartyName varchar(35) not null constraint u_Party_PartyName unique,
		constraint ck_PartyName_cannot_be_blank check(PartyName <> ''),
	YearStarted int not null constraint ck_YearStarted_must_be_greater_than_0_and_cannot_be_a_future_date check(YearStarted between 1 and year(getdate())),
	Color varchar(20) not null constraint ck_Color_cannot_be_blank check(Color <> '')
)
go
		create table dbo.President(
		PresidentId int not null identity (1000,1) primary key,
		PartyId int not null constraint f_Party_President foreign key references Party(PartyId),
		Num int not null 
			constraint u_president_num_must_unique unique, 
			constraint ck_President_num_cannot_be_zero check(Num > 0),
		FirstName varchar(100) not null constraint ck_President_first_name_cannot_be_blank check(FirstName <> ''), 
		LastName varchar(100) not null constraint ck_President_last_name_cannot_be_blank check(LastName <> ''), 
		DateBorn date not null constraint ck_Date_born_cannot_be_blank check(DateBorn <> ''),
		DateDied datetime2 constraint ck_Date_died_cannot_be_blank check(DateDied <> ''),
		YearBorn as datepart(year,DateBorn),
		YearDied as datepart(year,DateDied),
		TermStart int not null constraint ck_Term_start_cannot_be_before_the_year_1789 check (TermStart >= 1789),
		TermEnd int,
		constraint ck_Term_end_cannot_be_before_term_start check(TermEnd >= TermStart),
		constraint ck_Age_at_start_of_presidency_must_be_at_least_35 check(TermStart - year(DateBorn) >= 35),
		constraint ck_Date_died_cannot_be_before_date_born check (DateDied > DateBorn)
	)
go
alter table president drop column if exists Code

alter table president add Code as replace(concat(Num,'-',FirstName,'-',LastName),' ','-') persisted

alter table president drop column if exists AgeAtDeath 

alter table president add AgeAtDeath as DATEDIFF(YEAR, DateBorn, DateDied) persisted

alter table president drop column if exists YearsServed

alter table president add YearsServed as TermEnd - TermStart persisted

alter table president drop column if exists CompleteTermsServed

alter table president add CompleteTermsServed as 
      case 
            when TermEnd - TermStart  < 4 then 0
            when TermEnd - TermStart  between 4 and 7 then 1
            when TermEnd - TermStart  between 8 and 11 then 2
            when TermEnd - TermStart  = 12 then 3
            end
persisted
go
go
create table dbo.ExecutiveOrder(
	ExecutiveOrderId int not null identity primary key,
	PresidentId int not null constraint f_President_ExecutiveOrder foreign key references President(PresidentId),
	OrderNo int not null constraint u_ExecutiveOrder_OrderNo unique,
		constraint ck_OrderNo_must_be_greater_than_0 check(OrderNo > 0),
	PageNum int not null constraint ck_PageNum_must_be_greater_than_0 check(PageNum > 0),
	YearIssued int not null constraint ck_YearIssued_must_be_greater_than_0_and_cannot_be_a_future_date check(YearIssued between 1 and year(getdate())),
	OrderName varchar(1000) not null constraint ck_OrderName_cannot_be_blank check(OrderName <> ''),
	Reference as concat('Exec. Order No. ', OrderNo, ', 3 C.F.R. ', PageNum, ' ', YearIssued, '. ', OrderName) persisted,
	UpheldByCourt bit not null,
	AuditDate date not null default getdate()
)
