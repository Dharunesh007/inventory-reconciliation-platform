# Enterprise Inventory Reconciliation Platform

A world-class internal enterprise web application for IT Asset Inventory Reconciliation, designed for Fortune 100 enterprises.

## Overview

This platform reconciles IT asset inventory from physical verification (Excel) against TOPS export data with intelligent asset matching, comprehensive reporting, and enterprise-grade UX.

## Key Features

- **Intelligent Asset Matching**: Primary matching via ASSET TAG with fallback to Serial Number and Host Name
- **Real-time Reconciliation**: Compare and identify mismatches instantly
- **Premium Dashboard**: Executive-grade KPIs and analytics
- **Enterprise Data Grid**: Virtual scrolling, search, filter, sort, group, export
- **Bulk Actions**: Approve, reject, merge values with audit trail
- **Comprehensive Reporting**: Excel, CSV, PDF export with executive summaries
- **Dark/Light Mode**: Beautiful design system with Fluent UI inspiration
- **Audit Trail**: Complete history of all changes with timestamps

## Tech Stack

- **Frontend**: Blazor Server + MudBlazor
- **Backend**: ASP.NET Core 8.0 / C#
- **Database**: SQL Server
- **Excel**: EPPlus
- **CSV**: CsvHelper
- **Charts**: ApexCharts

## Quick Start

### Prerequisites
- .NET 8.0 SDK or later
- SQL Server 2019 or later
- Visual Studio 2022 or VS Code

### Installation

```bash
git clone https://github.com/Dharunesh007/inventory-reconciliation-platform.git
cd inventory-reconciliation-platform
dotnet restore
dotnet build
dotnet run --project src/InventoryReconciliation.Blazor
```

Navigate to `https://localhost:7001`

## Project Structure

```
inventory-reconciliation-platform/
├── src/
│   ├── InventoryReconciliation.API/
│   ├── InventoryReconciliation.Blazor/
│   ├── InventoryReconciliation.Core/
│   ├── InventoryReconciliation.Data/
│   ├── InventoryReconciliation.Services/
│   └── InventoryReconciliation.Shared/
├── tests/
├── database/
├── docs/
└── docker-compose.yml
```

## Core Features

### Landing Dashboard
- Animated hero section with glassmorphism effects
- Premium KPI cards with counters
- File upload experience with drag-and-drop

### Reconciliation Engine
- Primary matching via ASSET TAG
- Fallback matching: Serial Number → Host Name
- Normalization: trim, case-insensitive, whitespace handling
- Duplicate detection
- Blank field detection

### Enterprise Data Grid
- Virtual scrolling for 100k+ rows
- Advanced search and filtering
- Multi-column sorting
- Column pinning and resizing
- Bulk actions
- Keyboard navigation

### Reports & Export
- Full Reconciliation Report
- Missing in TOPS Report
- Missing in Inventory Report
- Duplicate Records Report
- Export as Excel, CSV, PDF

## API Endpoints

### Inventory
- `GET /api/inventory` - List all inventory assets
- `POST /api/inventory/upload` - Upload inventory file

### TOPS
- `GET /api/tops` - List all TOPS assets
- `POST /api/tops/upload` - Upload TOPS export file

### Reconciliation
- `GET /api/reconciliation/summary` - Dashboard KPIs
- `GET /api/reconciliation/matches` - All matches with discrepancies
- `POST /api/reconciliation/approve` - Approve reconciliation

### Reports
- `GET /api/reports/excel` - Export as Excel
- `GET /api/reports/csv` - Export as CSV
- `GET /api/reports/pdf` - Export as PDF

## Design System

- Fluent UI inspired design language
- MudBlazor component library
- Premium card layouts with soft shadows
- Dark and light modes
- Responsive mobile-first design
- Skeleton loading states
- Smooth transitions and micro-interactions

## Security

- Role-based access control (RBAC)
- Audit logging of all operations
- Data encryption at rest and in transit
- Input validation and sanitization

## Deployment

See DEPLOYMENT.md for deployment instructions.

## Contributing

1. Create a feature branch from `develop`
2. Make your changes
3. Submit a pull request
4. Ensure all tests pass

## License

Internal Use Only - Proprietary

## Support

For issues, questions, or feature requests, contact the IT Asset Management team.