USE LedgerAppDbNew;
IF OBJECT_ID('dbo.Customers', 'U') IS NOT NULL
    SELECT TOP 100 * FROM dbo.Customers;
ELSE
    PRINT 'dbo.Customers not found';    