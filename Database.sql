CREATE TABLE Helmet(
HelmetId serial,
HelmetMaker varchar(300),
HelmetName varchar(300),
HelmetProductionYear date,
HelmetPrice int
);

insert into Helmet(HelmetMaker, HelmetName, HelmetProductionYear, HelmetPrice) values 
('AGV', 'K-5', '2013-01-01', '230'),
('SHARK', 'Spartan', '2014-01-01', '320'),
('AGV', 'K-3', '2010-01-01', '190'),
('HJC', 'RPHA11', '2021-01-01', '450');

select * from Helmet;

CREATE TABLE HelmetMaker(
MakeId serial,
MakerName varchar(300),
MakerSafetyRank int,
MakerOpenYear date,
);

insert into HelmetMaker(MakerName, MakerSafetyRank, MakerOpenYear) values 
('AGV', '1', '1947-01-01'),
('SHARK', '3', '1986-01-01'),
('HJC', '7', '1971-01-01'),
('ACERBIS', '10', '1973-01-01');

select * from HelmetMaker;

