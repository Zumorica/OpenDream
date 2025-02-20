﻿using OpenDreamServer.Dream.Procs;
using System.Threading.Tasks;

namespace OpenDreamServer.Dream.Objects.MetaObjects {
    interface IDreamMetaObject {
        public void OnObjectCreated(DreamObject dreamObject, DreamProcArguments creationArguments);
        public void OnObjectDeleted(DreamObject dreamObject);
        public void OnVariableSet(DreamObject dreamObject, string variableName, DreamValue variableValue, DreamValue oldVariableValue);
        public DreamValue OnVariableGet(DreamObject dreamObject, string variableName, DreamValue variableValue);

        public DreamValue OperatorOutput(DreamValue a, DreamValue b);
        public DreamValue OperatorAdd(DreamValue a, DreamValue b);
        public DreamValue OperatorSubtract(DreamValue a, DreamValue b);
        public DreamValue OperatorAppend(DreamValue a, DreamValue b);
        public DreamValue OperatorRemove(DreamValue a, DreamValue b);
        public DreamValue OperatorCombine(DreamValue a, DreamValue b);
        public DreamValue OperatorMask(DreamValue a, DreamValue b);
    }
}
