using Neo.VM;
using System;

namespace Neo.SmartContract.Framework
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Constructor)]
    public class OpCode2Attribute : Attribute
    {
        public OpCode OpCodeX { get; }
        public OpCode OpCodeY { get; }

        public OpCode2Attribute(params OpCode[] opcodes)
        {
            this.OpCodeX = opcodes[0];
            this.OpCodeY = opcodes[1];
        }
    }
}
