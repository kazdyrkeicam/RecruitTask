using ParsingSql.Antlr;

namespace ParsingSql.Visitors;

public class ColumnVisitor : SqlBaseVisitor<int>
{
    private Dictionary<string, List<string>> _columns = new Dictionary<string, List<string>>();
    public Dictionary<string, List<string>> GetColumns()
    {
        return _columns;
    }

    /*
     * Adds a value to attribute : _columns
     * [ KEY = table alias ]
     * VALUE = List of columns that comes from the table  
     */
    public override int VisitColumn_name(SqlParser.Column_nameContext context)
    {
        string columnName = context.GetText();
        string tableName = context.parent.GetChild(0).GetText();

        if (_columns.ContainsKey(tableName))
        {
            if(!_columns[tableName].Contains(columnName))
                _columns[tableName].Add(columnName);
        }
        else
            _columns.Add(tableName, new List<string> {columnName});
        return 0;
    }
    
    /*
     * Stops visitation after visit join_constraint node
     * to avoid analyzing rest of the query
     * To safely stop visiting, it is necessary to catch that exception
     */
    public override int VisitJoin_constraint(SqlParser.Join_constraintContext context)
    {
        throw new Exception("Join_constraint occured");
    }
}