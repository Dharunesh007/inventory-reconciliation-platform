namespace InventoryReconciliation.Shared.DTOs;

public class InventoryAssetDto
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
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

public class TopsAssetDto
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
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

public class AssetMatchDto
{
    public int Id { get; set; }
    public InventoryAssetDto? InventoryAsset { get; set; }
    public TopsAssetDto? TopsAsset { get; set; }
    public string MatchStatus { get; set; } = string.Empty;
    public string Severity { get; set; } = string.Empty;
    public List<FieldDifferenceDto> FieldDifferences { get; set; } = new();
    public DateTime CreatedAt { get; set; }
}

public class FieldDifferenceDto
{
    public string FieldName { get; set; } = string.Empty;
    public string? InventoryValue { get; set; }
    public string? TopsValue { get; set; }
    public bool IsMismatch { get; set; }
}

public class ReconciliationSummaryDto
{
    public int TotalInventoryAssets { get; set; }
    public int TotalTopsAssets { get; set; }
    public int MatchedAssets { get; set; }
    public int MismatchedAssets { get; set; }
    public int MissingInTops { get; set; }
    public int MissingInInventory { get; set; }
    public int BlankDataIssues { get; set; }
    public int DuplicateRecords { get; set; }
    public decimal ReconciliationCompletionPercentage { get; set; }
    public decimal AccuracyPercentage { get; set; }
}

public class FileUploadDto
{
    public string FileName { get; set; } = string.Empty;
    public long FileSize { get; set; }
    public int RowCount { get; set; }
    public DateTime UploadedAt { get; set; }
    public string UploadedBy { get; set; } = string.Empty;
    public List<string> DetectedColumns { get; set; } = new();
}

public class ColumnMappingDto
{
    public int Id { get; set; }
    public string SourceColumn { get; set; } = string.Empty;
    public string TargetColumn { get; set; } = string.Empty;
    public decimal ConfidenceScore { get; set; }
    public bool IsManuallyMapped { get; set; }
}

public class ReconciliationReviewDto
{
    public int Id { get; set; }
    public int AssetMatchId { get; set; }
    public string ReviewStatus { get; set; } = string.Empty;
    public string ReviewedBy { get; set; } = string.Empty;
    public DateTime ReviewedAt { get; set; }
    public string Comments { get; set; } = string.Empty;
    public string RecommendedAction { get; set; } = string.Empty;
}
