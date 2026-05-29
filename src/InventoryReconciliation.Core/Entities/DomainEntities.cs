namespace InventoryReconciliation.Core.Entities;

public class InventoryAsset
{
    public int Id { get; set; }
    public string AssetTag { get; set; } = string.Empty;
    public string HostName { get; set; } = string.Empty;
    public string EmployeeName { get; set; } = string.Empty;
    public string EmployeeDesignation { get; set; } = string.Empty;
    public string EmployeeId { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string Make { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string SerialNumber { get; set; } = string.Empty;
    public string InvoiceNumber { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string Remarks { get; set; } = string.Empty;
    public string OsVersion { get; set; } = string.Empty;
    public string WindowsPatch { get; set; } = string.Empty;
    public string SentinelStatus { get; set; } = string.Empty;
    public int UploadBatchId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}

public class TopsAsset
{
    public int Id { get; set; }
    public string AssetTag { get; set; } = string.Empty;
    public string HostName { get; set; } = string.Empty;
    public string AssignedUser { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string Make { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string SerialNumber { get; set; } = string.Empty;
    public string AssetStatus { get; set; } = string.Empty;
    public string OsVersion { get; set; } = string.Empty;
    public int UploadBatchId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}

public class ReconciliationMatch
{
    public int Id { get; set; }
    public int? InventoryAssetId { get; set; }
    public int? TopsAssetId { get; set; }
    public string MatchStatus { get; set; } = string.Empty;
    public string Severity { get; set; } = string.Empty;
    public string IssueCategory { get; set; } = string.Empty;
    public List<AssetDiscrepancy> Discrepancies { get; set; } = new();
    public List<ReconciliationReview> Reviews { get; set; } = new();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}

public class AssetDiscrepancy
{
    public int Id { get; set; }
    public int ReconciliationMatchId { get; set; }
    public string FieldName { get; set; } = string.Empty;
    public string? InventoryValue { get; set; }
    public string? TopsValue { get; set; }
    public bool IsCritical { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

public class ReconciliationReview
{
    public int Id { get; set; }
    public int ReconciliationMatchId { get; set; }
    public string ReviewStatus { get; set; } = string.Empty;
    public string ReviewedBy { get; set; } = string.Empty;
    public DateTime ReviewedAt { get; set; }
    public string Comments { get; set; } = string.Empty;
    public string RecommendedAction { get; set; } = string.Empty;
    public string SourceOfTruth { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

public class AuditLog
{
    public int Id { get; set; }
    public string EntityType { get; set; } = string.Empty;
    public int EntityId { get; set; }
    public string Action { get; set; } = string.Empty;
    public string ChangedBy { get; set; } = string.Empty;
    public string BeforeValue { get; set; } = string.Empty;
    public string AfterValue { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

public class FileUploadBatch
{
    public int Id { get; set; }
    public string FileName { get; set; } = string.Empty;
    public string FileType { get; set; } = string.Empty;
    public long FileSize { get; set; }
    public int RowCount { get; set; }
    public string UploadedBy { get; set; } = string.Empty;
    public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
    public string Status { get; set; } = \"Completed\";
}

public class ColumnMapping
{
    public int Id { get; set; }
    public string SourceColumn { get; set; } = string.Empty;
    public string TargetColumn { get; set; } = string.Empty;
    public decimal ConfidenceScore { get; set; }
    public bool IsManuallyMapped { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
