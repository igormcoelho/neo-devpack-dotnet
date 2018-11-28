using Neo.VM;
using System;

namespace Neo.SmartContract.Framework
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Constructor)]
    public class OpCodeArrayAttribute : Attribute
    {
        public OpCode[] vOpCode { get; }

        public OpCodeArrayAttribute(OpCode[] vopcode)
        {
            this.vOpCode = vopcode;
        }
    }
}
