using Antlr4.Runtime;
using ParsingSql;
using ParsingSql.Antlr;
using ParsingSql.Tools;
using ParsingSql.Visitors;

namespace ParsingSqlTest;

public class Tests
{
    private ColumnVisitor columnVisitor;
    private TableVisitor tableVisitor;

    private void Setup(string query)
    {
        AntlrInputStream inputStream = new AntlrInputStream(query);
        SqlLexer sqlLexer = new SqlLexer(inputStream);
        CommonTokenStream tokenStream = new CommonTokenStream(sqlLexer);
        SqlParser sqlParser = new SqlParser(tokenStream);
        SqlParser.Select_coreContext selectCoreContext = sqlParser.select_core();
        
        columnVisitor = new ColumnVisitor();
        tableVisitor = new TableVisitor();
        
        tableVisitor.Visit(selectCoreContext);
        
        try { columnVisitor.Visit(selectCoreContext); }
        catch (Exception e) { ; }
    }

    [Test]
    public void NoJoinClause_SimpleSelectFrom()
    {
        const string query = "SELECT CustomerName, City FROM Customers;";
        Setup(query);

        string[] resultCorrect =
        {
            "Customers.CustomerName",
            "Customers.City"
        };
        var result = TablesColumnsUsed.SetResult(columnVisitor, tableVisitor);
        Assert.That(resultCorrect, Is.EqualTo(result));
    }
    
    [Test]
    public void JoinClause_SimpleSelectFrom()
    {
        const string query = @"SELECT c.CustomerName,

        c.City,
        s.PurchaseID,
        s.PurchaseDate
            FROM Customers c JOIN Sales s ON s.CustomerID = c.ID;";
        Setup(query);

        string[] resultCorrect =
        {
            "Customers.CustomerName",
            "Customers.City",
            "Sales.PurchaseID",
            "Sales.PurchaseDate"
        };
        var result = TablesColumnsUsed.SetResult(columnVisitor, tableVisitor);
        Assert.That(resultCorrect, Is.EqualTo(result));
    }

    [Test]
    public void InnerJoinClause_SimpleSelectFrom()
    {
        const string query = @"
            SELECT b.id, b.title, a.first_name, a.last_name
            FROM books b
            INNER JOIN authors a
            ON b.author_id = a.id
            ORDER BY b.id;
        ";
        Setup(query);

        string[] resultCorrect =
        {
            "books.id",
            "books.title",
            "authors.first_name",
            "authors.last_name"
        };
        var result = TablesColumnsUsed.SetResult(columnVisitor, tableVisitor);
        Assert.That(resultCorrect, Is.EqualTo(result));
    }
    
    [Test]
    public void JoinClause_ComplexSelectFrom()
    {
        const string query = @"
            SELECT pod.PurchaseOrderID, pod.ReceivedQty,
pod.RejectedQty,
rp.RejectedQty / pod.ReceivedQty AS RejectRatio,
pod.DueDate
FROM Purchasing.PurchaseOrderDetail pod JOIN
SalesRejectedProducts rp
ON pod.RejectedId = rp.Id
WHERE RejectedQty / ReceivedQty > 0
AND DueDate > CONVERT(DATETIME, ‘20010630’, 101)
        ";
        Setup(query);

        string[] resultCorrect =
        {
            "Purchasing.PurchaseOrderDetail.PurchaseOrderID",
            "Purchasing.PurchaseOrderDetail.ReceivedQty",
            "Purchasing.PurchaseOrderDetail.RejectedQty",
            "Purchasing.PurchaseOrderDetail.DueDate",
            "SalesRejectedProducts.RejectedQty"
        };
        var result = TablesColumnsUsed.SetResult(columnVisitor, tableVisitor);
        Assert.That(resultCorrect, Is.EqualTo(result));
    }
}