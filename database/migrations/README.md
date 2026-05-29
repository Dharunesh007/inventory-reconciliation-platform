# Database Migrations

This folder contains Entity Framework Core migration files.

## Running Migrations

```bash
# Add a new migration
dotnet ef migrations add MigrationName --project src/InventoryReconciliation.Data

# Update database with pending migrations
dotnet ef database update --project src/InventoryReconciliation.Data

# Remove the last migration
dotnet ef migrations remove --project src/InventoryReconciliation.Data
```

## Initial Setup

Run this command to create the database:

```bash
dotnet ef database update --project src/InventoryReconciliation.Data
```
