create or alter procedure dbo.PresidentSearch(@SearchCriteria varchar(1000), @Message varchar(1000) = '' output)
as
begin
    declare @Return int = 0

    select * 
    from President p 
    where p.LastName like '%' + @SearchCriteria + '%'
        or p.FirstName like '%' + @SearchCriteria + '%'
    return @Return
end
go

exec PresidentSearch @SearchCriteria = 'a'