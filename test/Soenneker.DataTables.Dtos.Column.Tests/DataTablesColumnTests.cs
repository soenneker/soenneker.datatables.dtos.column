using System.Text.Json;
using Soenneker.Tests.Unit;

namespace Soenneker.DataTables.Dtos.Column.Tests;

public sealed class DataTablesColumnTests : UnitTest
{
    [Test]
    public void CreatedCell_does_not_break_serialization()
    {
        var column = new DataTableColumn
        {
            Data = "name",
            CreatedCell = (_, _, _) => { }
        };

        JsonSerializer.Serialize(column);
    }
}
