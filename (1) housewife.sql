USE master;

IF EXISTS (SELECT 1 FROM sys.databases WHERE name = 'housewife')
BEGIN
    ALTER DATABASE housewife SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE housewife;
END
Go
CREATE DATABASE housewife COLLATE Latin1_General_100_CI_AS_SC_UTF8; -- Create the new database
Go
USE housewife;

CREATE TABLE users(
	id INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
	name VARCHAR(25) NOT NULL,
	username VARCHAR(25) NOT NULL,
	password VARCHAR(50) NOT NULL
);

insert into users(name,username,password) values('SoeLin','soelin',HASHBYTES('sha2_256','admin'));
insert into users(name,username,password) values('Tin Tin Swe','tintin',HASHBYTES('sha2_256','tintin'));
insert into users(name,username,password) values('Sann Lynn Htun','ace',HASHBYTES('sha2_256','ace'));

CREATE TABLE descriptions(
	id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	description VARCHAR(255) NOT NULL UNIQUE
);

CREATE TABLE cash_flow(
	id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	text VARCHAR(25) NOT NULL UNIQUE
);

CREATE TABLE monthly_net_amount(
	id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	amount DECIMAL(10,2) NOT NULL,
	month DATE NOT NULL
);

CREATE TABLE balance(
	id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	amount DECIMAL(10,2) NOT NULL DEFAULT(0)
);

CREATE table from_to_flow(
	id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	text VARCHAR(255) NOT NULL UNIQUE
);


CREATE TABLE incomes(
	id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	description_id INT NOT NULL,
	from_to_flow_id INT NOT NULL,
	user_id INT NOT NULL,
	amount DECIMAL(10,2) NOT NULL CHECK(amount>0),
	cash_flow_id INT NOT NULL,
	date DATE NOT NULL DEFAULT GETDATE(),
	FOREIGN KEY(description_id) REFERENCES descriptions(id),
	FOREIGN KEY(cash_flow_id) REFERENCES cash_flow(id),
	FOREIGN KEY(from_to_flow_id) REFERENCES from_to_flow(id),
	FOREIGN KEY(user_id) REFERENCES users(id)
);

CREATE TABLE expenses(
	id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	description_id INT NOT NULL,
	from_to_flow_id INT NOT NULL,
	user_id INT NOT NULL,
	amount DECIMAL(10,2) NOT NULL CHECK(amount>0),
	cash_flow_id INT NOT NULL,
	date DATE NOT NULL DEFAULT GETDATE(),
	FOREIGN KEY(description_id) REFERENCES descriptions(id),
	FOREIGN KEY(from_to_flow_id) REFERENCES from_to_flow(id),
	FOREIGN KEY(cash_flow_id) REFERENCES cash_flow(id),
	FOREIGN KEY(user_id) REFERENCES users(id)
);

CREATE TABLE saving(
	id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	user_id INT NOT NULL,
	amount DECIMAL(10,2) NOT NULL CHECK(amount>0),
	saving_month DATE NOT NULL DEFAULT GETDATE(),
	FOREIGN KEY(user_id) REFERENCES users(id)
);

CREATE TABLE expenditure_budgets(
	id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	month DATE NOT NULL,
	amount DECIMAL(10,2)NOT NULL CHECK(amount>0)
);

CREATE TABLE total_saving(
	id INT IDENTITY(1,1),
	amount DECIMAL(10,2) NOT NULL
);

CREATE TABLE withdraw_saving(
	id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	user_id INT NOT NULL,
	date DATE,
	amount DECIMAL(10,2),	
	FOREIGN KEY(user_id) REFERENCES users(id)
);