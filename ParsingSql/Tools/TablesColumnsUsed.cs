

using ParsingSql.Visitors;

namespace ParsingSql.Tools;

/*
 * A class that is a tool to create a specific data structure that is array of string and contains
 * "<DatabaseName>.<TableName>.<ColumnName>"
 */
public static class TablesColumnsUsed
{
    public static string[] SetResult(ColumnVisitor columnVisitor, TableVisitor tableVisitor)
    {
        var result = Array.Empty<string>();
        foreach (var column in columnVisitor.GetColumns())
        {
            var index = tableVisitor.GetTables().ContainsKey(TableVisitor.WithoutAlias)
                ? TableVisitor.WithoutAlias
                : column.Key;
            
            foreach (var item in column.Value)
            {
                result = result.Append(tableVisitor.GetTables()[index][0] + "." + item).ToArray();
                if (tableVisitor.GetTables()[index][1] != "")
                    result[^1] =
                        result[^1].Insert(0, tableVisitor.GetTables()[index][1] + ".");
            }
        }
        return result;
    }
}