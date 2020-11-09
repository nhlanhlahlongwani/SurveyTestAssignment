use connectiondb

create table userDetails
(
userID int not null primary key identity(1,1),
userName varchar(50) not null,
userSurname varchar(50) not null,
contactNo varchar(10) not null,
userDate date not null,
age int not null
)



create table surveyinfo
(
surInfo_id int not null primary key identity(1,1),
Fav_Food nvarchar(50),
eat_out int,
watch_movies int,
watch_TV int,
lis_radio int
)



SELECT * FROM userDetails
SELECT * FROM Surveyinfo