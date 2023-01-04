--Very nicely set up. One fix

--The year born must be before olympic year.
--YF this script only tests the Minimum year for Olympics, not the actual relationship between yearborn and olympicyear. Please fix and resubmit
insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
--select 1896, 'Summer', 'Athens, Greece', 'Athletics', 'Discus Throw', 'Gold', 'Robert', 'Garrett', 'United States', 1900
select 1896, 'Summer', 'Athens, Greece', 'Athletics', 'Discus Throw', 'Silver', 'Panagiotis', 'Paraskevopoulos', 'Greece', 1875
union select 1896, 'Summer', 'Athens, Greece', 'Athletics', 'Discus Throw', 'Bronze', 'Sotirios', 'Versis', 'Greece', 1879

--The first olympic games happened in 1896. No data is allowed to be inserted before that.
insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
--select 1895, 'Summer', 'Athens, Greece', 'Athletics', 'Discus Throw', 'Gold', 'Robert', 'Garrett', 'United States', 1875
select 1896, 'Summer', 'Athens, Greece', 'Athletics', 'Discus Throw', 'Silver', 'Panagiotis', 'Paraskevopoulos', 'Greece', 1875
union select 1896, 'Summer', 'Athens, Greece', 'Athletics', 'Discus Throw', 'Bronze', 'Sotirios', 'Versis', 'Greece', 1879

--No null data is allowed.
insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
--select null, 'Summer', 'Athens, Greece', 'Athletics', 'Discus Throw', 'Gold', 'Robert', 'Garrett', 'United States', 1875
--select 1896, null, 'Athens, Greece', 'Athletics', 'Discus Throw', 'Silver', 'Panagiotis', 'Paraskevopoulos', 'Greece', 1875
--select 1896, 'Summer', null, 'Athletics', 'Discus Throw', 'Bronze', 'Sotirios', 'Versis', 'Greece', 1879
--select 1896, 'Summer', 'Athens, Greece', null, '10 Km', 'Gold', 'Paul', 'Masson', 'France', 1876
--select 1896, 'Summer', 'Athens, Greece', 'Cycling', null, 'Silver', 'Léon', 'Flameng', 'France', 1877
--select 1896, 'Summer', 'Athens, Greece', 'Cycling', '10 Km', null, 'Adolf', 'Schmal', 'Austria', 1872
--select 1896, 'Summer', 'Athens, Greece', 'Fencing', 'Sabre', 'Gold', null, 'Georgiadis', 'Greece', 1876
--select 1896, 'Summer', 'Athens, Greece', 'Fencing', 'Sabre', 'Silver', 'Tilemachos', null, 'Greece', 1866
--select 1896, 'Summer', 'Athens, Greece', 'Fencing', 'Sabre', 'Bronze', 'Holger', 'Nielsen', null, 1866
select 1896, 'Summer', 'Athens, Greece', 'Swimming', 'Sailors 100 M Freestyle', 'Gold', 'Ioannis', 'Malokinis', 'Greece', null

--Columns should not allow blank data, zeros or negative numbers to be inserted. 
insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
--select 0, 'Summer', 'Athens, Greece', 'Athletics', 'Discus Throw', 'Gold', 'Robert', 'Garrett', 'United States', 1875
--select 1896, '', 'Athens, Greece', 'Athletics', 'Discus Throw', 'Silver', 'Panagiotis', 'Paraskevopoulos', 'Greece', 1875
--select 1896, 'Summer', '', 'Athletics', 'Discus Throw', 'Bronze', 'Sotirios', 'Versis', 'Greece', 1879
--select 1896, 'Summer', 'Athens, Greece', '', '10 Km', 'Gold', 'Paul', 'Masson', 'France', 1876
--select 1896, 'Summer', 'Athens, Greece', 'Cycling', '', 'Silver', 'Léon', 'Flameng', 'France', 1877
--select 1896, 'Summer', 'Athens, Greece', 'Cycling', '10 Km', '', 'Adolf', 'Schmal', 'Austria', 1872
--select 1896, 'Summer', 'Athens, Greece', 'Fencing', 'Sabre', 'Gold', '', 'Georgiadis', 'Greece', 1876
--select 1896, 'Summer', 'Athens, Greece', 'Fencing', 'Sabre', 'Silver', 'Tilemachos', '', 'Greece', 1866
--select 1896, 'Summer', 'Athens, Greece', 'Fencing', 'Sabre', 'Bronze', 'Holger', 'Nielsen', '', 1866
select 1896, 'Summer', 'Athens, Greece', 'Swimming', 'Sailors 100 M Free', 'Gold', 'Ioannis', 'Malokinis', 'Greece', 0

--Gymnasts must be at least 16 years old in order to compete.
insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
--select 1904, 'Summer', 'St. Louis, United States', 'Gymnastics', 'Club Swinging', 'Gold', 'Edward', 'Hennig', 'United States', 1889
select 1904, 'Summer', 'St. Louis, United States', 'Gymnastics', 'Club Swinging', 'Silver', 'Emil', 'Voigt', 'United States', 1888

--Boxers must be between 18 and 40 years old in order to compete.
insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
--select 1908, 'Summer', 'London, United Kingdom', 'Boxing', 'Heavyweight', 'Gold', 'Albert', 'Oldman', 'Great Britian', 1891
--select 1908, 'Summer', 'London, United Kingdom', 'Boxing', 'Heavyweight', 'Silver', 'Sidney', 'Evans', 'Great Britian', 1890
--select 1908, 'Summer', 'London, United Kingdom', 'Boxing', 'Heavyweight', 'Silver', 'Sidney', 'Evans', 'Great Britian', 1867
select 1908, 'Summer', 'London, United Kingdom', 'Boxing', 'Heavyweight', 'Silver', 'Sidney', 'Evans', 'Great Britian', 1868

--Each olympic year can only have one of each medal for each sport and its sport subcategory.
insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 1896, 'Summer', 'Athens, Greece', 'Athletics', 'Discus Throw', 'Silver', 'Robert', 'Garrett', 'United States', 1875
union select 1896, 'Summer', 'Athens, Greece', 'Athletics', 'Discus Throw', 'Silver', 'Panagiotis', 'Paraskevopoulos', 'Greece', 1875
select 1896, 'Summer', 'Athens, Greece', 'Athletics', 'Discus Throw', 'Bronze', 'Sotirios', 'Versis', 'Greece', 1879