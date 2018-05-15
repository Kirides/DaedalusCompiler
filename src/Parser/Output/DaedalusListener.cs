//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Daedalus.g4 by ANTLR 4.7.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="DaedalusParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public interface IDaedalusListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.daedalusFile"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDaedalusFile([NotNull] DaedalusParser.DaedalusFileContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.daedalusFile"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDaedalusFile([NotNull] DaedalusParser.DaedalusFileContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.functionDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionDef([NotNull] DaedalusParser.FunctionDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.functionDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionDef([NotNull] DaedalusParser.FunctionDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.constDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstDef([NotNull] DaedalusParser.ConstDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.constDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstDef([NotNull] DaedalusParser.ConstDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.classDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassDef([NotNull] DaedalusParser.ClassDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.classDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassDef([NotNull] DaedalusParser.ClassDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.prototypeDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrototypeDef([NotNull] DaedalusParser.PrototypeDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.prototypeDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrototypeDef([NotNull] DaedalusParser.PrototypeDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.instanceDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstanceDef([NotNull] DaedalusParser.InstanceDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.instanceDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstanceDef([NotNull] DaedalusParser.InstanceDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.instanceDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstanceDecl([NotNull] DaedalusParser.InstanceDeclContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.instanceDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstanceDecl([NotNull] DaedalusParser.InstanceDeclContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.varDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarDecl([NotNull] DaedalusParser.VarDeclContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.varDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarDecl([NotNull] DaedalusParser.VarDeclContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.constArrayDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstArrayDef([NotNull] DaedalusParser.ConstArrayDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.constArrayDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstArrayDef([NotNull] DaedalusParser.ConstArrayDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.constArrayAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstArrayAssignment([NotNull] DaedalusParser.ConstArrayAssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.constArrayAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstArrayAssignment([NotNull] DaedalusParser.ConstArrayAssignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.constValueDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstValueDef([NotNull] DaedalusParser.ConstValueDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.constValueDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstValueDef([NotNull] DaedalusParser.ConstValueDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.constValueAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstValueAssignment([NotNull] DaedalusParser.ConstValueAssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.constValueAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstValueAssignment([NotNull] DaedalusParser.ConstValueAssignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.varArrayDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarArrayDecl([NotNull] DaedalusParser.VarArrayDeclContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.varArrayDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarArrayDecl([NotNull] DaedalusParser.VarArrayDeclContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.varValueDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarValueDecl([NotNull] DaedalusParser.VarValueDeclContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.varValueDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarValueDecl([NotNull] DaedalusParser.VarValueDeclContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterList([NotNull] DaedalusParser.ParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterList([NotNull] DaedalusParser.ParameterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.parameterDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterDecl([NotNull] DaedalusParser.ParameterDeclContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.parameterDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterDecl([NotNull] DaedalusParser.ParameterDeclContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.statementBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementBlock([NotNull] DaedalusParser.StatementBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.statementBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementBlock([NotNull] DaedalusParser.StatementBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] DaedalusParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] DaedalusParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.funcCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFuncCall([NotNull] DaedalusParser.FuncCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.funcCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFuncCall([NotNull] DaedalusParser.FuncCallContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] DaedalusParser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] DaedalusParser.AssignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.ifCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfCondition([NotNull] DaedalusParser.IfConditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.ifCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfCondition([NotNull] DaedalusParser.IfConditionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.elseBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseBlock([NotNull] DaedalusParser.ElseBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.elseBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseBlock([NotNull] DaedalusParser.ElseBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseIfBlock([NotNull] DaedalusParser.ElseIfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseIfBlock([NotNull] DaedalusParser.ElseIfBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfBlock([NotNull] DaedalusParser.IfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfBlock([NotNull] DaedalusParser.IfBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.ifBlockStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfBlockStatement([NotNull] DaedalusParser.IfBlockStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.ifBlockStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfBlockStatement([NotNull] DaedalusParser.IfBlockStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturnStatement([NotNull] DaedalusParser.ReturnStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturnStatement([NotNull] DaedalusParser.ReturnStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.funcArgExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFuncArgExpression([NotNull] DaedalusParser.FuncArgExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.funcArgExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFuncArgExpression([NotNull] DaedalusParser.FuncArgExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.expressionBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionBlock([NotNull] DaedalusParser.ExpressionBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.expressionBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionBlock([NotNull] DaedalusParser.ExpressionBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>bitMoveExpression</c>
	/// labeled alternative in <see cref="DaedalusParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBitMoveExpression([NotNull] DaedalusParser.BitMoveExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>bitMoveExpression</c>
	/// labeled alternative in <see cref="DaedalusParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBitMoveExpression([NotNull] DaedalusParser.BitMoveExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>oneArgExpression</c>
	/// labeled alternative in <see cref="DaedalusParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOneArgExpression([NotNull] DaedalusParser.OneArgExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>oneArgExpression</c>
	/// labeled alternative in <see cref="DaedalusParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOneArgExpression([NotNull] DaedalusParser.OneArgExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>eqExpression</c>
	/// labeled alternative in <see cref="DaedalusParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEqExpression([NotNull] DaedalusParser.EqExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>eqExpression</c>
	/// labeled alternative in <see cref="DaedalusParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEqExpression([NotNull] DaedalusParser.EqExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>valExpression</c>
	/// labeled alternative in <see cref="DaedalusParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValExpression([NotNull] DaedalusParser.ValExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>valExpression</c>
	/// labeled alternative in <see cref="DaedalusParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValExpression([NotNull] DaedalusParser.ValExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>addExpression</c>
	/// labeled alternative in <see cref="DaedalusParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddExpression([NotNull] DaedalusParser.AddExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>addExpression</c>
	/// labeled alternative in <see cref="DaedalusParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddExpression([NotNull] DaedalusParser.AddExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>compExpression</c>
	/// labeled alternative in <see cref="DaedalusParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompExpression([NotNull] DaedalusParser.CompExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>compExpression</c>
	/// labeled alternative in <see cref="DaedalusParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompExpression([NotNull] DaedalusParser.CompExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>bitExpression</c>
	/// labeled alternative in <see cref="DaedalusParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBitExpression([NotNull] DaedalusParser.BitExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>bitExpression</c>
	/// labeled alternative in <see cref="DaedalusParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBitExpression([NotNull] DaedalusParser.BitExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>multExpression</c>
	/// labeled alternative in <see cref="DaedalusParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultExpression([NotNull] DaedalusParser.MultExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multExpression</c>
	/// labeled alternative in <see cref="DaedalusParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultExpression([NotNull] DaedalusParser.MultExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>bracketExpression</c>
	/// labeled alternative in <see cref="DaedalusParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBracketExpression([NotNull] DaedalusParser.BracketExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>bracketExpression</c>
	/// labeled alternative in <see cref="DaedalusParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBracketExpression([NotNull] DaedalusParser.BracketExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.simpleValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleValue([NotNull] DaedalusParser.SimpleValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.simpleValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleValue([NotNull] DaedalusParser.SimpleValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>integerLiteralValue</c>
	/// labeled alternative in <see cref="DaedalusParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntegerLiteralValue([NotNull] DaedalusParser.IntegerLiteralValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>integerLiteralValue</c>
	/// labeled alternative in <see cref="DaedalusParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntegerLiteralValue([NotNull] DaedalusParser.IntegerLiteralValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>floatLiteralValue</c>
	/// labeled alternative in <see cref="DaedalusParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloatLiteralValue([NotNull] DaedalusParser.FloatLiteralValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>floatLiteralValue</c>
	/// labeled alternative in <see cref="DaedalusParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloatLiteralValue([NotNull] DaedalusParser.FloatLiteralValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stringLiteralValue</c>
	/// labeled alternative in <see cref="DaedalusParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStringLiteralValue([NotNull] DaedalusParser.StringLiteralValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stringLiteralValue</c>
	/// labeled alternative in <see cref="DaedalusParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStringLiteralValue([NotNull] DaedalusParser.StringLiteralValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>nullLiteralValue</c>
	/// labeled alternative in <see cref="DaedalusParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNullLiteralValue([NotNull] DaedalusParser.NullLiteralValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>nullLiteralValue</c>
	/// labeled alternative in <see cref="DaedalusParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNullLiteralValue([NotNull] DaedalusParser.NullLiteralValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>funcCallValue</c>
	/// labeled alternative in <see cref="DaedalusParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFuncCallValue([NotNull] DaedalusParser.FuncCallValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>funcCallValue</c>
	/// labeled alternative in <see cref="DaedalusParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFuncCallValue([NotNull] DaedalusParser.FuncCallValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>complexReferenceValue</c>
	/// labeled alternative in <see cref="DaedalusParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComplexReferenceValue([NotNull] DaedalusParser.ComplexReferenceValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>complexReferenceValue</c>
	/// labeled alternative in <see cref="DaedalusParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComplexReferenceValue([NotNull] DaedalusParser.ComplexReferenceValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.complexReferenceLeftSide"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComplexReferenceLeftSide([NotNull] DaedalusParser.ComplexReferenceLeftSideContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.complexReferenceLeftSide"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComplexReferenceLeftSide([NotNull] DaedalusParser.ComplexReferenceLeftSideContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.complexReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComplexReference([NotNull] DaedalusParser.ComplexReferenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.complexReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComplexReference([NotNull] DaedalusParser.ComplexReferenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.complexReferenceNode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComplexReferenceNode([NotNull] DaedalusParser.ComplexReferenceNodeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.complexReferenceNode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComplexReferenceNode([NotNull] DaedalusParser.ComplexReferenceNodeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.typeReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeReference([NotNull] DaedalusParser.TypeReferenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.typeReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeReference([NotNull] DaedalusParser.TypeReferenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.nameNode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNameNode([NotNull] DaedalusParser.NameNodeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.nameNode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNameNode([NotNull] DaedalusParser.NameNodeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.referenceNode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReferenceNode([NotNull] DaedalusParser.ReferenceNodeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.referenceNode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReferenceNode([NotNull] DaedalusParser.ReferenceNodeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.assigmentOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssigmentOperator([NotNull] DaedalusParser.AssigmentOperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.assigmentOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssigmentOperator([NotNull] DaedalusParser.AssigmentOperatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.addOperators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddOperators([NotNull] DaedalusParser.AddOperatorsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.addOperators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddOperators([NotNull] DaedalusParser.AddOperatorsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.compOperators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompOperators([NotNull] DaedalusParser.CompOperatorsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.compOperators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompOperators([NotNull] DaedalusParser.CompOperatorsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.oneArgOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOneArgOperator([NotNull] DaedalusParser.OneArgOperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.oneArgOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOneArgOperator([NotNull] DaedalusParser.OneArgOperatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DaedalusParser.multOperators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultOperators([NotNull] DaedalusParser.MultOperatorsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DaedalusParser.multOperators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultOperators([NotNull] DaedalusParser.MultOperatorsContext context);
}
