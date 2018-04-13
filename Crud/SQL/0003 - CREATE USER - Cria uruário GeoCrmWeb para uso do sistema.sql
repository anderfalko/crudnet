CREATE LOGIN GeoCrmWeb
    WITH PASSWORD = 'MDsLeIEWXQe83P5w',
	DEFAULT_DATABASE= GEO_CRM,
	DEFAULT_LANGUAGE=[us_english],
	CHECK_EXPIRATION=OFF, 
	CHECK_POLICY=OFF;
GO

-- seleciona o banco que vai add u suário
USE GEO_CRM;
GO
CREATE USER GeoCrmWeb FOR LOGIN GeoCrmWeb;
GO
EXEC sp_addrolemember 'db_datareader', 'GeoCrmWeb';
EXEC sp_addrolemember 'db_datawriter', 'GeoCrmWeb';
GO



