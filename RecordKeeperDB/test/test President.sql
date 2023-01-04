
--Great work. one fix
insert president(Num, FirstName, LastName, Party, dateBorn, DateDied, TermStart, TermEnd)
    select 1, 'George', 'Washington', 'None, Federalist', '1732-02-22', '1799-12-14', 1789, 1797
union all select 1, 'George', 'Washington', 'None, Federalist', '1732-02-22', '1799-12-14', 1789, 1797

--The first president's term began in 1789 soon after the Constitution was ratified. 
insert president(Num, FirstName, LastName, Party, dateBorn, DateDied, TermStart, TermEnd)
--select 111, 'George', 'Washington', 'None, Federalist', '1732-02-22', '1799-12-14', 1788, 1797
select 222, 'John', 'Adams', 'Federalist', '1735-10-30', '1826-07-04', 1789, 1801

--Term end cannot be before term start.
insert president(Num, FirstName, LastName, Party, dateBorn, DateDied, TermStart, TermEnd)
select 1111, 'George', 'Washington', 'None, Federalist', '1732-02-22', '1799-12-14', 1789, 1788
select 2222, 'John', 'Adams', 'Federalist', '1735-10-30', '1826-07-04', 1797, 1801

--A president must be at least 35 years old.
insert president(Num, FirstName, LastName, Party, dateBorn, DateDied, TermStart, TermEnd)
select 11111, 'George', 'Washington', 'None, Federalist', '1755-02-22', '1799-12-14', 1789, 1797
select 22222, 'John', 'Adams', 'Federalist', '1762-10-30', '1826-01-01', 1797, 1801

--Can't be null besides date died and term end
insert president(Num, FirstName, LastName, Party, dateBorn, DateDied, TermStart, TermEnd)
--select null, 'George', 'Washington', 'None, Federalist', '1732-02-22', '1799-12-14', 1789, 1797
--select 212, null, 'Adams', 'Federalist', '1735-10-30', '1826-07-04', 1797, 1801
--select 313, 'Thomas', null, 'Democratic-Republican', '1743-04-13', '1826-07-04', 1801, 1809
--select 414, 'James', 'Madison', null, '1751-03-16', '1836-06-28', 1809, 1817
--select 515, 'James', 'Monroe', 'Democratic-Republican', null, '1831-07-04', 1817, 1825
--select 616, 'John Quincy', 'Adams', 'Democratic-Republican', '1767-07-11', null, 1825, 1829
--select 717, 'Andrew', 'Jackson', 'Democrat', '1767-03-15', '1845-06-08', null, 1837
select 818, 'Martin', 'van Buren', 'Democrat', '1782-12-05', '1862-07-24', 1837, null

--Can't be blank/zero/negative
--FYI negative num is not blocked
insert president(Num, FirstName, LastName, Party, dateBorn, DateDied, TermStart, TermEnd)
--select -4, 'George', 'Washington', 'None, Federalist', '1732-02-22', '1799-12-14', 1789, 1797
--select 221, '', 'Adams', 'Federalist', '1735-10-30', '1826-07-04', 1797, 1801
--select 331, 'Thomas', '', 'Democratic-Republican', '1743-04-13', '1826-07-04', 1801, 1809
--select 441, 'James', 'Madison', '', '1751-03-16', '1836-06-28', 1809, 1817
--select 551, 'James', 'Monroe', 'Democratic-Republican', '', '1831-07-04', 1817, 1825
--select 661, 'John Quincy', 'Adams', 'Democratic-Republican', '1767-07-11', '', 1825, 1829
--select 771, 'Andrew', 'Jackson', 'Democrat', '1767-03-15', '1845-06-08', 0, 1837
select 881, 'Martin', 'van Buren', 'Democrat', '1782-12-05', '1862-07-24', 1837,0


