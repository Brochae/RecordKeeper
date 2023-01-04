create or alter procedure dbo.PartyGet(
    @PartyId int = 0,
    @PartyName varchar(35) = '',
    @All bit = 0,
    @IncludeBlank bit = 0,
    @Message varchar(1000) = '' output
)
as
begin
    select @PartyId = ISNULL(@PartyId,0), @All = ISNULL(@All,0), @IncludeBlank = ISNULL(@IncludeBlank,0), @PartyName = ISNULL(@PartyName,'')

    select p.PartyId, p.PartyName, p.Color, p.YearStarted, PresidentCount = count(r.PresidentId)
    from Party p 
    left join President r
    on p.PartyId = r.PartyId
    where p.PartyId = @PartyId
    or @All = 1
    or p.PartyName = @PartyName
    group by p.PartyId, p.PartyName, p.Color, p.YearStarted
    union select 0,'','',0,0 where @IncludeBlank = 1
    order by p.PartyName

end

go

exec PartyGet @All = 1
exec PartyGet @All = 1, @IncludeBlank = 1
exec PartyGet @PartyId = 22
exec PartyGet @PartyName = 'Republican'