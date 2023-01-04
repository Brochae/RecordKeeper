--delete president where Num > 46

declare @PartyId int, @PresidentId int = 0, @Num int

select top 1 @PartyId = PartyId from Party order by PartyId


exec PresidentUpdate
@PresidentId = @PresidentId output,
@PartyId = @PartyId,
@Num = @Num output,
@FirstName = 'Max',
@LastName = 'Sax',
@DateBorn = '01/01/1968',
@DateDied = null,
@TermStart = 2024,
@TermEnd = null

select @Num

select * from President p order by p.PresidentId desc