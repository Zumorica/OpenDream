﻿using System;
using OpenDreamShared.Dream;
using OpenDreamShared.Dream.Procs;

namespace OpenDreamShared.Compiler.DM {
    interface DMASTVisitor {
        public void VisitFile(DMASTFile file) { throw new NotImplementedException(); }
        public void VisitBlockInner(DMASTBlockInner block) { throw new NotImplementedException(); }
        public void VisitProcBlockInner(DMASTProcBlockInner procBlock) { throw new NotImplementedException(); }
        public void VisitObjectDefinition(DMASTObjectDefinition statement) { throw new NotImplementedException(); }
        public void VisitPath(DMASTPath path) { throw new NotImplementedException(); }
        public void VisitObjectVarDefinition(DMASTObjectVarDefinition objectVarDefinition) { throw new NotImplementedException(); }
        public void VisitObjectVarOverride(DMASTObjectVarOverride objectVarOverride) { throw new NotImplementedException(); }
        public void VisitProcStatementExpression(DMASTProcStatementExpression statementExpression) { throw new NotImplementedException(); }
        public void VisitProcStatementVarDeclaration(DMASTProcStatementVarDeclaration varDeclaration) { throw new NotImplementedException(); }
        public void VisitProcStatementReturn(DMASTProcStatementReturn statementReturn) { throw new NotImplementedException(); }
        public void VisitProcStatementBreak(DMASTProcStatementBreak statementBreak) { throw new NotImplementedException(); }
        public void VisitProcStatementContinue(DMASTProcStatementContinue statementContinue) { throw new NotImplementedException(); }
        public void VisitProcStatementGoto(DMASTProcStatementGoto statementGoto) { throw new NotImplementedException(); }
        public void VisitProcStatementLabel(DMASTProcStatementLabel statementLabel) { throw new NotImplementedException(); }
        public void VisitProcStatementDel(DMASTProcStatementDel statementDel) { throw new NotImplementedException(); }
        public void VisitProcStatementSet(DMASTProcStatementSet statementSet) { throw new NotImplementedException(); }
        public void VisitProcStatementSpawn(DMASTProcStatementSpawn statementSpawn) { throw new NotImplementedException(); }
        public void VisitProcStatementIf(DMASTProcStatementIf statementIf) { throw new NotImplementedException(); }
        public void VisitProcStatementForStandard(DMASTProcStatementForStandard statementForStandard) { throw new NotImplementedException(); }
        public void VisitProcStatementForList(DMASTProcStatementForList statementForList) { throw new NotImplementedException(); }
        public void VisitProcStatementForRange(DMASTProcStatementForRange statementForRange) { throw new NotImplementedException(); }
        public void VisitProcStatementForLoop(DMASTProcStatementForLoop statementForLoop) { throw new NotImplementedException(); }
        public void VisitProcStatementWhile(DMASTProcStatementWhile statementWhile) { throw new NotImplementedException(); }
        public void VisitProcStatementDoWhile(DMASTProcStatementDoWhile statementDoWhile) { throw new NotImplementedException(); }
        public void VisitProcStatementSwitch(DMASTProcStatementSwitch statementSwitch) { throw new NotImplementedException(); }
        public void VisitProcStatementBrowse(DMASTProcStatementBrowse statementBrowse) { throw new NotImplementedException(); }
        public void VisitProcStatementBrowseResource(DMASTProcStatementBrowseResource statementBrowseResource) { throw new NotImplementedException(); }
        public void VisitProcStatementOutputControl(DMASTProcStatementOutputControl statementOutputControl) { throw new NotImplementedException(); }
        public void VisitProcDefinition(DMASTProcDefinition procDefinition) { throw new NotImplementedException(); }
        public void VisitIdentifier(DMASTIdentifier identifier) { throw new NotImplementedException(); }
        public void VisitConstantInteger(DMASTConstantInteger constant) { throw new NotImplementedException(); }
        public void VisitConstantFloat(DMASTConstantFloat constant) { throw new NotImplementedException(); }
        public void VisitConstantString(DMASTConstantString constant) { throw new NotImplementedException(); }
        public void VisitConstantResource(DMASTConstantResource constant) { throw new NotImplementedException(); }
        public void VisitConstantNull(DMASTConstantNull constant) { throw new NotImplementedException(); }
        public void VisitConstantPath(DMASTConstantPath constant) { throw new NotImplementedException(); }
        public void VisitStringFormat(DMASTStringFormat stringFormat) { throw new NotImplementedException(); }
        public void VisitList(DMASTList list) { throw new NotImplementedException(); }
        public void VisitInput(DMASTInput input) { throw new NotImplementedException(); }
        public void VisitInitial(DMASTInitial initial) { throw new NotImplementedException(); }
        public void VisitIsType(DMASTIsType isType) { throw new NotImplementedException(); }
        public void VisitImplicitIsType(DMASTImplicitIsType isType) { throw new NotImplementedException(); }
        public void VisitLocateCoordinates(DMASTLocateCoordinates locateCoordinates) { throw new NotImplementedException(); }
        public void VisitLocate(DMASTLocate locate) { throw new NotImplementedException(); }
        public void VisitCall(DMASTCall call) { throw new NotImplementedException(); }
        public void VisitAssign(DMASTAssign assign) { throw new NotImplementedException(); }
        public void VisitNewPath(DMASTNewPath newPath) { throw new NotImplementedException(); }
        public void VisitNewIdentifier(DMASTNewIdentifier newIdentifier) { throw new NotImplementedException(); }
        public void VisitNewDereference(DMASTNewDereference newDereference) { throw new NotImplementedException(); }
        public void VisitNewInferred(DMASTNewInferred newInferred) { throw new NotImplementedException(); }
        public void VisitNot(DMASTNot not) { throw new NotImplementedException(); }
        public void VisitNegate(DMASTNegate negate) { throw new NotImplementedException(); }
        public void VisitEqual(DMASTEqual equal) { throw new NotImplementedException(); }
        public void VisitNotEqual(DMASTNotEqual notEqual) { throw new NotImplementedException(); }
        public void VisitLessThan(DMASTLessThan lessThan) { throw new NotImplementedException(); }
        public void VisitLessThanOrEqual(DMASTLessThanOrEqual lessThanOrEqual) { throw new NotImplementedException(); }
        public void VisitGreaterThan(DMASTGreaterThan greaterThan) { throw new NotImplementedException(); }
        public void VisitGreaterThanOrEqual(DMASTGreaterThanOrEqual greaterThanOrEqual) { throw new NotImplementedException(); }
        public void VisitMultiply(DMASTMultiply multiply) { throw new NotImplementedException(); }
        public void VisitDivide(DMASTDivide divide) { throw new NotImplementedException(); }
        public void VisitModulus(DMASTModulus modulus) { throw new NotImplementedException(); }
        public void VisitPower(DMASTPower power) { throw new NotImplementedException(); }
        public void VisitAdd(DMASTAdd add) { throw new NotImplementedException(); }
        public void VisitSubtract(DMASTSubtract subtract) { throw new NotImplementedException(); }
        public void VisitPreIncrement(DMASTPreIncrement preIncrement) { throw new NotImplementedException(); }
        public void VisitPreDecrement(DMASTPreDecrement preDecrement) { throw new NotImplementedException(); }
        public void VisitPostIncrement(DMASTPostIncrement postIncrement) { throw new NotImplementedException(); }
        public void VisitPostDecrement(DMASTPostDecrement postDecrement) { throw new NotImplementedException(); }
        public void VisitTernary(DMASTTernary ternary) { throw new NotImplementedException(); }
        public void VisitAppend(DMASTAppend append) { throw new NotImplementedException(); }
        public void VisitRemove(DMASTRemove remove) { throw new NotImplementedException(); }
        public void VisitCombine(DMASTCombine combine) { throw new NotImplementedException(); }
        public void VisitMask(DMASTMask mask) { throw new NotImplementedException(); }
        public void VisitMultiplyAssign(DMASTMultiplyAssign multiplyAssign) { throw new NotImplementedException(); }
        public void VisitDivideAssign(DMASTDivideAssign divideAssign) { throw new NotImplementedException(); }
        public void VisitLeftShiftAssign(DMASTLeftShiftAssign leftShiftAssign) { throw new NotImplementedException(); }
        public void VisitRightShiftAssign(DMASTRightShiftAssign rightShiftAssign) { throw new NotImplementedException(); }
        public void VisitXorAssign(DMASTXorAssign xorAssign) { throw new NotImplementedException(); }
        public void VisitOr(DMASTOr or) { throw new NotImplementedException(); }
        public void VisitAnd(DMASTAnd and) { throw new NotImplementedException(); }
        public void VisitBinaryAnd(DMASTBinaryAnd binaryAnd) { throw new NotImplementedException(); }
        public void VisitBinaryXor(DMASTBinaryXor binaryXor) { throw new NotImplementedException(); }
        public void VisitBinaryOr(DMASTBinaryOr binaryOr) { throw new NotImplementedException(); }
        public void VisitBinaryNot(DMASTBinaryNot binaryNot) { throw new NotImplementedException(); }
        public void VisitLeftShift(DMASTLeftShift leftShift) { throw new NotImplementedException(); }
        public void VisitRightShift(DMASTRightShift rightShift) { throw new NotImplementedException(); }
        public void VisitIn(DMASTExpressionIn expressionIn) { throw new NotImplementedException(); }
        public void VisitListIndex(DMASTListIndex listIndex) { throw new NotImplementedException(); }
        public void VisitProcCall(DMASTProcCall procCall) { throw new NotImplementedException(); }
        public void VisitCallParameter(DMASTCallParameter callParameter) { throw new NotImplementedException(); }
        public void VisitDefinitionParameter(DMASTDefinitionParameter definitionParameter) { throw new NotImplementedException(); }
        public void VisitDereference(DMASTDereference dereference) { throw new NotImplementedException(); }
        public void VisitDereferenceProc(DMASTDereferenceProc dereferenceProc) { throw new NotImplementedException(); }
        public void VisitCallableProcIdentifier(DMASTCallableProcIdentifier procIdentifier) { throw new NotImplementedException(); }
        public void VisitCallableSuper(DMASTCallableSuper super) { throw new NotImplementedException(); }
        public void VisitCallableSelf(DMASTCallableSelf self) { throw new NotImplementedException(); }
    }

    interface DMASTNode : ASTNode<DMASTVisitor> {

    }

    interface DMASTStatement : DMASTNode {

    }

    interface DMASTProcStatement : DMASTNode {

    }

    interface DMASTExpression : DMASTNode {

    }

    interface DMASTExpressionConstant : DMASTExpression {

    }

    interface DMASTCallable : DMASTExpression {

    }

    class DMASTFile : DMASTNode {
        public DMASTBlockInner BlockInner;

        public DMASTFile(DMASTBlockInner blockInner) {
            BlockInner = blockInner;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitFile(this);
        }
    }

    class DMASTBlockInner : DMASTNode {
        public DMASTStatement[] Statements;

        public DMASTBlockInner(DMASTStatement[] statements) {
            Statements = statements;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitBlockInner(this);
        }
    }

    class DMASTProcBlockInner : DMASTNode {
        public DMASTProcStatement[] Statements;

        public DMASTProcBlockInner(DMASTProcStatement[] statements) {
            Statements = statements;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitProcBlockInner(this);
        }
    }

    class DMASTObjectDefinition : DMASTStatement {
        public DMASTPath Path;
        public DMASTBlockInner InnerBlock;

        public DMASTObjectDefinition(DMASTPath path, DMASTBlockInner innerBlock) {
            Path = path;
            InnerBlock = innerBlock;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitObjectDefinition(this);
        }
    }

    class DMASTProcDefinition : DMASTStatement {
        public DreamPath? ObjectPath;
        public string Name;
        public bool IsVerb = false;
        public DMASTDefinitionParameter[] Parameters;
        public DMASTProcBlockInner Body;

        public DMASTProcDefinition(DMASTPath astPath, DMASTDefinitionParameter[] parameters, DMASTProcBlockInner body) {
            DreamPath path = astPath.Path;
            int procElementIndex = path.FindElement("proc");

            if (procElementIndex == -1) {
                procElementIndex = path.FindElement("verb");

                if (procElementIndex != -1) IsVerb = true;
            }

            if (procElementIndex != -1) path = path.RemoveElement(procElementIndex);

            ObjectPath = (path.Elements.Length > 1) ? path.FromElements(0, -2) : null;
            Name = path.LastElement;
            Parameters = parameters;
            Body = body;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitProcDefinition(this);
        }
    }

    class DMASTPath : DMASTNode {
        public DreamPath Path;

        public DMASTPath(DreamPath path) {
            Path = path;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitPath(this);
        }
    }

    class DMASTObjectVarDefinition : DMASTStatement {
        public DreamPath? ObjectPath;
        public DreamPath? Type;
        public string Name;
        public DMASTExpression Value;
        public bool IsGlobal = false;

        public DMASTObjectVarDefinition(DMASTPath astPath, DMASTExpression value) {
            DreamPath path = astPath.Path;

            int globalElementIndex = path.FindElement("global");
            if (globalElementIndex != -1) {
                path = path.RemoveElement(globalElementIndex);
                IsGlobal = true;
            }

            int varElementIndex = path.FindElement("var");
            DreamPath varPath = path.FromElements(varElementIndex + 1, -1);

            ObjectPath = (varElementIndex > 0) ? path.FromElements(0, varElementIndex) : null;
            Type = (varPath.Elements.Length > 1) ? varPath.FromElements(0, -2) : null;
            Name = varPath.LastElement;
            Value = value;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitObjectVarDefinition(this);
        }
    }

    class DMASTObjectVarOverride : DMASTStatement {
        public DreamPath? ObjectPath;
        public string VarName;
        public DMASTExpression Value;

        public DMASTObjectVarOverride(DMASTPath path, DMASTExpression value) {
            ObjectPath = (path.Path.Elements.Length > 1) ? path.Path.FromElements(0, -2) : null;
            VarName = path.Path.LastElement;
            Value = value;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitObjectVarOverride(this);
        }
    }

    class DMASTProcStatementExpression : DMASTProcStatement {
        public DMASTExpression Expression;

        public DMASTProcStatementExpression(DMASTExpression expression) {
            Expression = expression;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementExpression(this);
        }
    }

    class DMASTProcStatementVarDeclaration : DMASTProcStatement {
        public DreamPath? Type;
        public string Name;
        public DMASTExpression Value;

        public DMASTProcStatementVarDeclaration(DMASTPath path, DMASTExpression value) {
            int varElementIndex = path.Path.FindElement("var");
            DreamPath typePath = path.Path.FromElements(varElementIndex + 1, -2);

            Type = (typePath.Elements.Length > 0) ? typePath : null;
            Name = path.Path.LastElement;
            Value = value;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementVarDeclaration(this);
        }
    }

    class DMASTProcStatementReturn : DMASTProcStatement {
        public DMASTExpression Value;

        public DMASTProcStatementReturn(DMASTExpression value) {
            Value = value;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementReturn(this);
        }
    }

    class DMASTProcStatementBreak : DMASTProcStatement {
        public void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementBreak(this);
        }
    }

    class DMASTProcStatementContinue : DMASTProcStatement {
        public void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementContinue(this);
        }
    }

    class DMASTProcStatementGoto : DMASTProcStatement {
        public DMASTIdentifier Label;

        public DMASTProcStatementGoto(DMASTIdentifier label) {
            Label = label;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementGoto(this);
        }
    }

    class DMASTProcStatementLabel : DMASTProcStatement {
        public string Name;

        public DMASTProcStatementLabel(string name) {
            Name = name;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementLabel(this);
        }
    }

    class DMASTProcStatementDel : DMASTProcStatement {
        public DMASTExpression Value;

        public DMASTProcStatementDel(DMASTExpression value) {
            Value = value;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementDel(this);
        }
    }

    class DMASTProcStatementSet : DMASTProcStatement {
        public string Attribute;
        public DMASTExpression Value;

        public DMASTProcStatementSet(string attribute, DMASTExpression value) {
            Attribute = attribute;
            Value = value;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementSet(this);
        }
    }

    class DMASTProcStatementSpawn : DMASTProcStatement {
        public DMASTExpression Time;
        public DMASTProcBlockInner Body;

        public DMASTProcStatementSpawn(DMASTExpression time, DMASTProcBlockInner body) {
            Time = time;
            Body = body;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementSpawn(this);
        }
    }

    class DMASTProcStatementIf : DMASTProcStatement {
        public DMASTExpression Condition;
        public DMASTProcBlockInner Body;
        public DMASTProcBlockInner ElseBody;

        public DMASTProcStatementIf(DMASTExpression condition, DMASTProcBlockInner body, DMASTProcBlockInner elseBody = null) {
            Condition = condition;
            Body = body;
            ElseBody = elseBody;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementIf(this);
        }
    }

    class DMASTProcStatementFor : DMASTProcStatement {
        public DMASTProcStatement Initializer;
        public DMASTProcBlockInner Body;

        public DMASTProcStatementFor(DMASTProcStatement initializer, DMASTProcBlockInner body) {
            Initializer = initializer;
            Body = body;
        }

        public virtual void Visit(DMASTVisitor visitor) {
            throw new NotImplementedException();
        }
    }

    class DMASTProcStatementForStandard : DMASTProcStatementFor {
        public DMASTExpression Comparator, Incrementor;

        public DMASTProcStatementForStandard(DMASTProcStatement initializer, DMASTExpression comparator, DMASTExpression incrementor, DMASTProcBlockInner body) : base(initializer, body) {
            Comparator = comparator;
            Incrementor = incrementor;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementForStandard(this);
        }
    }

    class DMASTProcStatementForList : DMASTProcStatementFor {
        public DMASTIdentifier Variable;
        public DMASTExpression List;

        public DMASTProcStatementForList(DMASTProcStatement initializer, DMASTIdentifier variable, DMASTExpression list, DMASTProcBlockInner body) : base(initializer, body) {
            Variable = variable;
            List = list;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementForList(this);
        }
    }

    class DMASTProcStatementForRange : DMASTProcStatementFor {
        public DMASTIdentifier Variable;
        public DMASTExpression RangeStart, RangeEnd, Step;

        public DMASTProcStatementForRange(DMASTProcStatement initializer, DMASTIdentifier variable, DMASTExpression rangeStart, DMASTExpression rangeEnd, DMASTExpression step, DMASTProcBlockInner body) : base(initializer, body) {
            Variable = variable;
            RangeStart = rangeStart;
            RangeEnd = rangeEnd;
            Step = step;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementForRange(this);
        }
    }

    class DMASTProcStatementForLoop : DMASTProcStatement {
        public DMASTProcStatementVarDeclaration VariableDeclaration;
        public DMASTCallable Variable;
        public DMASTExpression Condition, Incrementer;
        public DMASTProcBlockInner Body;

        public DMASTProcStatementForLoop(DMASTProcStatementVarDeclaration variableDeclaration, DMASTCallable variable, DMASTExpression condition, DMASTExpression incrementer, DMASTProcBlockInner body) {
            VariableDeclaration = variableDeclaration;
            Variable = variable;
            Condition = condition;
            Incrementer = incrementer;
            Body = body;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementForLoop(this);
        }
    }

    class DMASTProcStatementWhile : DMASTProcStatement {
        public DMASTExpression Conditional;
        public DMASTProcBlockInner Body;

        public DMASTProcStatementWhile(DMASTExpression conditional, DMASTProcBlockInner body) {
            Conditional = conditional;
            Body = body;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementWhile(this);
        }
    }

    class DMASTProcStatementDoWhile : DMASTProcStatement {
        public DMASTExpression Conditional;
        public DMASTProcBlockInner Body;

        public DMASTProcStatementDoWhile(DMASTExpression conditional, DMASTProcBlockInner body) {
            Conditional = conditional;
            Body = body;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementDoWhile(this);
        }
    }

    class DMASTProcStatementSwitch : DMASTProcStatement {
        public class SwitchCase {
            public DMASTProcBlockInner Body;

            protected SwitchCase(DMASTProcBlockInner body) {
                Body = body;
            }
        }

        public class SwitchCaseDefault : SwitchCase {
            public SwitchCaseDefault(DMASTProcBlockInner body) : base(body) { }
        }

        public class SwitchCaseValues : SwitchCase {
            public DMASTExpressionConstant[] Values;

            public SwitchCaseValues(DMASTExpressionConstant[] values, DMASTProcBlockInner body) : base(body) {
                Values = values;
            }
        }

        public DMASTExpression Value;
        public SwitchCase[] Cases;

        public DMASTProcStatementSwitch(DMASTExpression value, SwitchCase[] cases) {
            Value = value;
            Cases = cases;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementSwitch(this);
        }
    }

    class DMASTProcStatementBrowse : DMASTProcStatement {
        public DMASTExpression Receiver;
        public DMASTExpression Body;
        public DMASTExpression Options;

        public DMASTProcStatementBrowse(DMASTExpression receiver, DMASTExpression body, DMASTExpression options) {
            Receiver = receiver;
            Body = body;
            Options = options;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementBrowse(this);
        }
    }
    
    class DMASTProcStatementBrowseResource : DMASTProcStatement {
        public DMASTExpression Receiver;
        public DMASTExpression File;
        public DMASTExpression Filename;

        public DMASTProcStatementBrowseResource(DMASTExpression receiver, DMASTExpression file, DMASTExpression filename) {
            Receiver = receiver;
            File = file;
            Filename = filename;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementBrowseResource(this);
        }
    }

    class DMASTProcStatementOutputControl : DMASTProcStatement {
        public DMASTExpression Receiver;
        public DMASTExpression Message;
        public DMASTExpression Control;

        public DMASTProcStatementOutputControl(DMASTExpression receiver, DMASTExpression message, DMASTExpression control) {
            Receiver = receiver;
            Message = message;
            Control = control;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementOutputControl(this);
        }
    }

    class DMASTIdentifier : DMASTExpression {
        public string Identifier;

        public DMASTIdentifier(string identifier) {
            Identifier = identifier;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitIdentifier(this);
        }
    }

    class DMASTConstantInteger : DMASTExpressionConstant {
        public int Value;

        public DMASTConstantInteger(int value) {
            Value = value;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitConstantInteger(this);
        }
    }

    class DMASTConstantFloat : DMASTExpressionConstant {
        public float Value;

        public DMASTConstantFloat(float value) {
            Value = value;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitConstantFloat(this);
        }
    }

    class DMASTConstantString : DMASTExpressionConstant {
        public string Value;

        public DMASTConstantString(string value) {
            Value = value;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitConstantString(this);
        }
    }

    class DMASTConstantResource : DMASTExpressionConstant {
        public string Path;

        public DMASTConstantResource(string path) {
            Path = path;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitConstantResource(this);
        }
    }

    class DMASTConstantNull : DMASTExpressionConstant {
        public void Visit(DMASTVisitor visitor) {
            visitor.VisitConstantNull(this);
        }
    }

    class DMASTConstantPath : DMASTExpressionConstant {
        public DMASTPath Value;

        public DMASTConstantPath(DMASTPath value) {
            Value = value;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitConstantPath(this);
        }
    }

    class DMASTStringFormat : DMASTExpression {
        public string Value;
        public DMASTExpression[] InterpolatedValues;

        public DMASTStringFormat(string value, DMASTExpression[] interpolatedValues) {
            Value = value;
            InterpolatedValues = interpolatedValues;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitStringFormat(this);
        }
    }

    class DMASTList : DMASTExpression {
        public DMASTCallParameter[] Values;

        public DMASTList(DMASTCallParameter[] values) {
            Values = values;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitList(this);
        }
    }

    class DMASTInput : DMASTExpression {
        public DMASTCallParameter[] Parameters;
        public DMValueType Types;
        public DMASTExpression List;

        public DMASTInput(DMASTCallParameter[] parameters, DMValueType types, DMASTExpression list) {
            Parameters = parameters;
            Types = types;
            List = list;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitInput(this);
        }
    }
    
    class DMASTInitial : DMASTExpression {
        public DMASTExpression Expression;

        public DMASTInitial(DMASTExpression expression) {
            Expression = expression;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitInitial(this);
        }
    }

    class DMASTIsType : DMASTExpression {
        public DMASTExpression Value;
        public DMASTExpression Type;

        public DMASTIsType(DMASTExpression value, DMASTExpression type) {
            Value = value;
            Type = type;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitIsType(this);
        }
    }
    
    class DMASTImplicitIsType : DMASTExpression {
        public DMASTExpression Value;

        public DMASTImplicitIsType(DMASTExpression value) {
            Value = value;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitImplicitIsType(this);
        }
    }

    class DMASTLocateCoordinates : DMASTExpression {
        public DMASTExpression X, Y, Z;

        public DMASTLocateCoordinates(DMASTExpression x, DMASTExpression y, DMASTExpression z) {
            X = x;
            Y = y;
            Z = z;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitLocateCoordinates(this);
        }
    }
    
    class DMASTLocate : DMASTExpression {
        public DMASTExpression Expression;
        public DMASTExpression Container;

        public DMASTLocate(DMASTExpression expression, DMASTExpression container) {
            Expression = expression;
            Container = container;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitLocate(this);
        }
    }

    class DMASTCall : DMASTExpression {
        public DMASTCallParameter[] CallParameters, ProcParameters;

        public DMASTCall(DMASTCallParameter[] callParameters, DMASTCallParameter[] procParameters) {
            CallParameters = callParameters;
            ProcParameters = procParameters;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitCall(this);
        }
    }

    class DMASTAssign : DMASTExpression {
        public DMASTExpression Expression, Value;

        public DMASTAssign(DMASTExpression expression, DMASTExpression value) {
            Expression = expression;
            Value = value;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitAssign(this);
        }
    }

    class DMASTNewPath : DMASTExpression {
        public DMASTPath Path;
        public DMASTCallParameter[] Parameters;

        public DMASTNewPath(DMASTPath path, DMASTCallParameter[] parameters) {
            Path = path;
            Parameters = parameters;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitNewPath(this);
        }
    }

    class DMASTNewIdentifier : DMASTExpression {
        public DMASTIdentifier Identifier;
        public DMASTCallParameter[] Parameters;

        public DMASTNewIdentifier(DMASTIdentifier identifier, DMASTCallParameter[] parameters) {
            Identifier = identifier;
            Parameters = parameters;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitNewIdentifier(this);
        }
    }

    class DMASTNewDereference : DMASTExpression {
        public DMASTDereference Dereference;
        public DMASTCallParameter[] Parameters;

        public DMASTNewDereference(DMASTDereference dereference, DMASTCallParameter[] parameters) {
            Dereference = dereference;
            Parameters = parameters;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitNewDereference(this);
        }
    }

    class DMASTNewInferred : DMASTExpression {
        public DMASTCallParameter[] Parameters;

        public DMASTNewInferred(DMASTCallParameter[] parameters) {
            Parameters = parameters;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitNewInferred(this);
        }
    }

    class DMASTNot : DMASTExpression {
        public DMASTExpression Expression;

        public DMASTNot(DMASTExpression expression) {
            Expression = expression;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitNot(this);
        }
    }

    class DMASTNegate : DMASTExpression {
        public DMASTExpression Expression;

        public DMASTNegate(DMASTExpression expression) {
            Expression = expression;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitNegate(this);
        }
    }

    class DMASTEqual : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTEqual(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitEqual(this);
        }
    }

    class DMASTNotEqual : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTNotEqual(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitNotEqual(this);
        }
    }

    class DMASTLessThan : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTLessThan(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitLessThan(this);
        }
    }

    class DMASTLessThanOrEqual : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTLessThanOrEqual(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitLessThanOrEqual(this);
        }
    }

    class DMASTGreaterThan : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTGreaterThan(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitGreaterThan(this);
        }
    }

    class DMASTGreaterThanOrEqual : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTGreaterThanOrEqual(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitGreaterThanOrEqual(this);
        }
    }

    class DMASTMultiply : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTMultiply(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitMultiply(this);
        }
    }

    class DMASTDivide : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTDivide(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitDivide(this);
        }
    }

    class DMASTModulus : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTModulus(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitModulus(this);
        }
    }

    class DMASTPower : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTPower(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitPower(this);
        }
    }

    class DMASTAdd : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTAdd(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitAdd(this);
        }
    }

    class DMASTSubtract : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTSubtract(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitSubtract(this);
        }
    }

    class DMASTPreIncrement : DMASTExpression {
        public DMASTExpression Expression;

        public DMASTPreIncrement(DMASTExpression expression) {
            Expression = expression;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitPreIncrement(this);
        }
    }

    class DMASTPreDecrement : DMASTExpression {
        public DMASTExpression Expression;

        public DMASTPreDecrement(DMASTExpression expression) {
            Expression = expression;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitPreDecrement(this);
        }
    }

    class DMASTPostIncrement : DMASTExpression {
        public DMASTExpression Expression;

        public DMASTPostIncrement(DMASTExpression expression) {
            Expression = expression;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitPostIncrement(this);
        }
    }

    class DMASTPostDecrement : DMASTExpression {
        public DMASTExpression Expression;

        public DMASTPostDecrement(DMASTExpression expression) {
            Expression = expression;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitPostDecrement(this);
        }
    }

    class DMASTTernary : DMASTExpression {
        public DMASTExpression A, B, C;

        public DMASTTernary(DMASTExpression a, DMASTExpression b, DMASTExpression c) {
            A = a;
            B = b;
            C = c;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitTernary(this);
        }
    }

    class DMASTAppend : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTAppend(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitAppend(this);
        }
    }

    class DMASTRemove : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTRemove(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitRemove(this);
        }
    }

    class DMASTCombine : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTCombine(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitCombine(this);
        }
    }

    class DMASTMask : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTMask(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitMask(this);
        }
    }

    class DMASTMultiplyAssign : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTMultiplyAssign(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitMultiplyAssign(this);
        }
    }

    class DMASTDivideAssign : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTDivideAssign(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitDivideAssign(this);
        }
    }

    class DMASTLeftShiftAssign : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTLeftShiftAssign(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitLeftShiftAssign(this);
        }
    }

    class DMASTRightShiftAssign : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTRightShiftAssign(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitRightShiftAssign(this);
        }
    }

    class DMASTXorAssign : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTXorAssign(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitXorAssign(this);
        }
    }

    class DMASTOr : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTOr(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitOr(this);
        }
    }

    class DMASTAnd : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTAnd(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitAnd(this);
        }
    }

    class DMASTBinaryAnd : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTBinaryAnd(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitBinaryAnd(this);
        }
    }

    class DMASTBinaryXor : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTBinaryXor(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitBinaryXor(this);
        }
    }

    class DMASTBinaryOr : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTBinaryOr(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitBinaryOr(this);
        }
    }

    class DMASTBinaryNot : DMASTExpression {
        public DMASTExpression Value;

        public DMASTBinaryNot(DMASTExpression value) {
            Value = value;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitBinaryNot(this);
        }
    }

    class DMASTLeftShift : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTLeftShift(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitLeftShift(this);
        }
    }

    class DMASTRightShift : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTRightShift(DMASTExpression a, DMASTExpression b) {
            A = a;
            B = b;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitRightShift(this);
        }
    }

    class DMASTExpressionIn : DMASTExpression {
        public DMASTExpression Value;
        public DMASTExpression List;

        public DMASTExpressionIn(DMASTExpression value, DMASTExpression list) {
            Value = value;
            List = list;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitIn(this);
        }
    }

    class DMASTListIndex : DMASTExpression {
        public DMASTExpression Expression;
        public DMASTExpression Index;

        public DMASTListIndex(DMASTExpression expression, DMASTExpression index) {
            Expression = expression;
            Index = index;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitListIndex(this);
        }
    }

    class DMASTProcCall : DMASTExpression {
        public DMASTCallable Callable;
        public DMASTCallParameter[] Parameters;

        public DMASTProcCall(DMASTCallable callable, DMASTCallParameter[] parameters) {
            Callable = callable;
            Parameters = parameters;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitProcCall(this);
        }
    }

    class DMASTCallParameter : DMASTNode {
        public DMASTExpression Value;
        public string Name;

        public DMASTCallParameter(DMASTExpression value, string name = null) {
            Value = value;
            Name = name;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitCallParameter(this);
        }
    }

    class DMASTDefinitionParameter : DMASTNode {
        public DreamPath? ObjectType;
        public string Name;
        public DMASTExpression Value;
        public DMValueType Type;
        public DMASTExpression PossibleValues;

        public DMASTDefinitionParameter(DMASTPath astPath, DMASTExpression value, DMValueType type, DMASTExpression possibleValues) {
            DreamPath path = astPath.Path;

            int varElementIndex = path.FindElement("var");
            if (varElementIndex != -1) path = path.RemoveElement(varElementIndex);

            ObjectType = (path.Elements.Length > 1) ? path.FromElements(0, -2) : null;
            Name = path.LastElement;
            Value = value;
            Type = type;
            PossibleValues = possibleValues;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitDefinitionParameter(this);
        }
    }

    class DMASTDereference : DMASTCallable {
        public enum DereferenceType {
            Direct,
            Search
        }

        public struct Dereference {
            public DereferenceType Type;
            public string Property;

            public Dereference(DereferenceType type, string property) {
                Type = type;
                Property = property;
            }
        }

        public DMASTExpression Expression;
        public Dereference[] Dereferences;

        public DMASTDereference(DMASTExpression expression, Dereference[] dereferences) {
            Expression = expression;
            Dereferences = dereferences;
        }

        public virtual void Visit(DMASTVisitor visitor) {
            visitor.VisitDereference(this);
        }
    }

    class DMASTDereferenceProc : DMASTDereference, DMASTCallable {
        public DMASTDereferenceProc(DMASTExpression expression, Dereference[] dereferences) : base(expression, dereferences) { }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitDereferenceProc(this);
        }
    }

    class DMASTCallableProcIdentifier : DMASTCallable {
        public string Identifier;

        public DMASTCallableProcIdentifier(string identifier) {
            Identifier = identifier;
        }

        public void Visit(DMASTVisitor visitor) {
            visitor.VisitCallableProcIdentifier(this);
        }
    }

    class DMASTCallableSuper : DMASTCallable {
        public void Visit(DMASTVisitor visitor) {
            visitor.VisitCallableSuper(this);
        }
    }

    class DMASTCallableSelf : DMASTCallable {
        public void Visit(DMASTVisitor visitor) {
            visitor.VisitCallableSelf(this);
        }
    }
}
