CREATE TABLE [dbo].[InventoryAssets] (
    [Id] INT PRIMARY KEY IDENTITY(1,1),
    [AssetTag] NVARCHAR(100) NOT NULL,
    [HostName] NVARCHAR(255),
    [EmployeeName] NVARCHAR(255),
    [EmployeeDesignation] NVARCHAR(255),
    [EmployeeId] NVARCHAR(100),
    [Location] NVARCHAR(255),
    [Make] NVARCHAR(255),
    [Model] NVARCHAR(255),
    [SerialNumber] NVARCHAR(255),
    [InvoiceNumber] NVARCHAR(255),
    [Status] NVARCHAR(100),
    [Remarks] NVARCHAR(MAX),
    [OsVersion] NVARCHAR(100),
    [WindowsPatch] NVARCHAR(100),
    [SentinelStatus] NVARCHAR(100),
    [UploadBatchId] INT NOT NULL,
    [CreatedAt] DATETIME2 DEFAULT GETUTCDATE(),
    [UpdatedAt] DATETIME2 DEFAULT GETUTCDATE()
);

CREATE TABLE [dbo].[TopsAssets] (
    [Id] INT PRIMARY KEY IDENTITY(1,1),
    [AssetTag] NVARCHAR(100) NOT NULL,
    [HostName] NVARCHAR(255),
    [AssignedUser] NVARCHAR(255),
    [Location] NVARCHAR(255),
    [Make] NVARCHAR(255),
    [Model] NVARCHAR(255),
    [SerialNumber] NVARCHAR(255),
    [AssetStatus] NVARCHAR(100),
    [OsVersion] NVARCHAR(100),
    [UploadBatchId] INT NOT NULL,
    [CreatedAt] DATETIME2 DEFAULT GETUTCDATE(),
    [UpdatedAt] DATETIME2 DEFAULT GETUTCDATE()
);

CREATE TABLE [dbo].[ReconciliationMatches] (
    [Id] INT PRIMARY KEY IDENTITY(1,1),
    [InventoryAssetId] INT,
    [TopsAssetId] INT,
    [MatchStatus] NVARCHAR(100) NOT NULL,
    [Severity] NVARCHAR(100),
    [IssueCategory] NVARCHAR(100),
    [CreatedAt] DATETIME2 DEFAULT GETUTCDATE(),
    [UpdatedAt] DATETIME2 DEFAULT GETUTCDATE()
);

CREATE TABLE [dbo].[AssetDiscrepancies] (
    [Id] INT PRIMARY KEY IDENTITY(1,1),
    [ReconciliationMatchId] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[ReconciliationMatches]([Id]) ON DELETE CASCADE,
    [FieldName] NVARCHAR(100),
    [InventoryValue] NVARCHAR(MAX),
    [TopsValue] NVARCHAR(MAX),
    [IsCritical] BIT DEFAULT 0,
    [CreatedAt] DATETIME2 DEFAULT GETUTCDATE()
);

CREATE TABLE [dbo].[ReconciliationReviews] (
    [Id] INT PRIMARY KEY IDENTITY(1,1),
    [ReconciliationMatchId] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[ReconciliationMatches]([Id]) ON DELETE CASCADE,
    [ReviewStatus] NVARCHAR(100),
    [ReviewedBy] NVARCHAR(255),
    [ReviewedAt] DATETIME2,
    [Comments] NVARCHAR(MAX),
    [RecommendedAction] NVARCHAR(255),
    [SourceOfTruth] NVARCHAR(100),
    [CreatedAt] DATETIME2 DEFAULT GETUTCDATE()
);

CREATE TABLE [dbo].[AuditLogs] (
    [Id] INT PRIMARY KEY IDENTITY(1,1),
    [EntityType] NVARCHAR(100),
    [EntityId] INT,
    [Action] NVARCHAR(100),
    [ChangedBy] NVARCHAR(255),
    [BeforeValue] NVARCHAR(MAX),
    [AfterValue] NVARCHAR(MAX),
    [CreatedAt] DATETIME2 DEFAULT GETUTCDATE()
);

CREATE TABLE [dbo].[FileUploadBatches] (
    [Id] INT PRIMARY KEY IDENTITY(1,1),
    [FileName] NVARCHAR(255),
    [FileType] NVARCHAR(10),
    [FileSize] BIGINT,
    [RowCount] INT,
    [UploadedBy] NVARCHAR(255),
    [UploadedAt] DATETIME2,
    [Status] NVARCHAR(50) DEFAULT 'Completed'
);

CREATE TABLE [dbo].[ColumnMappings] (
    [Id] INT PRIMARY KEY IDENTITY(1,1),
    [SourceColumn] NVARCHAR(255),
    [TargetColumn] NVARCHAR(255),
    [ConfidenceScore] DECIMAL(5,2),
    [IsManuallyMapped] BIT DEFAULT 0,
    [CreatedAt] DATETIME2 DEFAULT GETUTCDATE()
);

-- Create Indexes
CREATE INDEX IDX_InventoryAssets_AssetTag ON [dbo].[InventoryAssets]([AssetTag]);
CREATE INDEX IDX_InventoryAssets_SerialNumber ON [dbo].[InventoryAssets]([SerialNumber]);
CREATE INDEX IDX_InventoryAssets_HostName ON [dbo].[InventoryAssets]([HostName]);

CREATE INDEX IDX_TopsAssets_AssetTag ON [dbo].[TopsAssets]([AssetTag]);
CREATE INDEX IDX_TopsAssets_SerialNumber ON [dbo].[TopsAssets]([SerialNumber]);
CREATE INDEX IDX_TopsAssets_HostName ON [dbo].[TopsAssets]([HostName]);

CREATE INDEX IDX_ReconciliationMatches_Status ON [dbo].[ReconciliationMatches]([MatchStatus]);
CREATE INDEX IDX_ReconciliationMatches_Severity ON [dbo].[ReconciliationMatches]([Severity]);

CREATE INDEX IDX_AuditLogs_EntityType ON [dbo].[AuditLogs]([EntityType]);
