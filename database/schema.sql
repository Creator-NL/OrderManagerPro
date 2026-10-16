-- ============================================================================
-- OrderManagerPro — SQL Server LocalDB Schema & Seed Script
-- Default Database File: C:\DataBase\DatabaseOrderManagerPro.mdf
-- Connection String:
--   Data Source=(LocalDB)\MSSQLLocalDB;
--   AttachDbFilename=C:\DataBase\DatabaseOrderManagerPro.mdf;
--   Integrated Security=True;Connect Timeout=30
-- ============================================================================

-- 1. Users Table (Authentication, Role Groups & Default Language)
IF OBJECT_ID('dbo.Users', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Users (
        ID           INT IDENTITY(1,1) PRIMARY KEY,
        Name         NVARCHAR(100) NOT NULL UNIQUE,
        [Group]      NVARCHAR(50)  NOT NULL, -- 'Inbound', 'Stock Control', 'Admin', 'Super Admin'
        Password     NVARCHAR(64)  NOT NULL, -- Lowercase SHA-256 hex digest
        UserLanguage NVARCHAR(50)  NOT NULL DEFAULT 'English' -- 'English', 'Nederlands', 'Deutsch'
    );
END
GO

-- 2. OrderProblems Table (Inbound Inquiries, Stock Control Investigations & SLA Tracking)
IF OBJECT_ID('dbo.OrderProblems', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.OrderProblems (
        ID                   BIGINT IDENTITY(1,1) PRIMARY KEY,
        DateAndTimeCreated   DATETIME2     NOT NULL DEFAULT SYSDATETIME(),
        NameCreator          NVARCHAR(100) NULL,
        Supplier             NVARCHAR(200) NULL,
        OrderNumber          NVARCHAR(100) NULL,
        DeliveryNumber       NVARCHAR(100) NULL,
        ProductNumber        NVARCHAR(100) NULL,
        OrderAmount          NVARCHAR(50)  NULL,
        ProductPrice         NVARCHAR(50)  NULL,
        ProblemType          NVARCHAR(100) NULL,
        ProblemAmount        NVARCHAR(50)  NULL,
        Comment              NVARCHAR(MAX) NULL,
        ProblemState         NVARCHAR(50)  NULL, -- 'Active', 'Ready', 'Finished'
        InquiryOrder         NVARCHAR(100) NULL,
        InquiryResult        NVARCHAR(100) NULL, -- 'Found', 'Not Found', 'Senior Approval'
        MistakeType          NVARCHAR(100) NULL,
        MistakeMadeBy        NVARCHAR(100) NULL,
        AmountFound          NVARCHAR(50)  NULL,
        FoundLocation        NVARCHAR(100) NULL,
        FoundHandlingUnit    NVARCHAR(100) NULL,
        InvestigatedBy       NVARCHAR(100) NULL,
        InvestigatorComment  NVARCHAR(MAX) NULL,
        DateAndTimeReady     DATETIME2     NULL,
        DateAndTimeFinished  DATETIME2     NULL
    );
END
GO

-- 3. Optional Seed Users (Default Password for all seed accounts below: "1" -> SHA-256: 6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b)
IF NOT EXISTS (SELECT 1 FROM dbo.Users WHERE Name = 'admin')
BEGIN
    INSERT INTO dbo.Users (Name, [Group], Password, UserLanguage)
    VALUES
        ('admin',        'Admin',         '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b', 'English'),
        ('inbound',      'Inbound',       '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b', 'English'),
        ('stockcontrol', 'Stock Control', '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b', 'English');
END
GO
