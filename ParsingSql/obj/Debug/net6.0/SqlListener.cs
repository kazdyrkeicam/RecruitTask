﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/hello.maciek/Documents/__rider/sql_parser/RecruitTask/ParsingSql/Antlr/Sql.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace ParsingSql.Antlr {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SqlParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface ISqlListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParse([NotNull] SqlParser.ParseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParse([NotNull] SqlParser.ParseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.sql_stmt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSql_stmt_list([NotNull] SqlParser.Sql_stmt_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.sql_stmt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSql_stmt_list([NotNull] SqlParser.Sql_stmt_listContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.sql_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSql_stmt([NotNull] SqlParser.Sql_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.sql_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSql_stmt([NotNull] SqlParser.Sql_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.alter_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_table_stmt([NotNull] SqlParser.Alter_table_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.alter_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_table_stmt([NotNull] SqlParser.Alter_table_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.analyze_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnalyze_stmt([NotNull] SqlParser.Analyze_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.analyze_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnalyze_stmt([NotNull] SqlParser.Analyze_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.attach_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttach_stmt([NotNull] SqlParser.Attach_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.attach_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttach_stmt([NotNull] SqlParser.Attach_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.begin_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBegin_stmt([NotNull] SqlParser.Begin_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.begin_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBegin_stmt([NotNull] SqlParser.Begin_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.commit_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommit_stmt([NotNull] SqlParser.Commit_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.commit_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommit_stmt([NotNull] SqlParser.Commit_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.compound_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompound_select_stmt([NotNull] SqlParser.Compound_select_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.compound_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompound_select_stmt([NotNull] SqlParser.Compound_select_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.create_index_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_index_stmt([NotNull] SqlParser.Create_index_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.create_index_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_index_stmt([NotNull] SqlParser.Create_index_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.create_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_table_stmt([NotNull] SqlParser.Create_table_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.create_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_table_stmt([NotNull] SqlParser.Create_table_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.create_trigger_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_trigger_stmt([NotNull] SqlParser.Create_trigger_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.create_trigger_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_trigger_stmt([NotNull] SqlParser.Create_trigger_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.create_view_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_view_stmt([NotNull] SqlParser.Create_view_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.create_view_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_view_stmt([NotNull] SqlParser.Create_view_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.create_virtual_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_virtual_table_stmt([NotNull] SqlParser.Create_virtual_table_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.create_virtual_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_virtual_table_stmt([NotNull] SqlParser.Create_virtual_table_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.delete_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDelete_stmt([NotNull] SqlParser.Delete_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.delete_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDelete_stmt([NotNull] SqlParser.Delete_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.delete_stmt_limited"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDelete_stmt_limited([NotNull] SqlParser.Delete_stmt_limitedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.delete_stmt_limited"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDelete_stmt_limited([NotNull] SqlParser.Delete_stmt_limitedContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.detach_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDetach_stmt([NotNull] SqlParser.Detach_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.detach_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDetach_stmt([NotNull] SqlParser.Detach_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.drop_index_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_index_stmt([NotNull] SqlParser.Drop_index_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.drop_index_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_index_stmt([NotNull] SqlParser.Drop_index_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.drop_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_table_stmt([NotNull] SqlParser.Drop_table_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.drop_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_table_stmt([NotNull] SqlParser.Drop_table_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.drop_trigger_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_trigger_stmt([NotNull] SqlParser.Drop_trigger_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.drop_trigger_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_trigger_stmt([NotNull] SqlParser.Drop_trigger_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.drop_view_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_view_stmt([NotNull] SqlParser.Drop_view_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.drop_view_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_view_stmt([NotNull] SqlParser.Drop_view_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.factored_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFactored_select_stmt([NotNull] SqlParser.Factored_select_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.factored_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFactored_select_stmt([NotNull] SqlParser.Factored_select_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.insert_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsert_stmt([NotNull] SqlParser.Insert_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.insert_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsert_stmt([NotNull] SqlParser.Insert_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.pragma_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPragma_stmt([NotNull] SqlParser.Pragma_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.pragma_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPragma_stmt([NotNull] SqlParser.Pragma_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.reindex_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReindex_stmt([NotNull] SqlParser.Reindex_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.reindex_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReindex_stmt([NotNull] SqlParser.Reindex_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.release_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelease_stmt([NotNull] SqlParser.Release_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.release_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelease_stmt([NotNull] SqlParser.Release_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.rollback_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRollback_stmt([NotNull] SqlParser.Rollback_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.rollback_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRollback_stmt([NotNull] SqlParser.Rollback_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.savepoint_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSavepoint_stmt([NotNull] SqlParser.Savepoint_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.savepoint_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSavepoint_stmt([NotNull] SqlParser.Savepoint_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.simple_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimple_select_stmt([NotNull] SqlParser.Simple_select_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.simple_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimple_select_stmt([NotNull] SqlParser.Simple_select_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_stmt([NotNull] SqlParser.Select_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_stmt([NotNull] SqlParser.Select_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.select_or_values"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_or_values([NotNull] SqlParser.Select_or_valuesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.select_or_values"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_or_values([NotNull] SqlParser.Select_or_valuesContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.update_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdate_stmt([NotNull] SqlParser.Update_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.update_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdate_stmt([NotNull] SqlParser.Update_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.update_stmt_limited"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdate_stmt_limited([NotNull] SqlParser.Update_stmt_limitedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.update_stmt_limited"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdate_stmt_limited([NotNull] SqlParser.Update_stmt_limitedContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.vacuum_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVacuum_stmt([NotNull] SqlParser.Vacuum_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.vacuum_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVacuum_stmt([NotNull] SqlParser.Vacuum_stmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.column_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_def([NotNull] SqlParser.Column_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.column_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_def([NotNull] SqlParser.Column_defContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_name([NotNull] SqlParser.Type_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_name([NotNull] SqlParser.Type_nameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.column_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_constraint([NotNull] SqlParser.Column_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.column_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_constraint([NotNull] SqlParser.Column_constraintContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.conflict_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConflict_clause([NotNull] SqlParser.Conflict_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.conflict_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConflict_clause([NotNull] SqlParser.Conflict_clauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] SqlParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] SqlParser.ExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.foreign_key_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForeign_key_clause([NotNull] SqlParser.Foreign_key_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.foreign_key_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForeign_key_clause([NotNull] SqlParser.Foreign_key_clauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.raise_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRaise_function([NotNull] SqlParser.Raise_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.raise_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRaise_function([NotNull] SqlParser.Raise_functionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.indexed_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexed_column([NotNull] SqlParser.Indexed_columnContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.indexed_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexed_column([NotNull] SqlParser.Indexed_columnContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.table_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_constraint([NotNull] SqlParser.Table_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.table_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_constraint([NotNull] SqlParser.Table_constraintContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.with_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWith_clause([NotNull] SqlParser.With_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.with_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWith_clause([NotNull] SqlParser.With_clauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.qualified_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQualified_table_name([NotNull] SqlParser.Qualified_table_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.qualified_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQualified_table_name([NotNull] SqlParser.Qualified_table_nameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.ordering_term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrdering_term([NotNull] SqlParser.Ordering_termContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.ordering_term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrdering_term([NotNull] SqlParser.Ordering_termContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.pragma_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPragma_value([NotNull] SqlParser.Pragma_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.pragma_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPragma_value([NotNull] SqlParser.Pragma_valueContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.common_table_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommon_table_expression([NotNull] SqlParser.Common_table_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.common_table_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommon_table_expression([NotNull] SqlParser.Common_table_expressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.result_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResult_column([NotNull] SqlParser.Result_columnContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.result_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResult_column([NotNull] SqlParser.Result_columnContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.table_or_subquery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_or_subquery([NotNull] SqlParser.Table_or_subqueryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.table_or_subquery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_or_subquery([NotNull] SqlParser.Table_or_subqueryContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.join_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoin_clause([NotNull] SqlParser.Join_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.join_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoin_clause([NotNull] SqlParser.Join_clauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.join_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoin_operator([NotNull] SqlParser.Join_operatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.join_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoin_operator([NotNull] SqlParser.Join_operatorContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.join_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoin_constraint([NotNull] SqlParser.Join_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.join_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoin_constraint([NotNull] SqlParser.Join_constraintContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.select_core"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_core([NotNull] SqlParser.Select_coreContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.select_core"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_core([NotNull] SqlParser.Select_coreContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.compound_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompound_operator([NotNull] SqlParser.Compound_operatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.compound_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompound_operator([NotNull] SqlParser.Compound_operatorContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.cte_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCte_table_name([NotNull] SqlParser.Cte_table_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.cte_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCte_table_name([NotNull] SqlParser.Cte_table_nameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.signed_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSigned_number([NotNull] SqlParser.Signed_numberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.signed_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSigned_number([NotNull] SqlParser.Signed_numberContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.literal_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteral_value([NotNull] SqlParser.Literal_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.literal_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteral_value([NotNull] SqlParser.Literal_valueContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.unary_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnary_operator([NotNull] SqlParser.Unary_operatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.unary_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnary_operator([NotNull] SqlParser.Unary_operatorContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.error_message"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterError_message([NotNull] SqlParser.Error_messageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.error_message"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitError_message([NotNull] SqlParser.Error_messageContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.module_argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModule_argument([NotNull] SqlParser.Module_argumentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.module_argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModule_argument([NotNull] SqlParser.Module_argumentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.column_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_alias([NotNull] SqlParser.Column_aliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.column_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_alias([NotNull] SqlParser.Column_aliasContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyword([NotNull] SqlParser.KeywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyword([NotNull] SqlParser.KeywordContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterName([NotNull] SqlParser.NameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitName([NotNull] SqlParser.NameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_name([NotNull] SqlParser.Function_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_name([NotNull] SqlParser.Function_nameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.database_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDatabase_name([NotNull] SqlParser.Database_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.database_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDatabase_name([NotNull] SqlParser.Database_nameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_name([NotNull] SqlParser.Table_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_name([NotNull] SqlParser.Table_nameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.table_or_index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_or_index_name([NotNull] SqlParser.Table_or_index_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.table_or_index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_or_index_name([NotNull] SqlParser.Table_or_index_nameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.new_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNew_table_name([NotNull] SqlParser.New_table_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.new_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNew_table_name([NotNull] SqlParser.New_table_nameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.column_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_name([NotNull] SqlParser.Column_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.column_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_name([NotNull] SqlParser.Column_nameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.collation_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCollation_name([NotNull] SqlParser.Collation_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.collation_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCollation_name([NotNull] SqlParser.Collation_nameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.foreign_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForeign_table([NotNull] SqlParser.Foreign_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.foreign_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForeign_table([NotNull] SqlParser.Foreign_tableContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_name([NotNull] SqlParser.Index_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_name([NotNull] SqlParser.Index_nameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.trigger_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrigger_name([NotNull] SqlParser.Trigger_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.trigger_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrigger_name([NotNull] SqlParser.Trigger_nameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.view_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterView_name([NotNull] SqlParser.View_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.view_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitView_name([NotNull] SqlParser.View_nameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.module_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModule_name([NotNull] SqlParser.Module_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.module_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModule_name([NotNull] SqlParser.Module_nameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.pragma_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPragma_name([NotNull] SqlParser.Pragma_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.pragma_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPragma_name([NotNull] SqlParser.Pragma_nameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.savepoint_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSavepoint_name([NotNull] SqlParser.Savepoint_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.savepoint_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSavepoint_name([NotNull] SqlParser.Savepoint_nameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.table_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_alias([NotNull] SqlParser.Table_aliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.table_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_alias([NotNull] SqlParser.Table_aliasContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.transaction_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransaction_name([NotNull] SqlParser.Transaction_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.transaction_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransaction_name([NotNull] SqlParser.Transaction_nameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SqlParser.any_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAny_name([NotNull] SqlParser.Any_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqlParser.any_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAny_name([NotNull] SqlParser.Any_nameContext context);
}
} // namespace ParsingSql.Antlr