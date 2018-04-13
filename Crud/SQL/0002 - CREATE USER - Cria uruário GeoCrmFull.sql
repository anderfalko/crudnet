CREATE LOGIN GeoCrmFull
    WITH PASSWORD = '3phmEP2LjGNduICK',
	DEFAULT_DATABASE= GEO_CRM,
	DEFAULT_LANGUAGE=[us_english],
	CHECK_EXPIRATION=OFF, 
	CHECK_POLICY=OFF;
GO

-- seleciona o banco que vai add u suário
USE GEO_CRM;
GO
CREATE USER GeoCrmFull FOR LOGIN GeoCrmFull;
GO
EXEC sp_addrolemember 'db_owner', 'GeoCrmFull';
GO



