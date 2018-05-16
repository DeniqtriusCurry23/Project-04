CREATE TABLE USERS(
    UserId int,
    UserPasscode varchar(25),
    Username varchar(25),
	Profileid int foreign key
)


CREATE TABLE Connections (
    ConnectionID int,
    LastName varchar(255),
    FirstName varchar(255),
    Address varchar(255),
    City varchar(255),
	Profileid int not null foreign key
);



CREATE TABLE Profile (
    Profileid int not null primary key,
    LastName varchar(255),
    FirstName varchar(255),
    Address varchar(255),
    City varchar(255),
	Connectionid int not null foreign key
);  