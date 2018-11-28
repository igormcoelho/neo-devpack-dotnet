using Neo.VM;
using System;

namespace Neo.SmartContract.Framework
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Constructor)]
    public class OpCodeAttribute : Attribute
    {
        public OpCode OpCodeX { get; }

        public OpCodeAttribute(OpCode opcode)
        {
            this.OpCodeX = opcode;
        }
    }
}
