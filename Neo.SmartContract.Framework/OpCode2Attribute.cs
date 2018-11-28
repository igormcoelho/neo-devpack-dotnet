using Neo.VM;
using System;

namespace Neo.SmartContract.Framework
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Constructor)]
    public class OpCode2Attribute : Attribute
    {
        public OpCode OpCodeX { get; }
        public byte OpCodeY { get; }

        public OpCode2Attribute(OpCode opcode, byte x)
        {
            this.OpCodeX = opcode;
            this.OpCodeY = x;
        }
    }
}
