IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name = 'Customer' AND schema_id = SCHEMA_ID('dbo'))
BEGIN
    CREATE TABLE dbo.Customer
    (
        Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        Name NVARCHAR(150) NOT NULL,
        Address NVARCHAR(250) NULL,
        Phone NVARCHAR(50) NULL,
        Email NVARCHAR(150) NULL
    );

    CREATE NONCLUSTERED INDEX IX_Customer_Name ON dbo.Customer(Name);
END
ELSE        
BEGIN
    PRINT 'Table dbo.Customer already exists.';
END;

-- Apply the migration to the database
-- dotnet ef migrations add AddCustomersTable -o Data/Migrations --context LedgerApplication.Data.AppDbContext
-- dotnet ef database update --context LedgerApplication.Data.AppDbContext

--# Show SQL Server service(s) status
--Get-Service -Name 'MSSQL*' | Select-Object Name, Status