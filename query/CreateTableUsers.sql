
CREATE TABLE users([Id] [bigint] IDENTITY(1,1) NOT NULL, [username] [varchar](255) NOT NULL unique, [password] [varchar](255) NOT NULL,[name] [varchar](255) NOT NULL,[surname] [varchar](255) NOT NULL);

