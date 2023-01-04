--LB: Nice work! 100%
--a) list all executive orders sorted by page number, display the official executive order format
select e.Reference
from ExecutiveOrder e
order by e.PageNum 

--b) same as a but include the presidents name
select p.FirstName, p.LastName, e.Reference
from ExecutiveOrder e
join President p 
on e.PresidentId = p.PresidentId
order by e.PageNum 

--c) same as b but include the party name
select p.FirstName, p.LastName, z.PartyName, e.Reference
from ExecutiveOrder e
join President p 
on e.PresidentId = p.PresidentId
join Party z 
on p.PartyId = z.PartyId
order by e.PageNum 

--d) show number of executive orders per presidents, include zero if none for president, sort by highest number of orders
select p.FirstName, p.LastName, NumOfExecutiveOrders = COUNT(e.OrderNo)
from President p 
left join ExecutiveOrder e 
on p.PresidentId = e.PresidentId
group by p.FirstName, p.LastName, p.Num
order by NumOfExecutiveOrders desc

--e) show number of executive orders per party, include zero if none for party
select  z.PartyName, NumOfExecutiveOrders = COUNT(e.ExecutiveOrderId)
from Party z
join President p 
on z.PartyId = p.PartyId
left join ExecutiveOrder e 
on p.PresidentId = e.PresidentId
group by z.PartyName

--f) delete a party that has one or more executive orders
--I didn't fully understand the answer that was given on get help. I know this gets the right results, but I'm not sure if it's the right way how to do it.
--AG What he meant was that you should delete for a specific party. By your select you did on a specific OrderNo but the delete was done correct.
--He said "Use where clause to that looks for a particular executive order." Same below. I changed it to how you said.
--LB: That's great!
select z.PartyName
from President p 
join ExecutiveOrder e 
on p.PresidentId = e.PresidentId
join Party z 
on p.PartyId = z.PartyId
where z.PartyName = 'Democrat'--e.OrderNo = 6102

delete e 
--select *
from President p 
join Party z
on p.PartyId = z.PartyId
join ExecutiveOrder e 
on p.PresidentId = e.PresidentId
where z.PartyName = 'Democrat'

delete p 
--select *
from President p 
join Party z
on p.PartyId = z.PartyId
where z.PartyName = 'Democrat'


delete z
--select  z.PartyName
from Party z
where z.PartyName = 'Democrat'

--g) for a particular party with exec orders update all to not upheld
select z.PartyName
from President p 
join ExecutiveOrder e 
on p.PresidentId = e.PresidentId
join Party z 
on p.PartyId = z.PartyId
where z.PartyName = 'Democrat'--e.OrderNo = 6102

--select e.ExecutiveOrderId, p.FirstName, p.LastName, z.PartyName, e.Reference, e.UpheldByCourt
update e 
set UpheldByCourt = 0
from ExecutiveOrder e 
join President p 
on e.PresidentId = p.PresidentId
join Party z 
on p.PartyId = z.PartyId
where z.PartyName = 'Democrat'
