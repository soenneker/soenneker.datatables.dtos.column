[![](https://img.shields.io/nuget/v/soenneker.datatables.dtos.column.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.dtos.column/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.dtos.column/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.dtos.column/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.datatables.dtos.column.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.dtos.column/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.dtos.column/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.dtos.column/actions/workflows/codeql.yml)

# Soenneker.DataTables.Dtos.Column

`DataTableColumn` represents a DataTables column definition that can be assembled in .NET and serialized for client-side table initialization.

## Installation

```bash
dotnet add package Soenneker.DataTables.Dtos.Column
```

## Usage

```csharp
using Soenneker.DataTables.Dtos.Column;
using System.Text.Json;

var columns = new[]
{
    new DataTableColumn
    {
        Data = "name",
        Name = "name",
        Title = "Customer",
        Searchable = true,
        Orderable = true,
        ResponsivePriority = 1
    },
    new DataTableColumn
    {
        Data = "createdAt",
        Name = "createdAt",
        Title = "Created",
        Type = "date",
        Orderable = true,
        Width = "12rem"
    }
};

string json = JsonSerializer.Serialize(columns);
```

The properties use DataTables' camel-case JSON names, so the output is ready to use as the `columns` option without a custom naming policy.

## Behavior to know

- `Visible` defaults to `true`; `Searchable` and `Orderable` default to `false`.
- `Order` and `ResponsivePriority` default to `-1` as an unspecified value for consuming code to interpret.
- `Data` and `OrderData` are `object` because DataTables accepts multiple shapes. Prefer predictable values such as a property-path string, an integer column index, or an integer array.
- `CreatedCell` is .NET-only callback state and is ignored during JSON serialization. Provide browser callbacks in JavaScript rather than expecting a delegate to cross the JSON boundary.
- This DTO does not verify that data paths, DataTables type names, widths, or ordering indices are valid.
