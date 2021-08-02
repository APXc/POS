CREATE TABLE Costumer(
	Id [bigint] IDENTITY(1,1) NOT NULL, 
	Name [varchar](255) NOT NULL, 
	Surname [varchar](255) NOT NULL,
	FiscalCode [varchar](255),
	Address [varchar](255),
	State [varchar](255), 
	PhoneNumber [varchar](255) , 
	Email [varchar](255),  
	Notes [varchar](255), 
	MktgId  [varchar](255),
	standardDiScont [bigint]
	)

