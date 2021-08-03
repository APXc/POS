# **#POS Point Of Sales Project**

This project is a simple Pos write C# windowform for windows client and read/write to database on Microsoft Sql Server.

## Start

For Start create a file SetApp.xml

```xml
<?xml version="1.0" encoding="utf-8" ?>
<set>
  <lang>IT</lang>
  <name>POS</name>
  <version>0.0.01</version>
  <database>YOUR_DATABASE_NAME</database>
  <server>YOUR_SERVER_SQL_LINK</server>
  <userdb>YOUR_USER_DATABASE</userdb>
  <passworddb>YOUR_PASSOWRD_DATABASE</passworddb>
</set>

```
Next step before starting the program create an administrator user for the test on your database (in the new version this problem will be solved)
```sql
CREATE TABLE users(
	[Id] [bigint] IDENTITY(1,1) NOT NULL, 
	[username] [varchar](255) NOT NULL unique,
	[password] [varchar](255) NOT NULL,
	[name] [varchar](255) NOT NULL,
	[surname] [varchar](255) NOT NULL
 );
INSERT INTO [dbo].[users]
  (
    [username]
   ,[password]
   ,[name]
   ,[surname])
   VALUES(
   'ADMIN'
   ,'YOUR_ADMIN_PASSOWORD'
   ,'ADMIN'
   ,'ADMIN');
```
## Prerequisites

Prerequisites is:

|                |Version                        | Future Update                         |
|----------------|-------------------------------|-----------------------------|
|Dotnet 		 |`Framework '4.7.2'` 			 |Yes                          |
|MS SQL Sever    |`2019`                         |No                           |
|Windows         |`10.0.19042.1110`              |Yes                          |

work is underway to make it compatible with:

|                |Version                        | Year                        |
|----------------|-------------------------------|-----------------------------|
|Dotnet 		 |`Core '4.7.2'` 			     | 2022                        |
|MySql           |`*******`                      | 2022                        |
|MongoDB         |`*******`                      | 2023                        |
|Ubunto          |`20.4`                         | 2023                        |
|WebClient       |`*******`                      | 2024                        |
|Chrome Addon    |`*******`                      | 2024                        |

## Attection 
 
   This is a test project, do not use in a production environment
   This Software is not currently certified by any National Tax Agency
   This software does not guarantee that there will be no data loss


## Licenses
[GNU GPL V3](https://www.gnu.org/licenses/gpl-3.0.html) 

   POS_PointOfSales Copyright (C) 2021 Alessio Pellizzaro

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.