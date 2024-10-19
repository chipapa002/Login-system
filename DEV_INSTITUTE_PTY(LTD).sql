CREATE DATABASE DEV_COMP;

USE DEV_COMP;

CREATE TABLE REGISTRATION_TBL(
	REG_ID INT PRIMARY KEY IDENTITY,
	UserName VARCHAR(50) NOT NULL,
	Reg_PassWord VARCHAR(100) NOT NULL,
	Re_Enter_Password VARCHAR(100) NOT NULL,
	Reg_Email VARCHAR(50) NOT NULL);

CREATE PROCEDURE Reg_Person(
	@name VARCHAR(50),
	@Password VARCHAR(100),
	@Re_password VARCHAR(100),
	@Email VARCHAR(50))
AS
INSERT INTO REGISTRATION_TBL
VALUES (@name, @Password, @Re_password, @Email);

CREATE TABLE appication(
	ID_No INT PRIMARY KEY,
	First_name VARCHAR(50) NOT NULL,
	Last_name VARCHAR(50) NOT NULL,
	Phone_No VARCHAR(10) NOT NULL,
	Gender VARCHAR(10) NOT NULL,
	Course VARCHAR(50) NOT NULL);

CREATE PROCEDURE user_apply(
	@ID_num INT,
	@f_name VARCHAR(50),
	@l_name VARCHAR(50),
	@phone_num VARCHAR(50),
	@Gender VARCHAR(10),
	@Course VARCHAR(50))
AS 
INSERT INTO appication 
VALUES(@ID_num, @f_name, @l_name, @phone_num, @Gender, @Course);

