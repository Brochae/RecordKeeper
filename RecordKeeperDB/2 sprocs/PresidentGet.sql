create or alter procedure PresidentGet(
    @PresidentId int = 0, 
    @Num int = 0, 
    @Code varchar(250)='',
    @PartyName varchar(35)='',
    @All bit = 0, 
    @Message varchar(1000) = '' output
    )
as
begin 
    declare @Return int = 0
    select @PresidentId = isnull(@PresidentId,0), @All = isnull(@All,0), @Num = isnull(@Num,0), @PartyName = isnull(@PartyName,'')

    select p.PresidentId, p.PartyId, a.PartyName, p.Num, p.FirstName, p.LastName, p.DateBorn, p.DateDied, p.YearBorn, p.YearDied, p.TermStart, p.TermEnd, p.AgeAtDeath, p.YearsServed, p.CompleteTermsServed, p.Code
    from President p 
    join Party a 
    on p.PartyId = a.PartyId
    where p.PresidentId = @PresidentId
        or @All = 1
        or p.Num = @Num
        or p.Code = @Code
        or a.PartyName = @PartyName
    order by p.Num

    Finished:
    return @Return
end

go 

exec PresidentGet @PartyName = 'whig'

exec PresidentGet @Code ='1-George-Washington'

exec PresidentGet @Num = 45

exec PresidentGet @PresidentId  = 1000

exec PresidentGet @All = 1

select * from president