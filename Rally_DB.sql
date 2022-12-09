create schema Rally;

create table Rally.Teams(
Team_ID serial,
Team_Name varchar(300),
Country varchar(300),
Established_In int,
Acting_Team_Principal varchar(300)
);

insert into Rally.Teams(Team_Name, Country, Established_In, Acting_Team_Principal) 
values 
('HYUNDAI SHELL MOBIS', 'Germany', '2012', 'Julien Moncet'),
('M-SPORT FORD', 'Great Britain', '2006', 'Richard Millener'),
('TOYOTA GAZOO RACING', 'Japan', '2016', 'Jari-Matti Latvala')
;

select * from Rally.Teams;

create table Rally.Drivers(
Driver_ID serial,
Driver_Name varchar(300),
Driver_Team varchar(300),
Codriver_Name varchar(300),
Driver_Birthplace varchar(300)
);
insert into Rally.Drivers(Driver_Name, Driver_Team, Codriver_Name, Driver_Birthplace) 
values 
('OTT TÄNAK', 'HYUNDAI SHELL MOBIS', 'Martin Järveoja', 'Kärla Parish, Estonia'),
('ADRIEN FOURMAUX', 'M-Sport Ford', 'ALEXANDRE CORIA', 'France'),
('ESAPEKKA LAPPI', 'TOYOTA GAZOO RACING', 'Janne Ferm', 'Pieksämäki, Finland')
;
select * from Rally.Drivers;