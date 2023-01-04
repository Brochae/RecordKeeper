create or alter procedure dbo.PresidentUpdate(
    @PresidentId int output,
    @PartyId int output,
    @Num int output,
    @FirstName varchar(100),
    @LastName varchar(100),
    @DateBorn date,
    @DateDied datetime2 = null,
    --@YearBorn int,
    --@YearDied int,
    @TermStart int,
    @TermEnd int,
    @Code varchar(250) = '' output,
    --@AgeAtDeath int,
    --@YearsServed int,
    --@CompleteTermsServed int
    @Message varchar(1000) = '' output
)   
as
begin
    declare @Return int
    select @PresidentId = ISNULL(@PresidentId, 0), @TermEnd = NULLIF(@TermEnd,0), @Num = ISNULL(@Num,0)

    if @PresidentId = 0
    begin
            if @Num = 0
                begin
                    select @Num = MAX(p.Num) +1 from president p
                end
        insert President(PartyId, Num, FirstName, LastName, DateBorn, DateDied, TermStart, TermEnd)
        values (@PartyId, @Num, @FirstName, @LastName, @DateBorn, @DateDied, @TermStart, @TermEnd)

        select @PresidentId = scope_identity()
    end
    else
    begin
        if(@num <> (select Num from president p where p.PresidentId = @PresidentId))
        begin
            select @Return = 1, @Message = 'President Num cannot be changed.'
            goto Finished
        end
        update p
        set 
            PartyId = @PartyId,
            Num = @Num,
            FirstName = @FirstName,
            LastName = @LastName,
            DateBorn = @DateBorn,
            DateDied = @DateDied,
            TermStart = @TermStart,
            TermEnd = @TermEnd
        from President p
        where p.PresidentId = @PresidentId
    end

    select @Code = p.Code from President p where p.PresidentId = @PresidentId
    Finished:
    return @Return
end

select * from party