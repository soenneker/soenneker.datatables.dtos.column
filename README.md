[![](https://img.shields.io/nuget/v/soenneker.datatables.dtos.column.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.dtos.column/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.dtos.column/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.dtos.column/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.datatables.dtos.column.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.dtos.column/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.dtos.column/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.dtos.column/actions/workflows/codeql.yml)

# Soenneker.DataTables.Dtos.Column

A C# type mapping to DataTables.js Column.

## Install

```bash
dotnet add package Soenneker.DataTables.Dtos.Column
```

## What you get

- `DataTableColumn` — A C# type mapping to DataTables.js Column.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `DataTableColumn.AriaTitle` | Set the columns' aria-label attribute value. | Set the columns' aria-label attribute value. |
| `DataTableColumn.CellType` | Cell type to be created for a column. | Cell type to be created for a column. |
| `DataTableColumn.ClassName` | Class to assign to each cell in the column. | Class to assign to each cell in the column. |
| `DataTableColumn.ContentPadding` | Add padding to the text content used when calculating the optimal width for a table. | Add padding to the text content used when calculating the optimal width for a table. |
| `DataTableColumn.CreatedCell` | Cell created callback to allow DOM manipulation. | Cell created callback to allow DOM manipulation. |
| `DataTableColumn.Data` | Set the data source for the column from the rows data object/array. | Set the data source for the column from the rows data object/array. |
| `DataTableColumn.DefaultContent` | Set default, static, content for a column. | Set default, static, content for a column. |
| `DataTableColumn.Footer` | Set the column footer text. | Set the column footer text. |
| `DataTableColumn.Name` | Set a descriptive name for a column. | Set a descriptive name for a column. |
| `DataTableColumn.Orderable` | Enable or disable ordering on this column. | Enable or disable ordering on this column. |
| `DataTableColumn.OrderData` | Define multiple column ordering as the default order for a column. Can be int or array. | Define multiple column ordering as the default order for a column. Can be int or array. |
| `DataTableColumn.OrderDataType` | Live DOM sorting type assignment. | Live DOM sorting type assignment. |
| `DataTableColumn.OrderSequence` | Order direction application sequence. | Order direction application sequence. |
| `DataTableColumn.Searchable` | Enable or disable search on the data in this column. | Enable or disable search on the data in this column. |
| `DataTableColumn.Title` | Set the column title. | Set the column title. |
| `DataTableColumn.Type` | Set the column type - used for filtering and sorting string processing. | Set the column type - used for filtering and sorting string processing. |
| `DataTableColumn.Visible` | Enable or disable the display of this column. | Enable or disable the display of this column. |
| `DataTableColumn.Width` | Column width assignment. | Column width assignment. |
