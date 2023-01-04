create or alter procedure dbo.ExecutiveOrderGet(@PresidentId int)
as
begin
    select e.ExecutiveOrderId,  e.PresidentId, e.OrderNo, e.PageNum, e.YearIssued, e.OrderName, e.Reference, e.UpheldByCourt, e.AuditDate
    from ExecutiveOrder e 
    where e.PresidentId = @PresidentId
    order by e.Reference
end
go

exec ExecutiveOrderGet @PresidentId = 1031