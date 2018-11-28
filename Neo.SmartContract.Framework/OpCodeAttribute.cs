using Neo.VM;
using System;

namespace Neo.SmartContract.Framework
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Constructor)]
    public class OpCodeAttribute : Attribute
    {
        public OpCode OpCodeX { get; }
        public byte OpCodeY { get; }

        public OpCodeAttribute(OpCode opcode, byte x)
        {
            this.OpCodeX = opcode;
            this.OpCodeY = x;
        }
    }
}
