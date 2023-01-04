insert WorldRecord (Category, RecordName, RecordDesc, FullName, Amount, UnitOfMeasure, YearAchieved, Country) 
--select null, 'B', 'C', 'D', 5, 'E', 2021, 'F'
--select 'A', null, 'C', 'D', 5, 'E', 2021, 'F'
--select 'A', 'B', null, 'D', 5, 'E', 2021, 'F'
--select 'A', 'B', 'C', null, 5, 'E', 2021, 'F'
--select 'A', 'B', 'C', 'D', null, 'E', 2021, 'F'
--select 'A', 'B', 'C', 'D', 5, null, 2021, 'F'
--select 'A', 'B', 'C', 'D', 5, 'E', null, 'F'
--select 'A', 'B', 'C', 'D', 5, 'E', 2021, null

--select '', 'B', 'C', 'D', 5, 'E', 2021, 'F'
--select 'A', '', 'C', 'D', 5, 'E', 2021, 'F'
--select 'A', 'B', '', 'D', 5, 'E', 2021, 'F'
--select 'A', 'B', 'C', '', 5, 'E', 2021, 'F'
--select 'A', 'B', 'C', 'D', 0, 'E', 2021, 'F'
--select 'A', 'B', 'C', 'D', 5, '', 2021, 'F'
--select 'A', 'B', 'C', 'D', 5, 'E', 1199, 'F'
--select 'A', 'B', 'C', 'D', 5, 'E', 2021, ''

--select 'A', 'B', 'C', 'D', 5, 'E', 1499, 'F'
--union select 'Aa', 'B', 'Ca', 'Da', 50, 'Ea', 2021, 'Fa'

--select 'A', 'B', 'C', 'D', 5, 'E', 1776, 'USA'

insert WorldRecord (Category, RecordName, RecordDesc, FullName, Amount, UnitOfMeasure, YearAchieved, Country) 
select 'Animals', 'Largest horn circumference on a horn', 'The largest horn circumference on a steer measured 95.25 cm (37.5 in) on 6 May 2003 and belong to Lurch, an African watusi steer owned by Janice Wolf (USA) of Gassville, Arkansas, USA. Sadly, Lurch died at 3 p.m. on 22 May 2010 of a cancer at the base of one of the horns. The body has has been released to a local taxidermist, who will produce a full-sized taxidermy of the steer.', 'Lurch', 95.25, 'Centimetres', 2003, 'USA'
