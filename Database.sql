CREATE TABLE Helmet(
helmetid serial,
helmettmaker varchar(300),
helmetname varchar(300),
helmetproductionyear date,
helmetprice int
);

insert into (Helmethelmettmaker, helmetname, helmetproductionyear, helmetprice) values 
('AGV', 'K-5', '2013-01-01', '230'),
('SHARK', 'Spartan', '2014-01-01', '320'),
('AGV', 'K-3', '2010-01-01', '190'),
('HJC', 'RPHA11', '2021-01-01', '450');

select * from Helmet;

CREATE TABLE HelmetMaker(
makeid serial,
makername varchar(300),
makersafetyrank int,
makeropenyear date
);

insert into HelmetMaker(makername, makersafetyrank , makeropenyear) values 
('AGV', '1', '1947-01-01'),
('SHARK', '3', '1986-01-01'),
('HJC', '7', '1971-01-01'),
('ACERBIS', '10', '1973-01-01');

select * from HelmetMaker;

