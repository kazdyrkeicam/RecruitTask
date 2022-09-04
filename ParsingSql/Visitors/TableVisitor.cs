using ParsingSql.Antlr;

namespace ParsingSql.Visitors;

public class TableVisitor : SqlBaseVisitor<int>
{
    private Dictionary<string, string[]> _tables = new Dictionary<string, string[]>();
    public const string WithoutAlias = "41f17868-0b05-470b-9e92-78e77f398248";

    public Dictionary<string, string[]> GetTables()
    {
        return _tables;
    }

    /*
     * Adds a value to attribute : _tables
     * [ KEY = table alias ]
     * VALUE = array string (better to use tuple), where first is full table name, second is database of the table
     */
    public override int VisitTable_or_subquery(SqlParser.Table_or_subqueryContext context)
    {
        var tableName = context.table_name().GetText();
        var tableAlias = WithoutAlias;
        var databaseName = "";

        // in table_or_subquery node, table_alias would always be the last child
        if (context.GetChild(context.ChildCount - 1).GetType() == typeof(SqlParser.Table_aliasContext))
            tableAlias = context.table_alias().GetText();

        // in table_or_subquery node, database will always be the first child if exists
        if (context.GetChild(0).GetType() == typeof(SqlParser.Database_nameContext))
            databaseName = context.database_name().GetText();
        
        _tables.Add(tableAlias, new [] {tableName, databaseName});
        return 0;
    }
}